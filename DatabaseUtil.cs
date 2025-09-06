using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public static class DatabaseUtil
{
    public static SqlConnection GetConnection()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        string connString = config.GetConnectionString("AzureSql");
        return new SqlConnection(connString);
    }
}
