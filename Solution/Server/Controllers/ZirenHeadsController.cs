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
    public class ZirenHeadsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ZirenHeadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ZirenHeads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ZirenHead>>> GetZirenHead()
        {
            return await _context.ZirenHead.ToListAsync();
        }



        [HttpGet("GetParternByUrl/{Url}")]
        public async Task<ActionResult<Partner>> GetParternByUrl(string url)
        {



            Partner partner = new Partner();
            #region ZirenHead
            if (url == "ziren")
            {
                var ZirenHeadQueryable = _context.ZirenHead.AsQueryable();
                var ZirenHeadList = await ZirenHeadQueryable.ToListAsync();
                var ZirenHead = ZirenHeadList.FirstOrDefault();
                partner = objectToParent(ZirenHead, ZirenHead.GetType());
                return partner;
            }
            #endregion
            #region Grupos
            var GruposQueryable = _context.Grupos.AsQueryable();
            GruposQueryable = GruposQueryable
           .Where(x => x.Url == url);
            var GruposList = await GruposQueryable.ToListAsync();
            var Grupo = GruposList.FirstOrDefault();
            if (Grupo != null)
            {
                partner = objectToParent(Grupo, Grupo.GetType());
                return partner;
            }
            #endregion

            #region Organizador
            var OrganizadoresQueryable = _context.Organizadores.AsQueryable();

            OrganizadoresQueryable = OrganizadoresQueryable
              .Where(x => x.Url == url);

            var OrganizadorList = await OrganizadoresQueryable.ToListAsync();
            var Organizador = OrganizadorList.FirstOrDefault();
            if (Organizador != null)
            {
                partner = objectToParent(Organizador, Organizador.GetType());
                return partner;
            }
            #endregion Organizador

            #region Productor
            var ProductoresQueryable = _context.Productores.AsQueryable();

            ProductoresQueryable = ProductoresQueryable
              .Where(x => x.Url == url);

            var ProductorList = await ProductoresQueryable.ToListAsync();
            var Productor = ProductorList.FirstOrDefault();
            if (Productor != null)
            {
                partner = objectToParent(Productor, Productor.GetType());
                return partner;
            }
            #endregion Productor

            #region Vendedor
            var VendedoresQueryable = _context.Vendedores.AsQueryable();

            VendedoresQueryable = VendedoresQueryable
              .Where(x => x.Url == url);

            var VendedorList = await VendedoresQueryable.ToListAsync();
            var Vendedor = VendedorList.FirstOrDefault();
            if (Vendedor != null)
            {
                partner = objectToParent(Vendedor, Vendedor.GetType());
                return partner;
            }
            #endregion Vendedor

            return null;
        }

        private Partner objectToParent(object objectPartner, Type typeName)
        {
            Partner partner = new Partner();
            partner.Type = objectPartner.GetType().Name;
            Type t = objectPartner.GetType();
            switch (objectPartner.GetType().Name)
            {
                case "ZirenHead":
                    partner.Id = ((ZirenHead)objectPartner).ZirenHeadId;
                    partner.IdPadre = 0;

                    partner.Url = ((ZirenHead)objectPartner).Url;
                    partner.Nombre = ((ZirenHead)objectPartner).Nombre;
                    partner.Apellido = ((ZirenHead)objectPartner).Url;
                    partner.Dni = ((ZirenHead)objectPartner).Dni;
                    partner.Matricula = ((ZirenHead)objectPartner).Matricula;
                    partner.Mail = ((ZirenHead)objectPartner).Mail;
                    partner.Celular1 = ((ZirenHead)objectPartner).Celular1;
                    partner.Celular2 = ((ZirenHead)objectPartner).Celular2;
                    partner.Domicilio = ((ZirenHead)objectPartner).Domicilio;
                    partner.Localidad = ((ZirenHead)objectPartner).Localidad;
                    partner.ComisionPrima = ((ZirenHead)objectPartner).ComisionPrima;
                    partner.Logo = ((ZirenHead)objectPartner).Logo;
                    partner.BotonDeseoDarDatos = ((ZirenHead)objectPartner).BotonDeseoDarDatos;
                    partner.Acarreo = ((ZirenHead)objectPartner).Acarreo;
                    partner.GncMonto = ((ZirenHead)objectPartner).GncMonto;
                    partner.Ajuste = ((ZirenHead)objectPartner).Ajuste;
                    partner.DescuentoRecarga = ((ZirenHead)objectPartner).DescuentoRecarga;
                    partner.Whatsapp = ((ZirenHead)objectPartner).Whatsapp;
                    break;
                case "Grupo":
                    partner.Id = ((Grupo)objectPartner).GrupoId;
                    partner.IdPadre = ((Grupo)objectPartner).ZirenHeadId;

                    partner.Url = ((Grupo)objectPartner).Url;
                    partner.Nombre = ((Grupo)objectPartner).Nombre;
                    partner.Apellido = ((Grupo)objectPartner).Url;
                    partner.Dni = ((Grupo)objectPartner).Dni;
                    partner.Matricula = ((Grupo)objectPartner).Matricula;
                    partner.Mail = ((Grupo)objectPartner).Mail;
                    partner.Celular1 = ((Grupo)objectPartner).Celular1;
                    partner.Celular2 = ((Grupo)objectPartner).Celular2;
                    partner.Domicilio = ((Grupo)objectPartner).Domicilio;
                    partner.Localidad = ((Grupo)objectPartner).Localidad;
                    partner.ComisionPrima = ((Grupo)objectPartner).ComisionPrima;
                    partner.Logo = ((Grupo)objectPartner).Logo;
                    partner.BotonDeseoDarDatos = ((Grupo)objectPartner).BotonDeseoDarDatos;
                    partner.Acarreo = ((Grupo)objectPartner).Acarreo;
                    partner.GncMonto = ((Grupo)objectPartner).GncMonto;
                    partner.Ajuste = ((Grupo)objectPartner).Ajuste;
                    partner.DescuentoRecarga = ((Grupo)objectPartner).DescuentoRecarga;
                    partner.Whatsapp = ((Grupo)objectPartner).Whatsapp;
                    break;
                case "Organizador":
                    partner.Id = ((Organizador)objectPartner).OrganizadorId;
                    partner.IdPadre = ((Organizador)objectPartner).GrupoId;

                    partner.Url = ((Organizador)objectPartner).Url;
                    partner.Nombre = ((Organizador)objectPartner).Nombre;
                    partner.Apellido = ((Organizador)objectPartner).Url;
                    partner.Dni = ((Organizador)objectPartner).Dni;
                    partner.Matricula = ((Organizador)objectPartner).Matricula;
                    partner.Mail = ((Organizador)objectPartner).Mail;
                    partner.Celular1 = ((Organizador)objectPartner).Celular1;
                    partner.Celular2 = ((Organizador)objectPartner).Celular2;
                    partner.Domicilio = ((Organizador)objectPartner).Domicilio;
                    partner.Localidad = ((Organizador)objectPartner).Localidad;
                    partner.ComisionPrima = ((Organizador)objectPartner).ComisionPrima;
                    partner.Logo = ((Organizador)objectPartner).Logo;
                    partner.BotonDeseoDarDatos = ((Organizador)objectPartner).BotonDeseoDarDatos;
                    partner.Acarreo = ((Organizador)objectPartner).Acarreo;
                    partner.GncMonto = ((Organizador)objectPartner).GncMonto;
                    partner.Ajuste = ((Organizador)objectPartner).Ajuste;
                    partner.DescuentoRecarga = ((Organizador)objectPartner).DescuentoRecarga;
                    partner.Whatsapp = ((Organizador)objectPartner).Whatsapp;
                    break;
                case "Productor":
                    partner.Id = ((Productor)objectPartner).ProductorId;
                    partner.IdPadre = ((Productor)objectPartner).OrganizadorId;

                    partner.Url = ((Productor)objectPartner).Url;
                    partner.Nombre = ((Productor)objectPartner).Nombre;
                    partner.Apellido = ((Productor)objectPartner).Url;
                    partner.Dni = ((Productor)objectPartner).Dni;
                    partner.Matricula = ((Productor)objectPartner).Matricula;
                    partner.Mail = ((Productor)objectPartner).Mail;
                    partner.Celular1 = ((Productor)objectPartner).Celular1;
                    partner.Celular2 = ((Productor)objectPartner).Celular2;
                    partner.Domicilio = ((Productor)objectPartner).Domicilio;
                    partner.Localidad = ((Productor)objectPartner).Localidad;
                    partner.ComisionPrima = ((Productor)objectPartner).ComisionPrima;
                    partner.Logo = ((Productor)objectPartner).Logo;
                    partner.BotonDeseoDarDatos = ((Productor)objectPartner).BotonDeseoDarDatos;
                    partner.Acarreo = ((Productor)objectPartner).Acarreo;
                    partner.GncMonto = ((Productor)objectPartner).GncMonto;
                    partner.Ajuste = ((Productor)objectPartner).Ajuste;
                    partner.DescuentoRecarga = ((Productor)objectPartner).DescuentoRecarga;
                    partner.Whatsapp = ((Productor)objectPartner).Whatsapp;
                    break;
                case "Vendedor":
                    partner.Id = ((Vendedor)objectPartner).VendedorId;
                    partner.IdPadre = ((Vendedor)objectPartner).ProductorId;

                    partner.Url = ((Vendedor)objectPartner).Url;
                    partner.Nombre = ((Vendedor)objectPartner).Nombre;
                    partner.Apellido = ((Vendedor)objectPartner).Url;
                    partner.Dni = ((Vendedor)objectPartner).Dni;
                    partner.Matricula = ((Vendedor)objectPartner).Matricula;
                    partner.Mail = ((Vendedor)objectPartner).Mail;
                    partner.Celular1 = ((Vendedor)objectPartner).Celular1;
                    partner.Celular2 = ((Vendedor)objectPartner).Celular2;
                    partner.Domicilio = ((Vendedor)objectPartner).Domicilio;
                    partner.Localidad = ((Vendedor)objectPartner).Localidad;
                    partner.ComisionPrima = ((Vendedor)objectPartner).ComisionPrima;
                    partner.Logo = ((Vendedor)objectPartner).Logo;
                    partner.BotonDeseoDarDatos = ((Vendedor)objectPartner).BotonDeseoDarDatos;
                    partner.Acarreo = ((Vendedor)objectPartner).Acarreo;
                    partner.GncMonto = ((Vendedor)objectPartner).GncMonto;
                    partner.Ajuste = ((Vendedor)objectPartner).Ajuste;
                    partner.DescuentoRecarga = ((Vendedor)objectPartner).DescuentoRecarga;
                    partner.Whatsapp = ((Vendedor)objectPartner).Whatsapp;
                    break;

                default:

                    break;

            }
            //if (t.Equals(typeof(ZirenHead)))
            //{
            //    partner.Id = ((ZirenHead)objectPartner).ZirenHeadId;
            //    partner.IdPadre = 0;
            //    partner.Nombre = ((ZirenHead)objectPartner).Nombre;

            //    partner.Url = ((ZirenHead)objectPartner).Url;
            //    partner.Nombre = ((ZirenHead)objectPartner).Nombre;
            //    partner.Apellido = ((ZirenHead)objectPartner).Url;
            //    partner.Dni = ((ZirenHead)objectPartner).Dni;
            //    partner.Matricula = ((ZirenHead)objectPartner).Matricula;
            //    partner.Mail = ((ZirenHead)objectPartner).Mail;
            //    partner.Celular1 = ((ZirenHead)objectPartner).Celular1;
            //    partner.Celular2 = ((ZirenHead)objectPartner).Celular2;
            //    partner.Domicilio = ((ZirenHead)objectPartner).Domicilio;
            //    partner.Localidad = ((ZirenHead)objectPartner).Localidad;
            //    partner.ComisionPrima = ((ZirenHead)objectPartner).ComisionPrima;
            //    partner.Logo = ((ZirenHead)objectPartner).Logo;
            //    partner.BotonDeseoDarDatos = ((ZirenHead)objectPartner).BotonDeseoDarDatos;
            //    partner.Acarreo = ((ZirenHead)objectPartner).Acarreo;
            //    partner.GncMonto = ((ZirenHead)objectPartner).GncMonto;
            //    partner.Ajuste = ((ZirenHead)objectPartner).Ajuste;
            //    partner.DescuentoRecarga = ((ZirenHead)objectPartner).DescuentoRecarga;
            //    partner.Whatsapp = ((ZirenHead)objectPartner).Whatsapp;


            //}

            return partner;
        }



        [HttpPost("YaExisteUrl/{typeName}")]
        public async Task<ActionResult<bool>> YaExisteUrl(Object objectPartner, string typeName)
        {
            int id = -1;
            string url = "";
            string urlOriginal = "";

            ZirenHead zirenHeadOriginal = new ZirenHead();
            Grupo grupoOriginal = new Grupo();
            Organizador organizadorOriginal = new Organizador();
            Productor productorOriginal = new Productor();
            Vendedor vendedorOriginal = new Vendedor();
            // switch (objectPartner.GetType().Name)

            var objLst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(objectPartner.ToString());

            switch (typeName)
            {
                case "ZirenHead":
                    id = ((ZirenHead)objectPartner).ZirenHeadId;
                    url = ((ZirenHead)objectPartner).Url;
                    zirenHeadOriginal = await _context.ZirenHead.FindAsync(id);
                    urlOriginal = zirenHeadOriginal.Url;
                    break;
                case "Grupo":
                    id = ((Grupo)objectPartner).GrupoId;
                    url = ((Grupo)objectPartner).Url;
                    grupoOriginal = await _context.Grupos.FindAsync(id);
                    urlOriginal = grupoOriginal.Url;
                    break;
                case "Organizador":
                    id = ((Organizador)objectPartner).OrganizadorId;
                    url = ((Organizador)objectPartner).Url;
                    organizadorOriginal = await _context.Organizadores.FindAsync(id);
                    urlOriginal = organizadorOriginal.Url;
                    break;
                case "Productor":
                    id = ((Productor)objectPartner).ProductorId;
                    url = ((Productor)objectPartner).Url;
                    productorOriginal = await _context.Productores.FindAsync(id);
                    urlOriginal = productorOriginal.Url;
                    break;
                case "Vendedor":
                    id = ((Vendedor)objectPartner).VendedorId;
                    url = ((Vendedor)objectPartner).Url;
                    vendedorOriginal = await _context.Vendedores.FindAsync(id);
                    urlOriginal = vendedorOriginal.Url;
                    break;

                default:

                    break;

            }
            if (id != 0)
            {
                if (url == urlOriginal)
                {
                    return false;    //SI ESTA EDITANDO Y NO CAMBIO la URL
                }
            }


            #region Genero Lista Completa

            var ZirenHeadQueryable = _context.ZirenHead.AsQueryable();
            var ZirenHeadList = await ZirenHeadQueryable.ToListAsync();

            var GruposQueryable = _context.Grupos.AsQueryable();
            var GruposList = await GruposQueryable.ToListAsync();

            var OrganizadoresQueryable = _context.Organizadores.AsQueryable();
            var OrganizadoresList = await OrganizadoresQueryable.ToListAsync();

            var ProductoresQueryable = _context.Productores.AsQueryable();
            var ProductoresList = await ProductoresQueryable.ToListAsync();

            var VendedoresQueryable = _context.Vendedores.AsQueryable();
            var VendedoresList = await VendedoresQueryable.ToListAsync();


            var ZirenHeadUrlList = from p in ZirenHeadList
                                   select p.Url;

            var GruposUrlList = from p in GruposList
                                select p.Url;

            var OrganizadoresUrlList = from p in OrganizadoresList
                                       select p.Url;

            var ProductoresUrlList = from p in ProductoresList
                                     select p.Url;

            var VendedoresUrlList = from p in VendedoresList
                                    select p.Url;

            List<string> PartnerList = ZirenHeadUrlList.Concat(GruposUrlList).Concat(OrganizadoresUrlList).Concat(ProductoresUrlList).Concat(VendedoresUrlList).ToList();

            #endregion


            List<string> urlIguales = (from p in PartnerList
                                       where p == url
                                       select p).ToList();
            if (id == 0)
            {
                if (urlIguales.Count() == 0)
                    return false;
                else
                    return true;
            }
            else
            {
                if (url != urlOriginal)
                {
                    if (urlIguales.Count() > 0)
                        return true;
                    else
                        return false;
                }

            }


            return false;
        }


        [HttpGet("GetallUrls")]
        public async Task<List<string>> GetallUrls()
        {


            List<string> Fruits = new List<string>() { "Apple", "Banana", "Orange", "Mango" };
            List<string> Vegetables = new List<string>() { "Potato", "Tomato", "Cauli Flower", "Onion" };
            List<string> FruitsAndVegetables = Fruits.Concat(Vegetables).ToList();



            var ZirenHeadQueryable = _context.ZirenHead.AsQueryable();
            var ZirenHeadList = await ZirenHeadQueryable.ToListAsync();

            var GruposQueryable = _context.Grupos.AsQueryable();
            var GruposList = await GruposQueryable.ToListAsync();


            List<string> queryAllCustomers = (List<string>)from cust in _context.ZirenHead
                                                           select cust.Url;



            return null;
        }


        // GET: api/ZirenHeads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZirenHead>> GetZirenHead(int id)
        {
            var zirenHead = await _context.ZirenHead.FindAsync(id);

            if (zirenHead == null)
            {
                return NotFound();
            }

            return zirenHead;
        }

        // PUT: api/ZirenHeads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZirenHead(int id, ZirenHead zirenHead)
        {
            if (id != zirenHead.ZirenHeadId)
            {
                return BadRequest();
            }

            _context.Entry(zirenHead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZirenHeadExists(id))
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

        // POST: api/ZirenHeads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ZirenHead>> PostZirenHead(ZirenHead zirenHead)
        {
            _context.ZirenHead.Add(zirenHead);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZirenHead", new { id = zirenHead.ZirenHeadId }, zirenHead);
        }

        // DELETE: api/ZirenHeads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZirenHead(int id)
        {
            var zirenHead = await _context.ZirenHead.FindAsync(id);
            if (zirenHead == null)
            {
                return NotFound();
            }

            _context.ZirenHead.Remove(zirenHead);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ZirenHeadExists(int id)
        {
            return _context.ZirenHead.Any(e => e.ZirenHeadId == id);
        }
    }
}
