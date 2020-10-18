using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class MedioPagoDTO
    {
        public Int32 medioPagoID { get; set; }
        public string vencimientoMedioPago { get; set; }
        public string numeroMedioPago { get; set; }
        public string nombreTitularTarjeta { get; set; }
        public string tipoDocTitularTarjeta { get; set; }
        public string nroDocTitularTarjeta { get; set; }
    }
}
