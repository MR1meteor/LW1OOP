using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

namespace LW1.Data;

public class DataContext
{
    private string connectionString;
    
    public DataContext()
    {
        connectionString = "Data Source=database.db";
    }

    public IDbConnection CreateConnection()
    {
        return new SqliteConnection(connectionString);
    }

    public async Task Init()
    {
        using var connection = CreateConnection();
        
        // TODO: Remake using DbUp
        await initAirports();
        
        async Task initAirports()
        {
            var sql = """
                          CREATE TABLE IF NOT EXISTS
                          Airports (
                              Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                              Name TEXT,
                              Code INTEGER,
                              Runways INTEGER,
                              SoldTickets INTEGER,
                              AverageVisitors REAL,
                              MonthlyIncome REAL,
                              IncidentsCount INTEGER,
                              MilitaryDistrict TEXT,
                              HasAirDefence INTEGER,
                              AircraftNumber INTEGER
                          );
                      """;
            await connection.ExecuteAsync(sql);
        }
    }
}