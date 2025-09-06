using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

public static class DatabaseUtil
{
    public static SqlConnection GetConnection()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        string? connString = config.GetConnectionString("AzureSql");
        if (string.IsNullOrEmpty(connString))
        {
            throw new InvalidOperationException("Azure SQL connection string not found in appsettings.json");
        }
        return new SqlConnection(connString);
    }
}
