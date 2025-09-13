# Database Utility Library

A C# library providing utilities for Azure SQL Database connections and operations.

## Features

- Simple database connection management
- Configuration-based connection strings
- Environment-specific settings support

## Quick Start

### Prerequisites

- .NET 8.0 or later
- Azure SQL Database or SQL Server

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/shriyanshacoustte/test.git
   cd test
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

### Configuration

1. Copy the template file:
   ```bash
   cp appsettings.Development.json.template appsettings.Development.json
   ```

2. Update `appsettings.Development.json` with your connection string:
   ```json
   {
     "ConnectionStrings": {
       "AzureSql": "your-actual-connection-string-here"
     }
   }
   ```

### Usage

Use the static method `DatabaseUtil.GetConnection()` to obtain a database connection:

```csharp
using var connection = DatabaseUtil.GetConnection();
connection.Open();
// Your database operations here
```

## Project Structure

- `DatabaseUtil.cs` - Main utility class for database connections
- `appsettings.Development.json` - Development configuration
- `appsettings.Development.json.template` - Template for configuration

## Development

### Building

```bash
dotnet build
```

### Code Style

This project uses EditorConfig for consistent code formatting. Most editors will automatically apply the formatting rules defined in `.editorconfig`.

## Security Notes

- **Never commit sensitive connection strings to version control**
- Configuration files with credentials are excluded via `.gitignore`
- Use environment variables or secure key management in production

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
