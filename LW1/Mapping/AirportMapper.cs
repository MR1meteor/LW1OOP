using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Mapping;

public static class AirportMapper
{
    public static Airport MapToService(this DbAirport service)
    {
        return service == null
            ? null
            : new Airport(service.Name, service.Code, service.Runways, service.SoldTickets,
                service.AverageVisitors, service.MonthlyIncome, service.IncidentsCount);
    }

    public static List<Airport> MapToService(this IEnumerable<DbAirport> db)
    {
        return db == null ? new List<Airport>() : db.Where(da => da != null).Select(da => da.MapToService()).ToList();
    }
    
    public static DbAirport MapToDb(this Airport service)
    {
        return service == null
            ? null
            : new DbAirport
            {
                Id = service.Id,
                Name = service.Name,
                Code = service.Code,
                Runways = service.Runways,
                SoldTickets = service.SoldTickets,
                AverageVisitors = service.AverageVisitors,
                MonthlyIncome = service.MonthlyIncome,
                IncidentsCount = service.IncidentsCount
            };
    }

    public static List<DbAirport> MapToDb(this IEnumerable<Airport> service)
    {
        return service == null ? new List<DbAirport>() : service.Where(a => a != null).Select(a => a.MapToDb()).ToList();
    }
}