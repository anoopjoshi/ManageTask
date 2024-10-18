# ManageTask Application Backend API

## Overview

The ManageTask application is designed to manage tasks using Onion Architecture. This architecture promotes a clean separation of concerns, making the application more maintainable and testable.

## Project Structure

The solution is divided into four main layers:

1. **Core (Domain) Layer**: Contains the domain entities and domain services.
2. **Application Layer**: Contains the application services and interfaces.
3. **Infrastructure Layer**: Contains the implementation of repositories, database context, and other infrastructure-related code.
4. **Presentation Layer**: Contains the API controllers and other presentation logic.

## Layers

### 1. Core (Domain) Layer

**Project**: `ManageTask.Core`

Contains the domain entities and value objects.

#### Entities

- `Task.cs`


### 2. Application Layer

**Project**: `ManageTask.Application`

Contains the application services and interfaces.

#### Interfaces

- `ITaskRepository.cs`
- `ITaskManager.cs`

#### Services

- `TaskManager.cs`

### 3. Infrastructure Layer

**Project**: `ManageTask.Infrastructure`

Contains the implementation of repositories, database context, and other infrastructure-related code.

#### DbContext

- `TaskManagementDbContext.cs`

#### Repositories

- `TaskRepository.cs`

### 4. Presentation Layer

**Project**: `ManageTask.Api`

Contains the API controllers and other presentation logic.

#### Controllers

- `TasksController.cs`


## Running the Application

1. **Clone the repository**:  

2. **Navigate to the solution directory**:  

3. **Restore the dependencies**:   dotnet restore

4. **Update the database**: database update
   Ensure your connection string is correctly set in `appsettings.json` and run:
   
5. **Run the application**:


## API Endpoints

- **POST** `/api/tasks` - Add a new task
- **GET** `/api/tasks/{id}` - Retrieve a task by Id
- **GET** `/api/tasks` - Retrieve all tasks
- **DELETE** `/api/tasks/{id}` - Delete a task by Id


- 



   
   