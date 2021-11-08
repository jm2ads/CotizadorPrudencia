// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project.Client.Pages.AdminPages.Productores
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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Productores\IndexProductor.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/Productores/{organizadorId:int}/{Url}")]
    public partial class IndexProductor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Productores\IndexProductor.razor"
       


    [Parameter] public int organizadorId { get; set; }
    [Parameter] public string Url { get; set; }
    private List<Grupo> grupoList;
    private Grupo grupo = new Grupo();

    private List<Organizador> organizadorList = new List<Organizador>();
    private Organizador organizador = new Organizador();

    private List<Productor> productorList ;
    private Productor productor = new Productor();

    private List<Vendedor> vendedorList = new List<Vendedor>();
    private Vendedor vendedor = new Vendedor();

    string oMarcaDescripcion = "";








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
        var responseHttp = await repositorio.Get<List<Productor>>("api/Productores/GetByOrganizadorId/" + organizadorId);
        productorList = responseHttp.Response;
    }
    private async Task BorrarProductor(Productor productor)
    {
        var responseHttp = await repositorio.Delete($"api/Productores/{productor.ProductorId}");
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
