using Formula1.Api.DTOs;
using Formula1.Api.Models;

namespace Formula1.Api.Mappings;

public static class DriverMappingExtensions
{
    public static DriverDTO? ToDto(this Driver? driver)
    {
        if (driver == null)
            return null;

        return new DriverDTO
        {
            Name = driver.Name,
            Team = driver.Team,
            Number = driver.Number,
            Age = driver.Age,
            Nationality = driver.Nationality,
            ImageUrl = driver.ImageUrl
        };
    }

    public static List<DriverDTO> ToDto(this List<Driver> drivers)
    {
        if (drivers == null || drivers.Count == 0)
            return new List<DriverDTO>();

        var result = new List<DriverDTO>();

        foreach (var driver in drivers)
        {
            result.Add(new DriverDTO
                {
                    Name = driver.Name,
                    Team = driver.Team,
                    Number = driver.Number,
                    Age = driver.Age,
                    Nationality = driver.Nationality,
                    ImageUrl = driver.ImageUrl
                });
        }
        return result;
    }
}