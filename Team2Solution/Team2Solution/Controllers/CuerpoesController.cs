using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team2.Models;

namespace Team2Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuerpoesController : ControllerBase
    {
        private readonly APIContext _context;

        public CuerpoesController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Cuerpoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuerpo>>> GetSuministros()
        {
            return await _context.Suministros.ToListAsync();
        }

        // GET: api/Cuerpoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuerpo>> GetCuerpo(char id)
        {
            var cuerpo = await _context.Suministros.FindAsync(id);

            if (cuerpo == null)
            {
                return NotFound();
            }

            return cuerpo;
        }

        // PUT: api/Cuerpoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuerpo(char id, Cuerpo cuerpo)
        {
            if (id != cuerpo.CUERPO)
            {
                return BadRequest();
            }

            _context.Entry(cuerpo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuerpoExists(id))
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

        // POST: api/Cuerpoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cuerpo>> PostCuerpo(Cuerpo cuerpo)
        {
            _context.Suministros.Add(cuerpo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuerpo", new { id = cuerpo.CUERPO }, cuerpo);
        }

        // DELETE: api/Cuerpoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cuerpo>> DeleteCuerpo(char id)
        {
            var cuerpo = await _context.Suministros.FindAsync(id);
            if (cuerpo == null)
            {
                return NotFound();
            }

            _context.Suministros.Remove(cuerpo);
            await _context.SaveChangesAsync();

            return cuerpo;
        }

        private bool CuerpoExists(char id)
        {
            return _context.Suministros.Any(e => e.CUERPO == id);
        }
    }
}
