using Microsoft.JSInterop;
using Project.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {


        public async static ValueTask<string> ObtenerEstatusPermisoNotificaciones(this IJSRuntime js)
        {
            return await js.InvokeAsync<string>("obtenerEstatusPermisoNotificaciones");
        }

        public async static ValueTask<Notificacion> SuscribirANotificaciones(this IJSRuntime js)
        {
            return await js.InvokeAsync<Notificacion>("suscribirUsuario");
        }

        public async static ValueTask<Notificacion> DesuscribirANotificaciones(this IJSRuntime js)
        {
            return await js.InvokeAsync<Notificacion>("desuscribirUsuario");
        }



        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            await js.InvokeVoidAsync("console.log", "prueba de console.log");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }

        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content)
     => js.InvokeAsync<object>(
     "localStorage.setItem",
     key, content
     );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key)
            => js.InvokeAsync<object>(
                "localStorage.removeItem",
                key);








    }
}
