using OasisTrack.Core.Entities;

namespace OasisTrack.Core.Interfaces;

public interface IRouteService
{
    Task<Route> CreateRouteAsync(Route route);
    Task<IEnumerable<Route>> GetAllRoutesAsync();
    Task<Route> GetRouteByIdAsync(int id);
    Task UpdateRouteAsync(Route route);
    Task AssignStoreToRouteAsync(int routeId, int storeId);
    Task RemoveStoreFromRouteAsync(int routeId, int storeId);
    Task AssignDriverToRouteAsync(int routeId, int driverId);
    Task SetRouteActiveStatusAsync(int routeId, bool isActive);
}