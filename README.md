# Architecture

A starting point in ASP.NET Core.

# Goals

The goal of this repository is to provide a basic solution structure that can be used to build Domain-Driven Design (DDD)-based or simply well-factored, SOLID applications using .NET Core.

# Design Decisions and Dependencies

The goal is to provide a fairly bare-bones starter kit for new projects. It does not include every possible framework, tool, or feature that a particular enterprise application might benefit from. It doesn't (currently) include extensive support for things like logging, monitoring, or analytics, though these can all be added easily.

## The Core Project

The Core project is the center of the Architecture design, and all other project dependencies should point toward it. As such, it has very few external dependencies. The Core project should include things like:

- Entities
- Domain Events
- DTOs
- Interfaces
- Event Handlers
- Domain Services
- Specifications


## The Infrastructure Project

The Infrastructure project depends on `Microsoft.EntityFrameworkCore.SqlServer` and `StructureMap.Microsoft.DependencyInjection`. The former is used because it's built into the default ASP.NET Core templates and is the least common denominator of data access. StructureMap is used to allow wireup of dependencies to take place closest to where the implementations reside.

## The Web Project

The entry point of the application is the ASP.NET Core web project. This is actually a console application, with a `public static void Main` method in `Program.cs`. It currently uses the default MVC organization (Controllers and Views folders) as well as most of the default ASP.NET Core project template code. This includes its configuration system, which uses the default `appsettings.json` file plus environment variables, and is configured in `Startup.cs`.

## The Test Project

In a real application I will likely have separate test projects, organized based on the kind of test (unit, functional, integration, performance, etc.) or by the project they are testing (Core, Infrastructure, Web), or both. For this simple starter kit, there is just one test project, with folders representing the projects being tested.
