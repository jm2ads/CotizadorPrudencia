#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3a0392f6c754cace70c81c4f5d14561e307248"
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
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">SUBA IMÁGENES DEL AUTO</h3>\r\n");
            __builder.AddMarkupContent(1, @"<div class=""container-fluid"" style=""display: block;display: flex;justify-content:center;align-items: center;align-content:center;margin-left:auto;margin-right:auto""><span style=""color:white;font-size: 0.6em;align-content:initial;margin-bottom:10px"">
        LAS FOTOS DEBEN SER TOMADAS COMO INDICA LA IMAGEN DE EJEMPLO. DEBEN SER TOMADAS CON BUENA ILUMINACION
        ( DE DIA O BUENA ILUMINACIÓN ARTIFICIAL), TODAS DE UN MISMO MOMENTO Y  LUGAR,ACTUALES DEL DIA DE LA FECHA .
        CON LAS VENTANILLAS CERRADAS (NO CON LAS VENTANILLAS BAJAS ).
        <br>
        PUEDES SELECCIONAR DE TU GALERÍA DE FOTOS O TOMAR LA FOTO. VERÁS LA IMAGEN SELECCIONADA Y UNA VEZ QUE APARECE EL BOTÓN SUBIR,
        LO PRESIONAMOS PARA TERMINAR DE CARGAR LA IMAGEN
    </span></div>");
#nullable restore
#line 18 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
 if (oCotizacionAutoDTO == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(2);
            __builder.CloseComponent();
#nullable restore
#line 21 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                     oAdjuntos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                               oOnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container-fluid");
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
             if (oCotizacionAutoDTO.vehiculo.es0KM == true)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(11);
                __builder2.AddAttribute(12, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "oLabelText", "Factura");
                __builder2.SetKey(
#nullable restore
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
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
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "oLabelText", "Cert. Rodamiento");
                __builder2.SetKey(
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                              1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
#nullable restore
#line 32 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(20, "<img src=\"/images/Cotizacion/front.png\" alt=\"Fotos\" style=\"display:block;margin:auto;width:33%\">\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(21);
                __builder2.AddAttribute(22, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       0

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "oLabelText", "Parte Delantera");
                __builder2.SetKey(
#nullable restore
#line 36 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                             0

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "<img src=\"/images/Cotizacion/back.png\" alt=\"Fotos\" style=\"display:block;margin:auto;width:33%\">\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(26);
                __builder2.AddAttribute(27, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "oLabelText", "Parte Trasera");
                __builder2.SetKey(
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                           1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "<img src=\"/images/Cotizacion/left.png\" alt=\"Fotos\" style=\"display:block;margin:auto;width:33%\">\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(31);
                __builder2.AddAttribute(32, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "oLabelText", "Lateral Izquierdo Completo (Lado Conductor)");
                __builder2.SetKey(
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                                                         2

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "<img src=\"/images/Cotizacion/right.png\" alt=\"Fotos\" style=\"display:block;margin:auto;width:33%\">\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(36);
                __builder2.AddAttribute(37, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "oLabelText", "Lateral Derecho Completo (Lado Acompanante)");
                __builder2.SetKey(
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                                                         3

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "<img src=\"/images/Cotizacion/gncTubo.png\" alt=\"Fotos\" style=\"display:block;margin:auto;width:25%\">\r\n                ");
                __builder2.OpenComponent<Project.Client.Pages.ZirenPages.FormularioImagenRow>(41);
                __builder2.AddAttribute(42, "oAdjuntos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Project.Shared.PrudenciaDTOs.AdjuntoDTO[]>(
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                oAdjuntos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "oAdjuntoID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                       4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "oLabelText", "Si tiene equipo GNC subir foto del cilindro si no dejar vacío");
                __builder2.SetKey(
#nullable restore
#line 48 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
                                                                                                                                                           4

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, @"<label style=""color:white;font-size: 0.8em;align-content:center"">
                    EL VEHÍCULO DEBE ESTAR EN BUENAS CONDICIONES PARA PODER ASEGURARSE.
                    ADVERTENCIA: SI LAS FOTOS CARGADAS NO SON CORRECTAS O LEGIBLES, TE CONTACTAREMOS A LA BREVEDAD POSIBLE POR MAIL Y CELULAR. PARA QUE PUEDAS TOMAR LAS FOTOS CORRECTAS Y ENVIARLAS. DE NO HACERLO EL SEGURO LAMENTABLEMENTE QUEDARÁ SIN EFECTO .
                </label>");
#nullable restore
#line 54 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
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
#line 58 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
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
#line 61 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Imagenes.razor"
       


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

          
        }


        #endregion





        #region Confirmacion
      
        int oCotizacionID = oCotizacionAutoDTO.cotizacionID;

        ConfirmacionCotizacionAutoDTO oConfirmacionCotizacionAutoDTO = new ConfirmacionCotizacionAutoDTO();
        oConfirmacionCotizacionAutoDTO.coberturaID = oCoberturaID;



        var responseHttp2 = await repositorio.Post<ConfirmacionCotizacionAutoDTO, RespuestaCotizacionAutoDTO>("api/Externo/Prudencia/cotizaciones/autos/" + oCotizacionID + "/confirmar", oConfirmacionCotizacionAutoDTO);
        if (responseHttp2.Error)
        {
            var mensajeError = await responseHttp2.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            navigationManager.NavigateTo("/ziren/infopersonalCompleta/"+ oCoberturaID);
        }
        else
        {
            oRespuestaCotizacionAutoDTO = responseHttp2.Response;
            oCotizacionAutoDTO.cotizacionID = oRespuestaCotizacionAutoDTO.cotizacionID;
          
        }


        //COMENTAR PARA OBTNER UN 400
        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        #endregion

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
            if (oAdjuntos[0].id == 0 || oAdjuntos[1].id == 0)
            {
                var mensajeError = "Debe cargar los dos documentos";

                await mostrarMensajes.MostrarMensajeError(mensajeError);
                return;
            }

        }
        else
        {
            int oSumSinFoto = 0;

            if (oAdjuntos[0].id == 0)
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
