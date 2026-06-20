using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Text;
using System.Globalization;

namespace personal_manager
{
    public partial class frm_manager : Form
    {
        private List<TodoItem> todoList = new List<TodoItem>();
        private int nextId = 1;
        private int selectedId = -1;
        private Chart chartStatus;

        // 追蹤目前資料是否有被修改過
        private bool _isDirty = false;

        // 避免初始化 ComboBox 時觸發篩選事件
        private bool isInitializingFilter = false;

        public frm_manager()
        {
            InitializeComponent();

            this.Load += frmTodoManager_Load;
            dgvTodos.CellClick += dgvTodos_CellClick;

            RegisterFilterEvents();

            // User Manual 使用說明
            userManualToolStripMenuItem.Click -= userManualToolStripMenuItem_Click;
            userManualToolStripMenuItem.Click += userManualToolStripMenuItem_Click;
        }

        private void RegisterFilterEvents()
        {
            // 重新綁定事件，避免重複觸發
            textBox3.KeyDown -= textBox3_KeyDown;
            textBox3.KeyDown += textBox3_KeyDown;

            button4.Click -= button4_Click;
            button4.Click += button4_Click;

            allbutton.Click -= allbutton_Click;
            allbutton.Click += allbutton_Click;

            button6.Click -= button6_Click;
            button6.Click += button6_Click;

            button8.Click -= button8_Click;
            button8.Click += button8_Click;

            statuscombo.SelectedIndexChanged -= FilterCombo_SelectedIndexChanged;
            statuscombo.SelectedIndexChanged += FilterCombo_SelectedIndexChanged;

            classcombo.SelectedIndexChanged -= FilterCombo_SelectedIndexChanged;
            classcombo.SelectedIndexChanged += FilterCombo_SelectedIndexChanged;
        }

        private void InitPieChart()
        {
            chartStatus = new Chart();

            chartStatus.Name = "chartStatus";
            chartStatus.Size = new Size(260, 210);
            chartStatus.Location = new Point(18, 500);
            chartStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            chartStatus.BackColor = pnlList.BackColor;
            chartStatus.BorderlineColor = Color.Transparent;
            chartStatus.BorderlineWidth = 0;

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.BackColor = pnlList.BackColor;
            chartArea.BackSecondaryColor = pnlList.BackColor;
            chartArea.BorderColor = Color.Transparent;
            chartArea.ShadowColor = Color.Transparent;

            chartStatus.ChartAreas.Add(chartArea);

            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = pnlList.BackColor;
            legend.BorderColor = Color.Transparent;
            legend.ShadowColor = Color.Transparent;

            chartStatus.Legends.Add(legend);

            Series series = new Series("待辦狀態");
            series.ChartType = SeriesChartType.Pie;
            series.ChartArea = "MainArea";
            series.Legend = "Legend";
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX：#VAL";
            series.LegendText = "#VALX";

            chartStatus.Series.Add(series);

            Title title = new Title("待辦狀態比例");
            title.BackColor = pnlList.BackColor;
            title.ForeColor = Color.FromArgb(15, 23, 42);
            title.Font = new Font("微軟正黑體", 10, FontStyle.Bold);

            chartStatus.Titles.Add(title);

            pnlList.Controls.Add(chartStatus);
            chartStatus.BringToFront();
        }

        private void UpdatePieChart()
        {
            if (chartStatus == null)
            {
                return;
            }

            int notDone = todoList.Count(x => x.Status == "未完成");
            int doing = todoList.Count(x => x.Status == "進行中");
            int done = todoList.Count(x => x.Status == "已完成");

            Series series = chartStatus.Series["待辦狀態"];
            series.Points.Clear();

            if (notDone == 0 && doing == 0 && done == 0)
            {
                series.Points.AddXY("沒有資料", 1);
                return;
            }

            if (notDone > 0) series.Points.AddXY("未完成", notDone);
            if (doing > 0) series.Points.AddXY("進行中", doing);
            if (done > 0) series.Points.AddXY("已完成", done);
        }

        private void frmTodoManager_Load(object sender, EventArgs e)
        {
            InitCategory();
            InitFilterComboBox();
            InitGrid();
            InitPieChart();
            InitDefaultValue();
            UpdateAllDisplay();
        }

