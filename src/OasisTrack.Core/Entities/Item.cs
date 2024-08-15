namespace OasisTrack.Core.Entities;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SKU { get; set; }
    public decimal GlobalPrice { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public int ParLevel { get; set; }
    public bool IsActive { get; set; }
}