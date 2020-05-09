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
    public class Tms_OnboardingRDCInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_OnboardingRDCInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_OnboardingRDCInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingRDCInformation>>> GetOnboardingRdcinformation()
        {
            return await _context.OnboardingRdcinformation.ToListAsync();
        }

        // GET: api/Tms_OnboardingRDCInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_OnboardingRDCInformation>> GetTms_OnboardingRDCInformation(int id)
        {
            var tms_OnboardingRDCInformation = await _context.OnboardingRdcinformation.FindAsync(id);

            if (tms_OnboardingRDCInformation == null)
            {
                return NotFound();
            }

            return tms_OnboardingRDCInformation;
        }

        // GET: api/Tms_OnboardingRDCInformation/5
        //[Route("OnboardingId")]
        [HttpGet("OnboardingId/{onboardingid}")]
        public async Task<ActionResult<IEnumerable<Tms_OnboardingRDCInformation>>> GetTms_OnboardingRDCInformationByOnboardingID(int onboardingid)
        {
            var tms_OnboardingRDCInformation = await _context.OnboardingRdcinformation.Where(x => x.OnboardingId == onboardingid).ToListAsync<Tms_OnboardingRDCInformation>();

            if (tms_OnboardingRDCInformation == null)
            {
                return NotFound();
            }

            return tms_OnboardingRDCInformation;
        }

        // PUT: api/Tms_OnboardingRDCInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_OnboardingRDCInformation(int id, Tms_OnboardingRDCInformation tms_OnboardingRDCInformation)
        {
            if (id != tms_OnboardingRDCInformation.OnboardingRdcid)
            {
                return BadRequest();
            }

            _context.Entry(tms_OnboardingRDCInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_OnboardingRDCInformationExists(id))
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

        // POST: api/Tms_OnboardingRDCInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_OnboardingRDCInformation>> PostTms_OnboardingRDCInformation(Tms_OnboardingRDCInformation tms_OnboardingRDCInformation)
        {
            _context.OnboardingRdcinformation.Add(tms_OnboardingRDCInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_OnboardingRDCInformation", new { id = tms_OnboardingRDCInformation.OnboardingRdcid }, tms_OnboardingRDCInformation);
        }

        // DELETE: api/Tms_OnboardingRDCInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_OnboardingRDCInformation>> DeleteTms_OnboardingRDCInformation(int id)
        {
            var tms_OnboardingRDCInformation = await _context.OnboardingRdcinformation.FindAsync(id);
            if (tms_OnboardingRDCInformation == null)
            {
                return NotFound();
            }

            _context.OnboardingRdcinformation.Remove(tms_OnboardingRDCInformation);
            await _context.SaveChangesAsync();

            return tms_OnboardingRDCInformation;
        }

        private bool Tms_OnboardingRDCInformationExists(int id)
        {
            return _context.OnboardingRdcinformation.Any(e => e.OnboardingRdcid == id);
        }
    }
}
