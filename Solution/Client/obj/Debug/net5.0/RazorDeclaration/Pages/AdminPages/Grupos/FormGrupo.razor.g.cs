// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project.Client.Pages.AdminPages.Grupos
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
    public partial class FormGrupo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 227 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\AdminPages\Grupos\FormGrupo.razor"
       
    [Parameter] public Grupo grupo { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    private int? oPrefijo;
    private int? oNumeroDocumento;
    private int? oDigitoVerif;


    private string posterTemporal;

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(grupo.Logo))
        {
            posterTemporal = grupo.Logo;


            // grupo.Logo = null;           VER ASOSA
        }

        //if(grupo.CUIT.Length==11
        if (!string.IsNullOrEmpty(grupo.CUIT))
        {
            oPrefijo =int.Parse( grupo.CUIT.Substring(0,2));
            oNumeroDocumento = int.Parse(grupo.CUIT.Substring(2, 8));
            oDigitoVerif = int.Parse(grupo.CUIT.Substring(10, 1));
        }
    }
    private void ImagenSeleccionada(string imagenBase64)
    {
        grupo.Logo = imagenBase64;
        posterTemporal = null;
    }
    private void CuitOnChange()
    {
        grupo.CUIT= oPrefijo.ToString().Trim() + oNumeroDocumento.ToString().Trim() + oDigitoVerif.ToString().Trim();
    }
    private async Task OnDataAnnonationsValidated()
    {



        if (!string.IsNullOrWhiteSpace(grupo.Logo))
        {
            posterTemporal = null;
        }

        await OnValidSubmit.InvokeAsync(null);
    }
    private async Task SaveOnClick()
    {



        if (!string.IsNullOrWhiteSpace(grupo.Logo))
        {
            posterTemporal = null;
        }


        #region Valido Form
        if (string.IsNullOrEmpty(grupo.Url) || string.IsNullOrEmpty(grupo.Nombre) || string.IsNullOrEmpty(grupo.Apellido) || string.IsNullOrEmpty(grupo.Dni)
            || string.IsNullOrEmpty(grupo.Matricula) || string.IsNullOrEmpty(grupo.Mail) || string.IsNullOrEmpty(grupo.Celular1) || string.IsNullOrEmpty(grupo.Domicilio)
            || string.IsNullOrEmpty(grupo.Localidad) || string.IsNullOrEmpty(grupo.Logo) || string.IsNullOrEmpty(grupo.Whatsapp))
        {

            await mostrarMensajes.MostrarMensajeError("Los Campos => Url, Nombre, Apellido, Dni, Matricula, Mail, Celular1, Domicilio," +
                " Localidad, Logo y Whatsapp son Obligatorios");
            return;
        }


        if (!(UtilidadesString.ValidateCUIT(grupo.CUIT)))
        {
            var mensajeError = "Nro de Documento Invalido";

            await mostrarMensajes.MostrarMensajeError(mensajeError);
            return;
        }

        #endregion
        await OnValidSubmit.InvokeAsync(null);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
    }
}
#pragma warning restore 1591
