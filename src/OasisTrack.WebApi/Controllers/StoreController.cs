using Microsoft.AspNetCore.Mvc;
using OasisTrack.Core.Interfaces;
using OasisTrack.WebApi.DTOs.Store;

namespace OasisTrack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
  
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreDto>>> GetAllStores()
        {
            var stores = await _storeService.GetAllAsync();
            return Ok(stores.Select(s => new StoreDto(s)));
        }
    }
}