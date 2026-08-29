using System.Text.Json.Serialization;

namespace Formula1.Api.Services;

public record DriverPoint(
    [property: JsonPropertyName("driver_number")] int Number,
    [property: JsonPropertyName("points_current")] double Point,
    [property: JsonPropertyName("position_current")] int Position
);
