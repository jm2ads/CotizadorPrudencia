#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db3bf47e2ce502af7420fcf2b3ada0759cf11a1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
