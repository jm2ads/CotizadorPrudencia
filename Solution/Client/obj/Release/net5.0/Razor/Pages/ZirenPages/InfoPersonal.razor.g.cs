#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a65ee7e68449bbca7aa813b7fdb42358303f92"
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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/infopersonal")]
    public partial class InfoPersonal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Info Personal</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                 marcaID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddAttribute(6, "style", "margin:10px");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-5");
                __builder2.AddMarkupContent(9, "<label style=\"color:white\">Nombre y Apellido</label>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "placeholder", "Nombre y Apellido");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        onombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => onombre = __value, onombre))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => onombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-3");
                __builder2.AddMarkupContent(20, "<label style=\"color:white\">Patente</label>\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Patente");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        opatente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => opatente = __value, opatente))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => opatente));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-4");
                __builder2.AddMarkupContent(31, "<label style=\"color:white\">Fecha de Nacimiento</label>\r\n            ");
                __builder2.OpenElement(32, "div");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonal.TypeInference.CreateInputDate_0(__builder2, 33, 34, "form-control", 35, 
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                             ofechaNacimiento

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ofechaNacimiento = __value, ofechaNacimiento)), 37, () => ofechaNacimiento);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.AddAttribute(41, "style", "margin:10px");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-5");
                __builder2.AddMarkupContent(44, "<label style=\"color:white\">Mail</label>\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Mail");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        omail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => omail = __value, omail))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => omail));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-md-3");
                __builder2.AddMarkupContent(55, "<label style=\"color:white\">Celular</label>\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Sin 0 ni 15");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        otelefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => otelefono = __value, otelefono))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => otelefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "row");
                __builder2.AddAttribute(66, "style", "margin:10px");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-3");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "type", "button");
                __builder2.AddAttribute(71, "class", "btn btn-info");
                __builder2.AddAttribute(72, "style", "width:200px");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                                                       () => OnClickHandle()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(74, "Siguiente");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
       
    [Parameter] public int marcaID { get; set; }
    [Parameter] public int anoID { get; set; }
    [Parameter] public int modeloID { get; set; }
    [Parameter] public int provinciaID { get; set; }

    private string onombre;
    // private string ofechaNacimiento;
    private string omail;
    private string otelefono;
    private string opatente;

    private DateTime? ofechaNacimiento;

    protected override async Task OnInitializedAsync()
    {


        ofechaNacimiento = DateTime.Today.AddYears(-30);



#if DEBUG
        onombre = "Alejandro Sosa";
        omail = "jm2@outlook.com.ar";
        otelefono = "1144406739";
        opatente= UtilidadesString.GetRandomString(6);
#endif
    }

    private async Task OnClickHandle()
    {
        if (string.IsNullOrEmpty(onombre)  || string.IsNullOrEmpty(omail) || string.IsNullOrEmpty(otelefono)  || string.IsNullOrEmpty(opatente) )
        {
            var mensajeError = "Todos los campos son requeridos";
            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }
        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.asegurado.nombre = onombre;
        oCotizacionAutoDTO.asegurado.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");
        oCotizacionAutoDTO.asegurado.mail = omail;
        oCotizacionAutoDTO.asegurado.telefono = otelefono;

        oCotizacionAutoDTO.vehiculo.patente = opatente;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);



        navigationManager.NavigateTo("/ziren/CotizacionRapida");
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
namespace __Blazor.Project.Client.Pages.ZirenPages.InfoPersonal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591