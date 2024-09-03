using OasisTrack.Core.Entities;
using System.ComponentModel;

namespace OasisTrack.Core.Interfaces;

public interface IStoreRepository
{
    Task<Store> AddAsync(Store store);
    Task UpdateAsync(Store store);
    Task<IEnumerable<Store>> GetAllAsync();
    Task<Store> GetByIdAsync(int id);
    Task<bool> ExistsAsync(int id);
    // Additional methods to consider
    Task<IEnumerable<Store>> GetByRouteIdAsync(int routeId);
    Task<int> GetCountAsync();
}