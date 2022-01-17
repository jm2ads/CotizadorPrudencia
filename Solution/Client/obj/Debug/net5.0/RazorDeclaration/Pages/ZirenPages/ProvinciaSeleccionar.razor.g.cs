// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project.Client.Pages.ZirenPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/provincia")]
    public partial class ProvinciaSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
       

    Partner partner = new Partner();
    string oProvinciaDescripcion = "";

    private List<ProvinciaDTO> oProvinciasList;
    private List<ProvinciaDTO> oProvinciasAuxList;
    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<ProvinciaDTO>>("api/Externo/Prudencia/catalogos/GetProvincias");
        oProvinciasList = responseHttp.Response;
        oProvinciasAuxList = responseHttp.Response;

        #region GetFromLocalStoragePartner
        string partnerJson = await JsRuntime.GetFromLocalStorage("partner");
        partner = JsonSerializer.Deserialize<Partner>(partnerJson);
        #endregion

    }
    private async Task ProvinciaKeyUp(KeyboardEventArgs e)
    {

        oProvinciasAuxList = (from c in oProvinciasList
                              where c.descripcion.ToLower().Contains(oProvinciaDescripcion.ToLower())
                              select c).ToList();




    }
    private async Task OnClickHandle(string oprovinciasID)
    {
        //Singleton.oCotizacionAutoDTO.asegurado.provinciaID = oprovinciasID;

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.asegurado.provinciaID = oprovinciasID;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);


        #region CotizacionEntitiesDTO
        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);



        ProvinciaDTO oProvincias = (from c in oProvinciasList
                                    where c.provinciaID == oprovinciasID
                                    select c).FirstOrDefault();

        cotizacionEntitiesDTO.provincia = oProvincias;

        cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
        await JsRuntime.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);
        Console.WriteLine(cotizacionEntitiesDTOJson);
        #endregion


        navigationManager.NavigateTo("/ziren/cp");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
