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
    public class Tms_OnboardingACHInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_OnboardingACHInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_OnboardingACHInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingACHInformation>>> GetOnboardingAchinformation()
        {
            return await _context.OnboardingAchinformation.ToListAsync();
        }

        // GET: api/Tms_OnboardingACHInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_OnboardingACHInformation>> GetTms_OnboardingACHInformation(int id)
        {
            var tms_OnboardingACHInformation = await _context.OnboardingAchinformation.FindAsync(id);

            if (tms_OnboardingACHInformation == null)
            {
                return NotFound();
            }

            return tms_OnboardingACHInformation;
        }

        [HttpGet("OnboardingId/{onboardingid}")]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingACHInformation>>> GetTms_OnboardingRDCInformationByOnboardingID(int onboardingid)
        {
            var tms_OnboardingACHInformation = await _context.OnboardingAchinformation.Where(x => x.OnboardingId == onboardingid).ToListAsync<Tms_OnboardingACHInformation>();

            if (tms_OnboardingACHInformation == null)
            {
                return NotFound();
            }

            return tms_OnboardingACHInformation;
        }

        // PUT: api/Tms_OnboardingACHInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_OnboardingACHInformation(int id, Tms_OnboardingACHInformation tms_OnboardingACHInformation)
        {
            if (id != tms_OnboardingACHInformation.OnboardingAchid)
            {
                return BadRequest();
            }

            _context.Entry(tms_OnboardingACHInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_OnboardingACHInformationExists(id))
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

        // POST: api/Tms_OnboardingACHInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_OnboardingACHInformation>> PostTms_OnboardingACHInformation(Tms_OnboardingACHInformation tms_OnboardingACHInformation)
        {
            _context.OnboardingAchinformation.Add(tms_OnboardingACHInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_OnboardingACHInformation", new { id = tms_OnboardingACHInformation.OnboardingAchid }, tms_OnboardingACHInformation);
        }

        // DELETE: api/Tms_OnboardingACHInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_OnboardingACHInformation>> DeleteTms_OnboardingACHInformation(int id)
        {
            var tms_OnboardingACHInformation = await _context.OnboardingAchinformation.FindAsync(id);
            if (tms_OnboardingACHInformation == null)
            {
                return NotFound();
            }

            _context.OnboardingAchinformation.Remove(tms_OnboardingACHInformation);
            await _context.SaveChangesAsync();

            return tms_OnboardingACHInformation;
        }

        private bool Tms_OnboardingACHInformationExists(int id)
        {
            return _context.OnboardingAchinformation.Any(e => e.OnboardingAchid == id);
        }
    }
}
