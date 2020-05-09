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
    public class Tms_DocumentsController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_DocumentsController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_Documents>>> GetDocuments1()
        {
            return await _context.Documents1.ToListAsync();
        }

        // GET: api/Tms_Documents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_Documents>> GetTms_Documents(long id)
        {
            var tms_Documents = await _context.Documents1.FindAsync(id);

            if (tms_Documents == null)
            {
                return NotFound();
            }

            return tms_Documents;
        }

        // PUT: api/Tms_Documents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_Documents(long id, Tms_Documents tms_Documents)
        {
            if (id != tms_Documents.DocumentId)
            {
                return BadRequest();
            }

            _context.Entry(tms_Documents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_DocumentsExists(id))
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

        // POST: api/Tms_Documents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_Documents>> PostTms_Documents(Tms_Documents tms_Documents)
        {
            _context.Documents1.Add(tms_Documents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTms_Documents", new { id = tms_Documents.DocumentId }, tms_Documents);
        }

        // DELETE: api/Tms_Documents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_Documents>> DeleteTms_Documents(long id)
        {
            var tms_Documents = await _context.Documents1.FindAsync(id);
            if (tms_Documents == null)
            {
                return NotFound();
            }

            _context.Documents1.Remove(tms_Documents);
            await _context.SaveChangesAsync();

            return tms_Documents;
        }

        private bool Tms_DocumentsExists(long id)
        {
            return _context.Documents1.Any(e => e.DocumentId == id);
        }
    }
}
