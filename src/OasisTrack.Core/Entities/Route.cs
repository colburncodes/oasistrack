namespace OasisTrack.Core.Entities;

public class Route
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public int? DriverId { get; set; }
    public Driver Driver { get; set; }
    public ICollection<Store> Stores { get; set; } = new List<Store>();
}