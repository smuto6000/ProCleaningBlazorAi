using FluentValidation;
using ProCleaningBlazorAi.Application.DTOs;
using ProCleaningBlazorAi.WebUI.Resources;

namespace ProCleaningBlazorAi.WebUI.Validators;

public class CarCreateDtoValidator : AbstractValidator<CarCreateDto>
{
    public CarCreateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangCars.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangCars.Val_PlateRequired);
    }
}

public class CarUpdateDtoValidator : AbstractValidator<CarUpdateDto>
{
    public CarUpdateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangCars.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangCars.Val_PlateRequired);
    }
}

public class TrailerCreateDtoValidator : AbstractValidator<TrailerCreateDto>
{
    public TrailerCreateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangTrailers.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangTrailers.Val_PlateRequired);
    }
}

public class TrailerUpdateDtoValidator : AbstractValidator<TrailerUpdateDto>
{
    public TrailerUpdateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangTrailers.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangTrailers.Val_PlateRequired);
    }
}

public class PlatformCreateDtoValidator : AbstractValidator<PlatformCreateDto>
{
    public PlatformCreateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangPlatforms.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangPlatforms.Val_PlateRequired);
    }
}

public class PlatformUpdateDtoValidator : AbstractValidator<PlatformUpdateDto>
{
    public PlatformUpdateDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(LangPlatforms.Val_ModelRequired);
            
        RuleFor(x => x.Plate)
            .NotEmpty().WithMessage(LangPlatforms.Val_PlateRequired);
    }
}

