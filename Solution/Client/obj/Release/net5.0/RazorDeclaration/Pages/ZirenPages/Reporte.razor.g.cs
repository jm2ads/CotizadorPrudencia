// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Reporte.razor"
       
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




            string reporteAux = "";

            oRespuestaReporteDTOListAux = responseHttp.Response;
            oRespuestaReporteDTOList = new List<RespuestaReporteDTO>();
            for (int i = 0; i <= oRespuestaReporteDTOListAux.Count() - 1; i++)
            {
                switch (oRespuestaReporteDTOListAux[i].reporte)
                {
                    case "TarjetaCirculacion.pdf":
                        reporteAux = "TARJETA DE CIRCULACION";
                        break;
                    case "Poliza.pdf":
                        reporteAux = "POLIZA";
                        break;
                    case "Factura.pdf":
                        reporteAux = "FACTURA";
                        break;
                    case "TarjetaMercosur.pdf":
                        reporteAux = "MERCOSUR";
                        break;
                    case "Clausulas.pdf":
                        reporteAux = "CLAUSULAS";
                        break;
                    default:
                        continue;

                        break;

                }


                RespuestaReporteDTO oRespuestaReporteDTO = new RespuestaReporteDTO();
                oRespuestaReporteDTO.reporte = reporteAux;// oRespuestaReporteDTOListAux[i].reporte;
                oRespuestaReporteDTO.urlReporte = oRespuestaReporteDTOListAux[i].urlReporte;

                oRespuestaReporteDTOList.Add(oRespuestaReporteDTO);

            }




            SendPolizaMail(oRespuestaReporteDTOListAux);

            SendEmail(oRespuestaReporteDTOListAux);
        }





    }
    private async Task SendEmail(RespuestaReporteDTO[] oRespuestaReporteDTOListAux)
    {
        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO cotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
        #region Send Email
        Decimal valor;
        string coberturaStr;

        switch (cotizacionAutoDTO.cotizacionID)
        {
            case 1:
                //valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].a;
                coberturaStr = "a";
                break;
            case 2:

                //valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].b1;
                coberturaStr = "b1";
                break;
            case 5:

                //valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].c;
                coberturaStr = "c";
                break;
            case 23:

                //valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].cf;
                coberturaStr = "cf";
                break;
            case 10:

                //valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].d2;
                coberturaStr = "d2";
                break;
            default:
                valor = 0;
                coberturaStr = "error";
                break;




        }

        //
        #region MyRegion

        System.Text.StringBuilder sHtml = new System.Text.StringBuilder();
        string CeldaBegin = "<tr><td align='left'>";
        string CeldaEnd = "</td></tr>";


        sHtml.Append("<HTML style='height: 100 %;margin: 0;background-image: radial-gradient(circle, #803496, #70288d, #5f1c83, #4e107a, #3c0371);'><body >");
        sHtml.Append("<table border='0' align='center'>");
        sHtml.Append(CeldaBegin);
        sHtml.Append("Nombre : " + cotizacionAutoDTO.asegurado.nombre);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        RespuestaReporteDTO respuestaReporteDTO = (from c in oRespuestaReporteDTOListAux
                                                   where c.reporte == "Poliza.pdf"
                                                   select c).FirstOrDefault();
        sHtml.Append("<a href='" + respuestaReporteDTO.urlReporte + "' target='_blank'>PÓLIZA</a>");
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Cobertura : " + coberturaStr);
        sHtml.Append(CeldaEnd);


        sHtml.Append(CeldaBegin);
        sHtml.Append("Suma Asegurada : " + cotizacionAutoDTO.vehiculo.sumaAsegurada);
        sHtml.Append(CeldaEnd);

        //sHtml.Append(CeldaBegin);
        //sHtml.Append("Valor : " + valor);
        //sHtml.Append(CeldaEnd);


        sHtml.Append(CeldaBegin);
        sHtml.Append("Mail : " + cotizacionAutoDTO.asegurado.mail);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Tel : " + cotizacionAutoDTO.asegurado.telefono);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Fec.Nac : " + cotizacionAutoDTO.asegurado.fechaNacimiento);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("C.P. : " + cotizacionAutoDTO.asegurado.codigoPostal);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Marca : " + cotizacionEntitiesDTO.marcasAutos.descripcion);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Modelo : " + cotizacionEntitiesDTO.modelosAutos.descripcionGrupo);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Version : " + cotizacionEntitiesDTO.versionesAutos.descripcion);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Ano : " + cotizacionEntitiesDTO.ano);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Gnc : " + cotizacionAutoDTO.vehiculo.tieneGNC);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Gnc Valor: " + cotizacionAutoDTO.vehiculo.valorGNC);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Provincia : " + cotizacionEntitiesDTO.provincia.descripcion);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);

        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/icon-192.png' width='100'  />");
        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/LogoPrudencia.png' width='200'  />");
        sHtml.Append(CeldaEnd);

        sHtml.Append("</table></body></HTML>");


        #endregion

        string oSubject = "Ziren Cotizador=> Nueva Poliza 💪💪💪 ";

        MailApp oMailApp = new MailApp();
        oMailApp.To = "clientes@ziren.com.ar";
        //oMailApp.Bcc = "jm2@outlook.com.ar";
        oMailApp.Body = sHtml.ToString();
        oMailApp.Subject = oSubject;

        var responseHttp = await repositorio.Post<MailApp, string>("api/Externo/Prudencia/SendMail", oMailApp);

        if (responseHttp.Error)
        {
            Console.WriteLine("No se pudo enviar el mail con los enlaces para la poliza");

        }
        else
        {
            Console.WriteLine("Se le envio un mail con los enlaces para la poliza");
        }







        #endregion
    }

    private async Task SendPolizaMail(RespuestaReporteDTO[] oRespuestaReporteDTOListAux)
    {

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        MailApp oMailApp = new MailApp();
        string oSubject = "Ziren => Enlaces de tu Poliza";
        oMailApp.To = oCotizacionAutoDTO.asegurado.mail;
        oMailApp.Bcc = "clientes@ziren.com.ar";
        // oMailApp.Body = oBody;
        oMailApp.Subject = oSubject;


        SendPolizaMailDTO sendPolizaMailDTO = new SendPolizaMailDTO();
        sendPolizaMailDTO.mailApp = oMailApp;
        sendPolizaMailDTO.cotizacionAutoDTO = oCotizacionAutoDTO;
        sendPolizaMailDTO.cotizacionEntitiesDTO = cotizacionEntitiesDTO;
        sendPolizaMailDTO.respuestaReporteDTOList = oRespuestaReporteDTOList;
        var responseHttp2 = await repositorio.Post<SendPolizaMailDTO, string>("api/Externo/Prudencia/SendPolizaMail", sendPolizaMailDTO);

        if (responseHttp2.Error)
        {
            var mensajeError = await responseHttp2.GetBody();

            await mostrarMensajes.MostrarMensajeError("No se pudo enviar el mail con los enlaces para la poliza");


        }
        else
        {
            await mostrarMensajes.MostrarMensajeExitoso("Se le envio un mail con los enlaces para la poliza");

        }
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
