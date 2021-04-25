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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/infopersonalcompleta/{oCoberturaID:int}")]
    public partial class InfoPersonalCompleta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonalCompleta.razor"
       


    [Parameter] public int oCoberturaID { get; set; }

    private string onombre;
    private string omail;
    private string otelefono;
    private string opatente;
    private DateTime? ofechaNacimiento;



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

        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);
        onombre= oCotizacionAutoDTO.asegurado.nombre;
        omail=oCotizacionAutoDTO.asegurado.mail;
        otelefono= oCotizacionAutoDTO.asegurado.telefono;
        opatente = "";// oCotizacionAutoDTO.vehiculo.patente;
        ofechaNacimiento = Convert.ToDateTime(oCotizacionAutoDTO.asegurado.fechaNacimiento,  new System.Globalization.CultureInfo("es-ES"));

        otipoDocumento = "81";
        ocondicionIVA = "4";
#if DEBUG

        oPrefijo = 20;
        oNumeroDocumento = 18205329;
        oDigitoVerif = 6;

        odomicilio = "Enrique Prins ";
        odomicilioNumero = 1469;
        odomicilioPiso = 0;
        odomicilioDpto = "-";

        otipoDocumento = "81";
        ocondicionIVA = "4";

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

        if (string.IsNullOrEmpty(onombre) || string.IsNullOrEmpty(omail) || string.IsNullOrEmpty(otelefono) || string.IsNullOrEmpty(opatente))
        {
            var mensajeError = "Todos los campos son requeridos";
            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }

        if (!(new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(omail)))
        {
            var mensajeError = "El Mail debe ser Valido";
            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }
        if (otelefono.Length < 10)
        {
            var mensajeError = "El Telefono debe ser Valido";
            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }

        Int64 number;

        bool Isnumber = Int64.TryParse(otelefono, out number);
        if (!Isnumber)
        {
            var mensajeError = "El Telefono debe ser Solo Numerico";
            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }




        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);


        oCotizacionAutoDTO.asegurado.nombre = onombre;
        oCotizacionAutoDTO.asegurado.mail = omail;
        oCotizacionAutoDTO.asegurado.telefono = otelefono;
        oCotizacionAutoDTO.asegurado.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");

        oCotizacionAutoDTO.vehiculo.patente= opatente.ToUpper();





        oCotizacionAutoDTO.asegurado.sexo = osexo;
        oCotizacionAutoDTO.asegurado.tipoDocumento = otipoDocumento;
        oCotizacionAutoDTO.asegurado.numeroDocumento = oNroDoc;
        oCotizacionAutoDTO.asegurado.condicionIVA = ocondicionIVA;


        oCotizacionAutoDTO.asegurado.domicilio = odomicilio;
        oCotizacionAutoDTO.asegurado.domicilioNumero = odomicilioNumero;
        oCotizacionAutoDTO.asegurado.domicilioPiso = odomicilioPiso;
        oCotizacionAutoDTO.asegurado.domicilioDpto = odomicilioDpto;

        //oCotizacionAutoDTO.asegurado.localidad = "Localidad TODO";
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
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioSingleton Singleton { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
