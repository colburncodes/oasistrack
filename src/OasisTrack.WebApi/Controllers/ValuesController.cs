using Microsoft.AspNetCore.Mvc;
using OasisTrack.Infrastructure.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OasisTrack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : Controller
    {
        private readonly AppDbContext _context;
        public ValuesController(AppDbContext context)
        {
            _context = context;
            
        }

        // GET: api/<ValuesController>
        [HttpGet("test-db")]
        public IActionResult TestDatabase()
        {
            var stores = _context.Stores.ToList();
            return Ok(stores.Select(s => new { s.Name, s.Address, s.City, s.State, s.ZipCode }));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
