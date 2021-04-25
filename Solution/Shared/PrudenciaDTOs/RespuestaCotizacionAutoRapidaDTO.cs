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
        public int clausulaAjuste { get; set; }
        public string tipoAjustePrima { get; set; }
        public Decimal porcAjustePrima { get; set; }
        public string fechaFinCotizacion { get; set; }
      

        public int vehiculoID { get; set; }
        public RespuestaVehiculoDTO vehiculo { get; set; }


        public Boolean usaAcarreo { get; set; } = true;
        public RespuestaDetalleCotizacionAuto[] coberturas { get; set; }

       
        


    }
}
