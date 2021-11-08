#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc26965dd7a42d26b2afdf72459f058d6b88142"
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
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/Organizadores/{grupoId:int}/{Url}")]
    public partial class IndexOrganizador : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "style", "color:white");
            __builder.AddContent(2, "Organizadores (Grupo ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                              Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "class", "btn btn-success");
            __builder.AddAttribute(10, "href", "organizador/Crear/" + (
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                        grupoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                 Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Grupo Nuevo");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
 if (organizadorList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(12);
            __builder.CloseComponent();
#nullable restore
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
     if (organizadorList.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<label style=\"color:white\">No hay registros para mostrar</label>");
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
             foreach (var organizador in organizadorList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;border:solid;border-color:lightgrey;border-width:thin;border-radius:5px;padding:5px");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/admin/Productores/" + (
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                 organizador.OrganizadorId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                            organizador.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                           organizador.Logo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "alt", "Poster");
            __builder.AddAttribute(23, "style", "width: 112px; height:150px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddAttribute(28, "style", "margin:3px");
            __builder.AddAttribute(29, "href", "/admin/Productores/" + (
#nullable restore
#line 35 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                                                 organizador.OrganizadorId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 35 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                                                                            organizador.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Productores");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "div");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "btn btn-info");
            __builder.AddAttribute(35, "style", "margin:3px");
            __builder.AddAttribute(36, "href", "organizador/editar/" + (
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                                              organizador.OrganizadorId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                                                                                                         Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
                                            () => BorrarOrganizador(organizador)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-danger");
            __builder.AddContent(42, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 44 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Organizadores\IndexOrganizador.razor"
       
    [Parameter] public int grupoId { get; set; }
    [Parameter] public string Url { get; set; }



    private List<Grupo> grupoList;
    private Grupo grupo = new Grupo();

    private List<Organizador> organizadorList ;
    private Organizador organizador = new Organizador();

    private List<Productor> productorList = new List<Productor>();
    private Productor productor = new Productor();

    private List<Vendedor> vendedorList = new List<Vendedor>();
    private Vendedor vendedor = new Vendedor();

    string oMarcaDescripcion = "";



    private int organizadorId;

    private int productorId;

    private int vendedorId;



    protected override async Task OnInitializedAsync()
    {

        await Cargar();

    }




    private async Task Cargar()
    {
        var responseHttp = await repositorio.Get<List<Organizador>>("api/Organizadores/GetByGrupoId/" + grupoId);
        organizadorList = responseHttp.Response;
    }
    private async Task BorrarOrganizador(Organizador organizador)
    {
        var responseHttp = await repositorio.Delete($"api/Organizadores/{organizador.OrganizadorId}");
        if (responseHttp.Error)
        {
            Console.WriteLine(responseHttp.HttpResponseMessage.StatusCode);
            await mostrarMensajes.MostrarMensajeError(await responseHttp.GetBody());
        }
        else
        {
            await Cargar();
        }

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
