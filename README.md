# OasisTrack: Food Inventory Management System

OasisTrack is a comprehensive solution designed to address the challenges of food deserts by efficiently managing inventory and deliveries for stores in underserved areas. This system caters to both drivers and administrators, providing tools for route management, inventory tracking, and data analysis.

## Table of Contents

- [Features](#features)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Mobile App](#mobile-app)
- [Admin Web Interface](#admin-web-interface)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Features

### For Drivers
- Secure account login
- Daily route and store information access
- Real-time price change notifications
- Inventory management (par levels, sales, shrinkage)
- Delivery comments and data submission
- Data correction capabilities
- Maintenance request submission (optional)

### For Administrators
- Store and route management
- Sales agreement administration
- Global and local item pricing control
- Weekly invoice generation
- Comprehensive data access and analysis

## Project Structure

```
OasisTrack/
├── src/
│   ├── OasisTrack.Core/
│   ├── OasisTrack.Infrastructure/
│   ├── OasisTrack.Application/
│   └── OasisTrack.WebApi/
├── tests/
└── README.md
```

For a detailed breakdown of the project structure, please refer to the [Project Structure Document](PROJECT_STRUCTURE.md).

## Getting Started

### Prerequisites

- .NET 8 SDK
- Node.js (v14 or later)
- Postgresql (or your preferred database)
- Android Studio (for mobile app development)

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/oasistrack.git
   cd oasistrack
   ```

2. Set up the .NET backend:
   ```
   cd src
   dotnet restore
   dotnet build
   ```

3. Set up the Next.js frontend (for admin interface):
   ```
   cd OasisTrack.Application
   npm install
   ```

4. Configure your database connection in `appsettings.json` in the API project.

5. Run database migrations:
   ```
   cd ../OasisTrack.WebApi
   dotnet ef database update
   ```

6. For the Android app, open the mobile project in Android Studio and follow the setup wizard.

## Usage

### Running the API

1. Start the API:
   ```
   dotnet run --project OasisTrack.API
   ```

### Running the Admin Web Interface

1. In a new terminal, start the Next.js dev server:
   ```
   cd src/OasisTrack.Web
   npm run dev
   ```

2. Open your browser and navigate to `http://localhost:3000`

### Deploying the Mobile App

1. Build the Android app in Android Studio
2. Deploy to tablets using your preferred method (e.g., Google Play Store, direct APK installation)

## API Endpoints

- `POST /api/auth/login` - User authentication
- `GET /api/driver/route` - Get driver's daily route
- `GET /api/driver/store/{id}` - Get store details
- `POST /api/driver/delivery` - Submit delivery data
- `PUT /api/driver/delivery/{id}` - Update delivery data
- `GET /api/admin/stores` - List all stores
- `POST /api/admin/store` - Create a new store
- `PUT /api/admin/store/{id}` - Update store information
- `GET /api/admin/invoices` - Generate store invoices

For a complete list of endpoints, refer to the API documentation.

## Mobile App

The Android mobile app is designed for drivers to:
- View their daily route
- Access store information
- Input delivery data
- Submit maintenance requests

## Admin Web Interface

The web interface allows administrators to:
- Manage stores and routes
- Control pricing and inventory
- Generate invoices
- Access and analyze data

## Technologies Used

- Backend: .NET 8, Entity Framework Core
- API: ASP.NET Core
- Admin Frontend: Next.js, React
- Mobile App: Android (Kotlin/Java)
- Database: Postgresql
- Authentication: JWT (JSON Web Tokens)

## Contributing

We welcome contributions to OasisTrack! Please read our [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct and the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
