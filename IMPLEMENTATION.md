# Database Table Creation Implementation

This implementation creates the `mylist` table using `DatabaseUtil.GetConnection()` as required.

## Table Schema

The `mylist` table is created with the following columns:

- **id** (int, primary key, identity/auto-increment)
- **item_name** (nvarchar(100), not null)  
- **created_at** (datetime, default GETDATE())

## Usage

To create the table, run:

```bash
dotnet run
```

The application will:
1. Use `DatabaseUtil.GetConnection()` to connect to the Azure SQL database
2. Check if the `mylist` table already exists
3. Create the table with the specified schema if it doesn't exist

## Files Created

- **test.csproj** - Project file with necessary dependencies
- **Program.cs** - Main application that uses DatabaseUtil.GetConnection() to create the table
- **TableCreationTest.cs** - Validation tests for the table creation logic

## Dependencies

- Microsoft.Data.SqlClient 5.2.2 - For Azure SQL Database connectivity
- Microsoft.Extensions.Configuration 8.0.0 - For reading appsettings.json
- Microsoft.Extensions.Configuration.Json 8.0.0 - For JSON configuration support

The existing `DatabaseUtil.cs` has been updated to use the newer Microsoft.Data.SqlClient package and includes proper error handling for missing connection strings.