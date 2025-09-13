using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public static class DatabaseUtil
{
    public static SqlConnection GetConnection()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();
        
        string? connString = config.GetConnectionString("AzureSql");
        if (string.IsNullOrEmpty(connString))
        {
            throw new InvalidOperationException("Connection string 'AzureSql' not found in configuration.");
        }
        
        return new SqlConnection(connString);
    }
}