        private void InitCategory()
        {
            combotype.DropDownStyle = ComboBoxStyle.DropDownList;

            combotype.Items.Clear();
            combotype.Items.Add("學校");
            combotype.Items.Add("工作");
            combotype.Items.Add("生活");
            combotype.Items.Add("購物");
            combotype.Items.Add("重要事項");
            combotype.Items.Add("其他");

            combotype.SelectedIndex = 0;
        }

        private void InitFilterComboBox()
        {
            isInitializingFilter = true;

            statuslbl.Text = "狀態篩選";
            classlbl.Text = "分類篩選";

            allbutton.Text = "顯示全部";

            statuscombo.DropDownStyle = ComboBoxStyle.DropDownList;
            classcombo.DropDownStyle = ComboBoxStyle.DropDownList;

            statuscombo.Items.Clear();
            statuscombo.Items.Add("全部");
            statuscombo.Items.Add("未完成");
            statuscombo.Items.Add("進行中");
            statuscombo.Items.Add("已完成");
            statuscombo.SelectedIndex = 0;

            classcombo.Items.Clear();
            classcombo.Items.Add("全部");

            foreach (object item in combotype.Items)
            {
                classcombo.Items.Add(item.ToString());
            }

            classcombo.SelectedIndex = 0;

            isInitializingFilter = false;
        }

        private void RefreshClassFilterOptions()
        {
            isInitializingFilter = true;

            string oldSelected = classcombo.SelectedItem == null ? "全部" : classcombo.SelectedItem.ToString();

            classcombo.Items.Clear();
            classcombo.Items.Add("全部");

            var categories = todoList
                .Select(x => x.Category)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            foreach (string category in categories)
            {
                classcombo.Items.Add(category);
            }

            if (classcombo.Items.Contains(oldSelected))
            {
                classcombo.SelectedItem = oldSelected;
            }
            else
            {
                classcombo.SelectedIndex = 0;
            }

            isInitializingFilter = false;
        }

        private void InitDefaultValue()
        {
            todobox.Clear();
            contextbox.Clear();
            textBox3.Clear();

            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            if (combotype.Items.Count > 0)
            {
                combotype.SelectedIndex = 0;
            }

            ResetFilterComboOnly();

            month.SetDate(DateTime.Today);

            selectedId = -1;

            if (dgvTodos.DataSource != null)
            {
                dgvTodos.ClearSelection();
            }
        }

        private void ResetFilterComboOnly()
        {
            isInitializingFilter = true;

            if (statuscombo.Items.Count > 0)
            {
                statuscombo.SelectedIndex = 0;
            }

            if (classcombo.Items.Count > 0)
            {
                classcombo.SelectedIndex = 0;
            }

            isInitializingFilter = false;
        }

        private void InitGrid()
        {
            dgvTodos.AutoGenerateColumns = false;
            dgvTodos.AllowUserToAddRows = false;
            dgvTodos.ReadOnly = true;
            dgvTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodos.MultiSelect = false;

            dgvTodos.Columns.Clear();

            AddColumn("Id", "編號", 60);
            AddColumn("Title", "待辦事項", 180);
            AddColumn("Description", "詳細內容", 220);
            AddColumn("Status", "目前狀態", 100);
            AddColumn("Category", "歸屬分類", 100);
            AddColumn("DueDateText", "截止日期", 110);
            AddColumn("AlertStatus", "提醒狀態", 110);
        }

        private void AddColumn(string propertyName, string headerText, int width)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = propertyName;
            col.HeaderText = headerText;
            col.Width = width;
            col.Name = propertyName;

            dgvTodos.Columns.Add(col);
        }

        private void RefreshGrid(IEnumerable<TodoItem> source)
        {
            var data = source.Select(x => new TodoView
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Status = x.Status,
                Category = x.Category,
                DueDateText = x.DueDate.ToString("yyyy/MM/dd"),
                AlertStatus = GetAlertStatus(x)
            }).ToList();

            dgvTodos.DataSource = null;
            dgvTodos.DataSource = data;

