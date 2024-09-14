namespace OasisTrack.WebApi.DTOs.Store;

public class StoreDto
{
    public StoreDto() {}
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public bool isActive { get; set; }
    public string ManagerName { get; set; }
    public int? RouteId { get; set; }
    public string FullAddress => $"{Address}, {City}, {State} {ZipCode}";

    public StoreDto(Core.Entities.Store store)
    {
        Id = store.Id;
        Name = store.Name;
        Address = store.Address;
        City = store.City;
        State = store.State;
        ZipCode = store.ZipCode;
        PhoneNumber = store.PhoneNumber;
        isActive = store.IsActive;
        RouteId = store.RouteId;
        ManagerName = store.ManagerName;
    }
    
    public class CreateStoreDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ManagerName { get; set; }
    }

    public class UpdateStoreDto : CreateStoreDto
    {
        public int Id { get; set; }
    }
}