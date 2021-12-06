#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a69c01aec1588b504d2101576c0f703fbd37a2"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages.AdminPages.Organizadores
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Organizador/editar/{organizadorId:int}/{Url}")]
    public partial class EditarOrganizador : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Editar Grupo</h3>");
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
 if (organizador == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Cargando...");
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
                             }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Pages.AdminPages.Organizadores.FormOrganizador>(2);
            __builder.AddAttribute(3, "organizador", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.Models.Organizador>(
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
                                  organizador

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "oOnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
                                                               Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\EditarOrganizador.razor"
       
    [Parameter] public int organizadorId { get; set; }
    [Parameter] public string Url { get; set; }
    private Organizador organizador;

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<Organizador>("api/Organizadores/" + organizadorId);
        if (httpResponse.Error)
        {
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("Grupos");
            }
            else
            {
                await mostrarMensaje.MostrarMensajeError(await httpResponse.GetBody());
            }
        }
        else
        {
            organizador = httpResponse.Response;
        }



    }
    private async Task Editar()
    {
        #region Valido Form
        if (string.IsNullOrEmpty(organizador.Url) || string.IsNullOrEmpty(organizador.Nombre) || string.IsNullOrEmpty(organizador.Apellido) || string.IsNullOrEmpty(organizador.Dni)
            || string.IsNullOrEmpty(organizador.Matricula) || string.IsNullOrEmpty(organizador.Mail) || string.IsNullOrEmpty(organizador.Celular1) || string.IsNullOrEmpty(organizador.Domicilio)
            || string.IsNullOrEmpty(organizador.Localidad) || string.IsNullOrEmpty(organizador.Logo) ||  string.IsNullOrEmpty(organizador.Whatsapp))
        {

            await mostrarMensaje.MostrarMensajeError("Los Campos => Url, Nombre, Apellido, Dni, Matricula, Mail, Celular1, Domicilio," +
                " Localidad, Logo y Whatsapp son Obligatorios");
            return;
        }
        #endregion
        #region Checkeo si ya existe la URL
        var httpResponse2 = await repositorio.Post<Organizador, bool>("api/ZirenHeads/YaExisteUrl", organizador);
        if (httpResponse2.Response == true)
        {
            await mostrarMensaje.MostrarMensajeError("Error : La url ya existe");
            return;
        }
        #endregion

        var httpResponse = await repositorio.Put("api/Organizadores/" + organizador.OrganizadorId, organizador);
        if (httpResponse.Error)
        {
            await mostrarMensaje.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo("/admin/Grupos");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensaje { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591