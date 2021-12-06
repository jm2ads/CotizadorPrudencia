#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\CrearGrupo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b488cce27f63a47d5e0240bf6f7da9a9b092ffd"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages.AdminPages.Grupos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Grupo/crear")]
    public partial class CrearGrupo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Crear Grupo</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Project.Client.Pages.AdminPages.Grupos.FormGrupo>(1);
            __builder.AddAttribute(2, "grupo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.Models.Grupo>(
#nullable restore
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\CrearGrupo.razor"
                  grupo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\CrearGrupo.razor"
                                        Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\CrearGrupo.razor"
       
    Grupo grupo = new Grupo();


    private async Task Crear()
    {
        #region Valido Form
        if ( string.IsNullOrEmpty(grupo.Url) || string.IsNullOrEmpty(grupo.Nombre)|| string.IsNullOrEmpty(grupo.Apellido) || string.IsNullOrEmpty(grupo.Dni)
            || string.IsNullOrEmpty(grupo.Matricula) || string.IsNullOrEmpty(grupo.Mail) || string.IsNullOrEmpty(grupo.Celular1) || string.IsNullOrEmpty(grupo.Domicilio)
            || string.IsNullOrEmpty(grupo.Localidad) || string.IsNullOrEmpty(grupo.Logo) || string.IsNullOrEmpty(grupo.Whatsapp)     )
        {

            await mostrarMensajes.MostrarMensajeError("Los Campos => Url, Nombre, Apellido, Dni, Matricula, Mail, Celular1, Domicilio," +
                " Localidad, Logo y Whatsapp son Obligatorios");
            return;
        }
        #endregion


        #region Checkeo si ya existe la URL  CAMBIAO EL TIPO
        //var httpResponse2 = await repositorio.Post<Grupo, bool>("api/ZirenHeads/YaExisteUrl/Grupo", grupo);
        //if (httpResponse2.Response == true)
        //{
        //    await mostrarMensajes.MostrarMensajeError("Error : La url ya existe");
        //    return;
        //}
        #endregion
        var httpResponse = await repositorio.Post("api/Grupos", grupo);


        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();

            await mostrarMensajes.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            //  await mostrarMensajes.MostrarMensajeExitoso(await httpResponse.GetBody());
            navigationManager.NavigateTo("/admin/Grupos");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
