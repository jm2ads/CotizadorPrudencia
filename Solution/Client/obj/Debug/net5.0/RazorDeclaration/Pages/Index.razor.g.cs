// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project.Client.Pages
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
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Index.razor"
        private Login oLogin = null;

    private CotizacionAutoDTO oCotizacionAutoDTO;
    private string permisoNotificaciones = string.Empty;



    CotizacionPopUp cotizacionPopUp;
    private List<RespuestaReporteDTO> oRespuestaReporteDTOList = new List<RespuestaReporteDTO>();
    RespuestaPolizaImpresionDTO oRespuestaPolizaImpresionDTO = null;



    protected async override Task OnInitializedAsync()
    {
        #region MyRegion
        //await repositorio.Post("api/notificaciones/TextToSpeech", "Esto es un Test");
        //permisoNotificaciones = await js.ObtenerEstatusPermisoNotificaciones();
        #endregion

        oCotizacionAutoDTO = new CotizacionAutoDTO();
        oCotizacionAutoDTO.vehiculo = new VehiculoDTO();
        oCotizacionAutoDTO.asegurado = new AseguradoPatrimonialDTO();
        oCotizacionAutoDTO.cotizacionID = 0;


        string CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);

        await js.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);


        #region CotizacionEntitiesDTO
        CotizacionEntitiesDTO cotizacionEntitiesDTO = new CotizacionEntitiesDTO();
        string cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
        await js.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);
        #endregion


        string oUser = "586701";
        string oPassword = "586701";

        UserPassWord oUserPassWord = new UserPassWord();

        oUserPassWord.user = oUser;
        oUserPassWord.password = oPassword;



        //var HttpResponse = await repositorio.Post<UserPassWord, Login>("api/Externo/Prudencia/login", oUserPassWord);
        //oLogin = HttpResponse.Response;


    }

    private async Task Suscribir()
    {
        var notificacion = await js.SuscribirANotificaciones();

        if (notificacion != null)
        {
            await repositorio.Post("api/notificaciones/suscribir", notificacion);
            permisoNotificaciones = await js.ObtenerEstatusPermisoNotificaciones();
            await mostrarMensajes.MostrarMensajeExitoso("Vas a recibir una notificación cuando salga una nueva película en cartelera");
            //#if DEBUG
            Console.WriteLine("URL : " + notificacion.URL);
            Console.WriteLine("P256dh : " + notificacion.P256dh);
            Console.WriteLine("Auth : " + notificacion.Auth);
            //#endif
            StateHasChanged();
        }

    }

    private async Task Desuscribir()
    {
        var notificacion = await js.DesuscribirANotificaciones();

        if (notificacion != null)
        {
            await repositorio.Post("api/notificaciones/desuscribir", notificacion);
            permisoNotificaciones = await js.ObtenerEstatusPermisoNotificaciones();
            await mostrarMensajes.MostrarMensajeExitoso("Ya no vas a recibir notificaciones");
            StateHasChanged();
        }
    }

    private async Task OnClickHandle()
    {
        //await mostrarMensajes.MostrarMensajeExitoso("mensaje");
        //await mostrarMensajes.MostrarMensajeConImagen( "mensaje");
        cotizacionPopUp.Mostrar();


    }
    private async Task onConfirm()
    {
        cotizacionPopUp.Ocultar();

        navigationManager.NavigateTo($"/ziren/marcas");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageManager LocalStorageManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
