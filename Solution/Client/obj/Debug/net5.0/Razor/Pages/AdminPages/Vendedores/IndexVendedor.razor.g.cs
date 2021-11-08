#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2faeef1e403ea4a0f99842cf54dc556fec73d2c1"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages.AdminPages.Vendedores
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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/Vendedores/{productorId:int}/{Url}")]
    public partial class IndexVendedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Vendedores</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "btn btn-success");
            __builder.AddAttribute(5, "href", "vendedor/Crear/" + (
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                                     productorId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                                                  Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Vendedor Nuevo");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
 if (vendedorList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(7);
            __builder.CloseComponent();
#nullable restore
#line 16 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
     if (vendedorList.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<label style=\"color:white\">No hay registros para mostrar</label>");
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
             foreach (var vendedor in vendedorList)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;border:solid;border-color:lightgrey;border-width:thin;border-radius:5px;padding:5px");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "XXXXX");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                                           vendedor.Logo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "alt", "Poster");
            __builder.AddAttribute(18, "style", "width: 112px; height:150px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-info");
            __builder.AddAttribute(23, "style", "margin:3px");
            __builder.AddAttribute(24, "href", "vendedor/editar/" + (
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                                                                          grupo.GrupoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                                                                                         Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
                                            () => BorrarVendedor(vendedor)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddContent(30, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"


            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"


      


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\IndexVendedor.razor"
       

    [Parameter] public int productorId { get; set; }
    [Parameter] public string Url { get; set; }
    private List<Grupo> grupoList;
    private Grupo grupo = new Grupo();

    private List<Organizador> organizadorList = new List<Organizador>();
    private Organizador organizador = new Organizador();

    private List<Productor> productorList = new List<Productor>();
    private Productor productor = new Productor();

    private List<Vendedor> vendedorList ;
    private Vendedor vendedor = new Vendedor();


    private CotizacionAutoDTO oCotizacionAutoDTO;

    protected override async Task OnInitializedAsync()
    {

        await Cargar();

    }




    protected override async Task OnParametersSetAsync()
    {



    }


    private async Task OnClickHandle(int omarcaID)
    {




        navigationManager.NavigateTo("/ziren/ano");

    }

    private async Task MarcaKeyUp(KeyboardEventArgs e)
    {




    }
    private async Task Cargar()
    {
        var responseHttp = await repositorio.Get<List<Vendedor>>("api/Vendedores/GetByProductorId/" + productorId);
        vendedorList = responseHttp.Response;
    }
    private async Task BorrarVendedor(Vendedor vendedor)
    {
        var responseHttp = await repositorio.Delete($"api/Vendedores/{vendedor.VendedorId}");
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