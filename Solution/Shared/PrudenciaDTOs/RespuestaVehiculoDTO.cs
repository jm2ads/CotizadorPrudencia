using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaVehiculoDTO
    {
        public Int32 vehiculoID { get; set; }
        public string patente { get; set; }
        public Int32 marcaID { get; set; }
        public Int32 anio { get; set; }
        public Int32 modeloID { get; set; }
        public double sumaAsegurada { get; set; }
        public Int32 tipoUsoID { get; set; }
        public Int32 tipoVehiculoID { get; set; }
        public bool es0KM { get; set; }
        public bool tieneGNC { get; set; }
        public string motor { get; set; }
        public string chasis { get; set; }
        public string gncMarca { get; set; }
        public Int32? gncCapacidad { get; set; }
        public string gncOblea { get; set; }
        public string gncRegulador { get; set; }
        public string gncVtoPruebaHidr { get; set; }
        public bool cubreGNC { get; set; }

        public decimal valorGNC { get; set; }

        public RespuestaAccesorioVehiculoDTO[] accesorios { get; set; }




    }
}
