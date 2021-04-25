using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class CotizacionAutoRapidaDTO
    {
        public Int32 cotizacionID { get; set; }

        //[NotMapped]
        //public Int32 provinciasID { get; set; }

        public string codigoPostal { get; set; }
        public bool tieneAcreedorPrendario { get; set; }
        public Int32 clausulaAjuste { get; set; }
        public string tipoAjustePrima { get; set; }
        public double porcAjustePrima { get; set; }


        public VehiculoDTO vehiculo { get; set; }

        public bool usaAcarreo { get; set; } = true;




    }
}
