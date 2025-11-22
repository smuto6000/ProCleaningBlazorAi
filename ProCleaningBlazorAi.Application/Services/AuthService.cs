using Microsoft.AspNetCore.Identity;
using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.Application.Interfaces.Repositories;
using ProCleaningBlazorAi.Application.Interfaces.Services;
using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<User> _passwordHasher;

    public AuthService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
    }

    public async Task<UserDto?> LoginAsync(string email, string password)
    {
        var user = await _userRepository.GetByEmailAsync(email);

        if (user == null)
        {
            return null;
        }

        var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

        if (result == PasswordVerificationResult.Failed)
        {
            return null;
        }

        return new UserDto(user.Id, user.Email, user.FirstName, user.LastName, user.Role?.Name ?? "User");
    }
}

