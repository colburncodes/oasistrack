namespace OasisTrack.Core.Entities;

public class MaintenanceRequeset
{
    public int Id { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public int DriverId { get; set; }
    public Driver Driver { get; set; }
    public string Description { get; set; }
    public DateTime RequestDate { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public DateTime? ResolutionDate { get; set; }
    public string ResolutionNotes { get; set; }
}