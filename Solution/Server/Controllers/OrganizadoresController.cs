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
    public class OrganizadoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrganizadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizador>>> GetOrganizadors()
        {
            return await _context.Organizadores.ToListAsync();
        }

        // GET: api/Organizadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organizador>> GetOrganizador(int id)
        {
            var organizador = await _context.Organizadores.FindAsync(id);

            if (organizador == null)
            {
                return NotFound();
            }

            return organizador;
        }


        [HttpGet("GetByGrupoId/{grupoId}")]
        public async Task<ActionResult<List<Organizador>>> Get(int grupoId)
        {
            var OrganizadoresQueryable = _context.Organizadores.AsQueryable();

            OrganizadoresQueryable = OrganizadoresQueryable
              .Where(x => x.GrupoId == grupoId);

            var OrganizadorList = await OrganizadoresQueryable.ToListAsync();

            return OrganizadorList;
        }


        // PUT: api/Organizadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganizador(int id, Organizador organizador)
        {
            if (id != organizador.OrganizadorId)
            {
                return BadRequest();
            }

            _context.Entry(organizador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizadorExists(id))
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

        // POST: api/Organizadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Organizador>> PostOrganizador(Organizador organizador)
        {
            _context.Organizadores.Add(organizador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrganizador", new { id = organizador.OrganizadorId }, organizador);
        }

        // DELETE: api/Organizadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrganizador(int id)
        {
            var organizador = await _context.Organizadores.FindAsync(id);
            if (organizador == null)
            {
                return NotFound();
            }

            _context.Organizadores.Remove(organizador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrganizadorExists(int id)
        {
            return _context.Organizadores.Any(e => e.OrganizadorId == id);
        }
    }
}
