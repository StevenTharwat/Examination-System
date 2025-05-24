
# 🧪 C# Examination System

This is a modular console-based Examination System developed in C#. It allows users to take different types of exams (e.g., Final, Practical) using a flexible question/answer structure. The project showcases object-oriented programming concepts like inheritance, polymorphism, and data encapsulation.

---

## 🔍 Features

- ✅ **Final and Practical Exam Modes**
- 🧠 **Supports Multiple Question Types**:
  - True/False
  - Choose One
  - Choose All That Apply
- 💾 **JSON-Based Question Persistence**
- 🗂️ **Separate Models for Questions, Answers, and Exams**
- 🔐 **Answer Evaluation and Marking System**

---

## 🏗️ Project Structure

```
Examination/
├── ExamGroup/
│   ├── Exam.cs
│   ├── FinalExam.cs
│   └── PracticalExam.cs
│
├── QuestionGroup/
│   ├── Question.cs
│   ├── ChooseOne.cs
│   ├── ChooseAll.cs
│   ├── TrueFalseQuestion.cs
│   ├── QuestionList.cs
│
├── AnswerGroup/
│   ├── Answer.cs
│   └── AnswerList.cs
```

---

## 🛠️ How It Works

1. Exams are created with a duration and a `QuestionList` (JSON-backed).
2. Each `Question` object holds multiple `Answer` objects, only some of which are correct.
3. User answers are parsed and validated.
4. Exams are automatically corrected based on user input vs. correct answers.
5. Final scores are displayed.

---

## 📦 Requirements

- [.NET 6.0 SDK or higher](https://dotnet.microsoft.com/en-us/download)

---

## ▶️ Getting Started

1. Clone the repo:
   ```bash
   git clone https://github.com/StevenTharwat/Examination-System.git
   ```
2. Open the solution in Visual Studio or run via CLI:
   ```bash
   dotnet run
   ```

---

## 📂 File-Based Questions

Questions are saved as JSON and loaded dynamically:
```json
[
  {
    "Type": "Choose One Answer",
    "Body": "What is 2 + 2?",
    "Marks": 1,
    "Answers": [
      { "Description": "3", "IsCorret": false },
      { "Description": "4", "IsCorret": true },
      { "Description": "5", "IsCorret": false }
    ]
  }
]
```

---

## 📜 License

This project is open source.
