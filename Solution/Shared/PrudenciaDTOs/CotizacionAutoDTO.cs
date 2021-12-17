using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class CotizacionAutoDTO
    {
        public Int32 cotizacionID { get; set; }


        public AseguradoPatrimonialDTO asegurado { get; set; }


        //public string codigoPostal { get; set; }
        public bool tieneAcreedorPrendario { get; set; }
        public Int32 clausulaAjuste { get; set; }
        public string tipoAjustePrima { get; set; }
        public double porcAjustePrima { get; set; }


        public VehiculoDTO vehiculo { get; set; }

        public bool usaAcarreo { get; set; } 
    }
}
