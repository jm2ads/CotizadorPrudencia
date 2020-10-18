using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.Shared.PrudenciaDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebPush;

namespace Project.Server.Helpers
{
    public class NotificacionesService 
    {
        private readonly IConfiguration configuration;
        private readonly ApplicationDbContext context;
      
        public NotificacionesService(IConfiguration configuration, ApplicationDbContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }
      

        public async Task EnviarNotificacionPeliculaEnCartelera(RespuestaCotizacionAutoRapidaDTO oRespuestaCotizacionAutoRapidaDTO,string oUrlRaiz)
        {
            var notificaciones = await context.Notificaciones.ToListAsync();// Busco todos a quienes notificar

            var llavePublica = configuration.GetValue<string>("notificaciones:llave_publica");
            var llavePrivada = configuration.GetValue<string>("notificaciones:llave_privada");
            var email = configuration.GetValue<string>("notificaciones:email");

            var vapidDetails = new VapidDetails(email, llavePublica, llavePrivada);
        

            foreach (var notificacion in notificaciones)
            {
                var pushSubscription = new PushSubscription(notificacion.URL,
                    notificacion.P256dh, notificacion.Auth);

                var webPushClient = new WebPushClient();
                   
                try
                {
                    var payload = JsonSerializer.Serialize(new
                    {
                        titulo =  oRespuestaCotizacionAutoRapidaDTO.nroCotizacion,
                        imagen = oUrlRaiz + "/images/pt.jpg",
                        url = $"Index"
                    });

                    await webPushClient.SendNotificationAsync(pushSubscription, payload, vapidDetails);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // ...
                }
            }

        }
    }
}
