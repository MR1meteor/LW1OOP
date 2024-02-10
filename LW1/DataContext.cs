using System.Data;

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
        
    }
}