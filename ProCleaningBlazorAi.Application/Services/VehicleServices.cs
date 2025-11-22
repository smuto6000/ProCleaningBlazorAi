using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.Application.Interfaces.Repositories;
using ProCleaningBlazorAi.Application.Interfaces.Services;
using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Application.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _repository;
    public CarService(ICarRepository repository) => _repository = repository;

    public async Task<List<CarDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return items.Select(MapToDto).ToList();
    }

    public async Task<CarDto?> GetByIdAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        return item == null ? null : MapToDto(item);
    }

    public async Task CreateAsync(CarCreateDto dto)
    {
        var item = new Car
        {
            Id = Guid.NewGuid(),
            Model = dto.Model,
            Plate = dto.Plate,
            Vin = dto.Vin,
            VignetteValidTo = dto.VignetteValidTo,
            EmissionControlValidTo = dto.EmissionControlValidTo,
            ServiceValidTo = dto.ServiceValidTo,
            ValidTo = dto.ValidTo
        };
        await _repository.AddAsync(item);
    }

    public async Task UpdateAsync(CarUpdateDto dto)
    {
        var item = await _repository.GetByIdAsync(dto.Id);
        if (item == null) return;

        item.Model = dto.Model;
        item.Plate = dto.Plate;
        item.Vin = dto.Vin;
        item.VignetteValidTo = dto.VignetteValidTo;
        item.EmissionControlValidTo = dto.EmissionControlValidTo;
        item.ServiceValidTo = dto.ServiceValidTo;
        item.ValidTo = dto.ValidTo;

        await _repository.UpdateAsync(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item != null) await _repository.DeleteAsync(item);
    }

    private static CarDto MapToDto(Car item) => new()
    {
        Id = item.Id,
        Model = item.Model,
        Plate = item.Plate,
        Vin = item.Vin,
        VignetteValidTo = item.VignetteValidTo,
        EmissionControlValidTo = item.EmissionControlValidTo,
        ServiceValidTo = item.ServiceValidTo,
        ValidTo = item.ValidTo
    };
}

public class TrailerService : ITrailerService
{
    private readonly ITrailerRepository _repository;
    public TrailerService(ITrailerRepository repository) => _repository = repository;

    public async Task<List<TrailerDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return items.Select(MapToDto).ToList();
    }

    public async Task<TrailerDto?> GetByIdAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        return item == null ? null : MapToDto(item);
    }

    public async Task CreateAsync(TrailerCreateDto dto)
    {
        var item = new Trailer
        {
            Id = Guid.NewGuid(),
            Model = dto.Model,
            Plate = dto.Plate,
            EmissionControlValidTo = dto.EmissionControlValidTo,
            ServiceValidTo = dto.ServiceValidTo,
            ValidTo = dto.ValidTo
        };
        await _repository.AddAsync(item);
    }

    public async Task UpdateAsync(TrailerUpdateDto dto)
    {
        var item = await _repository.GetByIdAsync(dto.Id);
        if (item == null) return;

        item.Model = dto.Model;
        item.Plate = dto.Plate;
        item.EmissionControlValidTo = dto.EmissionControlValidTo;
        item.ServiceValidTo = dto.ServiceValidTo;
        item.ValidTo = dto.ValidTo;

        await _repository.UpdateAsync(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item != null) await _repository.DeleteAsync(item);
    }

    private static TrailerDto MapToDto(Trailer item) => new()
    {
        Id = item.Id,
        Model = item.Model,
        Plate = item.Plate,
        EmissionControlValidTo = item.EmissionControlValidTo,
        ServiceValidTo = item.ServiceValidTo,
        ValidTo = item.ValidTo
    };
}

public class PlatformService : IPlatformService
{
    private readonly IPlatformRepository _repository;
    public PlatformService(IPlatformRepository repository) => _repository = repository;

    public async Task<List<PlatformDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();
        return items.Select(MapToDto).ToList();
    }

    public async Task<PlatformDto?> GetByIdAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        return item == null ? null : MapToDto(item);
    }

    public async Task CreateAsync(PlatformCreateDto dto)
    {
        var item = new Platform
        {
            Id = Guid.NewGuid(),
            Model = dto.Model,
            Plate = dto.Plate,
            EmissionControlValidTo = dto.EmissionControlValidTo,
            ServiceValidTo = dto.ServiceValidTo,
            ValidTo = dto.ValidTo
        };
        await _repository.AddAsync(item);
    }

    public async Task UpdateAsync(PlatformUpdateDto dto)
    {
        var item = await _repository.GetByIdAsync(dto.Id);
        if (item == null) return;

        item.Model = dto.Model;
        item.Plate = dto.Plate;
        item.EmissionControlValidTo = dto.EmissionControlValidTo;
        item.ServiceValidTo = dto.ServiceValidTo;
        item.ValidTo = dto.ValidTo;

        await _repository.UpdateAsync(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        if (item != null) await _repository.DeleteAsync(item);
    }

    private static PlatformDto MapToDto(Platform item) => new()
    {
        Id = item.Id,
        Model = item.Model,
        Plate = item.Plate,
        EmissionControlValidTo = item.EmissionControlValidTo,
        ServiceValidTo = item.ServiceValidTo,
        ValidTo = item.ValidTo
    };
}

