using Microsoft.AspNetCore.Mvc;
using OasisTrack.Core.Entities;
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

        [HttpPost("create")]
        public async Task<ActionResult> CreateStore([FromBody] StoreDto storeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var store = new Store()
                {
                    Name = storeDto.Name,
                    Address = storeDto.Address,
                    City = storeDto.City,
                    State = storeDto.State,
                    ZipCode = storeDto.ZipCode,
                    PhoneNumber = storeDto.PhoneNumber,
                    IsActive = storeDto.isActive,
                    ManagerName = storeDto.ManagerName
                };
                
                await _storeService.AddAsync(store);
                return StatusCode(201, new { Id = store.Id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating the store");
            }
        }
    }
}