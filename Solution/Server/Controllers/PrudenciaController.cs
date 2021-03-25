using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server;
using Project.Shared.PrudenciaDTOs;
using Project.Shared.Entidades;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using System.Net;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;
using Project.Server.Helpers;
using System.Net.Mail;
//using System.Web.Http;

namespace Project.Server.Controllers
{
    [Route("api/Externo/[controller]")]
    [ApiController]
    public class PrudenciaController : ControllerBase
    {
        private IMemoryCache oMemoryCache;
        private readonly IConfiguration oConfiguration;
        private readonly NotificacionesService oNotificacionesService;
      
        private string oUriBase;
        private string oUser;
        private string oPassword;



        //private Login oLogin;
        public PrudenciaController(IMemoryCache memoryCache, IConfiguration configuration,NotificacionesService notificacionesService)
        {
            oMemoryCache = memoryCache;
            oConfiguration = configuration;
            this.oNotificacionesService = notificacionesService;


            oUriBase = oConfiguration["prudencia_UriBase"];
            oUser = oConfiguration["prudencia_user"];
            oPassword = oConfiguration["prudencia_password"];
        }


        [HttpPost("login")]
        public async Task<ActionResult<Login>> GetLogin([FromBody] UserPassWord UserPassWord)
        {
            //  https://localhost:44331/api/Externo/Prudencia/login/user/password

            Login oLogin = null;
            HttpClient httpClient = new HttpClient();

            string url = "https://www.prudenciaseguros.com.ar/APIPrudenciaUAT/api/account/login";
            //var enviarJSON = JsonSerializer.Serialize(user);
            var enviarJSON = "{ 'user': '586701',  'password': '586701'}";

            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                oLogin = JsonConvert.DeserializeObject<Login>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oLogin);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            return oLogin;
        }


