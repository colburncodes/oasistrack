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

        [HttpGet("{id}")]
        public async Task<ActionResult<StoreDto>> GetStore(int id)
        {
            var store = await _storeService.GetByIdAsync(id);
            if (store == null)
            {
                return NotFound();
            }

            return Ok(new StoreDto(store));
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStore(int id, StoreDto.UpdateStoreDto updateStoreDto)
        {
            if (id != updateStoreDto.Id)
            {
                return BadRequest();
            }

            var existingStore = await _storeService.GetByIdAsync(id);
            if (existingStore == null)
            {
                return NotFound();
            }

            existingStore.Name = updateStoreDto.Name;
            existingStore.Address = updateStoreDto.Address;
            existingStore.City = updateStoreDto.City;
            existingStore.State = updateStoreDto.State;
            existingStore.ZipCode = updateStoreDto.ZipCode;
            existingStore.PhoneNumber = updateStoreDto.PhoneNumber;
            existingStore.ManagerName = updateStoreDto.ManagerName;

            await _storeService.UpdateAsync(existingStore);
            return NoContent();
        }

        [HttpPatch("{id}/activate")]
        public async Task<IActionResult> ActivateStore(int id)
        {
            var store = await _storeService.GetByIdAsync(id);
            if (store == null)
            {
                return NotFound();
            }

            store.IsActive = true;
            await _storeService.UpdateAsync(store);
            return NoContent();
        }
        
        [HttpPatch("{id}/deactivate")]
        public async Task<IActionResult> DeactivateStore(int id)
        {
            var store = await _storeService.GetByIdAsync(id);
            if (store == null)
            {
                return NotFound();
            }

            store.IsActive = false;
            await _storeService.UpdateAsync(store);
            return NoContent();
        }
    }
}