            dgvTodos.ClearSelection();
        }

        private void UpdateAllDisplay()
        {
            RefreshGrid(todoList);
            UpdateStats();
            UpdateFilterButtonText();
            UpdatePieChart();
        }

        private void UpdateFilterButtonText()
        {
            DateTime today = DateTime.Today;
            DateTime threeDaysLater = today.AddDays(3);

            int todayCount = todoList.Count(x =>
                x.DueDate.Date == today &&
                x.Status != "已完成"
            );

            int threeDaysCount = todoList.Count(x =>
                x.DueDate.Date > today &&
                x.DueDate.Date <= threeDaysLater &&
                x.Status != "已完成"
            );

            button6.Text = "今日待辦：" + todayCount;
            button8.Text = "三日內到期：" + threeDaysCount;
            allbutton.Text = "顯示全部";
        }

        private string GetSelectedStatus()
        {
            if (radioButton1.Checked) return "未完成";
            if (radioButton2.Checked) return "進行中";
            if (radioButton3.Checked) return "已完成";
            return "未完成";
        }

        private void SetSelectedStatus(string status)
        {
            if (status == "未完成") radioButton1.Checked = true;
            else if (status == "進行中") radioButton2.Checked = true;
            else if (status == "已完成") radioButton3.Checked = true;
            else radioButton1.Checked = true;
        }

        private string GetAlertStatus(TodoItem item)
        {
            DateTime today = DateTime.Today;
            DateTime dueDate = item.DueDate.Date;

            if (item.Status == "已完成") return "已完成";
            if (dueDate < today) return "已逾期";
            if (dueDate == today) return "今日到期";
            if (dueDate <= today.AddDays(3)) return "即將到期";
            return "正常";
        }

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(todobox.Text))
            {
                MessageBox.Show("請輸入待辦事項。");
                todobox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(contextbox.Text))
            {
                MessageBox.Show("請輸入詳細內容。");
                contextbox.Focus();
                return false;
            }

            if (combotype.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇歸屬分類。");
                combotype.Focus();
                return false;
            }

            return true;
        }

        // 新增
        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            TodoItem item = new TodoItem();
            item.Id = nextId;
            item.Title = todobox.Text.Trim();
            item.Description = contextbox.Text.Trim();
            item.Status = GetSelectedStatus();
            item.Category = combotype.Text;
            item.DueDate = month.SelectionStart.Date;
            item.CreatedAt = DateTime.Now;

            todoList.Add(item);
            nextId++;

            _isDirty = true; // 標記資料已變更

            RefreshClassFilterOptions();
            UpdateAllDisplay();
            InitDefaultValue();

            MessageBox.Show("新增成功！");
        }

        // 刪除
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("請先從下方表格選擇一筆資料。");
                return;
            }

            DialogResult result = MessageBox.Show(
                "確定要刪除這筆待辦事項嗎？",
                "刪除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes) return;

            TodoItem item = todoList.FirstOrDefault(x => x.Id == selectedId);
            if (item != null) todoList.Remove(item);

            _isDirty = true; // 標記資料已變更

            RefreshClassFilterOptions();
            UpdateAllDisplay();
            InitDefaultValue();

            MessageBox.Show("刪除成功！");
        }

        // 修改
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("請先從下方表格選擇一筆資料。");
                return;
            }

            if (!CheckInput()) return;

            TodoItem item = todoList.FirstOrDefault(x => x.Id == selectedId);
            if (item == null)
            {
                MessageBox.Show("找不到要修改的資料。");
                return;
            }

            item.Title = todobox.Text.Trim();
            item.Description = contextbox.Text.Trim();
            item.Status = GetSelectedStatus();
            item.Category = combotype.Text;
            item.DueDate = month.SelectionStart.Date;

            _isDirty = true; // 標記資料已變更

            RefreshClassFilterOptions();
            UpdateAllDisplay();
            InitDefaultValue();

            MessageBox.Show("修改成功！");
        }

        private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTodos.Rows[e.RowIndex].Cells["Id"].Value == null)
            {
                MessageBox.Show("這一列沒有編號資料。");
                return;
            }

            int id = Convert.ToInt32(dgvTodos.Rows[e.RowIndex].Cells["Id"].Value);
            TodoItem item = todoList.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                MessageBox.Show("找不到這筆待辦事項資料。");
                return;
            }

            selectedId = item.Id;

            todobox.Text = item.Title;
            contextbox.Text = item.Description;
            SetSelectedStatus(item.Status);
            combotype.Text = item.Category;
            month.SetDate(item.DueDate);

            MessageBox.Show("已選取：" + item.Title);
        }

        private void UpdateStats()
        {
            int total = todoList.Count;
            int notDone = todoList.Count(x => x.Status == "未完成");
            int doing = todoList.Count(x => x.Status == "進行中");
            int done = todoList.Count(x => x.Status == "已完成");

            double rate = total > 0 ? (double)done / total * 100 : 0;

            label5.Text = total.ToString();
            label6.Text = notDone.ToString();
            label7.Text = doing.ToString();
            label8.Text = done.ToString();
            label9.Text = rate.ToString("0") + " %";
        }

        // 取得目前關鍵字、狀態、分類篩選後的結果
        private List<TodoItem> GetCombinedFilterResult()
        {
            string keyword = textBox3.Text.Trim();

            string selectedStatus = "全部";
            string selectedClass = "全部";

            if (statuscombo.SelectedItem != null)
            {
                selectedStatus = statuscombo.SelectedItem.ToString();
            }

            if (classcombo.SelectedItem != null)
            {
                selectedClass = classcombo.SelectedItem.ToString();
            }

            IEnumerable<TodoItem> query = todoList;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    x.Title.Contains(keyword) ||
                    x.Description.Contains(keyword) ||
                    x.Category.Contains(keyword) ||
                    x.Status.Contains(keyword) ||
                    GetAlertStatus(x).Contains(keyword) ||
                    x.DueDate.ToString("yyyy/MM/dd").Contains(keyword)
                );
            }

            if (selectedStatus != "全部")
            {
                query = query.Where(x => x.Status == selectedStatus);
            }

            if (selectedClass != "全部")
            {
                query = query.Where(x => x.Category == selectedClass);
            }

            return query
                .OrderBy(x => x.DueDate)
                .ThenBy(x => x.Id)
                .ToList();
        }

        private void ApplyCombinedFilter(bool showNoResultMessage)
        {
            List<TodoItem> result = GetCombinedFilterResult();

            if (result.Count == 0 && showNoResultMessage)
            {
                MessageBox.Show(
                    "查無符合條件的待辦事項。",
                    "查無結果",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            RefreshGrid(result);
        }

        // 狀態篩選、分類篩選 ComboBox 改變時，自動篩選
        private void FilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializingFilter)
            {
                return;
            }

            ApplyCombinedFilter(false);
        }

        // 顯示全部
        private void allbutton_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            ResetFilterComboOnly();
            RefreshGrid(todoList);
        }

        // 今日待辦
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            var result = todoList
                .Where(x =>
                    x.DueDate.Date == today &&
                    x.Status != "已完成"
                )
                .OrderBy(x => x.DueDate)
                .ThenBy(x => x.Id)
                .ToList();

            RefreshGrid(result);

            if (result.Count == 0)
            {
                MessageBox.Show(
                    "今天沒有尚未完成的待辦事項。",
                    "今日待辦",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // 三日內到期
        private void button8_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime threeDaysLater = today.AddDays(3);

            var result = todoList
                .Where(x =>
                    x.DueDate.Date > today &&
                    x.DueDate.Date <= threeDaysLater &&
                    x.Status != "已完成"
                )
                .OrderBy(x => x.DueDate)
                .ThenBy(x => x.Id)
                .ToList();

            RefreshGrid(result);

            if (result.Count == 0)
            {
                MessageBox.Show(
                    "未來三天內沒有即將到期的待辦事項。",
                    "三日內到期",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // 關鍵字查詢，按 Enter
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            ApplyCombinedFilter(true);
        }

        // 查詢按鈕
        private void button4_Click(object sender, EventArgs e)
        {
            ApplyCombinedFilter(true);
        }

        private void SaveTodoListToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, new UTF8Encoding(true)))
            {
                writer.WriteLine("Id,Title,Description,Status,Category,DueDate,CreatedAt");

                foreach (TodoItem item in todoList)
                {
                    string line = string.Join(",",
                        EscapeCsv(item.Id.ToString()),
                        EscapeCsv(item.Title),
                        EscapeCsv(item.Description),
                        EscapeCsv(item.Status),
                        EscapeCsv(item.Category),
                        EscapeCsv(item.DueDate.ToString("yyyy-MM-dd")),
                        EscapeCsv(item.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"))
                    );
                    writer.WriteLine(line);
                }
            }
        }

        private string[] ReadCsvLines(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);

            if (bytes.Length >= 3 &&
                bytes[0] == 0xEF &&
                bytes[1] == 0xBB &&
                bytes[2] == 0xBF)
            {
                return File.ReadAllLines(filePath, Encoding.UTF8);
            }

            return File.ReadAllLines(filePath, Encoding.Default);
        }

        private void LoadTodoListFromCsv(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("找不到檔案。");
                return;
            }

            string[] lines = ReadCsvLines(filePath);

            if (lines.Length <= 1)
            {
                MessageBox.Show("CSV 檔案沒有資料。");
                return;
            }

            todoList.Clear();

            int successCount = 0;
            int failCount = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                List<string> values = ParseCsvLineAuto(lines[i]);

                if (values.Count < 7)
                {
                    failCount++;
                    continue;
                }

                TodoItem item = new TodoItem();

                int id;
                item.Id = int.TryParse(values[0].Trim(), out id) ? id : nextId;

                item.Title = values[1].Trim();
                item.Description = values[2].Trim();
                item.Status = values[3].Trim();
                item.Category = values[4].Trim();

                DateTime dueDate;
                item.DueDate = DateTime.TryParse(values[5].Trim(), out dueDate)
                    ? dueDate : DateTime.Today;

                DateTime createdAt;
                item.CreatedAt = DateTime.TryParse(values[6].Trim(), out createdAt)
                    ? createdAt : DateTime.Now;

                todoList.Add(item);
                successCount++;
            }

            nextId = todoList.Count > 0 ? todoList.Max(x => x.Id) + 1 : 1;

            _isDirty = false; // 載入後重設，尚未有任何修改

            RefreshClassFilterOptions();
            UpdateAllDisplay();
            InitDefaultValue();

            MessageBox.Show(
                "CSV 載入完成！\n" +
                "成功載入：" + successCount + " 筆\n" +
                "失敗略過：" + failCount + " 筆"
            );
        }

        private string EscapeCsv(string value)
        {
            if (value == null) return "";

            bool needQuote =
                value.Contains(",") ||
                value.Contains("\"") ||
                value.Contains("\n") ||
                value.Contains("\r");

            value = value.Replace("\"", "\"\"");

            if (needQuote) value = "\"" + value + "\"";

            return value;
        }

        private List<string> ParseCsvLineAuto(string line)
        {
            return ParseCsvLine(line, DetectDelimiter(line));
        }

        private char DetectDelimiter(string line)
        {
            int commaCount = line.Count(c => c == ',');
            int tabCount = line.Count(c => c == '\t');
            int semicolonCount = line.Count(c => c == ';');

            if (tabCount >= commaCount && tabCount >= semicolonCount) return '\t';
            if (semicolonCount >= commaCount) return ';';
            return ',';
        }

        private List<string> ParseCsvLine(string line, char delimiter)
        {
            List<string> result = new List<string>();
            StringBuilder current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == delimiter && !inQuotes)
                {
                    result.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            result.Add(current.ToString());
            return result;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "開啟待辦事項 CSV";
            openFileDialog.Filter = "CSV 檔案 (*.csv)|*.csv|所有檔案 (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadTodoListFromCsv(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "儲存待辦事項 CSV";
            saveFileDialog.Filter = "CSV 檔案 (*.csv)|*.csv";
            saveFileDialog.FileName = "TodoList.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveTodoListToCsv(saveFileDialog.FileName);
                _isDirty = false; // 儲存後重設變更旗標
                MessageBox.Show("CSV 儲存成功！");
            }
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manualForm = new Form();

            manualForm.Text = "使用說明 - 個人代辦事項管理系統";
            manualForm.StartPosition = FormStartPosition.CenterParent;
            manualForm.Size = new Size(760, 620);
            manualForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            manualForm.MaximizeBox = false;
            manualForm.MinimizeBox = false;
            manualForm.BackColor = Color.FromArgb(236, 248, 255);

            Label titleLabel = new Label();
            titleLabel.Text = "📘 個人代辦事項管理系統 使用說明";
            titleLabel.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(37, 99, 235);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(30, 25);

            RichTextBox manualText = new RichTextBox();
            manualText.ReadOnly = true;
            manualText.BorderStyle = BorderStyle.None;
            manualText.BackColor = Color.White;
            manualText.ForeColor = Color.FromArgb(15, 23, 42);
            manualText.Font = new Font("微軟正黑體", 11F);
            manualText.Location = new Point(30, 80);
            manualText.Size = new Size(680, 420);
            manualText.Text =
        @"一、系統功能介紹