        private async Task<Login> GetLoginAsync()
        {
            //  https://localhost:44331/api/Externo/Prudencia/login/user/password


            bool? oRerescarLogin;

            Login oLogin = oMemoryCache.Get("LoginKey") as Login;
            if (oLogin != null)
            {
                if (DateTime.Parse(oLogin.accessTokenExpirationDate) > DateTime.Now)
                {
                    oRerescarLogin = false;
                }
                else
                {
                    oRerescarLogin = true;
                }
            }
            else
            {
                oRerescarLogin = true;
            }
            if (oRerescarLogin == false)
            {
                return oLogin;
            }



            UserPassWord oUserPassWord = new UserPassWord();
            oUserPassWord.user = oUser;
            oUserPassWord.password = oPassword;


            //Login oLogin = null;
            HttpClient httpClient = new HttpClient();

            string url = oUriBase + "/account/login";
            var enviarJSON = JsonConvert.SerializeObject(oUserPassWord);
           
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                oLogin = JsonConvert.DeserializeObject<Login>(responseHttp.Content.ReadAsStringAsync().Result);
                oMemoryCache.Set("LoginKey", oLogin, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(5)));
            }
            else
            {

            }
            return oLogin;
        }


        [HttpGet("catalogos/GetMarcasAutos")]
        public async Task<ActionResult<List<MarcasAutos>>> GetMarcasAutos()
        {

            Login oLogin = await GetLoginAsync();

            //https://localhost:44331/api/Externo/Prudencia/GetMarcasAutos/{accessToken}
            string oToken = "Bearer " + oLogin.accessToken;

            List<MarcasAutos> oMarcasAutosList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetMarcasAutos";
          

            //var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.GetAsync(url);


            if (responseHttp.IsSuccessStatusCode)
            {
                oMarcasAutosList = JsonConvert.DeserializeObject<List<MarcasAutos>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oMarcasAutosList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oMarcasAutosList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            // return oMarcasAutosList;
        }

        [HttpGet("catalogos/GetModelosMarcasAutos3/{ano}/{marcaID}")]
        public async Task<ActionResult<List<ModelosAutos>>> GetModelosMarcasAutos(Int32 ano, Int32 marcaID)
        {
        //https://www.prudenciaseguros.com.ar/APIPrudenciaUAT/api/catalogos/GetModelosMarcasAutos/Año/Marca
        //https://www.prudenciaseguros.com.ar/APIPrudenciaUAT/api/catalogos/GetModelosMarcasAutos/2018/12

            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<ModelosAutos> oModelosAutosList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetModelosMarcasAutos/" + ano.ToString() + "/" + marcaID.ToString();
         
            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oModelosAutosList = JsonConvert.DeserializeObject<List<ModelosAutos>>(responseHttp.Content.ReadAsStringAsync().Result);

                //if (oModelosAutosList.Count == 0)
                //{
                //    return NotFound();
                //}
                return this.Ok(oModelosAutosList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            //  return oModelosAutosList;
        }

        [HttpGet("catalogos/GetVersionesModelosAutos/{ano}/{marcaID}/{codigoGrupoID}")]
        public async Task<ActionResult<List<ModelosAutos>>> GetVersionesModelosAutos(Int32 ano, Int32 marcaID,Int32 codigoGrupoID)
        {
        //https://www.prudenciaseguros.com.ar/APIPrudenciaUAT/api/catalogos/GetVersionesModelosAutos/Año/Marca/Grupo
        //https://www.prudenciaseguros.com.ar/APIPrudenciaUAT/api/catalogos/GetVersionesModelosAutos/2018/12/42

            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<VersionesAutos> oVersionesAutosList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetVersionesModelosAutos/" + ano.ToString() + "/" + marcaID.ToString() + "/" + codigoGrupoID.ToString();

            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oVersionesAutosList = JsonConvert.DeserializeObject<List<VersionesAutos>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oVersionesAutosList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oVersionesAutosList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            //  return oModelosAutosList;
        }
        [HttpGet("catalogos/GetModelosAutos/{marcaID}")]
        public async Task<ActionResult<List<ModelosAutos>>> GetModelosAutos(Int32 marcaID)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<ModelosAutos> oModelosAutosList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetModelosAutos?MarcaID=" + marcaID.ToString() + "&PageSize=10000";
           
            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oModelosAutosList = JsonConvert.DeserializeObject<List<ModelosAutos>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oModelosAutosList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oModelosAutosList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            //  return oModelosAutosList;
        }

       

        [HttpGet("catalogos/GetTiposDocumentos")]
        public async Task<ActionResult<List<TipoDocumentoDTO>>> GetTiposDocumentos()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<TipoDocumentoDTO> oTipoDocumentoDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetTiposDocumentos";

            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oTipoDocumentoDTOList = JsonConvert.DeserializeObject<List<TipoDocumentoDTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oTipoDocumentoDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oTipoDocumentoDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            // return oTipoDocumentoDTOList;
        }

        [HttpGet("catalogos/GetCondicionesIva")]
        public async Task<ActionResult<List<CondicionesIVADTO>>> GetCondicionesIva()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<CondicionesIVADTO> oCondicionesIVADTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetCondicionesIva";

            var responseHttp = await httpClient.GetAsync(url);


            if (responseHttp.IsSuccessStatusCode)
            {
                oCondicionesIVADTOList = JsonConvert.DeserializeObject<List<CondicionesIVADTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oCondicionesIVADTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oCondicionesIVADTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            //return oCondicionesIVADTOList;
        }

        [HttpGet("catalogos/GetMediosDePago")]
        public async Task<ActionResult<List<TipoMedioPagoDTO>>> GetMediosDePago()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<TipoMedioPagoDTO> oTipoMedioPagoDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetMediosDePago";

            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oTipoMedioPagoDTOList = JsonConvert.DeserializeObject<List<TipoMedioPagoDTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oTipoMedioPagoDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oTipoMedioPagoDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            //  return oTipoMedioPagoDTOList;
        }


        [HttpGet("catalogos/GetCoberturasAutos")]
        public async Task<ActionResult<List<CoberturaAutoDTO>>> GetCoberturasAutos()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<CoberturaAutoDTO> oCoberturaAutoDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetCoberturasAutos";

            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oCoberturaAutoDTOList = JsonConvert.DeserializeObject<List<CoberturaAutoDTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oCoberturaAutoDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oCoberturaAutoDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            //return oCoberturaAutoDTOList;
        }

        [HttpGet("catalogos/GetProvincias")]
        public async Task<ActionResult<List<ProvinciaDTO>>> GetProvincias()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<ProvinciaDTO> oCProvinciaDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetProvincias";

            var responseHttp = await httpClient.GetAsync(url);



            if (responseHttp.IsSuccessStatusCode)
            {
                oCProvinciaDTOList = JsonConvert.DeserializeObject<List<ProvinciaDTO>>(responseHttp.Content.ReadAsStringAsync().Result);


                oCProvinciaDTOList = (from c in oCProvinciaDTOList
                                      where int.Parse(c.provinciaID) < 97
                                      && int.Parse(c.provinciaID) > 0
                                      orderby int.Parse(c.provinciaID) ascending
                                      select c).ToList();


              
           

                if (oCProvinciaDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oCProvinciaDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            //return oCProvinciaDTOList;
        }

        [HttpGet("catalogos/GetCpLocalidad/{ProvinciaID}/{CpLodalidad}")]
        public async Task<ActionResult<List<CodigoPostalDTO>>> GetCodPostales(Int32 ProvinciaID,string CpLodalidad)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<CodigoPostalDTO> oCodigoPostalDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);

            string url;
            bool CpLodalidadIsNumber = Int16.TryParse(CpLodalidad, out Int16 resultAux);
            if (CpLodalidadIsNumber)
            {
                url = oUriBase + "/catalogos/GetCodPostales?ProvinciaID=" + ProvinciaID.ToString() + "&CodigoPostalID=" + CpLodalidad + "&PageSize=10000";
            }
            else
            {
                url = oUriBase + "/catalogos/GetCodPostales?ProvinciaID=" + ProvinciaID.ToString() + "&Localidad=" + CpLodalidad + "&PageSize=10000";
            }


            //var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oCodigoPostalDTOList = JsonConvert.DeserializeObject<List<CodigoPostalDTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oCodigoPostalDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oCodigoPostalDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            //  return oCodigoPostalDTOList;
        }

        [HttpGet("catalogos/GetCodPostales/{ProvinciaID}")]
        public async Task<ActionResult<List<CodigoPostalDTO>>> GetCodPostales(Int32 ProvinciaID)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            List<CodigoPostalDTO> oCodigoPostalDTOList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/catalogos/GetCodPostales?ProvinciaID=" + ProvinciaID.ToString() + "&PageSize=10000";
         

            //var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.GetAsync(url);

            if (responseHttp.IsSuccessStatusCode)
            {
                oCodigoPostalDTOList = JsonConvert.DeserializeObject<List<CodigoPostalDTO>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oCodigoPostalDTOList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oCodigoPostalDTOList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }

            //  return oCodigoPostalDTOList;
        }



        [HttpGet("catalogos/GetCodPostalesDistinct/{ProvinciaID}")]
        public async Task<ActionResult<List<string>>> GetCodPostalesDistinct(Int32 ProvinciaID)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            //Dictionary<string, string> oCodPostalesDicc = new Dictionary<string, string>();
            List<string> oCodPostalesList = new List<string>();
            List<CodigoPostalDTO> oCodigoPostalDTOList = new List<CodigoPostalDTO> ();
          
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);

            for (int i = 1; i <= 3; i++)
            {
                string url = oUriBase + "/catalogos/GetCodPostales?ProvinciaID=" + ProvinciaID.ToString() + "&PageSize=100000&PageNumber=" + i.ToString();

                var responseHttp = await httpClient.GetAsync(url);

                if (responseHttp.IsSuccessStatusCode)
                {
                    List<CodigoPostalDTO> oCodigoPostalDTOListAux = JsonConvert.DeserializeObject<List<CodigoPostalDTO>>(responseHttp.Content.ReadAsStringAsync().Result);
                  

                    foreach (CodigoPostalDTO codigoPostalDTO in oCodigoPostalDTOListAux)
                    {
                        oCodigoPostalDTOList.Add(codigoPostalDTO);
                    }

                }
                else
                {
                    return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
                }
            }
           

            oCodPostalesList = oCodigoPostalDTOList.
                  Select(x => x.codigoPostalID.ToString())
                  .Distinct().ToList();

            if (oCodPostalesList.Count == 0)
            {
                return NotFound();
            }
            else
            { 
                return this.Ok(oCodPostalesList); 
            }

            
        }





        [HttpPost("cotizaciones/autosrapida")]
        public async Task<ActionResult<RespuestaCotizacionAutoRapidaDTO>> CotizacionesautosRapida([FromBody] CotizacionAutoRapidaDTO oCotizacionAutoRapidaDTO)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            RespuestaCotizacionAutoRapidaDTO oRespuestaCotizacionAutoRapidaDTO = null;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/cotizaciones/autosrapida";
            var enviarJSON = JsonConvert.SerializeObject(oCotizacionAutoRapidaDTO);


            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaCotizacionAutoRapidaDTO = JsonConvert.DeserializeObject<RespuestaCotizacionAutoRapidaDTO>(responseHttp.Content.ReadAsStringAsync().Result);
                

                //  string oUrlRaiz = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host);
                string oUrlRaiz = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host);

               // await oNotificacionesService.EnviarNotificacionPeliculaEnCartelera(oRespuestaCotizacionAutoRapidaDTO, oUrlRaiz);


                return this.Ok(oRespuestaCotizacionAutoRapidaDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            // return oRespuestaCotizacionAutoRapidaDTO;
        }

        [HttpPost("cotizaciones/autos")]
        public async Task<ActionResult<RespuestaCotizacionAutoDTO>> Cotizacionesautos([FromBody] CotizacionAutoDTO oCotizacionAutoDTO)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            RespuestaCotizacionAutoDTO oRespuestaCotizacionAutoDTO = null;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/cotizaciones/autos";
            var enviarJSON = JsonConvert.SerializeObject(oCotizacionAutoDTO);


            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaCotizacionAutoDTO = JsonConvert.DeserializeObject<RespuestaCotizacionAutoDTO>(responseHttp.Content.ReadAsStringAsync().Result);


                return this.Ok(oRespuestaCotizacionAutoDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            //return oRespuestaCotizacionAutoDTO;
        }



        [HttpPost("imagenes/Post64File")]
        public async Task<ActionResult<ImagenDTO[]>> imagenes([FromBody] string oImagenBase64)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            ImagenDTO[] oImagenDTO = null;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/imagenes/Post64File";


            string[] oImagenBase64Array = new string[1];
            oImagenBase64Array[0] = oImagenBase64;
            //oImagenBase64Array[1] = oImagenBase64;
            var enviarJSON = JsonConvert.SerializeObject(oImagenBase64Array);




            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                oImagenDTO = JsonConvert.DeserializeObject<ImagenDTO[]>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oImagenDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            //return oImagenDTO;
        }

        [HttpPost("cotizaciones/autos/{oCotizacionId}/confirmar")]
        public async Task<ActionResult<RespuestaCotizacionAutoDTO>> CotizacionesConfirmar(int oCotizacionId, [FromBody] ConfirmacionCotizacionAutoDTO oConfirmacionCotizacionAutoDTO)
        {
            RespuestaCotizacionAutoDTO oRespuestaCotizacionAutoDTO = null;
            ErrorModel oErrorModel = null;
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/cotizaciones/autos/" + oCotizacionId + "/confirmar";
            var enviarJSON = JsonConvert.SerializeObject(oConfirmacionCotizacionAutoDTO);


            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaCotizacionAutoDTO = JsonConvert.DeserializeObject<RespuestaCotizacionAutoDTO>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oRespuestaCotizacionAutoDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }
            //return oRespuestaCotizacionAutoDTO;
        }





        [HttpPost("cotizaciones/autos/{oCotizacionId}/emitir")]
        public async Task<ActionResult<RespuestaPolizaAutoDTO>> CotizacionesEmitir(int oCotizacionId, [FromBody] EmitirCotizacionAutoDTO oEmitirCotizacionAutoDTO)
        {
           
            RespuestaPolizaAutoDTO oRespuestaPolizaAutoDTO = null;
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + "/cotizaciones/autos/" + oCotizacionId + "/emitir";
            var enviarJSON = JsonConvert.SerializeObject(oEmitirCotizacionAutoDTO);


            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);

            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaPolizaAutoDTO = JsonConvert.DeserializeObject<RespuestaPolizaAutoDTO>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oRespuestaPolizaAutoDTO);
            }
            else
            {
                ErrorModel oErrorModel = JsonConvert.DeserializeObject<ErrorModel>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.BadRequest(error:  oErrorModel.detail );
            }

            // return oRespuestaPolizaAutoDTO;
        }


        [HttpGet("polizas/{polizaID}/reportes")]
        public async Task<ActionResult<RespuestaReporteDTO[]>> GetPolizaReporte(Int32 polizaID)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            RespuestaReporteDTO[] oRespuestaReporteDTO = new RespuestaReporteDTO[7];

            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + $"/polizas/{polizaID}/reportes?reportes=0&reportes=1&reportes=2&reportes=3&reportes=4&reportes=5&reportes=6";
           
            var responseHttp = await httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaReporteDTO = JsonConvert.DeserializeObject<RespuestaReporteDTO[]>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oRespuestaReporteDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });

            }

            //return oRespuestaReporteDTO;
        }

        [HttpGet("polizas/{polizaID}/reportes2")]
        public async Task<ActionResult<RespuestaReporteDTO[]>> GetPolizaReporte2(Int32 polizaID)
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            RespuestaReporteDTO[] oRespuestaReporteDTO = new RespuestaReporteDTO[7];

            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + $"/polizas/{polizaID}/reportes?reportes=0&reportes=1&reportes=2&reportes=3&reportes=4&reportes=5&reportes=7";
           
            //var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.GetAsync(url);


            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaReporteDTO = JsonConvert.DeserializeObject<RespuestaReporteDTO[]>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oRespuestaReporteDTO);


            }
            else
            {

                ErrorModel oErrorModel = new ErrorModel();
                oErrorModel.type = "type";
                oErrorModel.title = "title";
                oErrorModel.status = 0;
                oErrorModel.detail = "detail";
                //return this.BadRequest(httpResponseMessage)
                //ErrorModel oErrorModel = JsonConvert.DeserializeObject<ErrorModel>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }



        }

        [HttpGet("polizas/")]
        public async Task<ActionResult<RespuestaPolizaImpresionDTO[]>> GetPolizas()
        {
            Login oLogin = await GetLoginAsync();
            string oToken = "Bearer " + oLogin.accessToken;

            RespuestaPolizaImpresionDTO[] oRespuestaPolizaImpresionDTO;

            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oToken);
            string url = oUriBase + $"/polizas?ProductorID={oUser}";
           
            var responseHttp = await httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                oRespuestaPolizaImpresionDTO = JsonConvert.DeserializeObject<RespuestaPolizaImpresionDTO[]>(responseHttp.Content.ReadAsStringAsync().Result);
                return this.Ok(oRespuestaPolizaImpresionDTO);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });

            }


        }


        [HttpPost("SendMail")]
        public async Task<ActionResult<string>> SendMail(MailApp oMailApp)
        {

            //string oUrlRaiz = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host);
            //oMailApp.Body = String.Format(oMailApp.Body, oUrlRaiz);
             // string imagen = oUrlRaiz + "/images/pt.jpg";
            #region MyRegion
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("clientes@ziren.com.ar", "brianadriel3166");


            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress("clientes@ziren.com.ar","Ziren ");
            mailMessage.To.Add(oMailApp.To);
            //mailMessage.Bcc.Add(oMailApp.Bcc);
            mailMessage.Body = oMailApp.Body;
            mailMessage.Subject = oMailApp.Subject;

            try
            {
               client.Send(mailMessage);
                return this.Ok("Ok");
            }
            catch (Exception ex)
            {
                return this.BadRequest(error: new { message = ex.Message });
            }
            #endregion



            // return oRespuestaPolizaAutoDTO;
        }





        [HttpGet("Prueba")]
        public async Task<ActionResult<string>> GetPrueba()
        {
            //https://localhost:44331/api/Externo/Prudencia/Prueba
            string json = "{\"cotizacionID\":990508,\"nroCotizacion\":931629,\"productorID\":xxx,\"estado\":\"PENDIENTE\",\"fecha\":\"2020-04-27T00:00:00-03:00\",\"tieneAcreedorPrendario\":true,\"tieneAccesorios\":false,\"clausulaAjuste\":0,\"tipoAjustePrima\":\"N\",\"porcAjustePrima\":0.0,\"fechaFinCotizacion\":\"2020-04-30T00:00:00-03:00\",\"vehiculoID\":990510,\"vehiculo\":{\"vehiculoID\":990510,\"patente\":\"ABC123\",\"marcaID\":23,\"anio\":2003,\"modeloID\":230001,\"sumaAsegurada\":100000.0,\"tipoUsoID\":1,\"tipoVehiculoID\":1,\"es0KM\":false,\"tieneGNC\":false,\"motor\":null,\"chasis\":null,\"gncMarca\":null,\"gncCapacidad\":null,\"gncOblea\":null,\"gncRegulador\":null,\"gncVtoPruebaHidr\":null,\"cubreGNC\":false,\"valorGNC\":0.0,\"accesorios\":[]},\"usaAcarreo\":false,\"coberturas\":[{\"concepto\":\"    Prima Comisionable\",\"porcentajeConcepto\":30.0000,\"a\":962.46,\"b1\":1135.11,\"b\":1143.94,\"c1\":1235.01,\"c\":1243.85,\"cg\":0.00,\"cf\":0.00,\"d2\":0.00},{\"concepto\":\"Premio Mensual\",\"porcentajeConcepto\":null,\"a\":1387.83,\"b1\":1636.79,\"b\":1649.52,\"c1\":1780.84,\"c\":1793.59,\"cg\":0.00,\"cf\":0.00,\"d2\":0.00}]}";
            RespuestaCotizacionAutoRapidaDTO oRespuestaCotizacionAutoRapidaDTO = JsonConvert.DeserializeObject<RespuestaCotizacionAutoRapidaDTO>(json);

            ToLog(oRespuestaCotizacionAutoRapidaDTO);
            return json;
        }

        //public static void ToLog(CotizacionAutoDTO oCotizacionAutoDTO)
        public static void ToLog(RespuestaCotizacionAutoRapidaDTO oRespuestaCotizacionAutoRapidaDTO)
        {


            XmlDocument oXmlDocument = GenericToXmlDocument(oRespuestaCotizacionAutoRapidaDTO);
            string basePath = Environment.CurrentDirectory;
            string oFecha = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Today.Day.ToString().PadLeft(2, '0');

            string oFile = basePath + "\\Logs\\" + oFecha + "-" + oRespuestaCotizacionAutoRapidaDTO.cotizacionID.ToString().PadLeft(10, '0');
            oXmlDocument.Save(oFile + ".xml");



        }



        public static XmlDocument GenericToXmlDocument(object o)
        {

            XmlSerializer s = new XmlSerializer(o.GetType());
            XmlDocument xml = null;
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            writer.Formatting = System.Xml.Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 5;


            try
            {
                s.Serialize(writer, o);
                xml = new XmlDocument();
                string xmlString = ASCIIEncoding.UTF8.GetString(ms.ToArray());
                xml.LoadXml(xmlString);



                foreach (XmlNode node in xml)
                {
                    if (node.NodeType == XmlNodeType.XmlDeclaration)
                    {
                        xml.RemoveChild(node);
                    }
                }


            }
            finally
            {
                writer.Close();
                ms.Close();
            }
            return xml;
        }


    }
}
