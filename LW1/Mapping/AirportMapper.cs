using LW1.Models.Db;
using LW1.Models.Service;

namespace LW1.Mapping;

public static class AirportMapper
{
    public static MilitaryAirport MapMilitaryToService(this DbAirport db)
    {
        return db == null
            ? null
            : new MilitaryAirport
            {
                Id = db.Id,
                Name = db.Name,
                Code = db.Code,
                Runways = db.Runways,
                IncidentsCount = db.IncidentsCount,
                MilitaryDistrict = db.MilitaryDistrict,
                HasAirDefence = db.HasAirDefence > 0,
                AircraftNumber = db.AircraftNumber
            };
    }
    
    public static ICollection<MilitaryAirport> MapMilitaryToService(this IEnumerable<DbAirport> db)
    { 
        return db == null ? new List<MilitaryAirport>() : db.Where(da => da != null).Select(da => da.MapMilitaryToService()).ToList();
    }
    
    public static CivilAirport MapCivilToService(this DbAirport db)
    {
        return db == null
            ? null
            : new CivilAirport
            {
                Id = db.Id,
                Name = db.Name,
                Code = db.Code,
                Runways = db.Runways,
                IncidentsCount = db.IncidentsCount,
                SoldTickets = db.SoldTickets,
                AverageVisitors = db.AverageVisitors,
                MonthlyIncome = db.MonthlyIncome
            };
    }

    public static ICollection<MilitaryAirport> MapCivilToService(this IEnumerable<DbAirport> db)
    {
        return db == null ? new List<MilitaryAirport>() : db.Where(da => da != null).Select(da => da.MapMilitaryToService()).ToList();
    }
    
    public static DbAirport MapToDb(this CivilAirport service)
    {
        return service == null
            ? null
            : new DbAirport
            {
                Id = service.Id,
                Name = service.Name,
                Code = service.Code,
                Runways = service.Runways,
                IncidentsCount = service.IncidentsCount,
                SoldTickets = service.SoldTickets,
                AverageVisitors = service.AverageVisitors,
                MonthlyIncome = service.MonthlyIncome,
                AirportType = 0
            };
    }

    public static ICollection<DbAirport> MapCivilToDb(this IEnumerable<CivilAirport> service)
    {
        return service == null ? new List<DbAirport>() : service.Where(a => a != null).Select(a => a.MapToDb()).ToList();
    }
    
    public static DbAirport MapToDb(this MilitaryAirport service)
    {
        return service == null
            ? null
            : new DbAirport
            {
                Id = service.Id,
                Name = service.Name,
                Code = service.Code,
                Runways = service.Runways,
                IncidentsCount = service.IncidentsCount,
                MilitaryDistrict = service.MilitaryDistrict,
                HasAirDefence = Convert.ToInt32(service.HasAirDefence),
                AircraftNumber = service.AircraftNumber,
                AirportType = 1
            };
    }
    
    public static ICollection<DbAirport> MapMilitaryToDb(this IEnumerable<MilitaryAirport> service)
    {
        return service == null ? new List<DbAirport>() : service.Where(a => a != null).Select(a => a.MapToDb()).ToList();
    }

    public static Airport MapToService(this DbAirport db)
    {
        if (db == null)
        {
            return null;
        }
        
        switch (db.AirportType)
        {
            case 0:
                return db.MapCivilToService();
            case 1:
                return db.MapMilitaryToService();
            default:
                return null;
        }
    }

    public static ICollection<Airport> MapToService(this IEnumerable<DbAirport> db)
    {
        return db == null ? new List<Airport>() : db.Where(a => a != null).Select(a => a.MapToService()).ToList();
    }
}