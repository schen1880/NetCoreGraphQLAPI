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
    public class Tms_DebtsController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_DebtsController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_Debts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_Debts>>> GetDebts2()
        {
            return await _context.Debts2.ToListAsync();
        }

        // GET: api/Tms_Debts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_Debts>> GetTms_Debts(int id)
        {
            var tms_Debts = await _context.Debts2.FindAsync(id);

            if (tms_Debts == null)
            {
                return NotFound();
            }

            return tms_Debts;
        }

        // PUT: api/Tms_Debts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_Debts(int id, Tms_Debts tms_Debts)
        {
            if (id != tms_Debts.DebtId)
            {
                return BadRequest();
            }

            _context.Entry(tms_Debts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_DebtsExists(id))
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

        // POST: api/Tms_Debts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_Debts>> PostTms_Debts(Tms_Debts tms_Debts)
        {
            _context.Debts2.Add(tms_Debts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_Debts", new { id = tms_Debts.DebtId }, tms_Debts);
        }

        // DELETE: api/Tms_Debts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_Debts>> DeleteTms_Debts(int id)
        {
            var tms_Debts = await _context.Debts2.FindAsync(id);
            if (tms_Debts == null)
            {
                return NotFound();
            }

            _context.Debts2.Remove(tms_Debts);
            await _context.SaveChangesAsync();

            return tms_Debts;
        }

        private bool Tms_DebtsExists(int id)
        {
            return _context.Debts2.Any(e => e.DebtId == id);
        }
    }
}
