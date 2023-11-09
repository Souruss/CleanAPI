namespace CleanAPI.Domain.Entities;

public class Marque : EntityBase
{
    public string Nom { get; set; } = string.Empty;
    public string Descrpition { get; set; } = string.Empty;
    public Country Country { get; set; }
    public List<Biere> Bieres { get; set; } = new List<Biere>();
}
