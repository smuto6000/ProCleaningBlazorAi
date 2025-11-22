using FluentValidation;
using Microsoft.Extensions.Localization;
using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.WebUI.Resources;

namespace ProCleaningBlazorAi.WebUI.Validators;

public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
{
    public UserCreateDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Meno je povinné.")
            .MaximumLength(100).WithMessage("Meno je príliš dlhé.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Priezvisko je povinné.")
            .MaximumLength(100).WithMessage("Priezvisko je príliš dlhé.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email je povinný.")
            .EmailAddress().WithMessage("Zadajte platný email.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Heslo je povinné.")
            .MinimumLength(6).WithMessage("Heslo musí mať aspoň 6 znakov.");

        RuleFor(x => x.RoleId)
            .GreaterThan(0).WithMessage("Vyberte rolu.");
    }
}

public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
{
    public UserUpdateDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Meno je povinné.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Priezvisko je povinné.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email je povinný.")
            .EmailAddress().WithMessage("Zadajte platný email.");

        RuleFor(x => x.RoleId)
            .GreaterThan(0).WithMessage("Vyberte rolu.");
    }
}

