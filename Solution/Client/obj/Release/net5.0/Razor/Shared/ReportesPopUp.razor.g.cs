#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2114a3947c83e68edd024bacc7076639a001489c"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Shared
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
    public partial class ReportesPopUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
 if (MostrarConfirmacion)
{



#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display: block;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddAttribute(18, "id", "exampleModalLabel");
            __builder.AddContent(19, 
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                                                    Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "close");
            __builder.AddAttribute(25, "data-dismiss", "modal");
            __builder.AddAttribute(26, "aria-label", "Close");
            __builder.AddMarkupContent(27, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-body");
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                     if (oRespuestaReporteDTOList == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenComponent<Project.Client.Shared.Cargando>(33);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(36, "div");
            __builder.OpenElement(37, "text");
            __builder.AddContent(38, 
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                       oRespuestaPolizaImpresionDTO.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                         for (int i = 0; i <= oRespuestaReporteDTOList.Count() - 1; i++)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(41, "div");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", 
#nullable restore
#line 41 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                              oRespuestaReporteDTOList[i].urlReporte

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "target", "_blank");
            __builder.AddAttribute(45, "class", "btn btn-info");
            __builder.AddAttribute(46, "style", "width:250px");
            __builder.AddContent(47, 
#nullable restore
#line 41 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                                                                                                                                oRespuestaReporteDTOList[i].reporte

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                                                                                                                   
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                \r\n\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-footer");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-secondary");
            __builder.AddAttribute(55, "data-dismiss", "modal");
            __builder.AddMarkupContent(56, "\r\n                        Cancelar\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
                                      onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddContent(62, "Ok");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Shared\ReportesPopUp.razor"
       
    private bool MostrarConfirmacion = false;
    [Parameter] public string Titulo { get; set; } = "Confirmación";
    [Parameter] public  List<RespuestaReporteDTO> oRespuestaReporteDTOList { get; set; }
    [Parameter] public RespuestaPolizaImpresionDTO oRespuestaPolizaImpresionDTO { get; set; }
    
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter] public EventCallback onConfirm { get; set; }
    //  [Parameter] public EventCallback onCancel { get; set; }
    public void Mostrar() => MostrarConfirmacion = true;
    public void Ocultar() => MostrarConfirmacion = false;


    protected override async Task OnInitializedAsync()
    {




    }




    void onCancel()
    {
        MostrarConfirmacion = false;
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
