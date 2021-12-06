#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95737b78872d95284f2417e6fb5d32cb36f2a4ae"
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
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/Grupos")]
    public partial class IndexGrupo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Grupos</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-success\" href=\"grupo/Crear\">Grupo Nuevo</a></div>");
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
 if (grupoList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(2);
            __builder.CloseComponent();
#nullable restore
#line 16 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
     if (grupoList.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<label style=\"color:white\">No hay registros para mostrar</label>");
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
             foreach (var grupo in grupoList)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;border:solid;border-color:lightgrey;border-width:thin;border-radius:5px;padding:5px");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "/admin/Organizadores/" + (
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                               grupo.GrupoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                                              grupo.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                                       grupo.Logo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "alt", "Poster");
            __builder.AddAttribute(13, "style", "width: 112px; height:150px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "btn btn-info");
            __builder.AddAttribute(18, "style", "margin:3px");
            __builder.AddAttribute(19, "href", "grupo/editar/" + (
#nullable restore
#line 37 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                                                                   grupo.GrupoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                        () => BorrarGrupo(grupo)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-danger");
            __builder.AddContent(25, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "btn btn-warning");
            __builder.AddAttribute(30, "style", "margin:3px");
            __builder.AddAttribute(31, "href", "/admin/Organizadores/" + (
#nullable restore
#line 41 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                                                                              grupo.GrupoId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 41 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
                                                                                                             grupo.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Ver Organizadores");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"


            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 127 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
          





    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\IndexGrupo.razor"
       


    private List<Grupo> grupoList;
    private Grupo grupo = new Grupo();

    private List<Organizador> organizadorList = new List<Organizador>();
    private Organizador organizador = new Organizador();

    private List<Productor> productorList = new List<Productor>();
    private Productor productor = new Productor();

    private List<Vendedor> vendedorList = new List<Vendedor>();
    private Vendedor vendedor = new Vendedor();

    string oMarcaDescripcion = "";

    private int grupoIdAux;
    public int grupoId
    {
        get { return grupoIdAux; }
        set
        {
            grupoIdAux = value;
            OnGrupoChange(value);
        }
    }


    private int organizadorIdAux;
    public int organizadorId
    {
        get { return organizadorIdAux; }
        set
        {
            organizadorIdAux = value;
            OnOrganizadorChange(value);
        }
    }

    private int productorIdAux;
    public int productorId
    {
        get { return productorIdAux; }
        set
        {
            productorIdAux = value;
            OnProductorChange(value);
        }
    }

    private int vendedorIdAux;
    public int vendedorId
    {
        get { return vendedorIdAux; }
        set
        {
            vendedorIdAux = value;
            //OnVendedorChange(value);
        }
    }








    private CotizacionAutoDTO oCotizacionAutoDTO;

    protected override async Task OnInitializedAsync()
    {

        await Cargar();


    }
    private async void OnGrupoChange(int grupoid)
    {
        //organizadorList.Clear();
        //productorList.Clear();
        //vendedorList.Clear();

        //organizadorId = 0;
        //productorId = 0;
        //vendedorId = 0;
        //organizadorList = (from c in grupoList
        //                   where c.GrupoId == grupoid
        //                   select c).FirstOrDefault().OrganizadoresList.ToList();
    }

    private async void OnOrganizadorChange(int organizadorId)
    {
        //productorList.Clear();
        //vendedorList.Clear();

        //productorId = 0;
        //vendedorId = 0;
        //productorList = (from c in organizadorList
        //                 where c.GrupoId == organizadorId
        //                 select c).FirstOrDefault().ProductoresList.ToList();
    }




    private async void OnProductorChange(int productorId)
    {
        //vendedorList.Clear();

        //vendedorId = 0;
        //vendedorList = (from c in productorList
        //                where c.ProductorId == productorId
        //                select c).FirstOrDefault().VendedoresList.ToList();
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
        var responseHttp = await repositorio.Get<List<Grupo>>("api/Grupos");
        grupoList = responseHttp.Response;
    }
    private async Task BorrarGrupo(Grupo grupo)
    {
        var responseHttp = await repositorio.Delete($"api/Grupos/{grupo.GrupoId}");
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
