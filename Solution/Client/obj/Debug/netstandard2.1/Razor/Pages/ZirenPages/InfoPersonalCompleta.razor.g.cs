#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1812a619130aa0d8605eb43736fe66150776febf"
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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/infopersonalcompleta/{oCoberturaID:int}")]
    public partial class InfoPersonalCompleta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Info Personal</h3>\r\n");
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
 if (oTipoDocumentoDTOList == null || oCondicionesIVADTOList == null)
{

#line default
#line hidden
            __builder.OpenComponent<Project.Client.Shared.Cargando>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                     oCoberturaID

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddAttribute(10, "style", "margin:10px");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-2");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label style=\"color:white\">Tipo Doc.</label>\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputSelect_0(__builder2, 18, 19, "form-control", 20, 
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              otipoDocumento

#line default
#line hidden
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => otipoDocumento = __value, otipoDocumento)), 22, () => otipoDocumento, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                        ");
                    __builder3.AddMarkupContent(25, "<option value>Tipo Doc ...</option>\r\n");
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                         foreach (var oTipoDocumento in oTipoDocumentoDTOList)
                            {

#line default
#line hidden
                    __builder3.AddContent(26, "                            ");
                    __builder3.OpenElement(27, "option");
                    __builder3.AddAttribute(28, "value", 
#line 27 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                            oTipoDocumento.tipoDocumentoID

#line default
#line hidden
                    );
                    __builder3.AddContent(29, 
#line 27 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                                                             oTipoDocumento.nombre

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n");
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                            }

#line default
#line hidden
                    __builder3.AddContent(31, "                    ");
                }
                );
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-md-5");
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.AddMarkupContent(38, "<label style=\"color:white\">Nro. Doc.</label>\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputNumber_1(__builder2, 42, 43, "form-control", 44, "width:65px;", 45, "99", 46, 
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              oPrefijo

#line default
#line hidden
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oPrefijo = __value, oPrefijo)), 48, () => oPrefijo);
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.AddMarkupContent(50, "<label style=\"color:white;vertical-align:central\">-</label>\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputNumber_2(__builder2, 51, 52, "form-control", 53, "width:120px;", 54, "9999999999", 55, 
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              oNumeroDocumento

#line default
#line hidden
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oNumeroDocumento = __value, oNumeroDocumento)), 57, () => oNumeroDocumento);
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.AddMarkupContent(59, "<label style=\"color:white\">-</label>\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputNumber_3(__builder2, 60, 61, "form-control", 62, "width:55px;", 63, "9", 64, 
#line 40 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              oDigitoVerif

#line default
#line hidden
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oDigitoVerif = __value, oDigitoVerif)), 66, () => oDigitoVerif);
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n        ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "row");
                __builder2.AddAttribute(73, "style", "margin:10px");
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-2");
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.AddMarkupContent(78, "<label style=\"color:white\">Sexo</label>\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddMarkupContent(80, "\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputSelect_4(__builder2, 81, 82, "form-control", 83, 
#line 49 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              osexo

#line default
#line hidden
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => osexo = __value, osexo)), 85, () => osexo, 86, (__builder3) => {
                    __builder3.AddMarkupContent(87, "\r\n                        ");
                    __builder3.AddMarkupContent(88, "<option value>Sexo ...</option>\r\n                        ");
                    __builder3.AddMarkupContent(89, "<option value=\"F\">Femenino</option>\r\n                        ");
                    __builder3.AddMarkupContent(90, "<option value=\"M\">Masculino</option>\r\n                    ");
                }
                );
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "col-md-3");
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.AddMarkupContent(97, "<label style=\"color:white\">Condicion Iva</label>\r\n                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputSelect_5(__builder2, 100, 101, "form-control", 102, 
#line 62 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                              ocondicionIVA

#line default
#line hidden
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ocondicionIVA = __value, ocondicionIVA)), 104, () => ocondicionIVA, 105, (__builder3) => {
                    __builder3.AddMarkupContent(106, "\r\n                        ");
                    __builder3.AddMarkupContent(107, "<option value>Iva ...</option>\r\n");
#line 64 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                         foreach (var oCondicionesIVA in oCondicionesIVADTOList)
                            {

#line default
#line hidden
                    __builder3.AddContent(108, "                            ");
                    __builder3.OpenElement(109, "option");
                    __builder3.AddAttribute(110, "value", 
#line 66 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                            oCondicionesIVA.condicionIVAID

#line default
#line hidden
                    );
                    __builder3.AddContent(111, 
#line 66 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                                                             oCondicionesIVA.nombre

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n");
#line 67 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                            }

#line default
#line hidden
                    __builder3.AddContent(113, "                    ");
                }
                );
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-md-3");
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.AddMarkupContent(120, "<label style=\"color:white\">Tiene Acreedor Prendario?</label>\r\n                ");
                __builder2.OpenElement(121, "div");
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(123);
                __builder2.AddAttribute(124, "style", "margin-left:20px");
                __builder2.AddAttribute(125, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 74 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                                oprendario

#line default
#line hidden
                ));
                __builder2.AddAttribute(126, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oprendario = __value, oprendario))));
                __builder2.AddAttribute(127, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => oprendario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n\r\n        ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "row");
                __builder2.AddAttribute(134, "style", "margin:10px");
                __builder2.AddMarkupContent(135, "\r\n           \r\n\r\n            ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "col-md-7");
                __builder2.AddMarkupContent(138, "\r\n                ");
                __builder2.AddMarkupContent(139, "<label style=\"color:white\">Domicilio Calle</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                __builder2.AddAttribute(141, "class", "form-control");
                __builder2.AddAttribute(142, "placeholder", "Calle");
                __builder2.AddAttribute(143, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 87 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                        odomicilio

#line default
#line hidden
                ));
                __builder2.AddAttribute(144, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => odomicilio = __value, odomicilio))));
                __builder2.AddAttribute(145, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => odomicilio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n            ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "col-md-2");
                __builder2.AddMarkupContent(150, "\r\n                ");
                __builder2.AddMarkupContent(151, "<label style=\"color:white\">Nro</label>\r\n                ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputNumber_6(__builder2, 152, 153, "form-control", 154, "Nro", 155, 
#line 91 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                          odomicilioNumero

#line default
#line hidden
                , 156, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => odomicilioNumero = __value, odomicilioNumero)), 157, () => odomicilioNumero);
                __builder2.AddMarkupContent(158, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n            ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "col-md-2");
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.AddMarkupContent(163, "<label style=\"color:white\">Piso</label>\r\n                ");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta.TypeInference.CreateInputNumber_7(__builder2, 164, 165, "form-control", 166, "Piso", 167, 
#line 95 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                          odomicilioPiso

#line default
#line hidden
                , 168, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => odomicilioPiso = __value, odomicilioPiso)), 169, () => odomicilioPiso);
                __builder2.AddMarkupContent(170, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.OpenElement(172, "div");
                __builder2.AddAttribute(173, "class", "col-md-1");
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.AddMarkupContent(175, "<label style=\"color:white\">Dto</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(176);
                __builder2.AddAttribute(177, "class", "form-control");
                __builder2.AddAttribute(178, "placeholder", "Dto");
                __builder2.AddAttribute(179, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 99 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                        odomicilioDpto

#line default
#line hidden
                ));
                __builder2.AddAttribute(180, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => odomicilioDpto = __value, odomicilioDpto))));
                __builder2.AddAttribute(181, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => odomicilioDpto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(182, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(185, "button");
                __builder2.AddAttribute(186, "type", "button");
                __builder2.AddAttribute(187, "class", "btn btn-info");
                __builder2.AddAttribute(188, "style", "width:200px");
                __builder2.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 105 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
                                                                                   () => OnClickHandle()

#line default
#line hidden
                ));
                __builder2.AddContent(190, "Confirma Cotizacion");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(191, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(192, "\r\n");
#line 107 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 112 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
       


    [Parameter] public int oCoberturaID { get; set; }
    private string osexo;
    private string otipoDocumento;


    private int? oPrefijo;
    private int? oNumeroDocumento;
    private int? oDigitoVerif;

    private bool oprendario;
    private string ocondicionIVA;

    private string odomicilio;
    private int odomicilioNumero;
    private int odomicilioPiso;
    private string odomicilioDpto;
    private string opaisID = "ARG";


    private List<TipoDocumentoDTO> oTipoDocumentoDTOList;
    private List<CondicionesIVADTO> oCondicionesIVADTOList;

    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<TipoDocumentoDTO>>("api/Externo/Prudencia/catalogos/GetTiposDocumentos");
        oTipoDocumentoDTOList = responseHttp.Response;

        oTipoDocumentoDTOList = (from c in oTipoDocumentoDTOList
                                 where c.tipoDocumentoID == "80" || c.tipoDocumentoID == "81" || c.tipoDocumentoID == "83"
                                 select c).ToList();




        var responseHttp2 = await repositorio.Get<List<CondicionesIVADTO>>("api/Externo/Prudencia/catalogos/GetCondicionesIva");
        oCondicionesIVADTOList = responseHttp2.Response;

#if DEBUG

        oPrefijo = 20;
        oNumeroDocumento = 18205329;
        oDigitoVerif = 6;

        odomicilio = "Enrique Prins ";
        odomicilioNumero = 1469;
        odomicilioPiso = 0;
        odomicilioDpto = "-";
#endif
    }
    private async Task OnClickHandle()
    {
        string oNroDoc = oPrefijo.ToString().Trim() + oNumeroDocumento.ToString().Trim() + oDigitoVerif.ToString().Trim();
        if (!(UtilidadesString.ValidateCUIT(oNroDoc)))
        {
            var mensajeError = "Nro de Documento Invalido";

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }

        if (string.IsNullOrEmpty(osexo) || string.IsNullOrEmpty(otipoDocumento)
            || string.IsNullOrEmpty(ocondicionIVA) || string.IsNullOrEmpty(odomicilio) )
        {
            var mensajeError = "Todos los campos son requeridos";

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.asegurado.sexo = osexo;
        oCotizacionAutoDTO.asegurado.tipoDocumento = otipoDocumento;
        oCotizacionAutoDTO.asegurado.numeroDocumento = oNroDoc;
        oCotizacionAutoDTO.asegurado.condicionIVA = ocondicionIVA;


        oCotizacionAutoDTO.asegurado.domicilio = odomicilio;
        oCotizacionAutoDTO.asegurado.domicilioNumero = odomicilioNumero;
        oCotizacionAutoDTO.asegurado.domicilioPiso = odomicilioPiso;
        oCotizacionAutoDTO.asegurado.domicilioDpto = odomicilioDpto;

        oCotizacionAutoDTO.asegurado.localidad = "Localidad TODO";
        oCotizacionAutoDTO.asegurado.paisID = opaisID;


        oCotizacionAutoDTO.tieneAcreedorPrendario= oprendario;


        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        //navigationManager.NavigateTo($"/ziren/cotizacion/{oCoberturaID}");
        navigationManager.NavigateTo($"/ziren/imagenes/{oCoberturaID}");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioSingleton Singleton { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
namespace __Blazor.Project.Client.Pages.ZirenPages.InfoPersonalCompleta
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "max", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "max", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "max", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
