namespace CleanAPI.Domain.Entities;

public class Client : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public List<Avis> Avis { get; set; } = new List<Avis>();

    public Guid? FavorisId { get; set; }
    public Favoris Favoris { get; set; } = null!;
}
