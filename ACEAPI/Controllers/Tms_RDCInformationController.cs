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
    public class Tms_RDCInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_RDCInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_RDCInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_RDCInformation>>> GetRdcinformation()
        {
            return await _context.Rdcinformation.ToListAsync();
        }

        // GET: api/Tms_RDCInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_RDCInformation>> GetTms_RDCInformation(int id)
        {
            var tms_RDCInformation = await _context.Rdcinformation.FindAsync(id);

            if (tms_RDCInformation == null)
            {
                return NotFound();
            }

            return tms_RDCInformation;
        }

        // PUT: api/Tms_RDCInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_RDCInformation(int id, Tms_RDCInformation tms_RDCInformation)
        {
            if (id != tms_RDCInformation.Rdcid)
            {
                return BadRequest();
            }

            _context.Entry(tms_RDCInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_RDCInformationExists(id))
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

        // POST: api/Tms_RDCInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_RDCInformation>> PostTms_RDCInformation(Tms_RDCInformation tms_RDCInformation)
        {
            _context.Rdcinformation.Add(tms_RDCInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_RDCInformation", new { id = tms_RDCInformation.Rdcid }, tms_RDCInformation);
        }

        // DELETE: api/Tms_RDCInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_RDCInformation>> DeleteTms_RDCInformation(int id)
        {
            var tms_RDCInformation = await _context.Rdcinformation.FindAsync(id);
            if (tms_RDCInformation == null)
            {
                return NotFound();
            }

            _context.Rdcinformation.Remove(tms_RDCInformation);
            await _context.SaveChangesAsync();

            return tms_RDCInformation;
        }

        private bool Tms_RDCInformationExists(int id)
        {
            return _context.Rdcinformation.Any(e => e.Rdcid == id);
        }
    }
}
