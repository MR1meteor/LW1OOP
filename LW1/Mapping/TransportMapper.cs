using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Mapping;

public static class TransportMapper
{
    public static Transport MapToService(this DbTransport service)
    {
        return service == null
            ? null
            : new Transport(service.Id, service.Model, service.Name, service.Surname, service.Patronymic,
                service.Route, service.Mileage);
    }

    public static List<Transport> MapToService(this IEnumerable<DbTransport> db)
    {
        return db == null ? new List<Transport>() : db.Where(da => da != null).Select(da => da.MapToService()).ToList();
    }
    
    public static DbTransport MapToDb(this Transport service)
    {
        return service == null
            ? null
            : new DbTransport
            {
                Id = service.Id,
                Model = service.Model,
                Name = service.Name,
                Surname = service.Surname,
                Patronymic = service.Patronymic,
                Route = service.Route,
                Mileage = service.Mileage
            };
    }

    public static List<DbTransport> MapToDb(this IEnumerable<Transport> service)
    {
        return service == null ? new List<DbTransport>() : service.Where(a => a != null).Select(a => a.MapToDb()).ToList();
    }
}