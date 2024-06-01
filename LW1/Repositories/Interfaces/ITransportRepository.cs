using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Repositories.Interfaces;

public interface ITransportRepository
{
    Task<List<Transport>> GetAll();
    Task<Transport> GetById(int id);
    Task<Transport> Add(DbTransport dbTransport);
    Task<Transport> Update(DbTransport dbTransport);
    Task Delete(int id);
}