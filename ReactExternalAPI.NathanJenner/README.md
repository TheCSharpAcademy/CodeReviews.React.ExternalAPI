# ReactExternalAPI.NathanJenner

A full-stack web application built with **React** (TypeScript) on the frontend and **ASP.NET Core** on the backend. This project demonstrates a modern image gallery application that fetches and displays images from a RESTful API, with individual detail pages and responsive card-based layouts.

## 🚀 Tech Stack

### Frontend
- **React 18** with TypeScript
- **Vite** - Next-generation frontend build tool
- **React Router DOM** - Client-side routing
- **React Bootstrap** - UI component library
- **Bootstrap 5** - CSS framework

### Backend
- **ASP.NET Core** - Minimal API
- **Entity Framework Core** - ORM with SQL Server
- **OpenAPI** - API documentation

## 📁 Project Structure

```
ReactExternalAPI.NathanJenner/
├── reactexternalapi.nathanjenner.client/    # React frontend
│   ├── src/
│   │   ├── components/
│   │   │   ├── card/
│   │   │   │   └── card.tsx          # Reusable card component
│   │   │   └── singlecard.tsx        # Single image detail page
│   │   ├── App.tsx                   # Main app with routing
│   │   ├── main.tsx                  # Entry point
│   │   └── *.css                     # Styling
│   ├── package.json
│   └── vite.config.ts
│
└── ReactExternalAPI.NathanJenner.Server/    # ASP.NET Core backend
    ├── Data/
    │   ├── ApplicationDbContext.cs   # EF Core DbContext
    │   └── SeedData.cs               # Database seeding
    ├── Models/
    │   └── ImageModel.cs             # Image entity model
    └── Program.cs                    # API configuration & endpoints
```

## ✨ Features

- **Image Gallery** - Browse a collection of images displayed in responsive cards
- **Image Details** - Click on any image to view its full details on a dedicated page
- **RESTful API** - Clean API endpoints for fetching images
- **Database Seeding** - Pre-populated sample data for development
- **CORS Configuration** - Properly configured cross-origin requests
- **HTTPS Support** - Secure development with auto-generated certificates

## 🛠️ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later
- [Node.js](https://nodejs.org/) (v18+ recommended)
- [SQL Server](https://www.microsoft.com/sql-server) (LocalDB or full instance)

## 🏃‍♂️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/NathanJenner/ReactExternalAPI.NathanJenner.git
cd ReactExternalAPI.NathanJenner
```

### 2. Set up the database connection

Update the connection string in `appsettings.json` (Server project):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ReactExternalAPI;Trusted_Connection=True;"
  }
}
```

### 3. Run the Backend

```bash
cd ReactExternalAPI.NathanJenner.Server
dotnet run
```

The API will be available at `https://localhost:7206`

### 4. Run the Frontend

```bash
cd reactexternalapi.nathanjenner.client
npm install
npm run dev
```

The React app will be available at `https://localhost:51703`

## 📡 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/images` | Retrieve all images |
| GET | `/images/{id}` | Retrieve a specific image by ID |

## 📦 Image Model

```csharp
public class ImageModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Author { get; set; }
}
```

## 🧪 Development

### Frontend Scripts

```bash
npm run dev      # Start development server
npm run build    # Build for production
npm run lint     # Run ESLint
npm run preview  # Preview production build
```

### Backend

The database is automatically created and seeded when running in Development mode.

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the [issues page](https://github.com/NathanJenner/ReactExternalAPI.NathanJenner/issues).

---

Made with ❤️ by [NathanJenner](https://github.com/NathanJenner)
