using Dapper;
using LW1.Db;

namespace LW1.Repositories;

public class AirportRepository : IAirportRepository
{
    private DataContext _context;

    public AirportRepository(DataContext context)
    {
        _context = context;
    }

    public Task<List<DbAirport>> GetAll()
    {
        using var conne
    }

    public async Task<DbAirport> GetById(int id)
    {
        using var connection = _context.CreateConnection();
        var sql = """
                  SELECT * FROM Airports WHERE Id=@Id
                  """;
        return await connection.QuerySingleOrDefaultAsync<DbAirport>(sql, new { Id = id });
    }
}