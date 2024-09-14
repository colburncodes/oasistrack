using OasisTrack.Core.Entities;
using OasisTrack.Core.Interfaces;

namespace OasisTrack.Application.Services;

public class StoreService : IStoreService
{
    private readonly IStoreRepository _storeRepository;

    public StoreService(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository; 
    }

    public async Task<Store> GetByIdAsync(int id)
    {
        return await _storeRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Store>> GetAllAsync()
    {
        return await _storeRepository.GetAllAsync();
    }

    public async Task AddAsync(Store store)
    {
        await _storeRepository.AddAsync(store);
    }

    public async Task UpdateAsync(Store store)
    {
       await  _storeRepository.UpdateAsync(store);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _storeRepository.ExistsAsync(id);
    }
}