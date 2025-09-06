# test
## Database Connection

This project uses Azure SQL Database.  
Store your connection string in `appsettings.json` under `ConnectionStrings:AzureSql`.

Use the static method `DatabaseUtil.GetConnection()` to obtain a database connection for all DB operations.
