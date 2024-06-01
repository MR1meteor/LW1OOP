using Dapper;
using LW1.Data;
using LW1.Mapping;
using LW1.Models.Db;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;

namespace LW1.Repositories;

public class TransportRepository : ITransportRepository
{
    private DataContext context;

    public TransportRepository(DataContext context)
    {
        this.context = context;
    }
    
    public async Task<List<Transport>> GetAll()
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Transports
                  """;
        return (await connection.QueryAsync<DbTransport>(sql)).MapToService();
    }

    public async Task<Transport> GetById(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  SELECT * FROM Transports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        return (await connection.QueryFirstOrDefaultAsync<DbTransport>(sql, parameters)).MapToService();
    }

    public async Task<Transport> Add(DbTransport dbTransport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  INSERT INTO Transports (Name, Code, Runways, SoldTickets, AverageVisitors, MonthlyIncome, IncidentsCount)
                  VALUES (@Name, @Code, @SoldTickets, @AverageVisitors, @MonthlyIncome, @IncidentsCount)
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbTransport>(sql, dbTransport)).MapToService();
    }

    public async Task<Transport> Update(DbTransport dbTransport)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  UPDATE Transports
                  SET Name = @Name,
                      Code = @Code,
                      Runways = @Runways,
                      SoldTickets = @SoldTickets,
                      AverageVisitors = @AverageVisitors,
                      IncidentsCount = @IncidentsCount
                  WHERE Id = @Id
                  RETURNING *
                  """;
        return (await connection.QuerySingleOrDefaultAsync<DbTransport>(sql, dbTransport)).MapToService();
    }

    public async Task Delete(int id)
    {
        using var connection = context.CreateConnection();
        var sql = """
                  DELETE FROM Transports WHERE Id = @Id
                  """;
        var parameters = new { Id = id };
        await connection.ExecuteAsync(sql, parameters);
    }
}