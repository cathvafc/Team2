using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team2.Models;
using Team2.DTO;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;

namespace Team2.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly APIContext _context;

        //DTOs

        private static readonly Expression<Func<Trabajadores, TrabajadoresDto>> AsTablaTrabajadoresDto =
            
            t => new TrabajadoresDto

            {
                CAMINO = t.NivelOrganizativo.Camino,
                ID_TRABAJADOR = t.ID_TRABAJADOR.ToString(),
                EMPRESA = t.empresa.D_EMPRESA,
                NOMBRE = t.NOMBRE + " " + t.APELLIDO1 + " " + t.APELLIDO2,
                TP = t.t_Provincia.ID_CLASE_PER.ToString(),
                TIPO_EMPRESA = t.t_Provincia.DESCRIP,
                GRUPO = t.GRUPO.ToString(),
                CUERPO = t.Cuerpo.DESCRIP,
                CATEGORIA = t.categorias.DESCRIP

            };

        private static readonly Expression<Func<NivOrg, DepartamentoDto>> AsTablaDepartamentoDto =

            d => new DepartamentoDto

            {          
                CAMINO = d.Camino,
                NOMBRE = d.DNivel
            };

        public TrabajadoresController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Trabajadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trabajadores>>> GetTrabajadores()
        {
            return await _context.Trabajadores.ToListAsync();
        }

        // GET: api/Trabajadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trabajadores>> GetTrabajadores(char id)
        {
            var trabajadores = await _context.Trabajadores.FindAsync(id);

            if (trabajadores == null)
            {
                return NotFound();
            }

            return trabajadores;
        }

        // PUT: api/Trabajadores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrabajadores(char id, Trabajadores trabajadores)
        {
            if (id != trabajadores.ID_EMPRESSA)
            {
                return BadRequest();
            }

            _context.Entry(trabajadores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrabajadoresExists(id))
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

        // POST: api/Trabajadores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Trabajadores>> PostTrabajadores(Trabajadores trabajadores)
        {
            _context.Trabajadores.Add(trabajadores);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrabajadoresExists(trabajadores.ID_EMPRESSA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrabajadores", new { id = trabajadores.ID_EMPRESSA }, trabajadores);
        }

        // DELETE: api/Trabajadores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trabajadores>> DeleteTrabajadores(char id)
        {
            var trabajadores = await _context.Trabajadores.FindAsync(id);
            if (trabajadores == null)
            {
                return NotFound();
            }

            _context.Trabajadores.Remove(trabajadores);
            await _context.SaveChangesAsync();

            return trabajadores;
        }

        private bool TrabajadoresExists(char id)
        {
            return _context.Trabajadores.Any(e => e.ID_EMPRESSA == id);
        }
    }
}
