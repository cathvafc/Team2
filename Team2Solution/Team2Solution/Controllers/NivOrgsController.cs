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
    public class NivOrgsController : ControllerBase
    {
        private readonly APIContext _context;

        public NivOrgsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/NivOrgs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivOrg>>> GetNivOrg()
        {
            return await _context.NivOrg.ToListAsync();
        }

        // GET: api/NivOrgs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NivOrg>> GetNivOrg(int id)
        {
            var nivOrg = await _context.NivOrg.FindAsync(id);

            if (nivOrg == null)
            {
                return NotFound();
            }

            return nivOrg;
        }

        // PUT: api/NivOrgs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNivOrg(int id, NivOrg nivOrg)
        {
            if (id != nivOrg.Id)
            {
                return BadRequest();
            }

            _context.Entry(nivOrg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NivOrgExists(id))
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

        // POST: api/NivOrgs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NivOrg>> PostNivOrg(NivOrg nivOrg)
        {
            _context.NivOrg.Add(nivOrg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNivOrg", new { id = nivOrg.Id }, nivOrg);
        }

        // DELETE: api/NivOrgs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NivOrg>> DeleteNivOrg(int id)
        {
            var nivOrg = await _context.NivOrg.FindAsync(id);
            if (nivOrg == null)
            {
                return NotFound();
            }

            _context.NivOrg.Remove(nivOrg);
            await _context.SaveChangesAsync();

            return nivOrg;
        }

        private bool NivOrgExists(int id)
        {
            return _context.NivOrg.Any(e => e.Id == id);
        }
    }
}
