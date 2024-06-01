using LW1.Models.Service;

namespace LW1.Services.Interfaces;

public interface ITransportService
{
    Task<List<Transport>> GetAll();
    Task<Transport> GetById(int id);
    Task<Transport> Add(Transport Transport);
    Task<Transport> Update(Transport Transport);
    Task Delete(int id);
}