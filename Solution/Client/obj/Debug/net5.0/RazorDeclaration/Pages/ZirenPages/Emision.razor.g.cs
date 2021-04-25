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
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Emision.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/emision/{oAdjuntoID1:int}/{oAdjuntoTipo1:int}/{oAdjuntoID2:int}/{oAdjuntoTipo2:int}/{oAdjuntoID3:int}/{oAdjuntoTipo3:int}/{oAdjuntoID4:int}/{oAdjuntoTipo4:int}/{oAdjuntoID5:int}/{oAdjuntoTipo5:int}")]
    public partial class Emision : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 323 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\Emision.razor"
       

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

    private List<TipoDocumentoDTO> oTipoDocumentoDTOList;
    private List<CondicionesIVADTO> oCondicionesIVADTOList;
    private List<ProvinciaDTO> oProvinciasList;
    private List<TipoMedioPagoDTO> oTipoMedioPagoDTOList = new List<TipoMedioPagoDTO>();
    private DateTime? ofechaNacimiento;
    private DateTime? oInicioVigencia;
    private string oVencimientoMedioPago;
    private string oVencimientoMedioPagoAno;
    private string oVencimientoMedioPagoMes;
    private DateTime? oVtoPruebaHidr;



    private CotizacionAutoDTO oCotizacionAutoDTO;
    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("b111" + oAdjuntoID1);
        Console.WriteLine("b222" + oAdjuntoID2);
        Console.WriteLine("b333" + oAdjuntoID3);
        Console.WriteLine("b444" + oAdjuntoID4);
        Console.WriteLine("b555" + oAdjuntoID5);

        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNumeroMedioPago", false);
        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNombreTitularTarjeta", false);
        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoMes", false);
        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoAno", false);
        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtTipoDocTitularTarjeta", false);
        //await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNroDocTitularTarjeta", false);


        oMostrarCargando = false;
        string CotizacionAutoDTOJson = await JSRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        var responseHttp = await repositorio.Get<List<TipoDocumentoDTO>>("api/Externo/Prudencia/catalogos/GetTiposDocumentos");
        oTipoDocumentoDTOList = responseHttp.Response;

        oTipoDocumentoDTOList = (from c in oTipoDocumentoDTOList
                                 where c.tipoDocumentoID == "80" || c.tipoDocumentoID == "81" || c.tipoDocumentoID == "83"
                                 select c).ToList();




        var responseHttp2 = await repositorio.Get<List<CondicionesIVADTO>>("api/Externo/Prudencia/catalogos/GetCondicionesIva");
        oCondicionesIVADTOList = responseHttp2.Response;

        var responseHttp3 = await repositorio.Get<List<ProvinciaDTO>>("api/Externo/Prudencia/catalogos/GetProvincias");
        oProvinciasList = responseHttp3.Response;

        var responseHttp4 = await repositorio.Get<List<TipoMedioPagoDTO>>("api/Externo/Prudencia/catalogos/GetMediosDePago");
        List<TipoMedioPagoDTO> oTipoMedioPagoDTOListAux = responseHttp4.Response;
        foreach (TipoMedioPagoDTO tipoMedioPagoDTO in oTipoMedioPagoDTOListAux)
        {
            if (tipoMedioPagoDTO.medioPagoID == "0")
                continue;
            if (tipoMedioPagoDTO.medioPagoID == "3")
                tipoMedioPagoDTO.nombre = "TARJETA DE CREDITO - MERCADO PAGO";

            oTipoMedioPagoDTOList.Add(tipoMedioPagoDTO);
        }


;


        oEmitirCotizacionAutoDTO.medioDePago = new MedioPagoDTO();
        oEmitirCotizacionAutoDTO.prendario = new AseguradoPatrimonialDTO();
        oEmitirCotizacionAutoDTO.adjuntos = new AdjuntoDTO[5];

        oInicioVigencia = DateTime.Today;
        oVencimientoMedioPagoAno = DateTime.Today.Day.ToString().PadLeft(2, '0');
        oVencimientoMedioPagoMes = DateTime.Today.Year.ToString();
        oVtoPruebaHidr = DateTime.Today;
        ofechaNacimiento = DateTime.Today.AddYears(-40);
