#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2508000d702cba248f470a37086049d3236d71a6"
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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/imagenes/{oCoberturaID:int}")]
    public partial class Imagenes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Suba Imagenes del Auto</h3>");
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
 if (oCotizacionAutoDTO == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(1);
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                     oAdjuntos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                               oOnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddAttribute(10, "style", "margin-left:5px");
#nullable restore
#line 19 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
             if (oCotizacionAutoDTO.vehiculo.es0KM == true)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(11);
                __builder2.AddAttribute(12, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 21 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "oLabelText", "Factura");
                __builder2.SetKey(
#nullable restore
#line 21 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                     0

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(16);
                __builder2.AddAttribute(17, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "oLabelText", "Cert. Rodamiento");
                __builder2.SetKey(
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                              1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"

            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(20, "<img src=\"/images/FotosEjemplo.jpg\" alt=\"Fotos\" style=\"display:block;margin:auto;width:50%\">");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(21);
                __builder2.AddAttribute(22, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "oLabelText", "Parte Delantera");
                __builder2.SetKey(
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                             0

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(26);
                __builder2.AddAttribute(27, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "oLabelText", "Parte Trasera");
                __builder2.SetKey(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                           1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(31);
                __builder2.AddAttribute(32, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "oLabelText", "Lateral Izquierdo Completo (Lado Conductor)");
                __builder2.SetKey(
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                                                         2

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(36);
                __builder2.AddAttribute(37, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "oLabelText", "Lateral Derecho Completo (Lado Acompanante)");
                __builder2.SetKey(
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                                                         3

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(41);
                __builder2.AddAttribute(42, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "oLabelText", "Foto 5");
                __builder2.SetKey(
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                    4

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, @"<label style=""color:white;font-size: 0.8em;align-content:center"">
                   SI LAS FOTOS NO SON CORRECTAS O LEGIBLES, SE TE AVISARA POR MAIL Y CELULAR  PARA QUE NOS LA ENVIES CORRECTAMENTE, DE NO HACERLO, LA POLIZA LAMENTABLEMENTE QUEDARA SIN EFECTO.
                </label>");
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"

                
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-success");
                __builder2.AddAttribute(51, "style", "margin:5px");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                         () => OnClick()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "Continuar");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 47 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
       


    AdjuntoDTO[] oAdjuntos = new AdjuntoDTO[5];

    int oAdjuntoID;

    private string imagenTemporal;

    private CotizacionAutoDTO oCotizacionAutoDTO;
    [Parameter] public int oCoberturaID { get; set; }
    protected override async Task OnInitializedAsync()
    {


        #region Cotizacion

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        oCotizacionAutoDTO.cotizacionID = 0;
        RespuestaCotizacionAutoDTO oRespuestaCotizacionAutoDTO;
        var responseHttp = await repositorio.Post<CotizacionAutoDTO, RespuestaCotizacionAutoDTO>("api/Externo/Prudencia/cotizaciones/autos", oCotizacionAutoDTO);
        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            navigationManager.NavigateTo("/ziren/infopersonalCompleta/" + oCoberturaID);
        }
        else
        {

            oRespuestaCotizacionAutoDTO = responseHttp.Response;
            oCotizacionAutoDTO.cotizacionID = oRespuestaCotizacionAutoDTO.cotizacionID;

            //CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            //await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        }


        #endregion





        #region Confirmacion
        //string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        //CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        int oCotizacionID = oCotizacionAutoDTO.cotizacionID;

        ConfirmacionCotizacionAutoDTO oConfirmacionCotizacionAutoDTO = new ConfirmacionCotizacionAutoDTO();
        oConfirmacionCotizacionAutoDTO.coberturaID = oCoberturaID;



        var responseHttp2 = await repositorio.Post<ConfirmacionCotizacionAutoDTO, RespuestaCotizacionAutoDTO>("api/Externo/Prudencia/cotizaciones/autos/" + oCotizacionID + "/confirmar", oConfirmacionCotizacionAutoDTO);
        if (responseHttp2.Error)
        {
            var mensajeError = await responseHttp2.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            navigationManager.NavigateTo("/ziren/infopersonalCompleta");
        }
        else
        {
            oRespuestaCotizacionAutoDTO = responseHttp2.Response;
            oCotizacionAutoDTO.cotizacionID = oRespuestaCotizacionAutoDTO.cotizacionID;
            //CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            //await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        }


        //COMENTAR PARA OBTNER UN 400
        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        #endregion








        //string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        //oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
        oAdjuntos = new AdjuntoDTO[5];

        oAdjuntos[0] = new AdjuntoDTO();
        oAdjuntos[1] = new AdjuntoDTO();
        oAdjuntos[2] = new AdjuntoDTO();
        oAdjuntos[3] = new AdjuntoDTO();
        oAdjuntos[4] = new AdjuntoDTO();

        Console.WriteLine("cotizacionID IMA: " + oCotizacionAutoDTO.cotizacionID);

    }

    private async Task oOnValidSubmit()
    {

    }


    private async Task OnClick()
    {
        Console.WriteLine("111" + oAdjuntos[0].id);
        Console.WriteLine("222" + oAdjuntos[1].id);
        Console.WriteLine("333" + oAdjuntos[2].id);
        Console.WriteLine("444" + oAdjuntos[3].id);
        Console.WriteLine("555" + oAdjuntos[4].id);
        if (oCotizacionAutoDTO.vehiculo.es0KM == true)
        {
            if (oAdjuntos[0].id==0 || oAdjuntos[1].id == 0)
            {
                var mensajeError = "Debe cargar los dos documentos";

                await mostrarMensajes.MostrarMensajeError(mensajeError);
                return;
            }

        }
        else
        {
            int oSumSinFoto = 0;

            if (oAdjuntos[0].id == 0 )
                oSumSinFoto = oSumSinFoto + 1;
            if (oAdjuntos[1].id == 0)
                oSumSinFoto = oSumSinFoto + 1;
            if (oAdjuntos[2].id == 0)
                oSumSinFoto = oSumSinFoto + 1;
            if (oAdjuntos[3].id == 0)
                oSumSinFoto = oSumSinFoto + 1;
            if (oAdjuntos[4].id == 0)
                oSumSinFoto = oSumSinFoto + 1;

            if (oSumSinFoto > 1)
            {
                var mensajeError = "Debe cargar al menos 4 fotos";

                await mostrarMensajes.MostrarMensajeError(mensajeError);
                return;
            }
        }

        navigationManager.NavigateTo($"/ziren/Emision/{oAdjuntos[0].id}/{oAdjuntos[0].tipo}/{oAdjuntos[1].id}/{oAdjuntos[1].tipo}/{oAdjuntos[2].id}/{oAdjuntos[2].tipo}/{oAdjuntos[3].id}/{oAdjuntos[3].tipo}/{oAdjuntos[4].id}/{oAdjuntos[4].tipo}");






    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
