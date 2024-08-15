namespace OasisTrack.Core.Entities;

public class Route
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Store> Stores { get; set; }
    public int DriverId { get; set; }
    public Driver Driver { get; set; }
}