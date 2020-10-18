#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf6abf904d4601ea1f8b594a4c841377d70a23c"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages
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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 style=\"color:white\">Cotize su Auto OnLine </h2>\r\n");
            __builder.AddMarkupContent(1, "<div style=\"height: 400px;display: flex;align-items: flex-start;\">\r\n    <a href=\"/ziren/marcas\" class=\"btn btn-success\" style=\"align-self:initial; \">Cotizar</a>\r\n</div>\r\n");
            __builder.AddMarkupContent(2, "<div style=\"position:absolute;bottom:0;\">\r\n  \r\n\r\n    <label style=\"color:white;font-size: 0.5em;align-content:end\">Version 20.9.14.1</label>\r\n</div>");
        }
        #pragma warning restore 1998
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Index.razor"
            private Login oLogin = null;

        private CotizacionAutoDTO oCotizacionAutoDTO;
        private string permisoNotificaciones = string.Empty;

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
    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageManager LocalStorageManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
