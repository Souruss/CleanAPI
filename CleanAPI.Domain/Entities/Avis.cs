namespace CleanAPI.Domain.Entities;

public class Avis : EntityBase
{
    public string Commentaire { get; set; } = string.Empty;

    public Guid ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public Guid? BiereId { get; set; }
    public Biere Biere { get; set; } = null!;

    public Guid? BarId { get; set; }
    public Bar Bar { get; set; } = null!;
}
