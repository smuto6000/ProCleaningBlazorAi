namespace ProCleaningBlazorAi.Application.DTOs;

// CAR
public class CarDto
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public string? Vin { get; set; }
    public DateTime? VignetteValidTo { get; set; }
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class CarCreateDto
{
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public string? Vin { get; set; }
    public DateTime? VignetteValidTo { get; set; }
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class CarUpdateDto : CarCreateDto
{
    public Guid Id { get; set; }
}

// TRAILER
public class TrailerDto
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class TrailerCreateDto
{
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class TrailerUpdateDto : TrailerCreateDto
{
    public Guid Id { get; set; }
}

// PLATFORM
public class PlatformDto
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class PlatformCreateDto
{
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

public class PlatformUpdateDto : PlatformCreateDto
{
    public Guid Id { get; set; }
}