#if DEBUG


        oEmitirCotizacionAutoDTO.motor = "XXXXXhathat";
        oEmitirCotizacionAutoDTO.chasis = "XXXXX";
        oEmitirCotizacionAutoDTO.observaciones = "XXXXX";
        oVencimientoMedioPagoAno = DateTime.Today.AddMonths(10).Day.ToString().PadLeft(2, '0');
        oVencimientoMedioPagoMes = DateTime.Today.AddMonths(10).Year.ToString();
        oEmitirCotizacionAutoDTO.medioDePago.numeroMedioPago = "4338330002590988";
        oEmitirCotizacionAutoDTO.medioDePago.nombreTitularTarjeta = "Noguera Adriel";
        oEmitirCotizacionAutoDTO.medioDePago.tipoDocTitularTarjeta = "DNI";
        oEmitirCotizacionAutoDTO.medioDePago.nroDocTitularTarjeta = "37683118";




        oEmitirCotizacionAutoDTO.gncMarca = "Marca";
        oEmitirCotizacionAutoDTO.gncCapacidad = 30;
        oEmitirCotizacionAutoDTO.gncOblea = "oblea4667";
        oEmitirCotizacionAutoDTO.gncRegulador = "Regulador";



        oEmitirCotizacionAutoDTO.prendario.nombre = "nombre";
        oEmitirCotizacionAutoDTO.prendario.numeroDocumento = "20182053297";
        ofechaNacimiento = DateTime.Now.AddYears(-40);
        oEmitirCotizacionAutoDTO.prendario.domicilio = "domicilio";
        oEmitirCotizacionAutoDTO.prendario.domicilioNumero = 2346;
        oEmitirCotizacionAutoDTO.prendario.domicilioPiso = 8;
        oEmitirCotizacionAutoDTO.prendario.domicilioDpto = "B";
        oEmitirCotizacionAutoDTO.prendario.localidad = "localidad";
        oEmitirCotizacionAutoDTO.prendario.codigoPostal = "1429";
        oEmitirCotizacionAutoDTO.prendario.telefono = "1144487654";
        oEmitirCotizacionAutoDTO.prendario.mail = "XXXXX@XX.com";

#endif

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
        if ((DateTime)oInicioVigencia < DateTime.Today || (DateTime)oInicioVigencia > DateTime.Today.AddDays(10))
        {
            await mostrarMensajes.MostrarMensajeError("La Fecha de Inicio de Vigencia no puede ser menor a hoy ni mayor a 10 dias a partir de hoy");
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

        oEmitirCotizacionAutoDTO.medioDePago.vencimientoMedioPago = oVencimientoMedioPagoMes + "/" + oVencimientoMedioPagoAno;

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
        oEmitirCotizacionAutoDTO.medioDePago.vencimientoMedioPago = oVencimientoMedioPagoMes + "/" + oVencimientoMedioPagoAno;
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
            // navigationManager.NavigateTo($"/ziren/Emision/{oAdjuntos[0].id}/{oAdjuntos[0].tipo}/{oAdjuntos[1].id}/{oAdjuntos[1].tipo}/{oAdjuntos[2].id}/{oAdjuntos[2].tipo}/{oAdjuntos[3].id}/{oAdjuntos[3].tipo}/{oAdjuntos[4].id}/{oAdjuntos[4].tipo}");

        }
        else
        {
            //= responseHttp.Response;
            oRespuestaPolizaAutoDTO = responseHttp.Response;
            navigationManager.NavigateTo($"/ziren/reporte/{ oRespuestaPolizaAutoDTO.polizaID}");

        }
    }

    private async void OnMedioPagoChange()
    {

        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNumeroMedioPago", false);
        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNombreTitularTarjeta", false);
        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoMes", false);
        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoAno", false);
        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtTipoDocTitularTarjeta", false);
        await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNroDocTitularTarjeta", false);
        if (oMedioPagoID == "2")
        {

            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNumeroMedioPago", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNombreTitularTarjeta", true);

        }
        else
        {
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNumeroMedioPago", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNombreTitularTarjeta", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoMes", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "cmbVencimientoMedioPagoAno", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtTipoDocTitularTarjeta", true);
            await JSRuntime.InvokeVoidAsync("JsFunctions.enableElementB", "txtNroDocTitularTarjeta", true);
        }
        // await JsRuntime.InvokeAsync<string>("open", $"https://ziren.com.ar/modo-comodo/", "_blank");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
