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

    public async Task AddAsync(Store store)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(store);
            await _appDbContext.Stores.AddAsync(store);
            await _appDbContext.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "An error occurred while adding a new store.");
            throw;
        }
    }

    public async Task UpdateAsync(Store store)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(store);
            _appDbContext.Stores.Update(store);
            await _appDbContext.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            _logger.LogError(ex, "An error occurred while adding a new store.");
            throw;
        }
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

    public async Task<bool> ExistsAsync(int id)
    {
        return await _appDbContext.Stores.AnyAsync(f => f.Id == id);
    }

    public async Task<IEnumerable<Store>> GetByRouteIdAsync(int routeId)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(routeId);
            return await _appDbContext.Stores
                .Where(s => s.RouteId == routeId)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"An error occurred while retrieving stores for route ID {routeId}.");
            throw;
        }
    }

    public async Task<int> GetCountAsync()
    {
        return await _appDbContext.Stores.CountAsync();
    }
}