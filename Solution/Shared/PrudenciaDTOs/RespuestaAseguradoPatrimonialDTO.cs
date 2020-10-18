using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaAseguradoPatrimonialDTO
    {
        public Int32 aseguradoID { get; set; }
        public Int32? codigoTitular { get; set; }
        public string nombre { get; set; }
        public string fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string condicionIVA { get; set; }

        public string domicilio { get; set; }
        public Int32 domicilioNumero { get; set; }
        public Int32 domicilioPiso { get; set; }
        public string domicilioDpto { get; set; }
        public string codigoPostal { get; set; }
        public string localidad { get; set; }
        public string provinciaID { get; set; }
        public string paisID { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
       

    }
}
