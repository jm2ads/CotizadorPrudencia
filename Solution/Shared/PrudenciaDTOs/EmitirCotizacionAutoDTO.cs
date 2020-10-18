using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class EmitirCotizacionAutoDTO
    {

        public string inicioVigencia { get; set; }
        public string motor { get; set; }
        public string chasis { get; set; }
        public string observaciones { get; set; }
        public string gncMarca { get; set; }
        public Int32 gncCapacidad { get; set; }
        public string gncOblea { get; set; }
        public string gncRegulador { get; set; }
        public string gncVtoPruebaHidr { get; set; }


        public AseguradoPatrimonialDTO prendario { get; set; }

        public AdjuntoDTO[] adjuntos { get; set; }


        public MedioPagoDTO medioDePago { get; set; }

        public Boolean retornaPoliza { get; set; }
}
}
