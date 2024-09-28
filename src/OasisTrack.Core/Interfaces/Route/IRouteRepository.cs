using OasisTrack.Core.Entities;

namespace OasisTrack.Core.Interfaces;

public interface IRouteRepository
{
    Task<Route> AddAsync(Route route);
    Task<IEnumerable<Route>> GetAllAsync();
    Task<Route> GetByIdAsync(int id);
    Task UpdateAsync(Route route);
}