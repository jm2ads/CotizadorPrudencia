#pragma checksum "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4822555d131781fb35fe7d239ad09ea4770a6297"
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
#nullable restore
#line 9 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/version")]
    public partial class VersionSeleccionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\"> Seleccione Version</h3>\r\n\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 15 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                           (KeyboardEventArgs e) => MarcaKeyUp(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "autocomplete", "off");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "id", "titulo");
            __builder.AddAttribute(9, "placeholder", "Version");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                            oVersionDescripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oVersionDescripcion = __value, oVersionDescripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenComponent<Project.Client.Shared.ConfirmacionPopUp>(13);
            __builder.AddAttribute(14, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                                           onConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "onRefuse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                                                                onRefuse

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 19 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                             confirmacionPopUp = (Project.Client.Shared.ConfirmacionPopUp)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 22 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
     if (oVersionesAutosAuxList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(17);
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
         if (oVersionesAutosList.Count == 0)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "No hay registros para mostrar");
#nullable restore
#line 30 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                                        
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "display: flex; flex-wrap: wrap; align-items: center;");
#nullable restore
#line 42 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                 foreach (var oVersionesAutos in oVersionesAutosAuxList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(23, "div");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "style", "width:auto");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                                                                                         () => OnClickHandle(@oVersionesAutos.modeloID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 48 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                                 oVersionesAutos.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
         
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\VersionSeleccionar.razor"
           
        [Parameter] public int marcaID { get; set; }
        [Parameter] public int anoID { get; set; }
        [Parameter] public int modeloID { get; set; }

        ConfirmacionPopUp confirmacionPopUp;

        private bool TieneGNC = false;
        string oVersionDescripcion = "";
        private List<VersionesAutos> oVersionesAutosList;
        private List<VersionesAutos> oVersionesAutosAuxList;

        protected override async Task OnInitializedAsync()
        {
            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

            var responseHttp = await repositorio.Get<List<VersionesAutos>>("api/Externo/Prudencia/catalogos/GetVersionesModelosAutos/" + oCotizacionAutoDTO.vehiculo.anio.ToString() + "/" + oCotizacionAutoDTO.vehiculo.marcaID.ToString() + "/" + oCotizacionAutoDTO.vehiculo.modeloID.ToString());
            oVersionesAutosList = responseHttp.Response;
            oVersionesAutosAuxList = responseHttp.Response;

        }
        private async Task OnClickHandle(int omodeloID)
        {
            VersionesAutos oVersionesAutos = (from c in oVersionesAutosList
                                              where c.modeloID == omodeloID
                                              select c).FirstOrDefault();



            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

            oCotizacionAutoDTO.vehiculo.modeloID = omodeloID;
            oCotizacionAutoDTO.vehiculo.tipoUsoID = 1;
            // oCotizacionAutoDTO.vehiculo.tieneGNC = TieneGNC;
            //oCotizacionAutoDTO.vehiculo.tipoVehiculoID = oModelosAutos.tipoVehiculoID;             VERRRRRRRRRRRRRRRR
            CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
            Console.WriteLine(CotizacionAutoDTOJson);



            #region CotizacionEntitiesDTO
            string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
            CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);


            cotizacionEntitiesDTO.versionesAutos = oVersionesAutos;

            cotizacionEntitiesDTOJson = JsonSerializer.Serialize(cotizacionEntitiesDTO);
            await JsRuntime.SetInLocalStorage("CotizacionEntitiesDTO", cotizacionEntitiesDTOJson);

            #endregion


            confirmacionPopUp.Mostrar();
            //navigationManager.NavigateTo("/ziren/provincia");
        }
        private async Task MarcaKeyUp(KeyboardEventArgs e)
        {

            oVersionesAutosAuxList = (from c in oVersionesAutosList
                                      where c.descripcion.ToLower().Contains(oVersionDescripcion.ToLower())
                                      select c).ToList();

        }

        private async Task onConfirm()
        {
            confirmacionPopUp.Ocultar();
            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
            oCotizacionAutoDTO.vehiculo.tieneGNC = true;
            oCotizacionAutoDTO.vehiculo.cubreGNC = true;
            CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
            Console.WriteLine(CotizacionAutoDTOJson);
            navigationManager.NavigateTo("/ziren/provincia");

        }

        private async Task onRefuse()
        {

            confirmacionPopUp.Ocultar();
            string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
            CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
            oCotizacionAutoDTO.vehiculo.tieneGNC = false;
            oCotizacionAutoDTO.vehiculo.cubreGNC = false;
            CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
            Console.WriteLine(CotizacionAutoDTOJson);
            navigationManager.NavigateTo("/ziren/provincia");
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
