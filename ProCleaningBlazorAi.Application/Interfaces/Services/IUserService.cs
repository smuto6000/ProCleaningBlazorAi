using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Application.Interfaces.Services;

public interface IUserService
{
    Task<List<UserDetailDto>> GetAllAsync();
    Task<UserDetailDto?> GetByIdAsync(Guid id);
    Task CreateAsync(UserCreateDto dto);
    Task UpdateAsync(UserUpdateDto dto);
    Task DeleteAsync(Guid id);
    Task<List<Role>> GetRolesAsync(); // Pomocná metóda pre dropdown
}

