using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server;
using Project.Shared.InfoAutoDTOs;
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
//using System.Web.Http;

namespace Project.Server.Controllers
{
    [Route("api/Externo/[controller]")]
    [ApiController]
    public class InfoAutoController : ControllerBase
    {
        private IMemoryCache oMemoryCache;
        private readonly IConfiguration oConfiguration;

        //private string oUriBase = "https://test-info_auto.gestion.online/api";
        //private string oUsername = "facundo@thecnocgroup.com";
        //private string oPassword = "12345678";
        //private string oClientID = "bd0fbd625a88bd62753a88889e93199b4a893f1ed09fff815fc140aa3728faaa";
        //private string oClientSecret = "b1ea0ec330cec09125436043ff55951f56b2c574b744302ed9162165154d0694";
        //private string oGrant_type = "password";
        private string oUriBaseAuth;
        private string oUriBase ;
        private string oUsername ;
        private string oPassword;
        private string oClientID ;
        private string oClientSecret;
        private string oGrant_type ;
        private string oToken;
        public InfoAutoController(IMemoryCache memoryCache, IConfiguration configuration)
        {
            oMemoryCache = memoryCache;
            oConfiguration = configuration;

            oUriBaseAuth = oConfiguration["InfoAuto_UriBaseAuth"];
            oUriBase = oConfiguration["InfoAuto_UriBase"];

            oClientID = oConfiguration["InfoAuto_client_id"];
            oClientSecret = oConfiguration["InfoAuto_client_secret"];
            oUsername = oConfiguration["InfoAuto_client_username"];
            oPassword = oConfiguration["InfoAuto_client_password"];
            oGrant_type = oConfiguration["InfoAuto_client_grant_type"];
        }
        


        private  async Task<Token> GetInfoAutoToken()
        {
            string url = oUriBaseAuth + "/token";
            //string baseAddress = @"https://test-info_auto.gestion.online/oauth/token";

            //string oUsername = "facundo@thecnocgroup.com";
            //string oPassword = "12345678";
            //string oClientID = "bd0fbd625a88bd62753a88889e93199b4a893f1ed09fff815fc140aa3728faaa";
            //string oClientSecret = "b1ea0ec330cec09125436043ff55951f56b2c574b744302ed9162165154d0694";
            //string oGrant_type = "password";

            #region MyRegion
            HttpClient client = new HttpClient();

           
          
            var form = new Dictionary<string, string>
                {
                    {"grant_type", oGrant_type},
                    {"client_id", oClientID},
                    {"client_secret", oClientSecret},
                    {"username", oUsername},
                    {"password", oPassword},
                };

            HttpResponseMessage tokenResponse = await client.PostAsync(url, new FormUrlEncodedContent(form));
            var jsonContent = await tokenResponse.Content.ReadAsStringAsync();
            Token tok = JsonConvert.DeserializeObject<Token>(jsonContent);
            return tok;
            #endregion

            #region MyRegion
            HttpWebRequest request = WebRequest.Create("https://test-info_auto.gestion.online/oauth/token") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
           
            // Metodo modificado

            string postData = "username=" + oUsername + "&password=" + oPassword + "&grant_type=password&client_id=" + oClientID + "&client_secret=" + oClientSecret + ";";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            StreamWriter stmw = new StreamWriter(dataStream);

            stmw.Write(postData);
            dataStream.Write(byteArray, 0, byteArray.Length);

      
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string resp = reader.ReadToEnd();
            }
            #endregion

            #region MyRegion

            HttpClient httpClient = new HttpClient();
            Token oToken = new Token();
             url = "https://test-info_auto.gestion.online/oauth/token";

            var enviarJSON = "{ 'user': '586701',  'password': '586701'}";
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer 890287f74febc0c992525a9459b86deb10f31d8a619a9d7ee93de5605c41ce1d");
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                oToken = JsonConvert.DeserializeObject<Token>(responseHttp.Content.ReadAsStringAsync().Result);

            }
            else
            {
                Console.WriteLine(responseHttp.Content.ReadAsStringAsync().Result);
                //    return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            return oToken;

            //var client = new RestClient("https://test-info_auto.gestion.online/oauth/token");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Authorization", "Bearer 890287f74febc0c992525a9459b86deb10f31d8a619a9d7ee93de5605c41ce1d");
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            #endregion
          
        }







        private async Task<string> GetLoginAsync()
        {
            //  https://localhost:44331/api/Externo/Prudencia/login/user/password
            bool? oRerescarLogin;

            oToken = oMemoryCache.Get("InfoAutoToken") as string;
            //if (oToken != null)
            //{
            //    if (DateTime.Parse(oToken.accessTokenExpirationDate) > DateTime.Now)
            //    {
            //        oRerescarLogin = false;
            //    }
            //    else
            //    {
            //        oRerescarLogin = true;
            //    }
            //}
            //else
            //{
            //    oRerescarLogin = true;
            //}
            //if (oRerescarLogin == false)
            //{
            //    return oLogin;
            //}







            //UserPassWord oUserPassWord = new UserPassWord();

            //oUserPassWord.user = oUser;
            //oUserPassWord.password = oPassword;


            ////Login oLogin = null;
            //HttpClient httpClient = new HttpClient();

            //string url = oUriBase + "/account/login";
            ////var enviarJSON = JsonSerializer.Serialize(user);
            //var enviarJSON = "{ 'user': '586701',  'password': '586701'}";

            //var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            //var responseHttp = await httpClient.PostAsync(url, enviarContent);
            //if (responseHttp.IsSuccessStatusCode)
            //{
            //    oLogin = JsonConvert.DeserializeObject<Login>(responseHttp.Content.ReadAsStringAsync().Result);
            //    oMemoryCache.Set("LoginKey", oLogin, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(5)));

            //}
            //else
            //{

            //}
            return oToken;
        }


