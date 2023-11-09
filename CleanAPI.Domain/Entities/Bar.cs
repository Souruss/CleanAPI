namespace CleanAPI.Domain.Entities;

public class Bar : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public string Front = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_jbdgyziS3WYZiYUkzlQCkhtPnT1bL5Y2dw&usqp=CAU";

    public List<Avis> Avis { get; set; } = new List<Avis>();
    public List<Biere> Biere { get; set; } = new List<Biere>();
    public Guid FavorisId { get; set; }


}
