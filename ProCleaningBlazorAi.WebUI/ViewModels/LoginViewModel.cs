using FluentValidation;
using Microsoft.Extensions.Localization;
using ProCleaningBlazorAi.WebUI.Resources;

namespace ProCleaningBlazorAi.WebUI.ViewModels;

public class LoginViewModel
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool RememberMe { get; set; } = false;
}

public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
{
    // Prijmeme IStringLocalizer
    public LoginViewModelValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(localizer["Validation_EmailRequired"])
            .EmailAddress().WithMessage(localizer["Validation_EmailInvalid"]);

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage(localizer["Validation_PasswordRequired"]);
    }
}
