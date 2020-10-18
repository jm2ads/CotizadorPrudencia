using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaPolizaCuotaDTO
    {

      public Int32 numeroCuota { get; set; }
        public string fechaVencimiento { get; set; }
        public Decimal importe { get; set; }
        public string fechaPago { get; set; }
        public Decimal importePagado { get; set; }
        public Decimal saldo { get; set; }
        public string medioPago { get; set; }
        public Int32 endoso { get; set; }

    }
}
