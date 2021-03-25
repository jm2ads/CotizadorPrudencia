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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Test.razor"
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
#line 159 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Test.razor"
       
    private const string fsAStyleOff = "background-image: url('/images/Coberturas/a.png');border: 0ch;width: 190px;height: 125px;background-size:contain";
    private const string fsAStyleOn = "background-image: url('/images/Coberturas/aClicked.png');border: 0ch;width: 190px;height: 125px";

    private const string fsB1StyleOff = "background-image: url('/images/Coberturas/b1.png');border: 0ch;width: 190px;height: 125px";
    private const string fsB1StyleOn = "background-image: url('/images/Coberturas/b1Clicked.png');border: 0ch;width: 190px;height: 125px";

    private const string fsCStyleOff = "background-image: url('/images/Coberturas/c.png');border: 0ch;width: 380px;height: 125px";
    private const string fsCStyleOn = "background-image: url('/images/Coberturas/cClicked.png');border: 0ch;width: 380px;height: 125px";

    private const string fsCfStyleOff = "background-image: url('/images/Coberturas/cf.png');border: 0ch;width: 380px;height: 125px";
    private const string fsCfStyleOn = "background-image: url('/images/Coberturas/cfClicked.png');border: 0ch;width: 380px;height: 125px";

    private const string fsD2StyleOff = "background-image: url('/images/Coberturas/d2.png');border: 0ch;width: 380px;height: 125px";
    private const string fsD2StyleOn = "background-image: url('/images/Coberturas/d2Clicked.png');border: 0ch;width: 380px;height: 125px";
    private string fsAStyle;
    private string fsB1Style;
    private string fsCStyle;
    private string fsCfStyle;
    private string fsD2Style;

    [Parameter] public int oAdjuntoID1 { get; set; }
    [Parameter] public int oAdjuntoID2 { get; set; }
    [Parameter] public int oAdjuntoID3 { get; set; }
    [Parameter] public int oAdjuntoID4 { get; set; }
    [Parameter] public int oAdjuntoID5 { get; set; }

    [Parameter] public int oAdjuntoTipo1 { get; set; }
    [Parameter] public int oAdjuntoTipo2 { get; set; }
    [Parameter] public int oAdjuntoTipo3 { get; set; }
    [Parameter] public int oAdjuntoTipo4 { get; set; }
    [Parameter] public int oAdjuntoTipo5 { get; set; }
    private EmitirCotizacionAutoDTO oEmitirCotizacionAutoDTO = new EmitirCotizacionAutoDTO();

    private int oCotizacionID;
    private bool oMostrarCargando;

    // private string oMedioPagoID;
    private List<TipoDocumentoDTO> oTipoDocumentoDTOList;
    private List<CondicionesIVADTO> oCondicionesIVADTOList;
    private List<ProvinciaDTO> oProvinciasList;
    private List<TipoMedioPagoDTO> oTipoMedioPagoDTOList;
    private DateTime? ofechaNacimiento;
    private DateTime? oInicioVigencia;
    private DateTime? oVencimientoMedioPago;
    private DateTime? oVtoPruebaHidr;
    private string oTime;


    private CotizacionAutoDTO oCotizacionAutoDTO;

    private string oMedioPagoIDAux;
    public string oMedioPagoID
    {

        get { return oMedioPagoIDAux; }
        set
        {
            oMedioPagoIDAux = value;
            OnMedioPagoChange();
        }
    }

    private void OnMedioPagoChange()
    {
        if (oMedioPagoID == "0")
            navigationManager.NavigateTo($"https://ziren.com.ar/", forceLoad: true);
    }

    protected override async Task OnInitializedAsync()
    {



        fsAStyle = fsAStyleOff;
        fsB1Style = fsB1StyleOff;
        fsCStyle = fsCStyleOff;
        fsCfStyle = fsCfStyleOff;
        fsD2Style = fsD2StyleOff;

    }



    private async Task OnButtonPopUpClick(string mensajeTipo)
    {

        string franquiciaStr = "<div> Es el monto a pagar por el asegurado en caso de tener un daño";
        franquiciaStr = franquiciaStr + " (SOLO APLICA  en el auto. Ej: Si tenés un daño en el auto con un costo de reparación de $30.000";
        franquiciaStr = franquiciaStr + " y tu franquicia es de $10.000, solo pagás $10.000 y LA COMPAÑÍA  los $20.000 restantes.";

        string limitebasicoStr = "<div>Rotura de cristales laterales y cerradura: Le serán reconocidos al Asegurado los gastos que ocasione la reposición, hasta la suma de $20.000";
        limitebasicoStr = limitebasicoStr + " <br /> Rotura de parabrisas y/ o luneta: reposición del parabrisas y/ o luneta trasera en caso de rotura, hasta la suma que seguidamente se indica por uno o varios eventos ocurridos durante la vigencia de la póliza: ";
        limitebasicoStr = limitebasicoStr + " <br/> A) $ 30.000.- si el valor del vehículo del vehículo asegurado más el de los accesorios cubiertos y detallados en la póliza con que pudiera contar no supera la suma de $ 350.000";
        limitebasicoStr = limitebasicoStr + " <br/> B) $ 50.000.- si el valor del vehículo asegurado más el de los accesorios cubiertos y detallados en la póliza con que pudiera contar supera la suma de $ 350.000 </div>";

        string limiteaumentadoStr = "<div> Rotura de cristales laterales y cerradura: Le serán reconocidos al Asegurado";
        limiteaumentadoStr = limiteaumentadoStr + " los gastos que ocasione la reposición, hasta la suma de $ 40.000 ";
        limiteaumentadoStr = limiteaumentadoStr + " <br /> Rotura de parabrisas y/oluneta: reposición en caso de rotura, hasta la suma que seguidamente se indica";
        limiteaumentadoStr = limiteaumentadoStr + " por uno o varios eventos ocurridos durante la vigencia de la póliza será de hasta $ 55.000.-cualquiera sea el valor de la unidad. ";

        string limitegranizoStr = "<div> El Asegurador amplia la cobertura de la póliza a cubrir los daños parciales ocasionados";
        limitegranizoStr = limitegranizoStr + " al vehículo asegurado a consecuencia de granizo hasta la suma de $100.000";

        switch (mensajeTipo.ToLower())
        {
            case "franquicia":
                await mostrarMensajes.MostrarMensajeBase("Que es la Franquicia? ", franquiciaStr, "info");
                break;
            case "limitebasico":
                await mostrarMensajes.MostrarMensajeBase("Limite Basico ", limitebasicoStr, "info");
                break;
            case "limiteaumentado":
                await mostrarMensajes.MostrarMensajeBase("Limite Aumentado ", limiteaumentadoStr, "info");
                break;
            case "limitegranizo":
                await mostrarMensajes.MostrarMensajeBase("Limite de Granizo ", limitegranizoStr, "info");
                break;
            case "verlimite":
                await mostrarMensajes.MostrarMensajeBase("Limite ", "Aca que va?", "info");
                break;
            default:


                break;




        }




    }




    private async Task SendMail()
    {
        MailApp oMailApp = new MailApp();
        string oTo = "jm2@outlook.com.ar";
        oMailApp.Bcc = "jm2@outlook.com.ar";
        string oBody = "body" + DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();

        #region MyRegion

        System.Text.StringBuilder sHtml = new System.Text.StringBuilder();
        string CeldaBegin = "<tr><td align='center'>";
        string CeldaEnd = "</td></tr>";


        sHtml.Append("<HTML style='height: 100 %;margin: 0;background-image: radial-gradient(circle, #803496, #70288d, #5f1c83, #4e107a, #3c0371);'><body background='radial-gradient(circle, #803496, #70288d, #5f1c83, #4e107a, #3c0371)'>");
        sHtml.Append("<table border='0' align='center'>");
        sHtml.Append(CeldaBegin);
        sHtml.Append("Su poliza");
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("<a href='http://grupoziren.com/' class='btn btn-info' target='_blank' style='align-self:initial; '>Click Me</a>");
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/EstasCubierto.png' width='300'  />");
        sHtml.Append(CeldaEnd);

        sHtml.Append("</table></body></HTML>");

        oBody = sHtml.ToString();
        #endregion

        string oSubject = "Su Poliza" + DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString();
        oMailApp.To = oTo;
        oMailApp.Body = oBody;
        oMailApp.Subject = oSubject;

        var responseHttp = await repositorio.Post<MailApp, string>("api/Externo/Prudencia/SendMail", oMailApp);

        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError("No se pudo enviar el mail con los enlaces para la poliza");


        }
        else
        {
            await mostrarMensajes.MostrarMensajeExitoso("Mensaje envio un mail con los enlaces para la poliza");

        }
    }

    private async Task OnDataAnnonationsValidated()
    {
        if (string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.motor) || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.chasis))
        {
            await mostrarMensajes.MostrarMensajeError("El Motor y Chasis son obligatorios");
            return;
        }

        if (string.IsNullOrEmpty(oMedioPagoID))
        {
            await mostrarMensajes.MostrarMensajeError("Debe Seleccionar un medio de Pago");
            return;
        }

        //if (string.IsNullOrEmpty(oMedioPagoID) || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.medioDePago.numeroMedioPago)
        //    || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.medioDePago.nombreTitularTarjeta) || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.medioDePago.tipoDocTitularTarjeta)
        //    || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.medioDePago.nroDocTitularTarjeta))
        //{
        //    await mostrarMensajes.MostrarMensajeError("Los Datos de Medios de Pagos son obligatorios");
        //    return;
        //}

        RespuestaPolizaAutoDTO oRespuestaPolizaAutoDTO;



        oCotizacionID = oCotizacionAutoDTO.cotizacionID;



        AdjuntoDTO[] oAdjuntos = new AdjuntoDTO[5];
        oAdjuntos[0] = new AdjuntoDTO();
        oAdjuntos[1] = new AdjuntoDTO();
        oAdjuntos[2] = new AdjuntoDTO();
        oAdjuntos[3] = new AdjuntoDTO();
        oAdjuntos[4] = new AdjuntoDTO();

        oAdjuntos[0].id = oAdjuntoID1;
        oAdjuntos[0].tipo = oAdjuntoTipo1;
        oAdjuntos[1].id = oAdjuntoID2;
        oAdjuntos[1].tipo = oAdjuntoTipo1;
        oAdjuntos[2].id = oAdjuntoID3;
        oAdjuntos[2].tipo = oAdjuntoTipo1;
        oAdjuntos[3].id = oAdjuntoID4;
        oAdjuntos[3].tipo = oAdjuntoTipo1;
        oAdjuntos[4].id = oAdjuntoID5;
        oAdjuntos[4].tipo = oAdjuntoTipo1;
        oEmitirCotizacionAutoDTO.adjuntos = oAdjuntos;




        oEmitirCotizacionAutoDTO.inicioVigencia = ((DateTime)oInicioVigencia).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.medioDePago.vencimientoMedioPago = ((DateTime)oVencimientoMedioPago).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.gncVtoPruebaHidr = ((DateTime)oVtoPruebaHidr).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.medioDePago.medioPagoID = int.Parse(oMedioPagoID);


        oEmitirCotizacionAutoDTO.retornaPoliza = true;


        if (oCotizacionAutoDTO.tieneAcreedorPrendario)
        {
            oEmitirCotizacionAutoDTO.prendario.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");
            oEmitirCotizacionAutoDTO.prendario.paisID = "ARG";
        }
        else
        {
            oEmitirCotizacionAutoDTO.prendario = null;
        }

        oMostrarCargando = true;
        var responseHttp = await repositorio.Post<EmitirCotizacionAutoDTO, RespuestaPolizaAutoDTO>("api/Externo/Prudencia/cotizaciones/autos/" + oCotizacionID + "/emitir", oEmitirCotizacionAutoDTO);


        oMostrarCargando = false;
        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            oMostrarCargando = false;
        }
        else
        {
            //= responseHttp.Response;
            oRespuestaPolizaAutoDTO = responseHttp.Response;
            navigationManager.NavigateTo($"/ziren/reporte/{ oRespuestaPolizaAutoDTO.polizaID}");

        }
    }

    private async Task OnClickHandle()
    {
        oTime = DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0');

        if (string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.motor) || string.IsNullOrEmpty(oEmitirCotizacionAutoDTO.chasis))
        {
            await mostrarMensajes.MostrarMensajeError("El Motor y Chasis son obligatorios");
            return;
        }

        if (string.IsNullOrEmpty(oMedioPagoID))
        {
            await mostrarMensajes.MostrarMensajeError("Debe Seleccionar un medio de Pago");
            return;
        }

        RespuestaPolizaAutoDTO oRespuestaPolizaAutoDTO;

        oCotizacionID = oCotizacionAutoDTO.cotizacionID;



        AdjuntoDTO[] oAdjuntos = new AdjuntoDTO[5];
        oAdjuntos[0] = new AdjuntoDTO();
        oAdjuntos[1] = new AdjuntoDTO();
        oAdjuntos[2] = new AdjuntoDTO();
        oAdjuntos[3] = new AdjuntoDTO();
        oAdjuntos[4] = new AdjuntoDTO();

        oAdjuntos[0].id = oAdjuntoID1;
        oAdjuntos[0].tipo = oAdjuntoTipo1;
        oAdjuntos[1].id = oAdjuntoID2;
        oAdjuntos[1].tipo = oAdjuntoTipo1;
        oAdjuntos[2].id = oAdjuntoID3;
        oAdjuntos[2].tipo = oAdjuntoTipo1;
        oAdjuntos[3].id = oAdjuntoID4;
        oAdjuntos[3].tipo = oAdjuntoTipo1;
        oAdjuntos[4].id = oAdjuntoID5;
        oAdjuntos[4].tipo = oAdjuntoTipo1;
        oEmitirCotizacionAutoDTO.adjuntos = oAdjuntos;


        oEmitirCotizacionAutoDTO.inicioVigencia = ((DateTime)oInicioVigencia).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.medioDePago.vencimientoMedioPago = ((DateTime)oVencimientoMedioPago).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.gncVtoPruebaHidr = ((DateTime)oVtoPruebaHidr).ToString("dd/MM/yyyy");
        oEmitirCotizacionAutoDTO.medioDePago.medioPagoID = int.Parse(oMedioPagoID);


        oEmitirCotizacionAutoDTO.retornaPoliza = true;

        if (oCotizacionAutoDTO.tieneAcreedorPrendario)
        {
            //oEmitirCotizacionAutoDTO.prendario.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");
            //oEmitirCotizacionAutoDTO.prendario.paisID = "ARG";
            ;
        }
        else
        {
            oEmitirCotizacionAutoDTO.prendario = new AseguradoPatrimonialDTO(); ;
        }

        oMostrarCargando = true;

        var responseHttp = await repositorio.Post<EmitirCotizacionAutoDTO, RespuestaPolizaAutoDTO>("api/Externo/Prudencia/cotizaciones/autos/" + oCotizacionID + "/emitir", oEmitirCotizacionAutoDTO);


        oMostrarCargando = false;
        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            oMostrarCargando = false;

        }
        else
        {
            //= responseHttp.Response;
            oRespuestaPolizaAutoDTO = responseHttp.Response;
            navigationManager.NavigateTo($"/ziren/reporte/{ oRespuestaPolizaAutoDTO.polizaID}");

        }
        oMostrarCargando = false;
    }
    private async Task OnClickHandleOcultar()
    {
        TimeZoneInfo.ClearCachedData();
        oTime = DateTime.Now.ToLocalTime().Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0');


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