        [HttpGet("custom/public/brands")]
        public async Task<ActionResult<List<Brands>>> GetBrands()
        {

            Token oToken = await GetInfoAutoToken();
             string oBearerToken = "Bearer " + oToken.access_token;

            List<Brands> oBrandsList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oBearerToken);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.gestion.online+json ");
            httpClient.DefaultRequestHeaders.Add("X-Force-Content-Type", "application/json");
            string url = oUriBase + "/custom/public/brands";
            
            var responseHttp = await httpClient.GetAsync(url);


            if (responseHttp.IsSuccessStatusCode)
            {
                oBrandsList = JsonConvert.DeserializeObject<List<Brands>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oBrandsList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oBrandsList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }


            // return oMarcasAutosList;
        }


        [HttpGet("custom/public/models/{brandId}")]
        public async Task<ActionResult<List<Brands>>> GetModelsByBrandId(string brandId)
        {
            //https://test-info_auto.gestion.online/api/custom/public/models?brandId=118521595
            Token oToken = await GetInfoAutoToken();
            string oBearerToken = "Bearer " + oToken.access_token;

            List<Models> oModelsList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oBearerToken);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.gestion.online+json ");
            httpClient.DefaultRequestHeaders.Add("X-Force-Content-Type", "application/json");
            string url = oUriBase + "/custom/public/models?brandId=" + brandId;
            var responseHttp = await httpClient.GetAsync(url);
            
           
            if (responseHttp.IsSuccessStatusCode)
            {
                oModelsList = JsonConvert.DeserializeObject<List<Models>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oModelsList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oModelsList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }



        }



        [HttpGet("custom/public/vehicles/{modelId}")]
        public async Task<ActionResult<List<Vehicles>>> GetVehiclesByModelId(string modelId)
        {
            //https://test-info_auto.gestion.online/api/custom/public/vehicles?modelId=87174486
            Token oToken = await GetInfoAutoToken();
            string oBearerToken = "Bearer " + oToken.access_token;

            List<Vehicles> oVehiclesList = null;
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", oBearerToken);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.gestion.online+json ");
            httpClient.DefaultRequestHeaders.Add("X-Force-Content-Type", "application/json");
            string url = oUriBase + "/custom/public/vehicles?modelId=" + modelId;
            var responseHttp = await httpClient.GetAsync(url);


            if (responseHttp.IsSuccessStatusCode)
            {
                oVehiclesList = JsonConvert.DeserializeObject<List<Vehicles>>(responseHttp.Content.ReadAsStringAsync().Result);

                if (oVehiclesList.Count == 0)
                {
                    return NotFound();
                }
                return this.Ok(oVehiclesList);
            }
            else
            {
                return this.BadRequest(error: new { message = responseHttp.Content.ReadAsStringAsync().Result });
            }



        }







        [HttpGet("Prueba")]
        public async Task<ActionResult<string>> GetPrueba()
        {
            await GetInfoAutoToken();

            //https://localhost:44331/api/Externo/Prudencia/Prueba
            string json = "{\"cotizacionID\":990508,\"nroCotizacion\":931629,\"productorID\":586701,\"estado\":\"PENDIENTE\",\"fecha\":\"2020-04-27T00:00:00-03:00\",\"tieneAcreedorPrendario\":true,\"tieneAccesorios\":false,\"clausulaAjuste\":0,\"tipoAjustePrima\":\"N\",\"porcAjustePrima\":0.0,\"fechaFinCotizacion\":\"2020-04-30T00:00:00-03:00\",\"vehiculoID\":990510,\"vehiculo\":{\"vehiculoID\":990510,\"patente\":\"ABC123\",\"marcaID\":23,\"anio\":2003,\"modeloID\":230001,\"sumaAsegurada\":100000.0,\"tipoUsoID\":1,\"tipoVehiculoID\":1,\"es0KM\":false,\"tieneGNC\":false,\"motor\":null,\"chasis\":null,\"gncMarca\":null,\"gncCapacidad\":null,\"gncOblea\":null,\"gncRegulador\":null,\"gncVtoPruebaHidr\":null,\"cubreGNC\":false,\"valorGNC\":0.0,\"accesorios\":[]},\"usaAcarreo\":false,\"coberturas\":[{\"concepto\":\"    Prima Comisionable\",\"porcentajeConcepto\":30.0000,\"a\":962.46,\"b1\":1135.11,\"b\":1143.94,\"c1\":1235.01,\"c\":1243.85,\"cg\":0.00,\"cf\":0.00,\"d2\":0.00},{\"concepto\":\"Premio Mensual\",\"porcentajeConcepto\":null,\"a\":1387.83,\"b1\":1636.79,\"b\":1649.52,\"c1\":1780.84,\"c\":1793.59,\"cg\":0.00,\"cf\":0.00,\"d2\":0.00}]}";
            Brands oRespuestaCotizacionAutoRapidaDTO = JsonConvert.DeserializeObject<Brands>(json);

            ToLog(oRespuestaCotizacionAutoRapidaDTO);
            return json;
        }

        //public static void ToLog(CotizacionAutoDTO oCotizacionAutoDTO)
        public static void ToLog(Brands oRespuestaCotizacionAutoRapidaDTO)
        {


            XmlDocument oXmlDocument = GenericToXmlDocument(oRespuestaCotizacionAutoRapidaDTO);
            string basePath = Environment.CurrentDirectory;
            string oFecha = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Today.Day.ToString().PadLeft(2, '0');

            string oFile = basePath + "\\Logs\\" + oFecha + "-" + oRespuestaCotizacionAutoRapidaDTO.ToString().PadLeft(10, '0');
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
