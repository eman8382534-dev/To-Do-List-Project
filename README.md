# To-Do List

A simple task management app built with ASP.NET Core and SQL Server, with a separate HTML frontend.

## Features

- Add new tasks
- View all tasks
- Edit and delete tasks
- Mark tasks as completed

## Tech Stack

| Layer | Technology |
|-------|------------|
| Backend | ASP.NET Core (C#) |
| Database | SQL Server + Entity Framework Core |
| Frontend | HTML, CSS, JavaScript |

## Project Structure

```
To-Do List/
├── backend/     # ASP.NET Core project
└── frontend/    # Frontend (index.html)
```

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB or full)

### Run the backend

```bash
cd "bachend/To-Do List Backend/WebApplication2"

# Create the database
dotnet ef database update

# Run the API
dotnet run
```

The connection string is in `appsettings.json` (default: `Server=.;Database=TaskDb`). Change it if your SQL Server instance is different.

### Run the frontend

Open the `frontend` folder in VS Code, right-click `index.html`, then choose **Open with Live Server**.

Make sure the API URL in the frontend matches the port your backend runs on.

## Author

Eman Ashraf