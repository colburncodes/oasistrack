namespace OasisTrack.Core.Entities;

public class Driver : User
{
    public string DriverLicenseNumber { get; set; }
    public DateTime LicenseExpirationDate { get; set; }
    public int CurrentRouteId { get; set; }
    public Route CurrentRoute { get; set; }
}