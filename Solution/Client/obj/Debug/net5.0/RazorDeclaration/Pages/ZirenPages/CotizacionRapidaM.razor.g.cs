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
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\CotizacionRapidaM.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/CotizacionRapidaM")]
    public partial class CotizacionRapidaM : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 312 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\CotizacionRapidaM.razor"
       


    //private const string btnPolizaStyleOff = "width: 32px;height: 20px;position: absolute;top: 7px;left: 8px;background-color: transparent;background-image: url('/images/Cotizacion/off.png');border: 0;padding: 0";
    //private const string btnPolizaStyleOn = "width: 32px;height: 20px;position: absolute;top: 7px;left: 8px;background-color: transparent;background-image: url('/images/Cotizacion/on.png');border: 0;padding: 0";
    private const string btnPolizaStyleOff = "width: 45px;height: 30px;position: absolute;top: 2px;left: 2px;background-color: transparent;background-image: url('/images/Cotizacion/off.png');border: 0;padding: 0;background-size:contain";
    private const string btnPolizaStyleOn = "width: 45px;height: 30px;position: absolute;top: 2px;left: 2px;background-color: transparent;background-image: url('/images/Cotizacion/on.png');border: 0;padding: 0;background-size:contain";

    private const string fsAStyleOff = "background-image: url('/images/Coberturas/a.png');border: 0ch;width: 190px;height: 125px;background-size:contain";
    private const string fsAStyleOn = "background-image: url('/images/Coberturas/aClicked.png');border: 0ch;width: 190px;height: 125px;background-size:contain";

    private const string fsB1StyleOff = "background-image: url('/images/Coberturas/b1.png');border: 0ch;width: 190px;height: 125px;background-size:contain";
    private const string fsB1StyleOn = "background-image: url('/images/Coberturas/b1Clicked.png');border: 0ch;width: 190px;height: 125px;background-size:contain";

    private const string fsCStyleOff = "background-image: url('/images/Coberturas/c.png');border: 0ch;width: 380px;height: 125px;background-size:contain";
    private const string fsCStyleOn = "background-image: url('/images/Coberturas/cClicked.png');border: 0ch;width: 380px;height: 125px;background-size:contain";

    private const string fsCfStyleOff = "background-image: url('/images/Coberturas/cf.png');border: 0ch;width: 380px;height: 125px;background-size:contain";
    private const string fsCfStyleOn = "background-image: url('/images/Coberturas/cfClicked.png');border: 0ch;width: 380px;height: 125px;background-size:contain";

    private const string fsD2StyleOff = "background-image: url('/images/Coberturas/d2.png');border: 0ch;width: 380px;height: 125px;background-size:contain";
    private const string fsD2StyleOn = "background-image: url('/images/Coberturas/d2Clicked.png');border: 0ch;width: 380px;height: 125px;background-size:contain";

    private string btnPolizaAStyle;
    private string btnPolizaB1Style;
    private string btnPolizaCStyle;
    private string btnPolizaCfStyle;
    private string btnPolizaD2Style;

    private string fsAStyle;
    private string fsB1Style;
    private string fsCStyle;
    private string fsCfStyle;
    private string fsD2Style;


    private string oAntiguedadGrupo = "F";
    private int oGncValor = 0;
    private string oCoberturaIDSeleccionada;
    private decimal oCoberturaValorSeleccionado;

    private string oCobSrc_a;
    private string oCobSrc_b;
    private string oCobSrc_b1;
    private string oCobSrc_c;
    private string oCobSrc_c1;
    private string oCobSrc_cf;
    private string oCobSrc_d2;
    [Parameter] public int modeloID { get; set; }
    //[Inject] protected ServicioSingleton Singleton { get; set; }
    private CotizacionAutoRapidaDTO oCotizacionAutoRapidaDTO = new CotizacionAutoRapidaDTO();
    private RespuestaCotizacionAutoRapidaDTO oRespuestaCotizacionAutoRapidaDTO;
    private CotizacionEntitiesDTO cotizacionEntitiesDTO;


    CotizacionPopUp cotizacionPopUp;
    ModoPopUp modoPopUp;
    int oCoberturaIDSelected;

    private string displayGNC;
    protected override async Task OnInitializedAsync()
    {

        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        btnPolizaAStyle = btnPolizaStyleOff;
        btnPolizaB1Style = btnPolizaStyleOff;
        btnPolizaCStyle = btnPolizaStyleOff;
        btnPolizaCfStyle = btnPolizaStyleOff;
        btnPolizaD2Style = btnPolizaStyleOff;

        fsAStyle = fsAStyleOff;
        fsB1Style = fsB1StyleOff;
        fsCStyle = fsCStyleOff;
        fsCfStyle = fsCfStyleOff;
        fsD2Style = fsD2StyleOff;


        oCobSrc_a = "a";
        oCobSrc_b = "b";
        oCobSrc_b1 = "b1";
        oCobSrc_c = "c";
        oCobSrc_c1 = "c1";
        oCobSrc_cf = "cf";
        oCobSrc_d2 = "d2";

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
        int oAntiguedad = DateTime.Today.Year - oCotizacionAutoDTO.vehiculo.anio;

        if (oCotizacionAutoDTO.vehiculo.tieneGNC == true)
        {
            displayGNC = "block";
        }
        else
        {
            displayGNC = "none";
        }

        if (oAntiguedad <= 10)
        {
            oAntiguedadGrupo = "A";
            if (oCotizacionAutoDTO.vehiculo.tieneGNC == true)
                oGncValor = 60000;
        }
        else
        {
            if (oCotizacionAutoDTO.vehiculo.tieneGNC == true)
                oGncValor = 60000;

            if (oAntiguedad <= 15)
                oAntiguedadGrupo = "B";
            else
            {
                if (oAntiguedad <= 20)
                    oAntiguedadGrupo = "C";
                else
                {
                    if (oAntiguedad <= 25)
                        oAntiguedadGrupo = "D";
                    else
                    {
                        if (oAntiguedad <= 30)
                            oAntiguedadGrupo = "E";
                        else
                            oAntiguedadGrupo = "F";
                    }
                }
            }
        }


        oCotizacionAutoDTO.tieneAcreedorPrendario = false;
        oCotizacionAutoDTO.clausulaAjuste = 20;
        oCotizacionAutoDTO.clausulaAjuste = 0;
        oCotizacionAutoDTO.tipoAjustePrima = "N";
        oCotizacionAutoDTO.porcAjustePrima = 0;
        //oCotizacionAutoDTO.vehiculo.patente = "XXX000";
        oCotizacionAutoDTO.vehiculo.sumaAsegurada = -1;
        oCotizacionAutoDTO.vehiculo.valorGNC = oGncValor;


        //oCotizacionAutoRapidaDTO.cotizacionID = oCotizacionAutoDTO.cotizacionID;
        oCotizacionAutoRapidaDTO.codigoPostal = oCotizacionAutoDTO.asegurado.codigoPostal;
        oCotizacionAutoRapidaDTO.tieneAcreedorPrendario = oCotizacionAutoDTO.tieneAcreedorPrendario;
        oCotizacionAutoRapidaDTO.clausulaAjuste = oCotizacionAutoDTO.clausulaAjuste;
        oCotizacionAutoRapidaDTO.tipoAjustePrima = oCotizacionAutoDTO.tipoAjustePrima;
        oCotizacionAutoRapidaDTO.porcAjustePrima = oCotizacionAutoDTO.porcAjustePrima;

        oCotizacionAutoRapidaDTO.vehiculo = oCotizacionAutoDTO.vehiculo;

        var responseHttp = await repositorio.Post<CotizacionAutoRapidaDTO, RespuestaCotizacionAutoRapidaDTO>("api/Externo/Prudencia/cotizaciones/autosrapida", oCotizacionAutoRapidaDTO);

        if (responseHttp.Error)
        {
            var mensajeError = await responseHttp.GetBody();

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            Console.WriteLine(mensajeError);
            navigationManager.NavigateTo("/ziren/infopersonal");
        }
        else
        {

            oRespuestaCotizacionAutoRapidaDTO = responseHttp.Response;
            oCotizacionAutoDTO.cotizacionID = oRespuestaCotizacionAutoRapidaDTO.cotizacionID;

            CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
            await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
            await OnCoberturaClick("a", oRespuestaCotizacionAutoRapidaDTO.coberturas[1].a);
            Console.WriteLine(CotizacionAutoDTOJson);
        }



    }
    private async Task OnCoberturaClick(string oCoberturaIDStr, decimal Valor)
    {
        int oCoberturaID;
        switch (oCoberturaIDStr)
        {
            case "a":

                if (oCobSrc_a == "aClicked")
                {
                    oCoberturaID = 0;
                    oCoberturaValorSeleccionado = 0;
                    oCoberturaIDSeleccionada = "";
                    oCoberturaIDSelected = 0;

                    fsAStyle = fsAStyleOff;
                    fsB1Style = fsB1StyleOff;
                    fsCStyle = fsCStyleOff;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOff;
                    btnPolizaB1Style = btnPolizaStyleOff;
                    btnPolizaCStyle = btnPolizaStyleOff;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "a";
                    oCobSrc_b1 = "b1";
                    oCobSrc_c = "c";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                else
                {
                    oCoberturaID = 1;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].a;
                    oCoberturaIDSeleccionada = "1";
                    oCoberturaIDSelected = 1;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOff;
                    fsCStyle = fsCStyleOff;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOff;
                    btnPolizaCStyle = btnPolizaStyleOff;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1";
                    oCobSrc_c = "c";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                break;
            case "b1":

                if (oCobSrc_b1 == "b1Clicked")
                {
                    oCoberturaID = 1;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].a;
                    oCoberturaIDSeleccionada = "1";
                    oCoberturaIDSelected = 1;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOff;
                    fsCStyle = fsCStyleOff;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOff;
                    btnPolizaCStyle = btnPolizaStyleOff;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1";
                    oCobSrc_c = "c";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                else
                {
                    oCoberturaID = 2;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].b1;
                    oCoberturaIDSeleccionada = "2";
                    oCoberturaIDSelected = 2;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOff;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOff;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "c";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                break;
            case "c":

                if (oCobSrc_c == "cClicked")
                {
                    oCoberturaID = 2;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].b1;
                    oCoberturaIDSeleccionada = "2";
                    oCoberturaIDSelected = 2;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOff;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOff;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "c";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                else
                {
                    oCoberturaID = 5;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].c;
                    oCoberturaIDSeleccionada = "5";
                    oCoberturaIDSelected = 5;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOn;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOn;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "cClicked";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                break;
            case "cf":

                if (oCobSrc_cf == "cfClicked")
                {
                    oCoberturaID = 5;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].c;
                    oCoberturaIDSeleccionada = "5";
                    oCoberturaIDSelected = 5;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOn;
                    fsCfStyle = fsCfStyleOff;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOn;
                    btnPolizaCfStyle = btnPolizaStyleOff;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "cClicked";
                    oCobSrc_cf = "cf";
                    oCobSrc_d2 = "d2";
                }
                else
                {
                    oCoberturaID = 23;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].cf;
                    oCoberturaIDSeleccionada = "23";
                    oCoberturaIDSelected = 23;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOn;
                    fsCfStyle = fsCfStyleOn;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOn;
                    btnPolizaCfStyle = btnPolizaStyleOn;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "cClicked";
                    oCobSrc_cf = "cfClicked";
                    oCobSrc_d2 = "d2";
                }
                break;
            case "d2":

                if (oCobSrc_d2 == "d2Clicked")
                {
                    oCoberturaID = 23;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].cf;
                    oCoberturaIDSeleccionada = "23";
                    oCoberturaIDSelected = 23;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOn;
                    fsCfStyle = fsCfStyleOn;
                    fsD2Style = fsD2StyleOff;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOn;
                    btnPolizaCfStyle = btnPolizaStyleOn;
                    btnPolizaD2Style = btnPolizaStyleOff;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "cClicked";
                    oCobSrc_cf = "cfClicked";
                    oCobSrc_d2 = "d2";
                }
                else
                {
                    oCoberturaID = 10;
                    oCoberturaValorSeleccionado = @oRespuestaCotizacionAutoRapidaDTO.coberturas[1].d2;
                    oCoberturaIDSeleccionada = "10";
                    oCoberturaIDSelected = 10;

                    fsAStyle = fsAStyleOn;
                    fsB1Style = fsB1StyleOn;
                    fsCStyle = fsCStyleOn;
                    fsCfStyle = fsCfStyleOn;
                    fsD2Style = fsD2StyleOn;

                    btnPolizaAStyle = btnPolizaStyleOn;
                    btnPolizaB1Style = btnPolizaStyleOn;
                    btnPolizaCStyle = btnPolizaStyleOn;
                    btnPolizaCfStyle = btnPolizaStyleOn;
                    btnPolizaD2Style = btnPolizaStyleOn;

                    oCobSrc_a = "aClicked";
                    oCobSrc_b1 = "b1Clicked";
                    oCobSrc_c = "cClicked";
                    oCobSrc_cf = "cfClicked";
                    oCobSrc_d2 = "d2Clicked";
                }
                break;
            default:
                oCoberturaID = 0;
                oCoberturaIDSelected = 0;
                break;




        }
        Console.WriteLine(oCoberturaID);

    }

    private async Task OnConfirmClick(int oCoberturaIDSelectedAux)
    {
        if (oCoberturaIDSelectedAux == 0)
        {
            await mostrarMensajes.MostrarMensajeError("Debe Seleccionar una Cobertura");
            return;

        }
        oCoberturaIDSelected = 0;

        oCoberturaIDSelected = oCoberturaIDSelectedAux;
        Console.WriteLine("oCoberturaIDSelected OnConfirmClick" + oCoberturaIDSelected);
        cotizacionPopUp.Mostrar();

    }

    private async Task onConfirm()
    {
        cotizacionPopUp.Ocultar();
        modoPopUp.Mostrar();

    }
    private async Task onContinuar()
    {
        cotizacionPopUp.Ocultar();
        navigationManager.NavigateTo($"/ziren/infopersonalcompleta/{oCoberturaIDSelected}");
        SendEmail("ModoContinuar");
    }
    private async Task onModoComodo()
    {
        modoPopUp.Ocultar();
        JsRuntime.InvokeAsync<string>("open", $"https://ziren.com.ar/modo-comodo/", "_blank");
        SendEmail("ModoComodo");
    }
    private async Task onPagoEf()
    {
        modoPopUp.Ocultar();
        JsRuntime.InvokeAsync<string>("open", $"https://ziren.com.ar/modo-comodo-efectivo/", "_blank");
        SendEmail("PagoEfectivo");
    }
    private async Task SendEmail(string origen)
    {
        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO cotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
        #region Send Email
        Decimal valor;
        string coberturaStr;
        switch (oCoberturaIDSelected)
        {
            case 1:
                valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].a;
                coberturaStr = "a";
                break;
            case 2:

                valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].b1;
                coberturaStr = "b1";
                break;
            case 5:

                valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].c;
                coberturaStr = "c";
                break;
            case 23:

                valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].cf;
                coberturaStr = "cf";
                break;
            case 10:

                valor = oRespuestaCotizacionAutoRapidaDTO.coberturas[1].d2;
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
        sHtml.Append("Cobertura : " + coberturaStr);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);
        sHtml.Append("Valor : " + valor);
        sHtml.Append(CeldaEnd);


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
        sHtml.Append("Gnc Valor: " + oGncValor);
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

        string oSubject = "Ziren Cotizador=> Nueva Consulta Origen " + origen;

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







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
