using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Helpers
{
    public class ControllersConnect : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ControllersConnect(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> YaExisteUrl(object objectPartner)
        {
            int id=-1;
            string url="";
            string urlOriginal = "";

            ZirenHead zirenHeadOriginal = new ZirenHead();
            Grupo grupoOriginal = new Grupo();
            Organizador organizadorOriginal = new Organizador();
            Productor productorOriginal = new Productor();
            Vendedor vendedorOriginal = new Vendedor();

            switch (objectPartner.GetType().Name)
            {
                case "ZirenHead":
                    id = ((ZirenHead)objectPartner).ZirenHeadId;
                    url = ((ZirenHead)objectPartner).Url;
                    if (id != 0)
                    {
                        zirenHeadOriginal = await _context.ZirenHead.FindAsync(id);
                        urlOriginal = zirenHeadOriginal.Url;
                    }
                    break;
                case "Grupo":
                    id = ((Grupo)objectPartner).GrupoId;
                    url = ((Grupo)objectPartner).Url;
                    if (id != 0)
                    {
                        grupoOriginal = await _context.Grupos.FindAsync(id);
                        urlOriginal = grupoOriginal.Url;
                    }
                    break;
                case "Organizador":
                    id = ((Organizador)objectPartner).OrganizadorId;
                    url = ((Organizador)objectPartner).Url;
                    if (id != 0)
                    {
                        organizadorOriginal = await _context.Organizadores.FindAsync(id);
                        urlOriginal = organizadorOriginal.Url;
                    }
                    break;
                case "Productor":
                    id = ((Productor)objectPartner).ProductorId;
                    url = ((Productor)objectPartner).Url;
                    if (id != 0)
                    {
                        productorOriginal = await _context.Productores.FindAsync(id);
                        urlOriginal = productorOriginal.Url;
                    }
                    break;
                case "Vendedor":
                    id = ((Vendedor)objectPartner).VendedorId;
                    url = ((Vendedor)objectPartner).Url;
                    if (id != 0)
                    {
                        vendedorOriginal = await _context.Vendedores.FindAsync(id);
                        urlOriginal = vendedorOriginal.Url;
                    }
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
                if(url!=urlOriginal)
                {
                    if (urlIguales.Count() > 0)
                        return true;
                    else
                        return false;
                }
                
            }


            return false;
        }
        public async Task<List<string>> GetallUrls()
        {

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


            return PartnerList;
        }

    }
}
