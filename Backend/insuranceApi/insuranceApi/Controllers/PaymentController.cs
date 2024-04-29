using insuranceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace insuranceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly InsuranceDatabaseContext _context;

        public PaymentController(InsuranceDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<UserPaymentDetail>> Get()
        {
            return await _context.UserPaymentDetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            var details = await _context.UserPaymentDetails.Where(p => p.UserId == id).ToListAsync();
            if (details == null || details.Count==0)
            {
                return NotFound();
            }
            return Ok(details);
        }

        [HttpPost]

        public async Task<IActionResult> Post(UserPaymentDetail details)
        {
            _context.Add(details);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Put(UserPaymentDetail details)
        {
            if (details == null || details.UserId == 0)
            {
                return BadRequest();
            }
            var cardDetail = await _context.UserPaymentDetails.FindAsync(details.PaymentId);
            if (cardDetail == null)
            {
                return NotFound();
            }
            cardDetail.UserCardnumber = details.UserCardnumber;
            cardDetail.UserCardname = details.UserCardname;
            cardDetail.UserId = details.UserId;
            cardDetail.UserCvv = details.UserCvv;
            cardDetail.UserCardvalidity = details.UserCardvalidity;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            var card = await _context.UserPaymentDetails.FirstOrDefaultAsync(p=> p.PaymentId==id);
            if (card == null)
            {
                return NotFound();
            }
            _context.UserPaymentDetails.Remove(card);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
