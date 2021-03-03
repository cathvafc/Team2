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
    public class Clase_PersonaController : ControllerBase
    {
        private readonly APIContext _context;

        public Clase_PersonaController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Clase_Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase_Persona>>> GetProveedores()
        {
            return await _context.Proveedores.ToListAsync();
        }

        // GET: api/Clase_Persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clase_Persona>> GetClase_Persona(char id)
        {
            var clase_Persona = await _context.Proveedores.FindAsync(id);

            if (clase_Persona == null)
            {
                return NotFound();
            }

            return clase_Persona;
        }

        // PUT: api/Clase_Persona/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClase_Persona(char id, Clase_Persona clase_Persona)
        {
            if (id != clase_Persona.ID_CLASE_PER)
            {
                return BadRequest();
            }

            _context.Entry(clase_Persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Clase_PersonaExists(id))
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

        // POST: api/Clase_Persona
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Clase_Persona>> PostClase_Persona(Clase_Persona clase_Persona)
        {
            _context.Proveedores.Add(clase_Persona);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Clase_PersonaExists(clase_Persona.ID_CLASE_PER))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClase_Persona", new { id = clase_Persona.ID_CLASE_PER }, clase_Persona);
        }

        // DELETE: api/Clase_Persona/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clase_Persona>> DeleteClase_Persona(char id)
        {
            var clase_Persona = await _context.Proveedores.FindAsync(id);
            if (clase_Persona == null)
            {
                return NotFound();
            }

            _context.Proveedores.Remove(clase_Persona);
            await _context.SaveChangesAsync();

            return clase_Persona;
        }

        private bool Clase_PersonaExists(char id)
        {
            return _context.Proveedores.Any(e => e.ID_CLASE_PER == id);
        }
    }
}
