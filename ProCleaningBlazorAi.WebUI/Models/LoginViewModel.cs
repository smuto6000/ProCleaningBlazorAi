using System.ComponentModel.DataAnnotations;

namespace ProCleaningBlazorAi.WebUI.Models;

public class LoginViewModel
{
    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;

    public bool RememberMe { get; set; }
}

