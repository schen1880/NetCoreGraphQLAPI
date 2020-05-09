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
    public class Tms_ACHInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_ACHInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_ACHInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_ACHInformation>>> GetAchinformation()
        {
            return await _context.Achinformation.ToListAsync();
        }

        // GET: api/Tms_ACHInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_ACHInformation>> GetTms_ACHInformation(int id)
        {
            var tms_ACHInformation = await _context.Achinformation.FindAsync(id);

            if (tms_ACHInformation == null)
            {
                return NotFound();
            }

            return tms_ACHInformation;
        }

        // PUT: api/Tms_ACHInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_ACHInformation(int id, Tms_ACHInformation tms_ACHInformation)
        {
            if (id != tms_ACHInformation.Achid)
            {
                return BadRequest();
            }

            _context.Entry(tms_ACHInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_ACHInformationExists(id))
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

        // POST: api/Tms_ACHInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_ACHInformation>> PostTms_ACHInformation(Tms_ACHInformation tms_ACHInformation)
        {
            _context.Achinformation.Add(tms_ACHInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_ACHInformation", new { id = tms_ACHInformation.Achid }, tms_ACHInformation);
        }

        // DELETE: api/Tms_ACHInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_ACHInformation>> DeleteTms_ACHInformation(int id)
        {
            var tms_ACHInformation = await _context.Achinformation.FindAsync(id);
            if (tms_ACHInformation == null)
            {
                return NotFound();
            }

            _context.Achinformation.Remove(tms_ACHInformation);
            await _context.SaveChangesAsync();

            return tms_ACHInformation;
        }

        private bool Tms_ACHInformationExists(int id)
        {
            return _context.Achinformation.Any(e => e.Achid == id);
        }
    }
}
