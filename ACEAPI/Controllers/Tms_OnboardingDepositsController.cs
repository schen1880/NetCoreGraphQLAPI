using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ACEAPI.Data;
using ACEAPI.Models;

namespace ACEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tms_OnboardingDepositsController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_OnboardingDepositsController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_OnboardingDeposits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingDeposits>>> GetOnboardingDeposits()
        {
            return await _context.OnboardingDeposits.ToListAsync();
        }

        // GET: api/Tms_OnboardingDeposits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_OnboardingDeposits>> GetTms_OnboardingDeposits(int id)
        {
            var tms_OnboardingDeposits = await _context.OnboardingDeposits.FindAsync(id);

            if (tms_OnboardingDeposits == null)
            {
                return NotFound();
            }

            return tms_OnboardingDeposits;
        }

        [HttpGet("OnboardingId/{onboardingid}")]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingDeposits>>> GetTms_OnboardingDebtsOnboardingId(int onboardingid)
        {
            var tms_OnboardingDeposits = await _context.OnboardingDeposits.Where(x => x.OnboardingId == onboardingid).ToListAsync<Tms_OnboardingDeposits>();

            if (tms_OnboardingDeposits == null)
            {
                return NotFound();
            }

            return tms_OnboardingDeposits;
        }

        // PUT: api/Tms_OnboardingDeposits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_OnboardingDeposits(int id, Tms_OnboardingDeposits tms_OnboardingDeposits)
        {
            if (id != tms_OnboardingDeposits.DepositId)
            {
                return BadRequest();
            }

            _context.Entry(tms_OnboardingDeposits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_OnboardingDepositsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tms_OnboardingDeposits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_OnboardingDeposits>> PostTms_OnboardingDeposits(Tms_OnboardingDeposits tms_OnboardingDeposits)
        {
            _context.OnboardingDeposits.Add(tms_OnboardingDeposits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_OnboardingDeposits", new { id = tms_OnboardingDeposits.DepositId }, tms_OnboardingDeposits);
        }

        // DELETE: api/Tms_OnboardingDeposits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_OnboardingDeposits>> DeleteTms_OnboardingDeposits(int id)
        {
            var tms_OnboardingDeposits = await _context.OnboardingDeposits.FindAsync(id);
            if (tms_OnboardingDeposits == null)
            {
                return NotFound();
            }

            _context.OnboardingDeposits.Remove(tms_OnboardingDeposits);
            await _context.SaveChangesAsync();

            return tms_OnboardingDeposits;
        }

        private bool Tms_OnboardingDepositsExists(int id)
        {
            return _context.OnboardingDeposits.Any(e => e.DepositId == id);
        }
    }
}
