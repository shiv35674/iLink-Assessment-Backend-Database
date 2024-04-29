using insuranceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace insuranceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly InsuranceDatabaseContext _context;

        public PolicyController(InsuranceDatabaseContext context)
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
            var details = await _context.PolicyDetails.Where(p => p.PolicyId == id).ToListAsync();
            if (details == null || details.Count == 0)
            {
                return NotFound();
            }
            return Ok(details);
        }
    }
}
