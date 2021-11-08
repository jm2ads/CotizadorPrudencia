#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\CrearVendedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf6473a66c47c30f490497ce9f636499a96a8f65"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vendedor/crear/{productorId:int}/{Url}")]
    public partial class CrearVendedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "style", "color:white");
            __builder.AddContent(2, "Crear Vendedor (de ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\CrearVendedor.razor"
                                            Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __builder.OpenComponent<Project.Client.Pages.AdminPages.Vendedores.FormVendedor>(6);
            __builder.AddAttribute(7, "grupo", "grupo");
            __builder.AddAttribute(8, "oOnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\CrearVendedor.razor"
                                            Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Vendedores\CrearVendedor.razor"
       
    [Parameter] public int productorId { get; set; }
    [Parameter] public string Url { get; set; }
    private Vendedor vendedor = new Vendedor();


    private async Task Crear()
    {
        vendedor.ProductorId = productorId;
        var httpResponse = await repositorio.Post("api/Vendedores", vendedor);


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
