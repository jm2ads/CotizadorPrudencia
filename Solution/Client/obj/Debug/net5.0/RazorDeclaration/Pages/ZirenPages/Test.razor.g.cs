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
#line 6 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Test.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Test.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\adfs\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Test.razor"
               
            private Employee employee = new Employee();

            private void HandleValidSubmit()
            {
                Console.WriteLine("OnValidSubmit");
            }
            public class Employee
            {
                public int ID { get; set; } = 1;
                public string Name { get; set; } = "Nancy";
            }


            List<RespuestaReporteDTO> oRespuestaReporteDTOList;

            private BrowserDimension browserDimension;

            private ElementReference username;
            private int browserDimensionWidth;

            public async Task SetFocusAsync()
            {
                username.FocusAsync();
                // await username.FocusAsync(JsRuntime);
                Console.WriteLine("Mando True");
                await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "employeeName", true);
            }
            public async Task SetFocusAsync2()
            {
                await JSRuntime.InvokeVoidAsync("JsFunctions.focusElementB", "employeeName");
                Console.WriteLine("Mando False");
                await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "employeeName", false);
            }

            public async Task SetDisableAsync()
            {
                await username.DisableAsync(JSRuntime);
                //  await username.DisableAsync(JsRuntime);

            }


            public async Task GetBrowserDimension()
            {
                browserDimension = await Service.GetDimensions();
                browserDimensionWidth = browserDimension.Width;



                RespuestaReporteDTO[] oRespuestaReporteDTOListAux = new RespuestaReporteDTO[2];

                oRespuestaReporteDTOListAux[0] = new RespuestaReporteDTO();
                oRespuestaReporteDTOListAux[1] = new RespuestaReporteDTO();
                oRespuestaReporteDTOListAux[0].reporte = "111111111111111";
                oRespuestaReporteDTOListAux[0].urlReporte = "111111111111111";
                oRespuestaReporteDTOListAux[1].reporte = "2222222";
                oRespuestaReporteDTOListAux[1].urlReporte = "2222222222";

                // SendEmail(oRespuestaReporteDTOListAux);

            }

            protected override async Task OnInitializedAsync()
            {


                RespuestaReporteDTO[] oRespuestaReporteDTOListAux = new RespuestaReporteDTO[7];

                var responseHttp = await repositorio.Get<RespuestaReporteDTO[]>($"api/Externo/Prudencia/polizas/16686793/reportes");
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






                      SendEmail(oRespuestaReporteDTOListAux);


                }



            }

            private async Task SendEmail(RespuestaReporteDTO[] oRespuestaReporteDTOListAux)
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



            public static string LeeArchivo(string rutaArchivo)
            {
                StreamReader sr = new StreamReader(@"D:\JM2\WP\CotizadorPrudencia\Solution\Client\wwwroot\templateMail.html");
                string contenido = sr.ReadToEnd();
                sr.Close();
                return contenido;
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BrowserService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
