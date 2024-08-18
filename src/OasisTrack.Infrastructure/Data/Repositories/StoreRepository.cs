using OasisTrack.Core.Interfaces;

namespace OasisTrack.Infrastructure.Data.Repositories;

public class StoreRepository : IStoreRepository
{
    private readonly AppDbContext _appDbContext;

    public StoreRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext; 
    }
}