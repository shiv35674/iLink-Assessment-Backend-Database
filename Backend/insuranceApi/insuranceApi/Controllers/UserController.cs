using insuranceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace insuranceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly InsuranceDatabaseContext _context;

        public UserController(InsuranceDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            var details = await _context.UserDetails.FirstOrDefaultAsync(p => p.UserId == id);
            if (details == null)
            {
                return NotFound();
            }
            return Ok(details);
        }
    }
}
