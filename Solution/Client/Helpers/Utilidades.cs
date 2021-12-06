using Microsoft.JSInterop;
using Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace Project.Client.Helpers
{
    public  class Utilidades
    {
        private readonly IJSRuntime js;
        public Utilidades(IJSRuntime js)
        {
            this.js = js;
        }
        public  async Task<bool> SavePartner(object objectPartner)
        {
           
            bool saved = false;
            Partner partner = new Partner();

            switch (objectPartner.GetType().Name)
            {
                case "ZirenHead":
                    ZirenHead zirenHead = ((ZirenHead)objectPartner);
                    string zirenHeadJson = JsonSerializer.Serialize(zirenHead);
                   await  js.SetInLocalStorage("zirenHead", zirenHeadJson);
                    
                    break;
                case "Grupo":
                    Grupo grupo = ((Grupo)objectPartner);
                    string grupoJson = JsonSerializer.Serialize(grupo);
                    await js.SetInLocalStorage("grupo", grupoJson);
                    break;
                case "Organizador":
                    Organizador oganizador = ((Organizador)objectPartner);
                    string oganizadorJson = JsonSerializer.Serialize(oganizador);
                    await js.SetInLocalStorage("oganizador", oganizadorJson);
                    break;
                case "Productor":
                    Productor productor = ((Productor)objectPartner);
                    string productorJson = JsonSerializer.Serialize(productor);
                    await js.SetInLocalStorage("productor", productorJson);

                    break;
                case "Vendedor":
                    Vendedor vendedor = ((Vendedor)objectPartner);
                    string vendedorJson = JsonSerializer.Serialize(vendedor);
                    await js.SetInLocalStorage("vendedor", vendedorJson);
                    break;

                default:

                    break;

            }

            saved = true;

            return saved;
        }

    }
}
