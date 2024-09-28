using OasisTrack.Core.Entities;
using OasisTrack.Core.Interfaces;

namespace OasisTrack.Infrastructure.Data.Repositories;

public class RouteRepository : IRouteRepository
{
    public Task<Route> AddAsync(Route route)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Route>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Route> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Route route)
    {
        throw new NotImplementedException();
    }
}