namespace OasisTrack.Core.Entities;

public class Admin : User
{
    public string Department { get; set; }
    public string AccessLevel { get; set; }
}