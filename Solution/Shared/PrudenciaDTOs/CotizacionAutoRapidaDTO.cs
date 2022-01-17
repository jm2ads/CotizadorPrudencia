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


        public int clausulaAjuste { get; set; }//aquí va el % con el cual se actualiza la suma asegurada cada 4 meses.El default es 20.


        public string tipoAjustePrima { get; set; }  // Esto es si se aplica un descuento sobre la poliza"N" No Aplica"D" Descuento"R" Recargo
        public Decimal porcAjustePrima { get; set; }// SI "tipoAjustePrima" es distinto de "N" va el porcentaje del recargo o descuento.



        public VehiculoDTO vehiculo { get; set; }

        public bool usaAcarreo { get; set; } 




    }
}
