<div align="center">

# Student Exam Qualification Calculator

A Dockerized C# console application for evaluating student examination eligibility through weighted academic assessments.

<p>

<img src="https://img.shields.io/badge/C%23-.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">
<img src="https://img.shields.io/badge/Docker-Containerized-2496ED?style=for-the-badge&logo=docker&logoColor=white">
<img src="https://img.shields.io/badge/Platform-Console-2E3440?style=for-the-badge">
<img src="https://img.shields.io/badge/Status-Complete-2EA043?style=for-the-badge">

</p>

---

*"Simple software, predictable behaviour, reproducible execution."*

</div>

<br>

## About

This project implements a command-line application that evaluates whether a student is eligible to write their final examination. Marks are collected across four assessment components, combined using predefined weighting rules, and evaluated against the required qualification threshold.

The application is packaged with Docker, allowing it to execute in an isolated and consistent runtime environment without requiring a local .NET installation.

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
Weighted Average ≥ 50%
```

---

## Architecture

```
                   User
                     │
                     ▼
         Console Input Interface
                     │
                     ▼
          Student Object Model
                     │
                     ▼
     Weighted Average Calculation
                     │
                     ▼
      Qualification Decision Engine
                     │
                     ▼
          Console Output Result
```

---

## Repository Layout

```
.
├── Program.cs
├── Student.cs
├── StudentExamQualificationCalculator.csproj
├── Dockerfile
├── .dockerignore
└── README.md
```

Every file has a single responsibility.

| File | Responsibility |
|------|----------------|
| `Program.cs` | Application workflow and user interaction |
| `Student.cs` | Student model and qualification logic |
| `Dockerfile` | Container build instructions |
| `.dockerignore` | Excludes unnecessary files during image creation |
| `README.md` | Project documentation |

---

## Design Principles

The application was intentionally designed around a small set of principles:

- Clear separation between application flow and business logic
- Readable object-oriented design
- Minimal project structure
- No external dependencies beyond the .NET runtime
- Deterministic execution through Docker

Rather than introducing unnecessary abstraction, the implementation focuses on clarity and maintainability.

---

## Container Execution

### Build

```bash
docker build -t student-exam .
```

### Run

```bash
docker run -it student-exam
```

The interactive (`-it`) flags allow the application to receive keyboard input from the terminal while running inside the container.

---

## Technology

| Category | Stack |
|----------|-------|
| Language | C# |
| Framework | .NET |
| Runtime | .NET SDK |
| Container | Docker |
| Version Control | Git & GitHub |

---

## Project Objectives

This implementation demonstrates practical understanding of:

- Object-oriented programming
- Console application development
- Collection management
- Business rule implementation
- Docker image creation
- Container-based application deployment

These objectives align with the Cloud Native Programming project requirements, which specify creating a console application to determine examination eligibility from weighted assessment marks and packaging the solution as a Docker container. :contentReference[oaicite:0]{index=0}

---

<div align="center">

### Built with C#, .NET and Docker

*Cloud Native Programming • Belgium Campus*

</div>