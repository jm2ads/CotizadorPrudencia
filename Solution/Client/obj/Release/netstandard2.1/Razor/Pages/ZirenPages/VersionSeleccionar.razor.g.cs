#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2e93e1b226a3c7e3d1d74271a414d6fd7d11f2"
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
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.DTOs;

#line default
#line hidden
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/version")]
    public partial class VersionSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\"> Seleccione Version</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "margin:0px");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.AddAttribute(7, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                           (KeyboardEventArgs e) => MarcaKeyUp(e)

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "id", "titulo");
            __builder.AddAttribute(14, "placeholder", "Version");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                            oModeloDescripcion

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oModeloDescripcion = __value, oModeloDescripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-2");
            __builder.AddAttribute(21, "style", "margin-right: 2%;\r\n        margin-bottom: 10px;\r\n        text-align: center;\r\n        border: solid;\r\n        border-color: lightgrey;\r\n        border-width: thin;\r\n        border-radius: 5px;\r\n        padding: 5px;height:38px");
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.AddMarkupContent(23, "<label style=\"color:white\">Tiene GNC?</label>\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "checkbox");
            __builder.AddAttribute(26, "style", "margin-top: 5px;");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                             TieneGNC

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TieneGNC = __value, TieneGNC));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n\r\n\r\n");
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
     if (oModelosAutosAuxList == null)
    {

#line default
#line hidden
            __builder.OpenComponent<Project.Client.Shared.Cargando>(32);
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
    }
    else
    {
        

#line default
#line hidden
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
         if (oModelosAutosList.Count == 0)
        {
            

#line default
#line hidden
            __builder.AddMarkupContent(34, "No hay registros para mostrar\r\n            ");
            __builder.AddMarkupContent(35, "<p><em>No hay registros para mostrar</em></p>\r\n");
#line 46 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "display: flex; flex-wrap: wrap; align-items: center;");
            __builder.AddMarkupContent(39, "\r\n\r\n\r\n");
#line 57 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                 foreach (var oModelosAutos in oModelosAutosAuxList)
                {

#line default
#line hidden
            __builder.AddContent(40, "                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "div");
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn btn-info");
            __builder.AddAttribute(49, "style", "width:auto");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 62 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                                                                                      () => OnClickHandle(@oModelosAutos.modeloID)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(51, "\r\n                                ");
            __builder.AddContent(52, 
#line 63 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                 oModelosAutos.descripcion

#line default
#line hidden
            );
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#line 67 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                }

#line default
#line hidden
            __builder.AddContent(57, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#line 69 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
        }

#line default
#line hidden
#line 69 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
         
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 72 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
           
        [Parameter] public int marcaID { get; set; }
        [Parameter] public int anoID { get; set; }
        [Parameter] public int modeloID { get; set; }


        private bool TieneGNC = false;

        private List<ModelosAutos> oModelosAutosList;
        private List<ModelosAutos> oModelosAutosAuxList;
        string oModeloDescripcion = "";
        protected override async Task OnInitializedAsync()
        {
            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

            var responseHttp = await repositorio.Get<List<ModelosAutos>>("api/Externo/Prudencia/catalogos/GetModelosAutos/" + oCotizacionAutoDTO.vehiculo.marcaID);
            oModelosAutosList = responseHttp.Response;
            oModelosAutosAuxList = responseHttp.Response;

        }
        private async Task OnClickHandle(int omodeloID)
        {
            ModelosAutos oModelosAutos = (from c in oModelosAutosList
                                          where c.modeloID == omodeloID
                                          select c).FirstOrDefault();

            //Singleton.oCotizacionAutoDTO.vehiculo.modeloID = omodeloID;
            //Singleton.oCotizacionAutoDTO.vehiculo.tipoUsoID = 1;
            //Singleton.oCotizacionAutoDTO.vehiculo.tipoVehiculoID = oModelosAutos.tipoVehiculoID;



            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

            oCotizacionAutoDTO.vehiculo.modeloID = omodeloID;
            oCotizacionAutoDTO.vehiculo.tipoUsoID = 1;
            oCotizacionAutoDTO.vehiculo.tieneGNC = TieneGNC;
            oCotizacionAutoDTO.vehiculo.tipoVehiculoID = oModelosAutos.tipoVehiculoID;
            CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
            Console.WriteLine(CotizacionAutoDTOJson);

            navigationManager.NavigateTo("/ziren/provincia");
        }
        private async Task MarcaKeyUp(KeyboardEventArgs e)
        {

            oModelosAutosAuxList = (from c in oModelosAutosList
                                    where c.descripcion.ToLower().Contains(oModeloDescripcion.ToLower())
                                    select c).ToList();

        }
    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
