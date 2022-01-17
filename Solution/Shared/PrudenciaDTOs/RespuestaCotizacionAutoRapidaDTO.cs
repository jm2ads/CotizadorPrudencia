using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaCotizacionAutoRapidaDTO
    {
       public int cotizacionID { get; set; }
      
        public int nroCotizacion { get; set; }
        public int productorID { get; set; }
        public string estado { get; set; }
        public string fecha { get; set; }
        public Boolean tieneAcreedorPrendario { get; set; }
        public Boolean tieneAccesorios { get; set; }
        public int clausulaAjuste { get; set; }//aquí va el % con el cual se actualiza la suma asegurada cada 4 meses.El default es 20.


        public string tipoAjustePrima { get; set; }  // Esto es si se aplica un descuento sobre la poliza"N" No Aplica"D" Descuento"R" Recargo
        public Decimal porcAjustePrima { get; set; }// SI "tipoAjustePrima" es distinto de "N" va el porcentaje del recargo o descuento.




        public string fechaFinCotizacion { get; set; }
      

        public int vehiculoID { get; set; }
        public RespuestaVehiculoDTO vehiculo { get; set; }


        public Boolean usaAcarreo { get; set; }
        public RespuestaDetalleCotizacionAuto[] coberturas { get; set; }

       
        


    }
}
