namespace ProCleaningBlazorAi.Domain.Entities;

public class Car
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

