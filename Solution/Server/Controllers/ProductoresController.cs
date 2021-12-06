using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server;
using Project.Shared.Models;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Productores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productor>>> GetProductores()
        {
            return await _context.Productores.ToListAsync();
        }

        // GET: api/Productores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Productor>> GetProductor(int id)
        {
            var productor = await _context.Productores.FindAsync(id);

            if (productor == null)
            {
                return NotFound();
            }

            return productor;
        }

        [HttpGet("GetByOrganizadorId/{organizadorId}")]
        public async Task<ActionResult<List<Productor>>> Get(int organizadorId)
        {
            var productoresQueryable = _context.Productores.AsQueryable();

            productoresQueryable = productoresQueryable
              .Where(x => x.OrganizadorId == organizadorId);

            List<Productor> productoresList = null;
            try {

                productoresList = await productoresQueryable.ToListAsync();
            }
            catch(Exception ex)
            {

            }
            return productoresList;
        }

         
        // PUT: api/Productores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductor(int id, Productor productor)
        {
            if (id != productor.ProductorId)
            {
                return BadRequest();
            }

            _context.Entry(productor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductorExists(id))
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

        // POST: api/Productores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Productor>> PostProductor(Productor productor)
        {
            _context.Productores.Add(productor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductor", new { id = productor.ProductorId }, productor);
        }

        // DELETE: api/Productores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductor(int id)
        {
            var productor = await _context.Productores.FindAsync(id);
            if (productor == null)
            {
                return NotFound();
            }

            _context.Productores.Remove(productor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductorExists(int id)
        {
            return _context.Productores.Any(e => e.ProductorId == id);
        }
    }
}