本系統主要用來管理個人待辦事項，可新增、修改、刪除、查詢待辦資料，並透過統計區快速查看目前任務完成狀況。

二、新增待辦事項

1. 在「代辦事項」輸入任務名稱。
2. 在「詳細內容」輸入任務說明。
3. 選擇目前狀態：未完成、進行中、已完成。
4. 選擇歸屬分類，例如：學校、工作、生活、購物等。
5. 選擇截止日期。
6. 按下「新增」即可建立待辦事項。

三、修改待辦事項

1. 先在下方表格點選要修改的資料。
2. 系統會自動將資料帶入上方輸入區。
3. 修改內容後，按下「修改」即可更新資料。

四、刪除待辦事項

1. 先在下方表格點選要刪除的資料。
2. 按下「刪除」。
3. 系統會跳出確認視窗，確認後即可刪除。

五、智慧篩選區

1. 關鍵字搜尋：
   可輸入待辦事項、詳細內容、分類、狀態或日期進行查詢。

2. 顯示全部：
   可清除目前查詢條件，重新顯示所有待辦事項。

3. 狀態篩選：
   可依照「全部、未完成、進行中、已完成」篩選資料。

4. 分類篩選：
   可依照「學校、工作、生活、購物、重要事項、其他」篩選資料。

5. 今日待辦：
   顯示今天截止且尚未完成的待辦事項。

