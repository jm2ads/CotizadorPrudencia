#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db3bf47e2ce502af7420fcf2b3ada0759cf11a1"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages.Map
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.DTOs;

#line default
#line hidden
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
using AspNetMonsters.Blazor.Geolocation;

#line default
#line hidden
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
using System.Text.Json;

#line default
#line hidden
#line 14 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
using System.Timers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/map/index")]
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:white\">Su Envio</h3>\r\n");
#line 18 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
 if (location == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Project.Client.Shared.Cargando>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#line 21 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"

}
else
{

#line default
#line hidden
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "color:white");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "label");
            __builder.AddAttribute(8, "style", "color:white;font-size:small");
            __builder.AddContent(9, "Lat: ");
            __builder.AddContent(10, 
#line 26 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
                                                     location.Latitude

#line default
#line hidden
            );
            __builder.AddContent(11, " - Long: ");
            __builder.AddContent(12, 
#line 26 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
                                                                                location.Longitude

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "  <br>\r\n    ");
            __builder.OpenElement(14, "label");
            __builder.AddAttribute(15, "style", "color: white;font-size:smaller");
            __builder.AddContent(16, "Time: ");
            __builder.AddContent(17, 
#line 27 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
                                                         oTime

#line default
#line hidden
            );
            __builder.AddContent(18, " - Precision: ");
            __builder.AddContent(19, 
#line 27 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
                                                                             location.Accuracy

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#line 30 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(22, "<div id=\"myMap\" style=\"height: 500px\"></div>");
        }
        #pragma warning restore 1998
#line 33 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor"
       
    Timer timer;

    private Location location;
    private string oTime;
    private string mapUser;
    private string permisoNotificaciones = string.Empty;
    //[Inject]
    //protected IJSRuntime JSRuntime { get; set; }
    //[Inject]
    //protected LocationService LocationService { get; set; }



    protected override async Task OnInitializedAsync()
    {
        
        //var currentLocation = await LocationService.GetLocationAsync();
        //location = await LocationService.GetLocationAsync();
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            mapUser = await js.GetFromLocalStorage("mapUser");
            if (string.IsNullOrEmpty(mapUser))
            {
                mapUser = Guid.NewGuid().ToString();
#if DEBUG
                mapUser = "ADFS";
#endif
                await js.SetInLocalStorage("mapUser", mapUser);
            }



            var urlBase = navigationManager.BaseUri;
            await js.InvokeVoidAsync("initialize", urlBase, mapUser, null);
        }
    }



    protected override void OnInitialized()
    {
        timer = new Timer();
        timer.Interval = 5000;
        timer.Elapsed += TimerOntimer;
        timer.Start();

    }
    private async void TimerOntimer(object sender, ElapsedEventArgs e)
    {

        location = await LocationService.GetLocationAsync();
        
        CurrentLocation currentLocation = new CurrentLocation();
        currentLocation.message = mapUser;




        currentLocation.timestamp = DateTime.Now.Second;
        Iss_Position iss_Position = new Iss_Position();
        iss_Position.latitude = location.Latitude.ToString();
        iss_Position.longitude = location.Longitude.ToString();
        currentLocation.iss_position = iss_Position;

        var httpResponse = await repositorio.Post<CurrentLocation, DateTime>("api/CurrentLocations", currentLocation);
        if (httpResponse.Error)
        {
            oTime = "Error de Geolocalizacion ";
        }
        else
        {

            //DateTime dateTime=    httpResponse.Response;
            //oTime = dateTime.ToLongTimeString();
            DateTime.Now.Second.ToString();

            oTime = DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Second.ToString().PadLeft(2, '0');
        }

        StateHasChanged();
    }













    public void Dispose()
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocationService LocationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageManager LocalStorageManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
