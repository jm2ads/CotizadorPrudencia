using Project.Shared.Entidades;
using Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.PrudenciaDTOs
{
    public class SendModoComodoMail
    {
        public Partner partner { get; set; }
        public MailApp mailApp { get; set; }

        public string carFront { get; set; }
        public string carBack { get; set; }
        public string carLeft { get; set; }
        public string carRight { get; set; }
        public string cedulaFront { get; set; }
        public string cedulaBack { get; set; }
        public string dniFront { get; set; }
        public string dniBack { get; set; }
        public string gncTubo { get; set; }
        public string NombreApellido { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Patente { get; set; }
        public string Ano { get; set; }

        public string MedioPago { get; set; }
        public string NombreApellidoTC { get; set; }
        public string MarcaTC { get; set; }
        public string DNITC { get; set; }
        public string NroTc { get; set; }

        public string VtoTc { get; set; }



        public string NombreApellidoCBU { get; set; }
        public string NroCBU { get; set; }


        public CotizacionEntitiesDTO CotizacionEntitiesDTO { get; set; }


    }
}
