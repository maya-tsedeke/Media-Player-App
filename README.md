# Media Player Application

Build a media player application that demonstrates advanced topics in C# programming, including solid, clean architecture, Factory pattern, Singleton pattern, Observer pattern, object lifetime, and thread safety.

## Description

The media player application is a robust software that meets the requirements by providing essential functionalities:
# Media Player Application

This is a media player application built using C# that allows users to play audio and video files, manage their media library, and control playback through a command-line interface. The application follows the principles of Clean Architecture and SOLID design principles.
# Media Player Application

The Media Player Application is a robust software that showcases advanced topics in C# programming, including SOLID principles, clean architecture, and various design patterns. It provides essential functionalities for playing audio and video files, managing media library and playlists, and a user-friendly command-line interface.

## Features

- **Playback Functionality:** Users can play audio and video files, control playback with play, pause, stop, and seek functionalities, and view current playback status.
- **Media Management:** Users can manage their media library by adding, removing, and organizing media files. The application also supports playlist management.
- **Command-Line Interface:** The application offers a user-friendly command-line interface that guides users through different operations, providing clear instructions and feedback.
- **Error Handling:** Potential errors and exceptions are handled gracefully, ensuring meaningful error messages are displayed to the user.

## SOLID Principles

The application adheres to the SOLID principles, which are a set of design principles that promote maintainability, extensibility, and reusability of code. These principles are:

- **Single Responsibility Principle (SRP):** Each class or module should have a single responsibility, focusing on one specific task.
- **Open-Closed Principle (OCP):** The code should be open for extension but closed for modification, allowing new functionality to be added without modifying existing code.
- **Liskov Substitution Principle (LSP):** Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.
- **Interface Segregation Principle (ISP):** Clients should not be forced to depend on interfaces they do not use. Interfaces should be specific to the needs of the clients.
- **Dependency Inversion Principle (DIP):** High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details; details should depend on abstractions.

## Clean Architecture

The Media Player Application follows the principles of Clean Architecture, which emphasizes separation of concerns and independence of external frameworks or libraries. The architecture consists of distinct layers:

- **Domain Layer:** Contains the core business logic, including entities and interfaces representing media playback and management.
- **Application Layer:** Implements application-specific services, factories, and interfaces, coordinating the interaction between the presentation and domain layers.
- **Infrastructure Layer:** Provides implementations of infrastructure-related concerns, such as media players and persistence (repositories).
- **Presentation Layer:** Handles the user interface and interaction, including the command-line interface and user interface interfaces.
- **Tests:** Contains unit tests for each layer, ensuring the correctness and functionality of the application.

## Design Patterns

The Media Player Application incorporates several design patterns:

- **Factory Pattern:** The application employs the Factory pattern to create different types of media players, such as audio players and video players, based on the media type.
- **Singleton Pattern:** The Singleton pattern ensures that there is only one instance of the media player manager throughout the application, allowing global access to its functionality.
- **Observer Pattern:** The Observer pattern enables the media player manager to notify other components of the application, such as the user interface, about playback events, facilitating event-driven communication.
- **Object Lifetime:** The application manages object lifetimes appropriately, ensuring objects are created, used, and disposed of correctly to prevent resource leaks and optimize memory usage.
- **Thread Safety:** The application handles concurrent access to shared resources, such as the media player manager, using synchronization techniques to ensure thread safety and prevent data corruption.

## Getting Started

To run the Media Player Application, follow these steps:

1. Clone the repository: `git clone https://github.com/maya-tsedeke/fs15_14-MediaPlayer.git`
2. Navigate to the project folder: `cd fs15_14-MediaPlayer`
3. Build the solution: `dotnet build`
4. Run the application: `dotnet run`

## Folder Structure

The project follows a modular folder structure based on Clean Architecture:

        MediaPlayerApp
        ├── MediaPlayerApp.Domain
        │   ├── Entities
        │   │   ├── MediaFile.cs
        │   │   └── Playlist.cs
        │   ├── Interfaces
        │   │   ├── IMediaPlayer.cs
        │   │   ├── IAudioPlayer.cs
        │   │   └── IVideoPlayer.cs
        ├── MediaPlayerApp.Application
        │   ├── Services
        │   │   └── MediaPlayerService.cs
        │   ├── Factories
        │   │   └── MediaPlayerFactory.cs
        │   ├── Interfaces
        │   │   └── IMediaPlayerService.cs
        │   └── Enums
        │       └── MediaType.cs
        ├── MediaPlayerApp.Infrastructure
        │   ├── Players
        │   │   ├── AudioPlayer.cs
        │   │   └── VideoPlayer.cs
        │   └── Persistence
        │       ├── MediaFileRepository.cs
        │       └── PlaylistRepository.cs
        ├── MediaPlayerApp.UI
        │   ├── Console
        │   │   ├── Program.cs
        │   │   └── ConsoleUI.cs
        │   └── Interfaces
        │       └── IUserInterface.cs
        └── MediaPlayerApp.Tests
            ├── Services
            │   └── MediaPlayerServiceTests.cs
            ├── Factories
            │   └── MediaPlayerFactoryTests.cs
            └── Persistence
                ├── MediaFileRepositoryTests.cs
                └── PlaylistRepositoryTests.cs
