using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Application.Interfaces.Repositories;

public interface ICarRepository
{
    Task<List<Car>> GetAllAsync();
    Task<Car?> GetByIdAsync(Guid id);
    Task AddAsync(Car entity);
    Task UpdateAsync(Car entity);
    Task DeleteAsync(Car entity);
}

public interface ITrailerRepository
{
    Task<List<Trailer>> GetAllAsync();
    Task<Trailer?> GetByIdAsync(Guid id);
    Task AddAsync(Trailer entity);
    Task UpdateAsync(Trailer entity);
    Task DeleteAsync(Trailer entity);
}

public interface IPlatformRepository
{
    Task<List<Platform>> GetAllAsync();
    Task<Platform?> GetByIdAsync(Guid id);
    Task AddAsync(Platform entity);
    Task UpdateAsync(Platform entity);
    Task DeleteAsync(Platform entity);
}

