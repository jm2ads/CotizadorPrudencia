#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8804d802ec3b7da565be5339acf57b5275f4a31"
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
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ziren/infopersonal")]
    public partial class InfoPersonal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Info Personal</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                 marcaID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddAttribute(6, "style", "margin:10px");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-5");
                __builder2.AddMarkupContent(9, "<label style=\"color:white\">Nombre y Apellido</label>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "placeholder", "Nombre y Apellido");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        onombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => onombre = __value, onombre))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => onombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-3");
                __builder2.AddMarkupContent(20, "<label style=\"color:white\">Fecha de Nacimiento</label>\r\n            ");
                __builder2.OpenElement(21, "div");
                __Blazor.Project.Client.Pages.ZirenPages.InfoPersonal.TypeInference.CreateInputDate_0(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 29 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                             ofechaNacimiento

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ofechaNacimiento = __value, ofechaNacimiento)), 26, () => ofechaNacimiento);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "row");
                __builder2.AddAttribute(30, "style", "margin:10px");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-5");
                __builder2.AddMarkupContent(33, "<label style=\"color:white\">Mail</label>\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Mail");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        omail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => omail = __value, omail))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => omail));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-3");
                __builder2.AddMarkupContent(44, "<label style=\"color:white\">Celular</label>\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Sin 0 ni 15");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                        otelefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => otelefono = __value, otelefono))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => otelefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "row");
                __builder2.AddAttribute(55, "style", "margin:10px");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-3");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "type", "button");
                __builder2.AddAttribute(60, "class", "btn btn-success");
                __builder2.AddAttribute(61, "style", "width:200px");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                                                          () => OnClickHandle()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(63, "Siguiente");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n    <br> <br> <br><br> <br>\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "row");
                __builder2.AddAttribute(67, "style", "margin:10px");
                __builder2.AddAttribute(68, "hidden", 
#nullable restore
#line 57 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                   ! botonDeseoDarDatos

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-md-3");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-success");
                __builder2.AddAttribute(74, "style", "width:200px");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                                                          () => OnClickHandleSinDatos()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "No quiero dejar mis Datos");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 66 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
 if (partnerWhatsapp == string.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Project.Client.Shared.Cargando>(77);
            __builder.CloseComponent();
#nullable restore
#line 69 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
}
else
{
    partner.Celular1 = "54" + partner.Celular1;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "a");
            __builder.AddAttribute(79, "href", "https://wa.me/" + (
#nullable restore
#line 73 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                            partner.Celular1

#line default
#line hidden
#nullable disable
            ) + "?text=" + (
#nullable restore
#line 73 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
                                                   partner.Whatsapp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "title", "Chat with Us");
            __builder.AddAttribute(81, "class", "whatsapp");
            __builder.AddAttribute(82, "target", "_blank");
            __builder.AddAttribute(83, "style", "position: fixed; top: 500px; right: 30px; z-index: 99");
            __builder.AddMarkupContent(84, "<img src=\"../images/whatsapp.png\" style=\"margin-top:0px;margin-left:0px\" height=\"48\" width=\"48\">");
            __builder.CloseElement();
#nullable restore
#line 76 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\ZirenPages\InfoPersonal.razor"
       
    [Parameter] public int marcaID { get; set; }
    [Parameter] public int anoID { get; set; }
    [Parameter] public int modeloID { get; set; }
    [Parameter] public int provinciaID { get; set; }

    private string onombre;
    // private string ofechaNacimiento;
    private string omail;
    private string otelefono;
    private string opatente;

    Partner partner = new Partner();
    private string partnerWhatsapp = string.Empty;

    private bool botonDeseoDarDatos = false;

    private DateTime? ofechaNacimiento;
    private BrowserDimension browserDimension;
    protected override async Task OnInitializedAsync()
    {

        #region busco datos del partner
        string partnerJson = await JsRuntime.GetFromLocalStorage("partner");
        partner = JsonSerializer.Deserialize<Partner>(partnerJson);
        partnerWhatsapp = partner.Whatsapp;
        #endregion

        botonDeseoDarDatos = partner.BotonDeseoDarDatos;
        ofechaNacimiento = DateTime.Today.AddYears(-30);
        browserDimension = await Service.GetDimensions();


#if DEBUG
        onombre = "Alejandro Sosa";
        omail = "jm2@outlook.com.ar";
        otelefono = "1144406739";

#endif
        opatente = UtilidadesString.GetRandomString(6);
    }



    private async Task OnClickHandle()
    {
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
        oCotizacionAutoDTO.asegurado.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");
        oCotizacionAutoDTO.asegurado.mail = omail;
        oCotizacionAutoDTO.asegurado.telefono = otelefono;

        oCotizacionAutoDTO.vehiculo.patente = opatente;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        SendEmail(oCotizacionAutoDTO);

        if (browserDimension.Width > 768)
            navigationManager.NavigateTo("/ziren/CotizacionRapida");
        else
            navigationManager.NavigateTo("/ziren/CotizacionRapidaM");
    }

    private async Task OnClickHandleSinDatos()
    {






        string CotizacionAutoDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionAutoDTO");
        CotizacionAutoDTO oCotizacionAutoDTO = JsonSerializer.Deserialize<CotizacionAutoDTO>(CotizacionAutoDTOJson);

        //oCotizacionAutoDTO.asegurado.nombre = onombre;
        //oCotizacionAutoDTO.asegurado.fechaNacimiento = ((DateTime)ofechaNacimiento).ToString("dd/MM/yyyy");
        //oCotizacionAutoDTO.asegurado.mail = omail;
        //oCotizacionAutoDTO.asegurado.telefono = otelefono;

        oCotizacionAutoDTO.vehiculo.patente = UtilidadesString.GetRandomString(6); ;

        CotizacionAutoDTOJson = JsonSerializer.Serialize(oCotizacionAutoDTO);
        await JsRuntime.SetInLocalStorage("CotizacionAutoDTO", CotizacionAutoDTOJson);
        Console.WriteLine(CotizacionAutoDTOJson);

        SendEmail(oCotizacionAutoDTO);

        if (browserDimension.Width > 768)
            navigationManager.NavigateTo("/ziren/CotizacionRapida");
        else
            navigationManager.NavigateTo("/ziren/CotizacionRapidaM");
    }
    private async Task SendEmail(CotizacionAutoDTO cotizacionAutoDTO)
    {
        string cotizacionEntitiesDTOJson = await JsRuntime.GetFromLocalStorage("CotizacionEntitiesDTO");
        CotizacionEntitiesDTO cotizacionEntitiesDTO = JsonSerializer.Deserialize<CotizacionEntitiesDTO>(cotizacionEntitiesDTOJson);
        #region Send Email




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
        sHtml.Append("Provincia : " + cotizacionEntitiesDTO.provincia.descripcion);
        sHtml.Append(CeldaEnd);

        sHtml.Append(CeldaBegin);

        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/icon-192.png' width='100'  />");
        sHtml.Append("<img src='https://cotice.ziren.com.ar/images/LogoPrudencia.png' width='200'  />");
        sHtml.Append(CeldaEnd);

        sHtml.Append("</table></body></HTML>");


        #endregion

        string oSubject = "Ziren Cotizador=> Nueva Consulta!!!";

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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BrowserService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
namespace __Blazor.Project.Client.Pages.ZirenPages.InfoPersonal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
