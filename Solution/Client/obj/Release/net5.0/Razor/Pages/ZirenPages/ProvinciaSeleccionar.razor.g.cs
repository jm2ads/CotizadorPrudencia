#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f725eb6d4b3db1cd2e2bcff4978163eff50c269"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages.ZirenPages
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
using Project.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/provincia")]
    public partial class ProvinciaSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Seleccione la Provincia</h3>\r\n");
            __builder.AddMarkupContent(1, "<label style=\"color:white;font-size: 0.8em;align-content:initial\">Declarar la provincia correcta ya que afecta al costo de tu seguro, para tener una cotización correcta 🤗</label>");
#nullable restore
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
 if (oProvinciasList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(2);
            __builder.CloseComponent();
#nullable restore
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
     if (oProvinciasAuxList.Count == 0)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "No hay registros para mostrar");
#nullable restore
#line 20 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
                                                  
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 26 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
                               (KeyboardEventArgs e) => ProvinciaKeyUp(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "titulo");
            __builder.AddAttribute(11, "placeholder", "Provincia");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
                                oProvinciaDescripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oProvinciaDescripcion = __value, oProvinciaDescripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
             foreach (var oProvincias in oProvinciasAuxList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(19, "div");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddAttribute(23, "style", "width:auto");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
                                                                                                     () => OnClickHandle(@oProvincias.provinciaID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, 
#nullable restore
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
                             oProvincias.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\ProvinciaSeleccionar.razor"
       


    string oProvinciaDescripcion = "";

    private List<ProvinciaDTO> oProvinciasList;
    private List<ProvinciaDTO> oProvinciasAuxList;
    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<ProvinciaDTO>>("api/Externo/Prudencia/catalogos/GetProvincias");
        oProvinciasList = responseHttp.Response;
        oProvinciasAuxList = responseHttp.Response;



    }
    private async Task ProvinciaKeyUp(KeyboardEventArgs e)
    {

        oProvinciasAuxList = (from c in oProvinciasList
                              where c.descripcion.ToLower().Contains(oProvinciaDescripcion.ToLower())
                              select c).ToList();




    }
    private async Task OnClickHandle(string oprovinciasID)
    {
        //Singleton.oCotizacionAutoDTO.asegurado.provinciaID = oprovinciasID;

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.asegurado.provinciaID = oprovinciasID;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);


        #region CotizacionEntitiesDTO
        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);



        ProvinciaDTO oProvincias = (from c in oProvinciasList
                                           where c.provinciaID == oprovinciasID
                                           select c).FirstOrDefault();

        cotizacionEntitiesDTO.provincia = oProvincias;

        cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
        await JsRuntime.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);
        Console.WriteLine(cotizacionEntitiesDTOJson);
        #endregion


        navigationManager.NavigateTo("/ziren/cp");
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
