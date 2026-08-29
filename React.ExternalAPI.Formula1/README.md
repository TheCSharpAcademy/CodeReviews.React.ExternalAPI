# 🏎️ F1 Driver Stats

A full-stack web application that displays Formula 1 driver information for the 2026 season. Built with **React + TypeScript** (Vite) on the frontend and **ASP.NET Core Web API** with **Entity Framework Core** and **SQL Server** on the backend.

![F1 Driver Stats](https://img.shields.io/badge/F1-Driver%20Stats-e10600?style=for-the-badge&logo=f1&logoColor=white)
![React](https://img.shields.io/badge/React-19-61DAFB?style=flat-square&logo=react)
![TypeScript](https://img.shields.io/badge/TypeScript-6.0-3178C6?style=flat-square&logo=typescript)
![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat-square&logo=dotnet)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?style=flat-square&logo=microsoftsqlserver)

## 📸 Features

- **Home Page** — Animated hero section with season overview stats
- **Driver Grid** — Browse all 22 F1 drivers grouped by team
- **Driver Detail** — View detailed stats (number, age, nationality, team) with driver photo
- **Leaderboard** — Live championship standings with podium for top 3 (gold/silver/bronze) and ranking table, powered by [OpenF1 API](https://openf1.org/)
- **Responsive Design** — Fully mobile-friendly with glassmorphism UI
- **Auto Database Seeding** — Database is automatically populated with all 2026 season drivers on first run

## 🏗️ Tech Stack

### Frontend (Client)
| Technology | Purpose |
|---|---|
| [React 19](https://react.dev/) | UI framework |
| [TypeScript 6](https://www.typescriptlang.org/) | Type safety |
| [Vite 8](https://vitejs.dev/) | Dev server & bundler |
| [React Router DOM 7](https://reactrouter.com/) | Client-side routing |

### Backend (Server)
| Technology | Purpose |
|---|---|
| [ASP.NET Core 10](https://dotnet.microsoft.com/apps/aspnet) | Web API framework |
| [Entity Framework Core 10](https://learn.microsoft.com/ef/core/) | ORM / Data access |
| [SQL Server](https://www.microsoft.com/sql-server) | Database |

### External API
| API | Purpose |
|---|---|
| [OpenF1 API](https://openf1.org/) | Live championship standings & driver points |

## 📁 Project Structure

```
React.ExternalAPI.Formula1/
├── Client/                          # React Frontend (Vite + TypeScript)
│   ├── src/
│   │   ├── components/
│   │   │   ├── Navbar.tsx           # Navigation bar
│   │   │   └── DriverCard.tsx       # Reusable driver card component
│   │   ├── pages/
│   │   │   ├── Home.tsx             # Landing page with hero section
│   │   │   ├── Drivers.tsx          # Driver grid page (grouped by team)
│   │   │   ├── DriverDetail.tsx     # Individual driver detail page
│   │   │   └── Leaderboard.tsx      # Championship standings with podium
│   │   ├── services/
│   │   │   └── api.ts              # API client functions
│   │   ├── types/
│   │   │   └── driver.ts           # TypeScript interfaces
│   │   ├── App.tsx                  # Root component with routing
│   │   ├── main.tsx                 # Entry point
│   │   └── index.css                # Global styles (design system)
│   ├── index.html
│   ├── vite.config.ts               # Vite config with API proxy
│   └── package.json
│
└── Server/                          # ASP.NET Core Web API
    ├── Controllers/
    │   ├── DriverController.cs      # Driver REST API endpoints
    │   └── LeaderboardController.cs # Leaderboard endpoint
    ├── Models/
    │   └── Driver.cs                # Entity model
    ├── DTOs/
    │   ├── DriverDTO.cs             # Driver data transfer object
    │   └── LeaderboardEntryDTO.cs   # Leaderboard entry DTO
    ├── Services/
    │   ├── IDriverService.cs        # Driver service interface
    │   ├── DriverService.cs         # Driver service implementation
    │   ├── ILeaderboardService.cs   # Leaderboard service interface
    │   ├── LeaderboardService.cs    # Fetches from OpenF1 API + enriches with DB
    │   └── DriverPoint.cs           # Record for external API response
    ├── Data/
    │   ├── AppDbContext.cs           # EF Core DbContext
    │   └── DbInitializer.cs         # Database seeder (22 drivers)
    ├── Mappings/
    │   └── DriverMappingExtensions.cs # Entity ↔ DTO mapping
    ├── Program.cs                    # App entry point & DI config
    └── appsettings.json              # Configuration
```

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (v18+)
- [SQL Server](https://www.microsoft.com/sql-server) (LocalDB or full instance)

### 1. Clone the repository

```bash
git clone https://github.com/M1nh4ke/CodeReviews.React.ExternalAPI.git
cd CodeReviews.React.ExternalAPI/React.ExternalAPI.Formula1
```

### 2. Setup & Run the Server

```bash
cd Server

# Restore NuGet packages
dotnet restore

# Run the server (database will be auto-created and seeded)
dotnet run
```

The API will be available at `http://localhost:5270`.

### 3. Setup & Run the Client

```bash
cd Client

# Install npm dependencies
npm install

# Start the dev server
npm run dev
```

The app will be available at `http://localhost:5173`.

## 🔌 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/drivers` | Get all drivers |
| `GET` | `/api/drivers/{number}` | Get a driver by their racing number |
| `GET` | `/api/leaderboard` | Get championship standings (enriched with driver info) |


## ⚙️ Configuration

### Server

The connection string is configured in `Server/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your_connection_string"
  }
}
```

### Client

The client uses Vite's proxy to forward API requests. The proxy is configured in `Client/vite.config.ts`:

- `/api/*` → `http://localhost:5270`
- `/images/*` → `http://localhost:5270`

You can override the API URL by creating a `.env` file in the `Client/` directory:

```env
VITE_API_URL=http://localhost:5270/api
```

