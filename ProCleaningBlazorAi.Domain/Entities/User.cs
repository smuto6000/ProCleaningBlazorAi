namespace ProCleaningBlazorAi.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ValidTo { get; set; }

    // Foreign Key - zmena na int
    public int RoleId { get; set; }
    
    public Role? Role { get; set; }
}
