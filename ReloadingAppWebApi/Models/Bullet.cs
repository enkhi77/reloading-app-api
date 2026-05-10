namespace ReloadingAppWebApi.Models;

public partial class Bullet
{
    public Guid Id { get; set; }
    public string Caliber { get; set; }
    public DateOnly? DatePurchased { get; set; }
    public decimal Diameter { get; set; }
    public string Lot { get; set; }
    public decimal Price { get; set; }
    public int Weight { get; set; }
}
