namespace OasisTrack.Core.Entities;

public class DeliveryItem
{
    public int Id { get; set; }
    public int DeliveryId { get; set; }
    public Delivery Delivery { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public int QuantitySold { get; set; }
    public int QuantityShrinkage { get; set; }
    public int QuantityAdded { get; set; }
    public decimal LocalPrice { get; set; }
}