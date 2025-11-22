using Microsoft.AspNetCore.Identity;
using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.Application.Interfaces.Repositories;
using ProCleaningBlazorAi.Application.Interfaces.Services;
using ProCleaningBlazorAi.Domain.Entities;

namespace ProCleaningBlazorAi.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UserService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
    }

    public async Task<List<UserDetailDto>> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(u => new UserDetailDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email,
            Role = u.Role?.Name ?? "",
            RoleId = u.RoleId
        }).ToList();
    }

    public async Task<UserDetailDto?> GetByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return null;

        return new UserDetailDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Role = user.Role?.Name ?? "",
            RoleId = user.RoleId
        };
    }

    public async Task CreateAsync(UserCreateDto dto)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            RoleId = dto.RoleId,
            CreatedAt = DateTime.UtcNow
        };

        user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

        await _userRepository.AddAsync(user);
    }

    public async Task UpdateAsync(UserUpdateDto dto)
    {
        var user = await _userRepository.GetByIdAsync(dto.Id);
        if (user == null) return;

        user.FirstName = dto.FirstName;
        user.LastName = dto.LastName;
        user.Email = dto.Email;
        user.RoleId = dto.RoleId;

        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user != null)
        {
            await _userRepository.DeleteAsync(user);
        }
    }

    public async Task<List<Role>> GetRolesAsync()
    {
        return await _userRepository.GetRolesAsync();
    }
}

