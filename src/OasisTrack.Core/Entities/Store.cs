namespace OasisTrack.Core.Entities;

public class Store
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public string ManagerName { get; set; }
    public bool IsActive { get; set; }
    public int RouteId { get; set; }
    public Route Route { get; set; }
    public List<Item> Items { get; set; }
    public SalesAgreement SalesAgreement { get; set; }
}