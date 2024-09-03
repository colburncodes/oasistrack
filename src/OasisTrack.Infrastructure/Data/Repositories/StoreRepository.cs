using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OasisTrack.Core.Entities;
using OasisTrack.Core.Interfaces;
using OasisTrack.Core.Interfaces.Logger;

namespace OasisTrack.Infrastructure.Data.Repositories;

public class StoreRepository : IStoreRepository
{
    private readonly AppDbContext _appDbContext;
    private readonly ILogger<ILoggerService> _logger;
    public StoreRepository(AppDbContext appDbContext, ILogger<ILoggerService> logger)
    {
        _appDbContext = appDbContext;
        _logger = logger;
    }

    public async Task<Store> AddAsync(Store store)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(store);
            await _appDbContext.Stores.AddAsync(store);
            await _appDbContext.SaveChangesAsync();
            return store;
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "An error occurred while adding a new store.");
            throw;
        }
    }

    public Task UpdateAsync(Store store)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Store>> GetAllAsync()
    {
        return await _appDbContext.Stores.ToListAsync();
    }

    public async Task<Store> GetByIdAsync(int id)
    {
        // TODO: consider including Inventory and Route future iterations.
        var store = await _appDbContext.Stores.FirstAsync(f => f.Id == id);

        if (store == null)
        {
            throw new DataException("Store Not Found.");
        }

        return store;
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Store>> GetByRouteIdAsync(int routeId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountAsync()
    {
        throw new NotImplementedException();
    }
}