#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2788fb96bd65f52fed2b5d410afc7fa01186b0b1"
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
    public partial class FormularioImagenRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                 oAdjuntos

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row align-items-center");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-8");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Project.Client.Shared.InputImg>(10);
                __builder2.AddAttribute(11, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                              oLabelText

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "ImagenSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                                                              ImagenSeleccionada

#line default
#line hidden
                )));
                __builder2.AddAttribute(13, "ImagenTemporal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                                                                                                   imagenTemporal

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-4");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-success");
                __builder2.AddAttribute(21, "hidden", 
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                                                     oButtonHid

#line default
#line hidden
                );
                __builder2.AddAttribute(22, "type", "button");
                __builder2.AddAttribute(23, "style", "height: 50px;vertical-align:middle");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                                                                                                                                      () => OnClickHandle(oImageStr)

#line default
#line hidden
                ));
                __builder2.AddContent(25, "Subir ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "span");
                __builder2.AddAttribute(28, "style", "display: inline-block; margin-right: 5px;");
                __builder2.OpenElement(29, "img");
                __builder2.AddAttribute(30, "src", "/images/wait.gif");
                __builder2.AddAttribute(31, "hidden", 
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
                                                                                                         oImgHid

#line default
#line hidden
                );
                __builder2.AddAttribute(32, "style", "width: 50px; height: 50px");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 16 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\FormularioImagenRow.razor"
       
    [Parameter] public int oAdjuntoID { get; set; }
    [Parameter] public AdjuntoDTO[] oAdjuntos { get; set; }
    [Parameter] public string oLabelText { get; set; }
    //[Parameter] public EventCallback oOnValidSubmit { get; set; }

    private string imagenTemporal;
    bool oButtonHid = true;
    bool oImgHid = true;
    string oImageStr;
    private async Task ImagenSeleccionada(string imagenBase64)
    {
        oButtonHid = false;
        oImageStr = imagenBase64;
    }

    private async Task OnClickHandle(string oImagenBase64)
    {
        ImagenDTO[] oImagenDTO = new ImagenDTO[1];
        oImgHid = false;
        var responseHttp = await repositorio.Post<string, ImagenDTO[]>("api/Externo/Prudencia/imagenes/Post64File", oImagenBase64);
        oImagenDTO = responseHttp.Response;
        oButtonHid = true;
        oImgHid = true;

        oAdjuntos[oAdjuntoID].id = oImagenDTO[0].id;
        oAdjuntos[oAdjuntoID].tipo = 2;
        Console.WriteLine("nombreArchivo" + oImagenDTO[0].nombreArchivo);

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
