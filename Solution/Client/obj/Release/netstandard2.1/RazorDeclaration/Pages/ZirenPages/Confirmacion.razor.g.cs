#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Confirmacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f083687cc108a76d3e1b4283da320239ec39e08"
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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Confirmacion.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/confirmacion/{oCoberturaID:int}")]
    public partial class Confirmacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 80 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Confirmacion.razor"
       

    [Parameter] public int oCoberturaID { get; set; }

    private CotizacionAutoDTO oCotizacionAutoDTO = new CotizacionAutoDTO();
    private RespuestaCotizacionAutoDTO oRespuestaCotizacionAutoDTO;
    protected override async Task OnInitializedAsync()
    {

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        int oCotizacionID = oCotizacionAutoDTO.cotizacionID;

        ConfirmacionCotizacionAutoDTO oConfirmacionCotizacionAutoDTO = new ConfirmacionCotizacionAutoDTO();
        oConfirmacionCotizacionAutoDTO.coberturaID = oCoberturaID;



        var responseHttp = await repositorio.Post<ConfirmacionCotizacionAutoDTO, RespuestaCotizacionAutoDTO>("api/Externo/Prudencia/cotizaciones/autos/" + oCotizacionID + "/confirmar", oConfirmacionCotizacionAutoDTO);
        oRespuestaCotizacionAutoDTO = responseHttp.Response;





        oCotizacionAutoDTO.cotizacionID = oRespuestaCotizacionAutoDTO.cotizacionID;


        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);
    }
    private async Task OnClickHandle()
    {
        navigationManager.NavigateTo("/ziren/imagenes");
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
