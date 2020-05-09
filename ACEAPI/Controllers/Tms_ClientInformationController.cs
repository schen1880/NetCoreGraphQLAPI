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
    public class Tms_ClientInformationController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_ClientInformationController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_ClientInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_ClientInformation>>> GetClientInformation()
        {
            return await _context.ClientInformation.ToListAsync();
        }

        // GET: api/Tms_ClientInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_ClientInformation>> GetTms_ClientInformation(int id)
        {
            var tms_ClientInformation = await _context.ClientInformation.FindAsync(id);

            if (tms_ClientInformation == null)
            {
                return NotFound();
            }

            return tms_ClientInformation;
        }

        // PUT: api/Tms_ClientInformation/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_ClientInformation(int id, Tms_ClientInformation tms_ClientInformation)
        {
            if (id != tms_ClientInformation.ClientNumber)
            {
                return BadRequest();
            }

            _context.Entry(tms_ClientInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_ClientInformationExists(id))
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

        // POST: api/Tms_ClientInformation
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_ClientInformation>> PostTms_ClientInformation(Tms_ClientInformation tms_ClientInformation)
        {
            _context.ClientInformation.Add(tms_ClientInformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Tms_ClientInformationExists(tms_ClientInformation.ClientNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTms_ClientInformation", new { id = tms_ClientInformation.ClientNumber }, tms_ClientInformation);
        }

        // DELETE: api/Tms_ClientInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_ClientInformation>> DeleteTms_ClientInformation(int id)
        {
            var tms_ClientInformation = await _context.ClientInformation.FindAsync(id);
            if (tms_ClientInformation == null)
            {
                return NotFound();
            }

            _context.ClientInformation.Remove(tms_ClientInformation);
            await _context.SaveChangesAsync();

            return tms_ClientInformation;
        }

        private bool Tms_ClientInformationExists(int id)
        {
            return _context.ClientInformation.Any(e => e.ClientNumber == id);
        }
    }
}
