using ProCleaningBlazorAi.Application.DTOs;

namespace ProCleaningBlazorAi.Application.Interfaces.Services;

public interface IAuthService
{
    Task<UserDto?> LoginAsync(string email, string password);
}

