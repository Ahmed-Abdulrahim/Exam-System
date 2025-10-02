# ExamSystem
# 📝 Exam System

![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp)
![Console App](https://img.shields.io/badge/Type-Console%20App-lightgrey)
![License](https://img.shields.io/github/license/Ahmed-Abdulrahim/Exam-System)

---

## 📚 Project Overview

**Exam System** is a C# console application designed to simulate an exam environment for students. The system supports different question types, manages exam sessions, and allows students to participate in either practice or final exams.

### 🎯 Main Features

- **Multiple Question Types:**  
  - True/False  
  - Choose One Answer  
  - Choose Multiple Answers

- **Exam Modes:**  
  - Practice Exam  
  - Final Exam

- **Student Management:**  
  - Students can join exams and receive notifications when exams start.

- **Persistence:**  
  - Questions and exam logs are saved to files for tracking and review.

---

## 🧩 Project Logic

### 1. **Question Types**
- All questions inherit from an abstract `Question` class.
- Each question type (`TrueOrFalseQuestion`, `ChooseOneAnswer`, `ChooseMultipleAnswer`) implements its own logic for displaying the question and checking answers.

### 2. **Exam Flow**
- Exams are created with a subject, a list of questions, and a time limit.
- Two main exam types:
  - **PracticeExam:** For self-assessment.
  - **FinalExam:** For official evaluation.
- Students are notified when an exam starts via event handling.

### 3. **Student Interaction**
- Students select the exam type.
- The system displays questions and collects answers.
- Results are processed and displayed at the end.

### 4. **File Management**
- Questions and exam attempts are logged to text files for persistence.

---

## 🛠️ Technologies Used

| Technology | Purpose                |
|------------|------------------------|
| ![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp) | Main programming language |
| ![.NET 8](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet) | Application framework    |
| ![Console](https://img.shields.io/badge/Console%20App-CLI-lightgrey) | User interface           |
| ![OOP](https://img.shields.io/badge/OOP-Design-blue) | Object-oriented design   |
| ![Events](https://img.shields.io/badge/Events-Pattern-green) | Event-driven notifications |

---
2. **Open in Visual Studio 2022.**
3. **Build and run the project.**
4. **Follow the console instructions to take an exam.**

---

## 👨‍💻 Author

- [Ahmed Abdulrahim](https://github.com/Ahmed-Abdulrahim)

## 🚀 Getting Started

1. **Clone the repository:**
