namespace OasisTrack.Core.Entities;

public class SalesAgreement
{
    public int Id { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public decimal CommissionRate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Terms { get; set; }
    public bool IsActive { get; set; }
}