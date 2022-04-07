#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f83cd4b5d38e1d6b0f2d1a04ac6b9f66ffdceb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Grupo/editar/{GrupoId:int}")]
    public partial class EditarGrupo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Editar Grupo</h3>");
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
 if (grupo == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(1);
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Pages.AdminPages.Grupos.FormGrupo>(2);
            __builder.AddAttribute(3, "grupo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.Models.Grupo>(
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
                      grupo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
                                            Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\EditarGrupo.razor"
       
    [Parameter] public int GrupoId { get; set; }
    Grupo grupo;

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<Grupo>("api/Grupos/" + GrupoId);
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
            grupo = httpResponse.Response;
        }



    }
    private async Task Editar()
    {
     
        #region Checkeo si ya existe la URL  CAMBIAO EL TIPO
        //var httpResponse2 = await repositorio.Post<Grupo,bool>("api/ZirenHeads/YaExisteUrl/Grupo", grupo);
        //if(httpResponse2.Response==true)
        //{
        //    await mostrarMensaje.MostrarMensajeError("Error : La url ya existe");
        //    return;
        //}
        #endregion

        var httpResponse = await repositorio.Put("api/Grupos/" + grupo.GrupoId, grupo);
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
