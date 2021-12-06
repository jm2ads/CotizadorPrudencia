using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server;
using Project.Server.Helpers;
using Project.Shared.Models;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GruposController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Grupos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grupo>>> GetGrupos()
        {
            return await _context.Grupos.ToListAsync();
            //List<Grupo> grupoList = await _context.Grupos.Include(p => p.OrganizadoresList).ThenInclude(x => x.ProductoresList).ThenInclude(x => x.VendedoresList).ToListAsync();
            //return grupoList;
        }

        // GET: api/Grupos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grupo>> GetGrupo(int id)
        {
            var grupo = await _context.Grupos.FindAsync(id);

            if (grupo == null)
            {
                return NotFound();
            }

            return grupo;
        }


        [HttpGet("GetParternByUrl/{Url}")]
        public async Task<ActionResult<object>> Get(string url)
        {
            #region ZirenHead
            if (url == "ziren")
            {
                var ZirenHeadQueryable = _context.ZirenHead.AsQueryable();

                var ZirenHeadList = await ZirenHeadQueryable.ToListAsync();
                var ZirenHead = ZirenHeadList.FirstOrDefault();
                if (ZirenHead != null)
                    return ZirenHead;

            }
            #endregion
            #region Grupos
            var GruposQueryable = _context.Grupos.AsQueryable();

            GruposQueryable = GruposQueryable
            .Where(x => x.Url == url);

            var GruposList = await GruposQueryable.ToListAsync();
            var Grupo = GruposList.FirstOrDefault();
            if (Grupo != null)
                return Grupo;
            #endregion

            #region Organizador
            var OrganizadoresQueryable = _context.Organizadores.AsQueryable();

            OrganizadoresQueryable = OrganizadoresQueryable
              .Where(x => x.Url == url);

            var OrganizadorList = await OrganizadoresQueryable.ToListAsync();
            var Organizador = OrganizadorList.FirstOrDefault();
            if (Organizador != null)
                return Organizador;
            #endregion Organizador

            #region Productor
            var ProductoresQueryable = _context.Productores.AsQueryable();

            ProductoresQueryable = ProductoresQueryable
              .Where(x => x.Url == url);

            var ProductorList = await ProductoresQueryable.ToListAsync();
            var Productor = ProductorList.FirstOrDefault();
            if (Productor != null)
                return Productor;
            #endregion Productor

            #region Vendedor
            var VendedoresQueryable = _context.Vendedores.AsQueryable();

            VendedoresQueryable = VendedoresQueryable
              .Where(x => x.Url == url);

            var VendedorList = await VendedoresQueryable.ToListAsync();
            var Vendedor = VendedorList.FirstOrDefault();
            if (Vendedor != null)
                return Vendedor;
            #endregion Vendedor

            return null;
        }



        // PUT: api/Grupos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupo(int id, Grupo grupo)
        {
               
            if (id != grupo.GrupoId)
            {
                return BadRequest();
            }

            _context.Entry(grupo).State = EntityState.Modified;

            try
            {
                //if(!string.IsNullOrWhiteSpace(grupo.Logo))

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrupoExists(id))
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

        // POST: api/Grupos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grupo>> PostGrupo(Grupo grupo)
        {
            //ControllersConnect controllersConnect = new ControllersConnect(_context);
            //bool yaExisteUrl = await controllersConnect.YaExisteUrl(grupo);

            #region Saco ZirenHeadId
            var ZirenHeadQueryable = _context.ZirenHead.AsQueryable();

            var ZirenHeadList = await ZirenHeadQueryable.ToListAsync();
            var ZirenHead = ZirenHeadList.FirstOrDefault();
            grupo.ZirenHeadId = ZirenHead.ZirenHeadId;
            #endregion


            _context.Grupos.Add(grupo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrupo", new { id = grupo.GrupoId }, grupo);
        }

        // DELETE: api/Grupos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrupo(int id)
        {
            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null)
            {
                return NotFound();
            }

            _context.Grupos.Remove(grupo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrupoExists(int id)
        {
            return _context.Grupos.Any(e => e.GrupoId == id);
        }
    }
}
