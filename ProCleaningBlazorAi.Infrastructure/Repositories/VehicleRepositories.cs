using Microsoft.EntityFrameworkCore;
using ProCleaningBlazorAi.Application.Interfaces.Repositories;
using ProCleaningBlazorAi.Domain.Entities;
using ProCleaningBlazorAi.Infrastructure.Persistence;

namespace ProCleaningBlazorAi.Infrastructure.Repositories;

public class CarRepository : ICarRepository
{
    private readonly ApplicationDbContext _context;
    public CarRepository(ApplicationDbContext context) => _context = context;

    public async Task<List<Car>> GetAllAsync() => await _context.Cars.OrderBy(x => x.Model).ToListAsync();
    public async Task<Car?> GetByIdAsync(Guid id) => await _context.Cars.FindAsync(id);
    public async Task AddAsync(Car entity) { await _context.Cars.AddAsync(entity); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(Car entity) { _context.Cars.Update(entity); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(Car entity) { _context.Cars.Remove(entity); await _context.SaveChangesAsync(); }
}

public class TrailerRepository : ITrailerRepository
{
    private readonly ApplicationDbContext _context;
    public TrailerRepository(ApplicationDbContext context) => _context = context;

    public async Task<List<Trailer>> GetAllAsync() => await _context.Trailers.OrderBy(x => x.Model).ToListAsync();
    public async Task<Trailer?> GetByIdAsync(Guid id) => await _context.Trailers.FindAsync(id);
    public async Task AddAsync(Trailer entity) { await _context.Trailers.AddAsync(entity); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(Trailer entity) { _context.Trailers.Update(entity); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(Trailer entity) { _context.Trailers.Remove(entity); await _context.SaveChangesAsync(); }
}

public class PlatformRepository : IPlatformRepository
{
    private readonly ApplicationDbContext _context;
    public PlatformRepository(ApplicationDbContext context) => _context = context;

    public async Task<List<Platform>> GetAllAsync() => await _context.Platforms.OrderBy(x => x.Model).ToListAsync();
    public async Task<Platform?> GetByIdAsync(Guid id) => await _context.Platforms.FindAsync(id);
    public async Task AddAsync(Platform entity) { await _context.Platforms.AddAsync(entity); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(Platform entity) { _context.Platforms.Update(entity); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(Platform entity) { _context.Platforms.Remove(entity); await _context.SaveChangesAsync(); }
}

