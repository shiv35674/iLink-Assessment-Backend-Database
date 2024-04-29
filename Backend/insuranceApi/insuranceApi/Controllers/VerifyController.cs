using insuranceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace insuranceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerifyController : ControllerBase
    {
        private readonly InsuranceDatabaseContext _context;

        public VerifyController(InsuranceDatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("api/users/{username}/password")]
        public async Task<IActionResult> GetPassword(string username)
        {
            var user = await _context.UserCredentials.FirstOrDefaultAsync(m => m.UserUsername == username);

            if (user == null)
            {
                return NotFound(); 
            }

            return Ok(new { password = user.UserPassword });
        }
    }
}
