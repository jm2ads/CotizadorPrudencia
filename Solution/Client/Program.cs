using Blazor.FileReader;
using Project.Client.Helpers;
using Project.Client.Repositorios;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AspNetMonsters.Blazor.Geolocation;
using System.Globalization;

namespace Project.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var cultureDefault = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureDefault;
            CultureInfo.DefaultThreadCurrentUICulture = cultureDefault;


            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServicioSingleton>();
            services.AddTransient<ServicioTransient>();
            services.AddScoped<IRepositorio, Repositorio>();
            services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            services.AddScoped<ILocalStorageManager, LocalStorageManager>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            services.AddSingleton<LocationService>();
        }
    }
}
