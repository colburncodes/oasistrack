using OasisTrack.Core.Entities;
using OasisTrack.Core.Interfaces;

namespace OasisTrack.Application.Services;

public class RouteService : IRouteService
{
    private IRouteRepository _routeRepository;

    public RouteService(IRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }
    public Task<Route> CreateRouteAsync(Route route)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Route>> GetAllRoutesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Route> GetRouteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRouteAsync(Route route)
    {
        throw new NotImplementedException();
    }

    public Task AssignStoreToRouteAsync(int routeId, int storeId)
    {
        throw new NotImplementedException();
    }

    public Task RemoveStoreFromRouteAsync(int routeId, int storeId)
    {
        throw new NotImplementedException();
    }

    public Task AssignDriverToRouteAsync(int routeId, int driverId)
    {
        throw new NotImplementedException();
    }

    public Task SetRouteActiveStatusAsync(int routeId, bool isActive)
    {
        throw new NotImplementedException();
    }
}