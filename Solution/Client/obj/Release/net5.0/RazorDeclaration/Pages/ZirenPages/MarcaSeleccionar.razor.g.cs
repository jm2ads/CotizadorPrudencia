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
using Project.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/marcas")]
    public partial class MarcaSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
       

    private List<MarcasAutos> oMarcasAutosList;
    private List<MarcasAutos> oMarcasAutosAuxList;
    private MarcasAutos oMarcasAutosAux = new MarcasAutos();
    string oMarcaDescripcion = "";



    private CotizacionAutoDTO oCotizacionAutoDTO;

    protected override async Task OnInitializedAsync()
    {

        Console.WriteLine("Inicia :" + DateTime.Now);

        var responseHttp = await repositorio.Get<List<MarcasAutos>>("api/Externo/Prudencia/catalogos/GetMarcasAutos");
        oMarcasAutosList = responseHttp.Response;
        // oMarcasAutosAuxList = responseHttp.Response;
        oMarcasAutosAuxList = (from c in oMarcasAutosList
                               where c.marcaID == 46
                               || c.marcaID == 18
                               || c.marcaID == 12
                               || c.marcaID == 17
                               || c.marcaID == 32
                               || c.marcaID == 11
                               || c.marcaID == 6

                               || c.marcaID == 45
                               || c.marcaID == 19
                               || c.marcaID == 30
                               || c.marcaID == 36
                               || c.marcaID == 20
                               || c.marcaID == 28
                               || c.marcaID == 8
                               || c.marcaID == 43
                               select c).ToList();
        Console.WriteLine("Fin :" + DateTime.Now);
    }

    protected override async Task OnParametersSetAsync()
    {



    }


    private async Task OnClickHandle(int omarcaID)
    {


        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.vehiculo.marcaID = omarcaID;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        #region CotizacionEntitiesDTO

        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        MarcasAutos marcasAutos = (from c in oMarcasAutosList
                                   where c.marcaID == omarcaID
                                   select c).FirstOrDefault();

        cotizacionEntitiesDTO.marcasAutos = marcasAutos;

        cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
        await JsRuntime.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);
        Console.WriteLine(cotizacionEntitiesDTOJson);
        #endregion


        navigationManager.NavigateTo("/ziren/ano");

    }

    private async Task MarcaKeyUp(KeyboardEventArgs e)
    {
        if (oMarcaDescripcion.Trim().Length < 2)
        {
            oMarcasAutosAuxList = (from c in oMarcasAutosList
                                   where c.marcaID == 46
                                   || c.marcaID == 18
                                   || c.marcaID == 12
                                   || c.marcaID == 17
                                   || c.marcaID == 32
                                   || c.marcaID == 11
                                   || c.marcaID == 6
                                   select c).ToList();
            return;
        }


        oMarcasAutosAuxList = (from c in oMarcasAutosList
                               where c.descripcion.ToLower().Contains(oMarcaDescripcion.ToLower())
                               select c).ToList();

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
