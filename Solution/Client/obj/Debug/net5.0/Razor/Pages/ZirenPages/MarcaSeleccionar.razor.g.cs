#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39bcdaac2c84c4fb3c92ae615268611ee3499d0e"
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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/marcas")]
    public partial class MarcaSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Seleccione la Marca</h3>");
#nullable restore
#line 19 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
 if (oMarcasAutosAuxList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(1);
            __builder.CloseComponent();
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label style=\"color:white;font-size: 0.8em;align-content:initial;margin:5px\">Si la marca de su vehiculo no aparece, tipee las primeras letras</label>");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "autocomplete", "off");
            __builder.AddAttribute(7, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
                           (KeyboardEventArgs e) => MarcaKeyUp(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "titulo");
            __builder.AddAttribute(11, "placeholder", "Marca");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
                            oMarcaDescripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oMarcaDescripcion = __value, oMarcaDescripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
     if (oMarcasAutosAuxList.Count == 0)
    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<label style=\"color:white\">No hay registros para mostrar</label>");
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"


    }
    else
    {




#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 47 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
             foreach (var oMarcasAutos in oMarcasAutosAuxList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "margin-right: 1%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(19, "div");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "class", "btn btn-success");
            __builder.AddAttribute(23, "style", "width:auto");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 51 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
                                                                                                 oMarcasAutos.marcaID

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
                                                                                                                                   () => OnClickHandle(oMarcasAutos.marcaID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, 
#nullable restore
#line 52 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
                             oMarcasAutos.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 59 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"






    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\MarcaSeleccionar.razor"
       

    private List<MarcasAutos> oMarcasAutosList;
    private List<MarcasAutos> oMarcasAutosAuxList;
    private MarcasAutos oMarcasAutosAux = new MarcasAutos();
    string oMarcaDescripcion = "";



    private CotizacionAutoDTO oCotizacionAutoDTO;

    protected override async Task OnInitializedAsync()
    {

        Console.WriteLine("Inicia :" + DateTime.Now);

        var responseHttp = await repositorio.Get<List<MarcasAutos>>("api/Externo/Prudencia/catalogos/GetMarcasAutos");
        oMarcasAutosList = responseHttp.Response;
        // oMarcasAutosAuxList = responseHttp.Response;
        oMarcasAutosAuxList = (from c in oMarcasAutosList
                               where c.marcaID == 46
                               || c.marcaID == 18
                               || c.marcaID == 12
                               || c.marcaID == 17
                               || c.marcaID == 32
                               || c.marcaID == 11
                               || c.marcaID == 6

                               || c.marcaID == 45
                               || c.marcaID == 19
                               || c.marcaID == 30
                               || c.marcaID == 36
                               || c.marcaID == 20
                               || c.marcaID == 28
                               || c.marcaID == 8
                               || c.marcaID == 43
                               select c).ToList();
        Console.WriteLine("Fin :" + DateTime.Now);
    }

    protected override async Task OnParametersSetAsync()
    {



    }


    private async Task OnClickHandle(int omarcaID)
    {


        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.vehiculo.marcaID = omarcaID;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        #region CotizacionEntitiesDTO

        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        MarcasAutos marcasAutos = (from c in oMarcasAutosList
                                   where c.marcaID == omarcaID
                                   select c).FirstOrDefault();

        cotizacionEntitiesDTO.marcasAutos = marcasAutos;

        cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
        await JsRuntime.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);
        Console.WriteLine(cotizacionEntitiesDTOJson);
        #endregion


        navigationManager.NavigateTo("/ziren/ano");

    }

    private async Task MarcaKeyUp(KeyboardEventArgs e)
    {
        if (oMarcaDescripcion.Trim().Length < 2)
        {
            oMarcasAutosAuxList = (from c in oMarcasAutosList
                                   where c.marcaID == 46
                                   || c.marcaID == 18
                                   || c.marcaID == 12
                                   || c.marcaID == 17
                                   || c.marcaID == 32
                                   || c.marcaID == 11
                                   || c.marcaID == 6
                                   select c).ToList();
            return;
        }


        oMarcasAutosAuxList = (from c in oMarcasAutosList
                               where c.descripcion.ToLower().Contains(oMarcaDescripcion.ToLower())
                               select c).ToList();

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
