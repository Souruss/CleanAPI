namespace CleanAPI.Domain.Entities;

public class Favoris  : EntityBase
{
    public Guid ClientId { get; set; }
    public Client Client { get; set; } = null!;
    public List<Biere> Bieres { get; set; } = new List<Biere>();
    public List<Bar> Bars { get; set; } = new List<Bar>();
}
