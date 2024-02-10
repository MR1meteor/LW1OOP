using System.Data;
using Microsoft.Data.Sqlite;

namespace LW1;

public class DataContext
{
    private string connectionString;
    
    public DataContext()
    {
        connectionString = "";
    }

    public IDbConnection CreateConnection()
    {
        return new SqliteConnection(connectionString);
    }
}