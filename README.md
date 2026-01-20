# 💰 Expense Tracker (Windows Forms)

<p align="center">
  <img src="https://i.imgur.com/E6XycXL.png">
  <br>
  <a href="https://youtu.be/p5dr-TtIy_8" target="_blank"><strong>📺 Video Demo</strong></a>
</p>

A desktop-based personal finance management application built with **C# WinForms**. This project focuses on delivering a modern, minimal user interface while managing local data persistence through **Microsoft Access (OleDB)**.

---

## 🛠️ Technologies Used

<p align="left">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white" /> 
  <img src="https://img.shields.io/badge/Microsoft_Access-A4373A?style=for-the-badge&logo=microsoft-access&logoColor=white">
</p>

---

## 🌟 Key Features

- **User Authentication:** Secure Login and Registration system.
- **Transaction Management:** Full CRUD (Create, Read, Update, Delete) operations for income and expense records.
- **Category Customization:** Dynamically add, edit, or remove transaction categories.
- **Profile Management:** In-app user profile updates.
- **Modern UI/UX:** Custom-styled components for a flat, minimal aesthetic, moving away from standard Windows legacy designs.

---

## 🧠 Technical Highlights

- **Database Integration:** Implemented data connectivity using **OleDB** to interact with a Microsoft Access (`.mdb`) database.
- **Custom UI Components:** Researched and implemented advanced GUI techniques to create a "Flat Design" look, utilizing custom-drawn controls and modern typography (Inter & Kanit).
- **Relational Data:** Managed 5 interconnected database tables to ensure data integrity between users, transactions, and categories.

---

## 📂 Project Architecture

```bash
Expense-Tracker/
├── ExpenseTracker.sln      # Main solution file
├── ExpenseTrackerDB.mdb    # Microsoft Access database (5 Tables)
├── ExpenseTracker/         # Source code folder
│   ├── Forms/              # All application UI Windows
│   ├── Resources/          # Asset management (Icons, Images)
│   └── CustomControls/     # Custom GUI implementations
└── Fonts/                  # Required fonts (Inter, Kanit)
```

---

## 📸 Application Preview

<details>
  <summary>Click to view screenshots</summary>
  <p align="center">
    <img src="https://i.imgur.com/TXyq7SS.png">
    <img src="https://i.imgur.com/ixAhWaL.png">
    <img src="https://i.imgur.com/PA248Hv.png">
    <img src="https://i.imgur.com/uFWbau6.png">
    <img src="https://i.imgur.com/k3YGTZy.png">
    <img src="https://i.imgur.com/cepU7Ac.png">
    <img src="https://i.imgur.com/64exE8u.png">
    <img src="https://i.imgur.com/YtIaQPI.png">
    <img src="https://i.imgur.com/1T32Xjb.png">
  </p>
</details>

---

## 🚀 Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/savant777/Expense-Tracker.git
   ```
2. **Open the Project:** Launch `ExpenseTracker.sln` in Visual Studio.
3. **Run:** Press `F5` or click **Start Debugging**.

*Note: Ensure the `.mdb` database file remains in the project root to maintain connection path integrity.*

---

## 📜 License

MIT License
