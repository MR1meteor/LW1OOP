using Dapper;
using LW1.Data;
using LW1.Mapping;
using LW1.Models.Db;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;

namespace LW1.Repositories;

public class AirportRepository : IAirportRepository
{
    private DataContext context;

    public AirportRepository(DataContext context)
    {
        this.context = context;
    }
    
    public async Task<List<Airport>> GetAll()
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Airports
                  """;
        return (await connection.QueryAsync<DbAirport>(sql)).MapToService();
    }

    public async Task<Airport> GetById(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Airports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        return (await connection.QueryFirstOrDefaultAsync<DbAirport>(sql, parameters)).MapToService();
    }

    public async Task<Airport> Add(DbAirport dbAirport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  INSERT INTO Airports (Name, Code, Runways, SoldTickets, AverageVisitors, MonthlyIncome, IncidentsCount)
                  VALUES (@Name, @Code, @SoldTickets, @AverageVisitors, @MonthlyIncome, @IncidentsCount)
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbAirport>(sql, dbAirport)).MapToService();
    }

    public async Task<Airport> Update(DbAirport dbAirport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  UPDATE Airports
                  SET Name = @Name,
                      Code = @Code,
                      Runways = @Runways,
                      SoldTickets = @SoldTickets,
                      AverageVisitors = @AverageVisitors,
                      IncidentsCount = @IncidentsCount
                  WHERE Id = @Id
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbAirport>(sql, dbAirport)).MapToService();
    }

    public async Task Delete(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  DELETE FROM Airports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        await connection.ExecuteAsync(sql, parameters);
    }
}