using OasisTrack.Core.Entities;
using System.ComponentModel;

namespace OasisTrack.Core.Interfaces;

public interface IStoreRepository
{
    Task AddAsync(Store store);
    // UpdateAsync(Store store)
    // GetAllAsync()
    //GetByIdAsync(int Id)
    //ExsistAsync(int Id)
}