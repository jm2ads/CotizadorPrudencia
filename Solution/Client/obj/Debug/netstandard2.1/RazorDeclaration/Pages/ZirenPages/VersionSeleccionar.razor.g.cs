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
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.DTOs;

#line default
#line hidden
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/version")]
    public partial class VersionSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 56 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
       
    [Parameter] public int marcaID { get; set; }
    [Parameter] public int anoID { get; set; }
    [Parameter] public int modeloID { get; set; }


    private bool TieneGNC = false;
    string oVersionDescripcion = "";
    private List<VersionesAutos> oVersionesAutosList;
    private List<VersionesAutos> oVersionesAutosAuxList;

    protected override async Task OnInitializedAsync()
    {
        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        var responseHttp = await repositorio.Get<List<VersionesAutos>>("api/Externo/Prudencia/catalogos/GetVersionesModelosAutos/" + oCotizacionAutoDTO.vehiculo.anio.ToString() + "/" + oCotizacionAutoDTO.vehiculo.marcaID.ToString() + "/" + oCotizacionAutoDTO.vehiculo.modeloID.ToString());
        oVersionesAutosList = responseHttp.Response;
        oVersionesAutosAuxList = responseHttp.Response;

    }
    private async Task OnClickHandle(int omodeloID)
    {
        VersionesAutos oVersionesAutos = (from c in oVersionesAutosList
                                          where c.modeloID == omodeloID
                                          select c).FirstOrDefault();



        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.vehiculo.modeloID = omodeloID;
        oCotizacionAutoDTO.vehiculo.tipoUsoID = 1;
        oCotizacionAutoDTO.vehiculo.tieneGNC = TieneGNC;
        //oCotizacionAutoDTO.vehiculo.tipoVehiculoID = oModelosAutos.tipoVehiculoID;             VERRRRRRRRRRRRRRRR
        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        navigationManager.NavigateTo("/ziren/provincia");
    }
    private async Task MarcaKeyUp(KeyboardEventArgs e)
    {

        oVersionesAutosAuxList = (from c in oVersionesAutosList
                                  where c.descripcion.ToLower().Contains(oVersionDescripcion.ToLower())
                                  select c).ToList();

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
