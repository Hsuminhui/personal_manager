# 個人待辦事項管理系統

系統介面如下:

<img width="1122" height="659" alt="image" src="https://github.com/user-attachments/assets/22db1635-4b94-4997-aa9b-7db7c35ef11f" />

## 功能特色

- **檔案建立操作**：新增、修改、刪除待辦事項
- **多欄位記錄**：事項名稱、詳細內容、狀態、分類、截止日期、建立時間
- **智慧提醒狀態**：自動判斷「已逾期 / 今日到期 / 即將到期 / 正常 / 已完成」
- **多條件篩選**：關鍵字搜尋 + 狀態下拉 + 分類下拉，可組合使用
- **快速篩選**：「今日待辦」與「三日內到期」一鍵切換
- **統計總覽**：即時顯示總數、各狀態數量與完成率
- **圓餅圖**：待辦狀態比例視覺化
- **CSV 支援**：載入 / 儲存資料
- **使用說明**：內建 User Manual 選單，點開即可查閱操作指南
- **清除並新建**：一鍵清空所有資料，回到初始狀態

使用說明介面:

<img width="557" height="459" alt="image" src="https://github.com/user-attachments/assets/69212af2-9594-499b-9f1d-099152b5a2f4" />


---

## 快速上手

### 新增待辦事項

1. 在「代辦事項」輸入任務名稱
2. 在「詳細內容」輸入說明
3. 選擇狀態（未完成 / 進行中 / 已完成）
4. 選擇分類（學校 / 工作 / 生活 / 購物 / 重要事項 / 其他）
5. 設定截止日期
6. 點擊「新增」

(新增代辦事項畫面)

<img width="1123" height="659" alt="image" src="https://github.com/user-attachments/assets/164cec3b-67ee-4bc2-bce9-90041d3e095c" />

### 修改 / 刪除

- 在下方表格**點選一筆資料**，資料會自動帶入上方欄位
- 修改後點擊「修改」，或直接點擊「刪除」並確認

刪除功能:

(選取刪除項)
<img width="1123" height="659" alt="螢幕擷取畫面 2026-06-21 170231" src="https://github.com/user-attachments/assets/70f39741-6107-4930-9c9c-84966640142c" />

(跳出"刪除確認"確認視窗)
<img width="1122" height="658" alt="螢幕擷取畫面 2026-06-21 170243" src="https://github.com/user-attachments/assets/44653b46-f9fe-4360-bd3b-4d7a9a4ff5a3" />

(刪除成功)
<img width="1124" height="663" alt="螢幕擷取畫面 2026-06-21 170257" src="https://github.com/user-attachments/assets/0685ce39-af31-4c82-b6e6-61bcceb70fbd" />

修改功能:

(選取修改項)
<img width="1124" height="656" alt="螢幕擷取畫面 2026-06-21 170607" src="https://github.com/user-attachments/assets/82bc3c4c-ad55-4323-bee7-5df3392b659d" />

(修改成功)
<img width="1121" height="659" alt="螢幕擷取畫面 2026-06-21 170619" src="https://github.com/user-attachments/assets/374b1831-38f4-4b9b-800c-9c99baae757b" />

### 篩選查詢

- 在關鍵字欄輸入文字後按 `Enter` 或點擊「查詢」
- 使用狀態、分類下拉選單組合篩選
- 「今日待辦」顯示今天截止且未完成的事項
- 「三日內到期」顯示未來三天內到期且未完成的事項
- 「顯示全部」清除所有篩選條件

關鍵字欄輸入查詢:
<img width="1123" height="656" alt="image" src="https://github.com/user-attachments/assets/b2ce32fd-62a2-4bf9-a087-cc3c668d5bc6" />

使用狀態、分類下拉選單組合篩選:
<img width="1121" height="658" alt="image" src="https://github.com/user-attachments/assets/0413e1df-de37-4a12-a501-86218ada9deb" />

### CSV 匯入匯出

- 上方選單 **File → Load**：載入 CSV 檔案
- 上方選單 **File → Save**：儲存 CSV 檔案

載入 CSV 檔案:
<img width="1127" height="659" alt="螢幕擷取畫面 2026-06-21 170938" src="https://github.com/user-attachments/assets/76307cd6-2550-4780-b032-a84270227bbb" />

(載入成功)
<img width="1123" height="661" alt="螢幕擷取畫面 2026-06-21 170952" src="https://github.com/user-attachments/assets/197e811c-0196-4e33-a698-e666a9ae26a9" />

儲存 CSV 檔案:
<img width="1118" height="659" alt="螢幕擷取畫面 2026-06-21 171057" src="https://github.com/user-attachments/assets/3f15d72e-edb4-47eb-be01-83e2524b1380" />

(儲存成功)
<img width="1121" height="662" alt="螢幕擷取畫面 2026-06-21 171107" src="https://github.com/user-attachments/assets/740e5489-b059-49d1-a044-fe5c9ae1488d" />

---

## 提醒狀態說明

| 提醒狀態 | 說明 |
|----------|------|
| 已逾期 | 截止日期已過，且尚未完成 |
| 今日到期 | 截止日期為今天 |
| 即將到期 | 三天內即將截止 |
| 正常 | 尚未接近截止日期 |
| 已完成 | 任務已標記為完成 |

---

## 注意事項

- 本系統**不會自動儲存**，關閉前請手動執行 File → Save
- 若有未儲存的變更，執行「清除並新建」時會出現警示
