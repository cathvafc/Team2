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
    public class CategoriasController : ControllerBase
    {
        private readonly APIContext _context;

        public CategoriasController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorias>>> GetCategors()
        {
            return await _context.Categors.ToListAsync();
        }

        // GET: api/Categorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorias>> GetCategorias(char id)
        {
            var categorias = await _context.Categors.FindAsync(id);

            if (categorias == null)
            {
                return NotFound();
            }

            return categorias;
        }

        // PUT: api/Categorias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorias(char id, Categorias categorias)
        {
            if (id != categorias.CATEGORI)
            {
                return BadRequest();
            }

            _context.Entry(categorias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriasExists(id))
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

        // POST: api/Categorias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Categorias>> PostCategorias(Categorias categorias)
        {
            _context.Categors.Add(categorias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorias", new { id = categorias.CATEGORI }, categorias);
        }

        // DELETE: api/Categorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categorias>> DeleteCategorias(char id)
        {
            var categorias = await _context.Categors.FindAsync(id);
            if (categorias == null)
            {
                return NotFound();
            }

            _context.Categors.Remove(categorias);
            await _context.SaveChangesAsync();

            return categorias;
        }

        private bool CategoriasExists(char id)
        {
            return _context.Categors.Any(e => e.CATEGORI == id);
        }
    }
}
