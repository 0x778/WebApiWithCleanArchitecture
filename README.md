# WebApi Project

## Overview

MySchoolProjectWebApi is a .NET Core Web API project designed following Clean Architecture principles. It prioritizes separation of concerns, maintainability, and testability to ensure the development of robust and scalable web applications.

## Table of Contents

1. [Introduction](#introduction)
2. [Principles](#principles)
3. [Layers](#layers)
4. [Getting Started](#getting-started)
5. [Contributing](#contributing)
6. [License](#license)

## Introduction

Clean Architecture is an architectural approach that promotes the independence of the core business logic from external concerns such as frameworks, databases, and UIs. MyWebApi project embraces Clean Architecture to facilitate maintainability, flexibility, and testability.

## Principles

The project adheres to the following Clean Architecture principles:

- **Single Responsibility Principle (SRP):** Each component has a single responsibility, promoting easier maintenance and extensibility.
- **Dependency Inversion Principle (DIP):** High-level modules depend on abstractions, enabling loose coupling and flexibility.
- **Separation of Concerns:** Different concerns are separated into distinct layers (Presentation, Application, Domain, and Infrastructure) to facilitate maintainability and testability.
- **Dependency Injection (DI):** Dependencies are injected into components, promoting loose coupling and facilitating testing and swapping of implementations.
- **Testability:** The architecture is designed with testability in mind, allowing for efficient unit testing, integration testing, and acceptance testing.

## Layers

The project consists of the following layers:

1. **API Layer:** Handles HTTP requests and responses. Contains controllers, view models, and DTOs. Delegates business logic to the service layer.
2. **Core Layer:** Implements use cases or application-specific business rules. Orchestrates interactions between different parts of the system. Does not contain infrastructure concerns.
3. **Service Layer:** Represents the core business logic and entities of the application. Contains domain entities, value objects, and domain services. Independent of external frameworks or technologies.
4. **Infrastructure Layer:** Provides implementations for external concerns such as databases, file systems, or third-party services. Contains repositories, data access logic, and infrastructure-specific configurations. Depends on the service layer but not vice versa.
5. **Data Layer:** Deals with data persistence, including database access, data models, and data access logic. Implements repositories and database interactions. Depends on the service layer but not vice versa.

## Getting Started

To get started with MyWebApi project, follow these steps:

1. Clone the repository: `git clone https://github.com/0x778/WebApiWithCleanArchitecture.git`
2. Navigate to the project directory: `cd WebApiWithCleanArchitecture`
3. Build the solution: `dotnet build`
4. Run the application: `dotnet run --project WebApi.WebApi`

## Contributing

Contributions are welcome! If you'd like to contribute to MyWebApi project, please follow these guidelines:

1. Fork the repository.
2. Create a new branch: `git checkout -b feature/new-feature`
3. Make your changes and commit them: `git commit -m 'Add new feature'`
4. Push to the branch: `git push origin feature/new-feature`
5. Submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
