using OasisTrack.Core.Entities;

namespace OasisTrack.Core.Interfaces;

public interface IStoreService
{
    Task<Store> GetByIdAsync(int id);
    Task<IEnumerable<Store>> GetAllAsync();
    Task AddAsync(Store store);
    Task UpdateAsync(Store store);
    Task<bool> ExistsAsync(int id);
}