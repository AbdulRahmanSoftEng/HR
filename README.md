# HRMSystem – Human Resource Management System

A practice project for building a Human Resource Management System using C#, ASP.NET Core Web API, and Microsoft SQL Server.

The main goal of this project is to apply and consolidate software development concepts, database design, RESTful APIs, and layered architecture through a practical application.

## Project Overview

HRMSystem is designed to manage the basic operations of an organization's Human Resources department.

The system includes the following main modules:

- **Departments Management:** Manage company departments.
- **Employees Management:** Manage employee information and department assignments.
- **Attendance Management:** Record employee check-in and check-out.
- **User Management:** Manage system user accounts.
- **Roles Management:** Define user roles.
- **Permissions Management:** Define permissions and assign them to roles.
- **Dashboard:** Display basic HR statistics.

## Technologies Used

- **Backend:** C# / ASP.NET Core Web API
- **Data Access:** ADO.NET
- **Database:** Microsoft SQL Server
- **Database Operations:** Stored Procedures
- **API Testing:** Swagger / OpenAPI
- **Version Control:** Git & GitHub
- **Frontend:** Under development

## Project Architecture

The project follows a layered architecture to separate responsibilities and improve maintainability.

```text
HRMSystem
│
├── HRMSystemFrontend
│   └── Frontend Application
│
├── HRMSystem
│   └── API Layer
│
├── BuisnessLogic
│   └── Business Logic Layer
│
└── DataAccess
    ├── Data
    ├── DTOs
    └── Settings
```

### 1. Frontend Layer – HRMSystemFrontend

Responsible for the user interface and interacting with the backend API.

### 2. API Layer – HRMSystem

Responsible for exposing RESTful endpoints, receiving HTTP requests, validating incoming data, and returning appropriate HTTP responses.

### 3. Business Logic Layer – BuisnessLogic

Responsible for application logic, managing business operations, and communicating with the Data Access Layer.

### 4. Data Access Layer – DataAccess

Responsible for database communication using ADO.NET and SQL Server Stored Procedures.

## Database Design

The database is designed around the following main tables:

- Departments
- Employees
- Attendance
- Users
- Roles
- Permissions
- RolePermissions

The database uses relationships and constraints to maintain data integrity.

## Key Concepts Practiced

This project is an opportunity to practice and apply:

- Object-Oriented Programming (OOP)
- Layered Architecture
- Data Transfer Objects (DTOs)
- ADO.NET and SQL Server
- Stored Procedures
- CRUD Operations
- RESTful API Principles
- HTTP Methods and Status Codes
- Exception Handling
- Database Relationships and Constraints
- Git and GitHub Workflow

## Project Status

<ins>In Progress</ins>

The project is being developed incrementally, starting with database design and the Data Access and Business Logic layers, followed by API development and frontend integration.

## Future Improvements

- Complete RESTful API endpoints.
- Implement centralized exception handling.
- Add authentication and authorization.
- Apply role-based permissions.
- Complete frontend integration.
- Improve validation and error responses.
- Add unit and integration tests.

## Learning Objective

This project is part of my journey toward becoming a **Full-Stack Web Developer**.

My focus is not only on completing the application, but also on understanding how its components work together and applying the concepts I have learned in a practical project.

---

**Developer:** AbdulRahman Al-moshki  
**Repository:** HR