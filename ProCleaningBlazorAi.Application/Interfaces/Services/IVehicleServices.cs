using ProCleaningBlazorAi.Application.DTOs;

namespace ProCleaningBlazorAi.Application.Interfaces.Services;

public interface ICarService
{
    Task<List<CarDto>> GetAllAsync();
    Task<CarDto?> GetByIdAsync(Guid id);
    Task CreateAsync(CarCreateDto dto);
    Task UpdateAsync(CarUpdateDto dto);
    Task DeleteAsync(Guid id);
}

public interface ITrailerService
{
    Task<List<TrailerDto>> GetAllAsync();
    Task<TrailerDto?> GetByIdAsync(Guid id);
    Task CreateAsync(TrailerCreateDto dto);
    Task UpdateAsync(TrailerUpdateDto dto);
    Task DeleteAsync(Guid id);
}

public interface IPlatformService
{
    Task<List<PlatformDto>> GetAllAsync();
    Task<PlatformDto?> GetByIdAsync(Guid id);
    Task CreateAsync(PlatformCreateDto dto);
    Task UpdateAsync(PlatformUpdateDto dto);
    Task DeleteAsync(Guid id);
}

