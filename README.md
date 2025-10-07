DEPENDENCY INJECTION DEMO

🚀 Overview

This project simulates the concept of Dependency Injection (DI) — a fundamental design pattern in modern software development — within a console application.
Its purpose is to demonstrate how a service’s dependencies are managed, how their lifetimes are tracked, and how classes are resolved through a custom-built container, without using any existing DI framework.

✨ Key Features and Examples

This simulation includes the core functionalities that a typical DI container should provide


1. Class Registration
   
Demonstrates how individual classes or interface–implementation pairs are registered within the project.

Single Class Registration: Adding a class directly to the container.

Generic Class Registration: Registering generic structures such as IRepository<T> in the container.

2. Lifetime Management
   
Simulates how the container manages the lifetimes of classes:

Transient: A new instance is created for every request.

Singleton: A single instance is used throughout the entire application.

3.  Automatic Injection (Injection / Resolution)
   
Demonstrates how the container automatically resolves and injects a class’s required dependencies (via its constructor) when the registered class is requested.

5.  Usage Examples
   
Demonstrates how classes with different lifetimes can be used together in cases with multiple dependencies.
(Example: A UserService class that uses a Transient logger and a Singleton configuration manager.)


🛠️ How to Run

Clone the project to your local machine

git clone https://github.com/muhammetyonkuc/DependencyInjectionDemo.git


cd DependencyInjectionDemo
dotnet run


Navigate to the project directory and build it (for example, using the .NET CLI)



The application will print the simulated registration and resolution steps to the console.
