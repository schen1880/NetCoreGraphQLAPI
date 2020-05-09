using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ACEAPI.Data;
using ACEAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ACEAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Tms_OnboardingClientInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_OnboardingClientInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_OnboardingClientInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingClientInformation>>> GetOnboardingClientInformation()
        {
            return await _context.OnboardingClientInformation.ToListAsync();
        }

        // GET: api/Tms_OnboardingClientInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_OnboardingClientInformation>> GetTms_OnboardingClientInformation(int id)
        {
            var tms_OnboardingClientInformation = await _context.OnboardingClientInformation.FindAsync(id);

            if (tms_OnboardingClientInformation == null)
            {
                return NotFound();
            }

            return tms_OnboardingClientInformation;
        }

        // PUT: api/Tms_OnboardingClientInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_OnboardingClientInformation(int id, Tms_OnboardingClientInformation tms_OnboardingClientInformation)
        {
            if (id != tms_OnboardingClientInformation.OnboardingId)
            {
                return BadRequest();
            }

            _context.Entry(tms_OnboardingClientInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_OnboardingClientInformationExists(id))
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

        // POST: api/Tms_OnboardingClientInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_OnboardingClientInformation>> PostTms_OnboardingClientInformation(Tms_OnboardingClientInformation tms_OnboardingClientInformation)
        {
            _context.OnboardingClientInformation.Add(tms_OnboardingClientInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_OnboardingClientInformation", new { id = tms_OnboardingClientInformation.OnboardingId }, tms_OnboardingClientInformation);
        }

        // DELETE: api/Tms_OnboardingClientInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_OnboardingClientInformation>> DeleteTms_OnboardingClientInformation(int id)
        {
            var tms_OnboardingClientInformation = await _context.OnboardingClientInformation.FindAsync(id);
            if (tms_OnboardingClientInformation == null)
            {
                return NotFound();
            }

            _context.OnboardingClientInformation.Remove(tms_OnboardingClientInformation);
            await _context.SaveChangesAsync();

            return tms_OnboardingClientInformation;
        }

        private bool Tms_OnboardingClientInformationExists(int id)
        {
            return _context.OnboardingClientInformation.Any(e => e.OnboardingId == id);
        }
    }
}
