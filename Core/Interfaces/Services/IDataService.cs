namespace CleanArchitecture.Core.Interfaces.Services;

public interface IDataService
{
    Task<bool> SeedData();
}