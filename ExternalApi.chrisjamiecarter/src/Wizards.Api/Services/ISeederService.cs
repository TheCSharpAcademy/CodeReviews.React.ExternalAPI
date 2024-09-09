namespace Wizards.Api.Services;

/// <summary>
/// Defines the contract for a service that manages Seeding a Database with entities.
/// </summary>
internal interface ISeederService
{
    void SeedDatabase();
}