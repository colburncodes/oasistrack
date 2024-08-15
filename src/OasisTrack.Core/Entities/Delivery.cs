namespace OasisTrack.Core.Entities;

public class Delivery
{
    public int Id { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public int DriverId { get; set; }
    public Driver Driver { get; set; }
    public DateTime DeliveryDate { get; set; }
    public List<DeliveryItem> DeliveryItems { get; set; }
    public string Comments { get; set; }
    public bool IsSubmitted { get; set; }
    public DateTime SubmittedAt { get; set; }
}