6. 三日內到期：
   顯示未來三天內即將到期且尚未完成的待辦事項。

六、統計總覽

右側統計區會自動顯示：
1. 總代辦數量
2. 未完成數量
3. 進行中數量
4. 已完成數量
5. 完成率
6. 待辦狀態比例圖

七、CSV 檔案功能

上方 File 選單可使用：
1. Load：載入 CSV 待辦資料。
2. Save：將目前待辦資料儲存成 CSV 檔案。
3. 清除並新建：清除目前所有資料，回到初始空白狀態。

八、提醒狀態說明

系統會依照截止日期自動判斷提醒狀態：
1. 已逾期：截止日期已過，且尚未完成。
2. 今日到期：截止日期為今天。
3. 即將到期：三天內即將截止。
4. 正常：尚未接近截止日期。
5. 已完成：任務已完成。";

            Button closeButton = new Button();
            closeButton.Text = "關閉";
            closeButton.Font = new Font("微軟正黑體", 11F, FontStyle.Bold);
            closeButton.BackColor = Color.FromArgb(14, 165, 233);
            closeButton.ForeColor = Color.White;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Size = new Size(120, 42);
            closeButton.Location = new Point(590, 520);
            closeButton.Click += (s, args) =>
            {
                manualForm.Close();
            };

            manualForm.Controls.Add(titleLabel);
            manualForm.Controls.Add(manualText);
            manualForm.Controls.Add(closeButton);

            manualForm.ShowDialog(this);
        }

        // 清除並新建
        private void outnowfile_Click(object sender, EventArgs e)
        {
            // 根據是否有未儲存的變更，決定提示訊息與圖示
            string msg = _isDirty
                ? "目前資料有未儲存的變更，確定要清除所有資料並重新開始嗎？\n（未儲存的內容將會遺失）"
                : "即將清除所有資料並回到初始空白狀態，確定嗎？";

            string title = _isDirty ? "⚠ 尚未儲存" : "確認清除";

            MessageBoxIcon icon = _isDirty
                ? MessageBoxIcon.Warning
                : MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, icon);

            if (result != DialogResult.Yes) return;

            // 清除所有資料
            todoList.Clear();
            nextId = 1;
            selectedId = -1;

            // 重設篩選分類選項
            RefreshClassFilterOptions();

            // 重設所有欄位
            InitDefaultValue();

            // 刷新畫面（表格、統計、圓餅圖）
            UpdateAllDisplay();

            // 重設變更旗標
            _isDirty = false;

            MessageBox.Show("已清除所有資料，回到初始狀態。", "清除完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class TodoView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string DueDateText { get; set; }
        public string AlertStatus { get; set; }
    }
}