using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Mapping;

public static class AirportMapper
{
    public static Airport MapToService(this DbAirport db)
    {
        return db == null
            ? null
            : new Airport
            {
                Id = db.Id,
                Name = db.Name,
                Code = db.Code,
                Runways = db.Runways,
                SoldTickets = db.SoldTickets,
                AverageVisitors = db.AverageVisitors,
                MonthlyIncome = db.MonthlyIncome,
                IncidentsCount = db.IncidentsCount
            };
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