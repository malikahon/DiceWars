🎲 DiceWars – Fundamentals of Programming Coursework
DiceWars is a programming project developed as part of the Fundamentals of Programming course. It showcases core programming concepts in C#, with a focus on object-oriented design, database interaction, and application structure in Visual Studio.
This project simulates a turn-based dice combat game, demonstrating how logic, data handling, and UI components can be integrated into a functioning application.

Key Features
Turn-Based Combat Logic using dice rolls
Data-Driven Architecture with an integrated SQLite database (Dice_Wars.db)
Object-Oriented Programming (OOP) principles such as classes and methods (Clash.cs, ByAttribute.cs)
Separation of Concerns via a clear Data Access Layer (DAL)
App configuration using App.config for connection strings and settings

Technologies Used
C# (.NET Framework)
Visual Studio
SQLite (via .db file)
Windows Forms or Console Interface (depending on the project type)

Project Structure: 
bash
Copy
Edit
DiceWars/
│
├── DiceWars.sln                 # Visual Studio Solution file
├── Dice_Wars.db                 # SQLite Database
├── DiceWars.DAL/                # Data Access Layer
│   ├── ByAttribute.cs
│   ├── Clash.cs
│   └── App.config
└── .vs/                         # Visual Studio temporary files

How to Run:
Open the DiceWars.sln file in Visual Studio.
Restore any missing packages if prompted.
Build the solution (Ctrl + Shift + B).
Run the application (F5) and interact with the game.
**Make sure you have SQLite installed or compatible drivers in your environment.**

Learning Outcomes
This project demonstrates foundational skills in:
Writing and organizing C# code
Understanding and applying OOP principles
Database operations (CRUD)
Configuring and debugging applications in Visual Studio

Reflection
DiceWars helped solidify my understanding of how to structure small-scale applications and connect logic with persistent storage. It was also a great exercise in designing reusable code components and learning how different parts of a program work together.
