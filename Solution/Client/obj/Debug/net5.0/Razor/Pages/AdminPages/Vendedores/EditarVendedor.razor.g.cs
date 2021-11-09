#pragma checksum "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992a18f0e4cfea4a53039fbc1debdaf50d00b49f"
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
#line 1 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vendedor/editar/{vendedorId:int}/{Url}")]
    public partial class EditarVendedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Editar Grupo</h3>");
#nullable restore
#line 8 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
 if (vendedor == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Cargando...");
#nullable restore
#line 10 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
                             }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Pages.AdminPages.Vendedores.FormVendedor>(2);
            __builder.AddAttribute(3, "vendedor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.Models.Vendedor>(
#nullable restore
#line 13 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
                            vendedor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "oOnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
                                                      Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\EditarVendedor.razor"
       
    [Parameter] public int vendedorId { get; set; }
    [Parameter] public string Url { get; set; }
    private Vendedor vendedor;

    protected override async Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<Vendedor>("api/Vendedores/" + vendedorId);
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
            vendedor = httpResponse.Response;
        }



    }
    private async Task Editar()
    {

        var httpResponse = await repositorio.Put("api/Vendedores/" + vendedor.VendedorId, vendedor);
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
