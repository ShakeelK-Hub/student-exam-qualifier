<div align="center">

# Student Exam Qualification Calculator

A Dockerized C# console application for evaluating student examination eligibility through weighted academic assessments.

<p>

<img src="https://img.shields.io/badge/C%23-.NET%2010-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">
<img src="https://img.shields.io/badge/Docker-Containerized-2496ED?style=for-the-badge&logo=docker&logoColor=white">
<img src="https://img.shields.io/badge/Platform-Console-2E3440?style=for-the-badge">

</p>

</div>

---

## About

This project implements a command-line application that evaluates whether a student is eligible to write their final examination. Marks are collected across four assessment components, combined using predefined weighting rules, and evaluated against the required qualification threshold.

The application is packaged with Docker, allowing it to run in an isolated, consistent environment without requiring a local .NET installation.

---

## Assessment Model

| Component | Weight |
|:----------|-------:|
| Test 1 | **30%** |
| Test 2 | **50%** |
| Assignment 1 | **10%** |
| Project | **10%** |

**Qualification Requirement**

```
Weighted Average >= 50%
```

---

## How It Works

1. The user is shown a menu: enter a new student, view all students, or exit.
2. Entering a student prompts for their name and four marks (0-100 each).
3. Each mark is validated - non-numeric input or an out-of-range value cancels that entry.
4. The weighted average is calculated and compared against the 50% threshold.
5. Results are stored in memory for the session and can be viewed at any time via "View all students."

Data is held in memory only and is not persisted once the program exits.

---

## Repository Layout

```
.
├── Program.cs
├── ExamQualifier.csproj
├── Dockerfile
├── .gitignore
└── README.md
```

| File | Responsibility |
|------|----------------|
| `Program.cs` | Application menu, input handling, and qualification logic |
| `ExamQualifier.csproj` | Project configuration (.NET 10 console app) |
| `Dockerfile` | Multi-stage build: compiles with the .NET SDK, runs on the smaller .NET runtime image |
| `.gitignore` | Excludes build artifacts from version control |
| `README.md` | Project documentation |

---

## Container Execution

### Build

```bash
docker build -t examqualifier .
```

### Run

```bash
docker run -it examqualifier
```

The interactive (`-it`) flags allow the application to receive keyboard input from the terminal while running inside the container.

---

## Technology

| Category | Stack |
|----------|-------|
| Language | C# |
| Framework | .NET 10 |
| Container | Docker (multi-stage build) |
| Version Control | Git & GitHub |

---

## Project Objectives

This implementation demonstrates practical understanding of:

- Console application development in C#
- Input validation and error handling
- Business rule implementation (weighted averages, qualification thresholds)
- Docker image creation and multi-stage builds
- Container-based application deployment

---

<div align="center">

### Built with C#, .NET and Docker

*Cloud Native Programming - Belgium Campus*

</div>
