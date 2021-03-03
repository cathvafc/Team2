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
    public class T_ProvinciasController : ControllerBase
    {
        private readonly APIContext _context;

        public T_ProvinciasController(APIContext context)
        {
            _context = context;
        }

        // GET: api/T_Provincias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_Provincias>>> GetPiezas()
        {
            return await _context.Piezas.ToListAsync();
        }

        // GET: api/T_Provincias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_Provincias>> GetT_Provincias(char id)
        {
            var t_Provincias = await _context.Piezas.FindAsync(id);

            if (t_Provincias == null)
            {
                return NotFound();
            }

            return t_Provincias;
        }

        // PUT: api/T_Provincias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_Provincias(char id, T_Provincias t_Provincias)
        {
            if (id != t_Provincias.T_PROVIS)
            {
                return BadRequest();
            }

            _context.Entry(t_Provincias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_ProvinciasExists(id))
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

        // POST: api/T_Provincias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<T_Provincias>> PostT_Provincias(T_Provincias t_Provincias)
        {
            _context.Piezas.Add(t_Provincias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_Provincias", new { id = t_Provincias.T_PROVIS }, t_Provincias);
        }

        // DELETE: api/T_Provincias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<T_Provincias>> DeleteT_Provincias(char id)
        {
            var t_Provincias = await _context.Piezas.FindAsync(id);
            if (t_Provincias == null)
            {
                return NotFound();
            }

            _context.Piezas.Remove(t_Provincias);
            await _context.SaveChangesAsync();

            return t_Provincias;
        }

        private bool T_ProvinciasExists(char id)
        {
            return _context.Piezas.Any(e => e.T_PROVIS == id);
        }
    }
}
