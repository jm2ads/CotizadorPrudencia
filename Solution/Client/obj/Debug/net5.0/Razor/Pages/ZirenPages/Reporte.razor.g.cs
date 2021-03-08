#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0331ac45dbf58340164afe3cf5c6748289cee1b4"
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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/reporte/{polizaID:int}")]
    public partial class Reporte : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Ya tenes tu Seguro!!!</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4 style=\"color:white\">Descargue sus Reportes</h4>");
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
 if (oRespuestaReporteDTOList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenComponent<Project.Client.Shared.Cargando>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
     for (int i = 0; i <= oRespuestaReporteDTOList.Count() - 1; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(7, "div");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", 
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
                          oRespuestaReporteDTOList[i].urlReporte

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "target", "_blank");
            __builder.AddAttribute(11, "class", "btn btn-info");
            __builder.AddAttribute(12, "style", "width:250px");
            __builder.AddContent(13, 
#nullable restore
#line 22 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
                                                                                                                            oRespuestaReporteDTOList[i].reporte

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
       
    [Parameter] public int polizaID { get; set; }

    List<RespuestaReporteDTO> oRespuestaReporteDTOList;


    protected override async Task OnInitializedAsync()
    {


        RespuestaReporteDTO[] oRespuestaReporteDTOListAux = new RespuestaReporteDTO[7];

        var responseHttp = await repositorio.Get<RespuestaReporteDTO[]>($"api/Externo/Prudencia/polizas/{polizaID}/reportes");
        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
        }
        else
        {




            oRespuestaReporteDTOListAux = responseHttp.Response;
            oRespuestaReporteDTOList = new List<RespuestaReporteDTO>();
            for (int i = 0; i <= oRespuestaReporteDTOListAux.Count() - 1; i++)
            {
                RespuestaReporteDTO oRespuestaReporteDTO = new RespuestaReporteDTO();
                oRespuestaReporteDTO.reporte = oRespuestaReporteDTOListAux[i].reporte;
                oRespuestaReporteDTO.urlReporte = oRespuestaReporteDTOListAux[i].urlReporte;

                oRespuestaReporteDTOList.Add(oRespuestaReporteDTO);
            }



            SendEmail( oRespuestaReporteDTOListAux);


        }





    }


    private async Task SendEmail(RespuestaReporteDTO[] oRespuestaReporteDTOListAux)
    {
        #region Send Email
        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);


        MailApp oMailApp = new MailApp();
        string oTo = oCotizacionAutoDTO.asegurado.mail;
        string oBody = "body" + DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();

        #region MyRegion

        System.Text.StringBuilder sHtml = new System.Text.StringBuilder();
        string CeldaBegin = "<tr><td align='left'>";
        string CeldaEnd = "</td></tr>";


        sHtml.Append("<HTML style='height: 100 %;margin: 0;background-image: radial-gradient(circle, #803496, #70288d, #5f1c83, #4e107a, #3c0371);'><body >");
        sHtml.Append("<table border='0' align='center'>");
        sHtml.Append(CeldaBegin);

        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/EstasCubierto.png' width='200'  />");
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Auto " + cotizacionEntitiesDTO.marcasAutos.descripcion + "/" + cotizacionEntitiesDTO.modelosAutos.descripcionGrupo + "/" + cotizacionEntitiesDTO.versionesAutos.descripcion + "/" + cotizacionEntitiesDTO.ano.ToString());
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Asegurado " + oCotizacionAutoDTO.asegurado.nombre);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Su poliza nro " + polizaID);
        sHtml.Append(CeldaEnd);







        for (int i = 0; i <= oRespuestaReporteDTOListAux.Count() - 1; i++)
        {

            sHtml.Append(CeldaBegin);
            sHtml.Append("<a href='" + oRespuestaReporteDTOListAux[i].urlReporte + "' class='btn btn-info' target='_blank' style='align-self:initial; '>" + oRespuestaReporteDTOListAux[i].reporte + "</a>");
            sHtml.Append(CeldaEnd);
        }











        sHtml.Append(CeldaBegin);
        //sHtml.Append("<img src='{0}/images/EstasCubierto.png' width='300' />");
        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/icon-192.png' width='100'  />");
        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/LogoPrudencia.png' width='200'  />");
        sHtml.Append(CeldaEnd);

        sHtml.Append("</table></body></HTML>");

        oBody = sHtml.ToString();
        #endregion

        string oSubject = "Ziren => Enlaces de tu Poliza";
        oMailApp.To = oTo;
        oMailApp.Bcc = "adriel@ziren.com.ar";
        oMailApp.Body = oBody;
        oMailApp.Subject = oSubject;

        var responseHttp = await repositorio.Post<MailApp, string>("api/Externo/Prudencia/SendMail", oMailApp);

        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp   .GetBody();

            await mostrarMensajes.MostrarMensajeError("No se pudo enviar el mail con los enlaces para la poliza");


        }
        else
        {
            await mostrarMensajes.MostrarMensajeExitoso("Se le envio un mail con los enlaces para la poliza");

        }







        #endregion
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