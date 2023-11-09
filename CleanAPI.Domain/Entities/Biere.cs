namespace CleanAPI.Domain.Entities;

public class Biere : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public BiereType Type { get; set; }
    public double DegreAlcool { get; set; }

    public Guid MarqueId { get; set; }
    public Marque Marque { get; set; } = null!;

    public List<Avis> Avis { get; set; } = new List<Avis>();
    public Guid FavorisId { get; set; }

}
