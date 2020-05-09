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
    public class Tms_NotesCommentsController : ControllerBase
    {
        private readonly aceContext _context;

        public Tms_NotesCommentsController(aceContext context)
        {
            _context = context;
        }

        // GET: api/Tms_NotesComments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tms_NotesComments>>> GetNotesComments2()
        {
            return await _context.NotesComments2.ToListAsync();
        }

        // GET: api/Tms_NotesComments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tms_NotesComments>> GetTms_NotesComments(int id)
        {
            var tms_NotesComments = await _context.NotesComments2.FindAsync(id);

            if (tms_NotesComments == null)
            {
                return NotFound();
            }

            return tms_NotesComments;
        }

        // PUT: api/Tms_NotesComments/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTms_NotesComments(int id, Tms_NotesComments tms_NotesComments)
        {
            if (id != tms_NotesComments.CommentId)
            {
                return BadRequest();
            }

            _context.Entry(tms_NotesComments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tms_NotesCommentsExists(id))
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

        // POST: api/Tms_NotesComments
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Tms_NotesComments>> PostTms_NotesComments(Tms_NotesComments tms_NotesComments)
        {
            _context.NotesComments2.Add(tms_NotesComments);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Tms_NotesCommentsExists(tms_NotesComments.CommentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTms_NotesComments", new { id = tms_NotesComments.CommentId }, tms_NotesComments);
        }

        // DELETE: api/Tms_NotesComments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tms_NotesComments>> DeleteTms_NotesComments(int id)
        {
            var tms_NotesComments = await _context.NotesComments2.FindAsync(id);
            if (tms_NotesComments == null)
            {
                return NotFound();
            }

            _context.NotesComments2.Remove(tms_NotesComments);
            await _context.SaveChangesAsync();

            return tms_NotesComments;
        }

        private bool Tms_NotesCommentsExists(int id)
        {
            return _context.NotesComments2.Any(e => e.CommentId == id);
        }
    }
}
