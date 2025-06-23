# Payroll_Program
A Windows Forms payroll application built in Visual Basic, featuring multiple forms, tax calculations, and UI navigation via both buttons and menus.

---
## 💡 About This Project

This payroll application was built to explore real-world logic using multiple forms in Visual Basic and Windows Forms. It calculates gross and net pay for hourly and salaried employees, applying taxes based on user inputs. The project also demonstrates different UI navigation methods (buttons and menus) and accumulates daily pay totals.

---

## 🧾 Features

### 👤 **Employee Types**
- **Hourly Employees**
  - Enter: Name, Hourly Wage, Hours Worked, Year-to-Date (YTD) Pay, State of Residence
  - Calculates:
    - Weekly Gross Pay (`Hourly Wage × Hours Worked`)
    - FICA, Federal Tax, State Tax (based on state entered)
    - Net Pay after all deductions
- **Salaried Employees**
  - Enter: Name, Yearly Salary, YTD Pay, State
  - Calculates:
    - Weekly Gross Pay (`Yearly Salary ÷ 52`)
    - FICA, Federal Tax, State Tax
    - Net Pay per week

### 🧮 **Tax Calculations**
State taxes are handled in each forms code varying depending on state.  FICA and Federal tax logic is handled in a separate **Payroll Module**, applying:
- FICA tax
- Federal income tax

### 📊 **Daily Totals**
- Tracks and displays:
  - Total gross pay distributed for the day
  - Total net pay distributed for the day
- Accessible via a dedicated button or menu item

### 🧭 **Navigation Options**
- Main form includes:
  - Four buttons: `Hourly`, `Salaried`, `Daily Totals`, and `Exit`
  - A matching **menu toolbar** for each action, demonstrating dual UI control

### 💬 **User Feedback**
- Displays a "Thank you" message after each form is closed

---

## 🖥️ How to Run

1. **Clone or download** this repository.
2. Open the `.sln` file in **Visual Studio**.
3. Build and run the solution.

> ⚠️ This application is intended for Windows systems with the **.NET Framework** installed.

---

## 📁 Project Structure

- `MainForm.vb`: Entry point with navigation
- `HourlyForm.vb`: UI for hourly employee input
- `SalariedForm.vb`: UI for salaried employee input
- `PayrollModule.vb`: Handles tax and pay calculations
-  Displays accumulated totals through a messagebox

---

## 📌 Notes
- There is **no license** associated with this repository. It is a **portfolio project only**, created to demonstrate my skills in Windows Forms development and Visual Basic logic.
- All tax logic is simplified for learning purposes and may not reflect actual tax rules.

---

## 🎯 Project Purpose & Motivation

This project was designed as a personal learning experience to help me strengthen my understanding of **multiple form applications** in Visual Basic and how different parts of an application can interact in a modular, maintainable way.

I wanted to:
- Apply **real-world payroll logic** including tax calculations and weekly pay structures.
- Gain experience using **buttons and menus** for navigation within the same application to demonstrate multiple ways of handling user interface controls.
- Work with **modular code structures**, such as using a shared module for tax calculations and separation of logic across forms.
- Build a **functional, user-friendly Windows Forms application** that could serve as a strong example of my ability to design, structure, and complete a project from scratch.

This application represents both a technical and practical learning milestone for me, and I’m sharing it here to showcase my work to employers and recruiters reviewing my portfolio.
