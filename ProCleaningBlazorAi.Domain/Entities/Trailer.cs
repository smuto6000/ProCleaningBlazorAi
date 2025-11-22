namespace ProCleaningBlazorAi.Domain.Entities;

public class Trailer
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    public DateTime? EmissionControlValidTo { get; set; }
    public DateTime? ServiceValidTo { get; set; }
    public DateTime? ValidTo { get; set; }
}

