using Microsoft.AspNetCore.Mvc;
using Project.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Threading.Tasks;

namespace Project.Server.Controllers
{
    [Route("api/notificaciones")]
    [ApiController]
    public class NotificacionesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public NotificacionesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost("suscribir")]
        public async Task<ActionResult> Suscribir(Notificacion notificacion)
        {
            context.Add(notificacion);
            try { 
           await context.SaveChangesAsync();
                return this.Ok();
            }
            catch (Exception ex)
            {
                return this.BadRequest(error: new { message = ex.InnerException.Message });

            }
          
            //return NoContent();
        }


        [HttpPost("suscribir2")]
        public async Task<ActionResult> Suscribir2(Notificacion notificacion)
        {
            
            try
            {
                int a = 0;
                 a = a + 1;

                  return this.Ok();
            }
            catch (Exception ex)
            {
                return this.BadRequest(error: new { message = ex.InnerException.Message });

            }

            //return NoContent();
        }



        [HttpPost("desuscribir")]
        public async Task<ActionResult> Desuscribir(Notificacion notificacion)
        {
            var notificacionDB = context.Notificaciones
                .FirstOrDefault(x => x.Auth == notificacion.Auth && x.P256dh == notificacion.P256dh);

            if (notificacionDB == null) { return NotFound(); }

            context.Remove(notificacionDB);
            await context.SaveChangesAsync();
            return NoContent();
        }


        [HttpPost("TextToSpeech")]
        public async Task<ActionResult> TextToSpeech(string textToSpeech)
        {
            string appId = "2EDD9625CFAE53A9545DD9DE9B87FD3C5111B4D7";
            string language = "es";
            try
            {
                string uri2 = "http://api.microsofttranslator.com/v2/Http.svc/Speak?appId=" + appId + "&text=" + textToSpeech + "&language=" + language;

                string uri = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=Esto+es+una+pruebaaaaa&tl=es";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
                WebResponse resp = httpWebRequest.GetResponse();
                Stream strm = resp.GetResponseStream();
                SoundPlayer player = new SoundPlayer(strm);
                player.Play();
            }
            catch (Exception ex)
            {
                //return false;
            }
            return NoContent();
        }



    }
}
