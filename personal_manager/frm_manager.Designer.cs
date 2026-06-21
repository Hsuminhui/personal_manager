namespace personal_manager
{
    partial class frm_manager
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.outnowfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.classcombo = new System.Windows.Forms.ComboBox();
            this.statuscombo = new System.Windows.Forms.ComboBox();
            this.classlbl = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.allbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblleft = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblright = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finishrate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbling = new System.Windows.Forms.Label();
            this.lblfinished = new System.Windows.Forms.Label();
            this.lblunfinished = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltodo = new System.Windows.Forms.Label();
            this.lbldue = new System.Windows.Forms.Label();
            this.lblnow = new System.Windows.Forms.Label();
            this.lblcontext = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.todobox = new System.Windows.Forms.TextBox();
            this.contextbox = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.MonthCalendar();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvTodos = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(170)))));
            this.pnlHeader.Controls.Add(this.lbltitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1500, 61);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(548, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(468, 48);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "📋  個人待辦事項管理系統";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.outnowfile);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.button7);
            this.pnlInput.Controls.Add(this.classcombo);
            this.pnlInput.Controls.Add(this.statuscombo);
            this.pnlInput.Controls.Add(this.classlbl);
            this.pnlInput.Controls.Add(this.statuslbl);
            this.pnlInput.Controls.Add(this.button8);
            this.pnlInput.Controls.Add(this.button6);
            this.pnlInput.Controls.Add(this.allbutton);
            this.pnlInput.Controls.Add(this.button4);
            this.pnlInput.Controls.Add(this.lblsearch);
            this.pnlInput.Controls.Add(this.lblleft);
            this.pnlInput.Controls.Add(this.textBox3);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 96);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlInput.Size = new System.Drawing.Size(300, 754);
            this.pnlInput.TabIndex = 2;
            // 
            // outnowfile
            // 
            this.outnowfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.outnowfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outnowfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.outnowfile.FlatAppearance.BorderSize = 2;
            this.outnowfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.outnowfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outnowfile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outnowfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.outnowfile.Location = new System.Drawing.Point(22, 605);
            this.outnowfile.Name = "outnowfile";
            this.outnowfile.Size = new System.Drawing.Size(246, 50);
            this.outnowfile.TabIndex = 43;
            this.outnowfile.Text = "跳出目前檔案";
            this.outnowfile.UseVisualStyleBackColor = false;
            this.outnowfile.Click += new System.EventHandler(this.outnowfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(18, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(18, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(50)))), ((int)(((byte)(190)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(22, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(246, 42);
            this.button7.TabIndex = 40;
            this.button7.Text = "⚙ 套用篩選";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // classcombo
            // 
            this.classcombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.classcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classcombo.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.classcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.classcombo.FormattingEnabled = true;
            this.classcombo.Items.AddRange(new object[] {
            "全部",
            "學校",
            "工作",
            "生活",
            "購物",
            "重要事項",
            "其他"});
            this.classcombo.Location = new System.Drawing.Point(124, 308);
            this.classcombo.Name = "classcombo";
            this.classcombo.Size = new System.Drawing.Size(144, 32);
            this.classcombo.TabIndex = 39;
            // 
            // statuscombo
            // 
            this.statuscombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.statuscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statuscombo.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.statuscombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.statuscombo.FormattingEnabled = true;
            this.statuscombo.Items.AddRange(new object[] {
            "全部",
            "未完成",
            "進行中",
            "已完成"});
            this.statuscombo.Location = new System.Drawing.Point(124, 258);
            this.statuscombo.Name = "statuscombo";
            this.statuscombo.Size = new System.Drawing.Size(144, 32);
            this.statuscombo.TabIndex = 38;
            // 
            // classlbl
            // 
            this.classlbl.AutoSize = true;
            this.classlbl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.classlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.classlbl.Location = new System.Drawing.Point(22, 312);
            this.classlbl.Name = "classlbl";
            this.classlbl.Size = new System.Drawing.Size(109, 30);
            this.classlbl.TabIndex = 37;
            this.classlbl.Text = "分類篩選";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statuslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.statuslbl.Location = new System.Drawing.Point(22, 262);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(109, 30);
            this.statuslbl.TabIndex = 36;
            this.statuslbl.Text = "狀態篩選";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(200)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(22, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(246, 50);
            this.button8.TabIndex = 35;
            this.button8.Text = "三日內到期：0";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button6.Location = new System.Drawing.Point(22, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 50);
            this.button6.TabIndex = 33;
            this.button6.Text = "今日待辦：0";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // allbutton
            // 
            this.allbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.allbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.allbutton.FlatAppearance.BorderSize = 2;
            this.allbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.allbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.allbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.allbutton.Location = new System.Drawing.Point(152, 158);
            this.allbutton.Name = "allbutton";
            this.allbutton.Size = new System.Drawing.Size(116, 40);
            this.allbutton.TabIndex = 32;
            this.allbutton.Text = "↺ 全部";
            this.allbutton.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(22, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 25;
            this.button4.Text = "🔍 搜尋";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblsearch.Location = new System.Drawing.Point(22, 78);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(133, 30);
            this.lblsearch.TabIndex = 31;
            this.lblsearch.Text = "關鍵字搜尋";
            // 
            // lblleft
            // 
            this.lblleft.AutoSize = true;
            this.lblleft.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblleft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblleft.Location = new System.Drawing.Point(18, 22);
            this.lblleft.Name = "lblleft";
            this.lblleft.Size = new System.Drawing.Size(232, 40);
            this.lblleft.TabIndex = 30;
            this.lblleft.Text = "🔎  智慧篩選區";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.textBox3.Location = new System.Drawing.Point(22, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(246, 35);
            this.textBox3.TabIndex = 20;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.lblright);
            this.pnlList.Controls.Add(this.label9);
            this.pnlList.Controls.Add(this.finishrate);
            this.pnlList.Controls.Add(this.label8);
            this.pnlList.Controls.Add(this.label7);
            this.pnlList.Controls.Add(this.label6);
            this.pnlList.Controls.Add(this.label5);
            this.pnlList.Controls.Add(this.lbling);
            this.pnlList.Controls.Add(this.lblfinished);
            this.pnlList.Controls.Add(this.lblunfinished);
            this.pnlList.Controls.Add(this.lbltotal);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlList.Location = new System.Drawing.Point(1184, 96);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(316, 754);
            this.pnlList.TabIndex = 3;
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblright.Location = new System.Drawing.Point(28, 22);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(200, 40);
            this.lblright.TabIndex = 35;
            this.lblright.Text = "📊  統計總覽";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            this.label9.Location = new System.Drawing.Point(188, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 56);
            this.label9.TabIndex = 29;
            this.label9.Text = "0 %";
            // 
            // finishrate
            // 
            this.finishrate.AutoSize = true;
            this.finishrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finishrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.finishrate.Location = new System.Drawing.Point(38, 332);
            this.finishrate.Name = "finishrate";
            this.finishrate.Size = new System.Drawing.Size(85, 30);
            this.finishrate.TabIndex = 28;
            this.finishrate.Text = "完成率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(188, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 56);
            this.label8.TabIndex = 27;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(188, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 56);
            this.label7.TabIndex = 26;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(188, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 56);
            this.label6.TabIndex = 25;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(188, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 56);
            this.label5.TabIndex = 24;
            this.label5.Text = "0";
            // 
            // lbling
            // 
            this.lbling.AutoSize = true;
            this.lbling.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lbling.Location = new System.Drawing.Point(38, 208);
            this.lbling.Name = "lbling";
            this.lbling.Size = new System.Drawing.Size(85, 30);
            this.lbling.TabIndex = 23;
            this.lbling.Text = "進行中";
            // 
            // lblfinished
            // 
            this.lblfinished.AutoSize = true;
            this.lblfinished.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblfinished.Location = new System.Drawing.Point(38, 270);
            this.lblfinished.Name = "lblfinished";
            this.lblfinished.Size = new System.Drawing.Size(85, 30);
            this.lblfinished.TabIndex = 22;
            this.lblfinished.Text = "已完成";
            // 
            // lblunfinished
            // 
            this.lblunfinished.AutoSize = true;
            this.lblunfinished.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblunfinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblunfinished.Location = new System.Drawing.Point(38, 146);
            this.lblunfinished.Name = "lblunfinished";
            this.lblunfinished.Size = new System.Drawing.Size(85, 30);
            this.lblunfinished.TabIndex = 21;
            this.lblunfinished.Text = "未完成";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lbltotal.Location = new System.Drawing.Point(38, 84);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(85, 30);
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = "總代辦";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1500, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.fileToolStripMenuItem.Text = "📁 File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.loadToolStripMenuItem.Text = "載入 Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.saveToolStripMenuItem.Text = "儲存 Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.userManualToolStripMenuItem.Text = "User Manual";
            // 
            // lbltodo
            // 
            this.lbltodo.AutoSize = true;
            this.lbltodo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lbltodo.Location = new System.Drawing.Point(420, 142);
            this.lbltodo.Name = "lbltodo";
            this.lbltodo.Size = new System.Drawing.Size(155, 31);
            this.lbltodo.TabIndex = 5;
            this.lbltodo.Text = "✏  代辦事項";
            // 
            // lbldue
            // 
            this.lbldue.AutoSize = true;
            this.lbldue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lbldue.Location = new System.Drawing.Point(420, 378);
            this.lbldue.Name = "lbldue";
            this.lbldue.Size = new System.Drawing.Size(155, 31);
            this.lbldue.TabIndex = 6;
            this.lbldue.Text = "📅  截止日期";
            // 
            // lblnow
            // 
            this.lblnow.AutoSize = true;
            this.lblnow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblnow.Location = new System.Drawing.Point(420, 258);
            this.lblnow.Name = "lblnow";
            this.lblnow.Size = new System.Drawing.Size(155, 31);
            this.lblnow.TabIndex = 7;
            this.lblnow.Text = "⚡  目前狀態";
            // 
            // lblcontext
            // 
            this.lblcontext.AutoSize = true;
            this.lblcontext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcontext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblcontext.Location = new System.Drawing.Point(420, 198);
            this.lblcontext.Name = "lblcontext";
            this.lblcontext.Size = new System.Drawing.Size(155, 31);
            this.lblcontext.TabIndex = 8;
            this.lblcontext.Text = "📝  詳細內容";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lbltype.Location = new System.Drawing.Point(420, 318);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(155, 31);
            this.lbltype.TabIndex = 9;
            this.lbltype.Text = "🏷  歸屬分類";
            // 
            // todobox
            // 
            this.todobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.todobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todobox.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.todobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.todobox.Location = new System.Drawing.Point(580, 142);
            this.todobox.Multiline = true;
            this.todobox.Name = "todobox";
            this.todobox.Size = new System.Drawing.Size(430, 32);
            this.todobox.TabIndex = 10;
            // 
            // contextbox
            // 
            this.contextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.contextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextbox.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.contextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.contextbox.Location = new System.Drawing.Point(580, 196);
            this.contextbox.Multiline = true;
            this.contextbox.Name = "contextbox";
            this.contextbox.Size = new System.Drawing.Size(430, 33);
            this.contextbox.TabIndex = 11;
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.month.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.month.Location = new System.Drawing.Point(580, 378);
            this.month.MaxSelectionCount = 1;
            this.month.Name = "month";
            this.month.TabIndex = 12;
            this.month.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.month.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(170)))));
            this.month.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            // 
            // combotype
            // 
            this.combotype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combotype.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combotype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "學校",
            "工作",
            "生活",
            "購物",
            "重要事項",
            "其他"});
            this.combotype.Location = new System.Drawing.Point(580, 312);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(210, 39);
            this.combotype.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.radioButton1.Location = new System.Drawing.Point(580, 254);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 35);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "未完成";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.radioButton2.Location = new System.Drawing.Point(700, 254);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 35);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "進行中";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(80)))));
            this.radioButton3.Location = new System.Drawing.Point(820, 254);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 35);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "已完成";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "＋ 新增";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.button2.Location = new System.Drawing.Point(630, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "✕ 刪除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(780, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "✎ 修改";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvTodos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTodos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodos.ColumnHeadersHeight = 40;
            this.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodos.EnableHeadersVisualStyles = false;
            this.dgvTodos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(218)))), ((int)(((byte)(240)))));
            this.dgvTodos.Location = new System.Drawing.Point(299, 625);
            this.dgvTodos.Name = "dgvTodos";
            this.dgvTodos.RowHeadersVisible = false;
            this.dgvTodos.RowHeadersWidth = 62;
            this.dgvTodos.RowTemplate.Height = 38;
            this.dgvTodos.Size = new System.Drawing.Size(885, 225);
            this.dgvTodos.TabIndex = 24;
            // 
            // frm_manager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.dgvTodos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.month);
            this.Controls.Add(this.contextbox);
            this.Controls.Add(this.todobox);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblcontext);
            this.Controls.Add(this.lblnow);
            this.Controls.Add(this.lbldue);
            this.Controls.Add(this.lbltodo);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人待辦事項管理系統";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ── 控件宣告 ────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lbltodo;
        private System.Windows.Forms.Label lbldue;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.Label lblcontext;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox todobox;
        private System.Windows.Forms.TextBox contextbox;
        private System.Windows.Forms.MonthCalendar month;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbling;
        private System.Windows.Forms.Label lblfinished;
        private System.Windows.Forms.Label lblunfinished;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblleft;
        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label finishrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvTodos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button allbutton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox classcombo;
        private System.Windows.Forms.ComboBox statuscombo;
        private System.Windows.Forms.Label classlbl;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.Button outnowfile;
    }
}