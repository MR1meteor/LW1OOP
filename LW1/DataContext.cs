using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

namespace LW1;

public class DataContext
{
    private string connectionString;
    
    public DataContext()
    {
        connectionString = "jdbc:sqlite:sqlite_database_file_path";
    }

    public IDbConnection CreateConnection()
    {
        return new SqliteConnection(connectionString);
    }

    public async Task Init()
    {
        using var connection = CreateConnection();
        await initAirports();

        async Task initAirports()
        {
            var sql = """
                          CREATE TABLE IF NOT EXISTS
                          Users (
                              Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                              Name TEXT,
                              Code INTEGER,
                              Runways INTEGER,
                              SoldTickets INTEGER,
                              AveragePassengers REAL,
                              MonthlyIncome REAL,
                              IncidentsCount INTEGER
                          );
                      """;
            await connection.ExecuteAsync(sql);
        }
    }
}