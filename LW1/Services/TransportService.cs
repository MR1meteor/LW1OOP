using LW1.Mapping;
using LW1.Models.Service;
using LW1.Repositories.Interfaces;
using LW1.Services.Interfaces;

namespace LW1.Services;

public class TransportService : ITransportService
{
    private ITransportRepository TransportRepository;

    public TransportService(ITransportRepository TransportRepository)
    {
        this.TransportRepository = TransportRepository;
    }
    
    public async Task<List<Transport>> GetAll()
    {
        return await TransportRepository.GetAll();
    }

    public async Task<Transport> GetById(int id)
    {
        return await TransportRepository.GetById(id);
    }

    public async Task<Transport> Add(Transport Transport)
    {
        var dbTransport = Transport.MapToDb();
        return await TransportRepository.Add(dbTransport);
    }

    public async Task<Transport> Update(Transport Transport)
    {
        var dbTransport = Transport.MapToDb();
        return await TransportRepository.Update(dbTransport);
    }

    public async Task Delete(int id)
    {
        await TransportRepository.Delete(id);
    }
}