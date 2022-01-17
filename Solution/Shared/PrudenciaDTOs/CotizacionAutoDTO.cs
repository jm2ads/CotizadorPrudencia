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
        public int clausulaAjuste { get; set; }//aquí va el % con el cual se actualiza la suma asegurada cada 4 meses.El default es 20.


        public string tipoAjustePrima { get; set; }  // Esto es si se aplica un descuento sobre la poliza"N" No Aplica"D" Descuento"R" Recargo
        public Decimal porcAjustePrima { get; set; }// SI "tipoAjustePrima" es distinto de "N" va el porcentaje del recargo o descuento.



        public VehiculoDTO vehiculo { get; set; }

        public bool usaAcarreo { get; set; } 
    }
}
