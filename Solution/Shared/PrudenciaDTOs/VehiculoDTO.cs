using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class VehiculoDTO
    {

        public string patente { get; set; }
        public Int32 marcaID { get; set; }
        public Int32 anio { get; set; }
        public Int32 modeloID { get; set; }
        public double sumaAsegurada { get; set; }
        public Int32 tipoUsoID { get; set; }
        public Int32 tipoVehiculoID { get; set; }
        public bool es0KM { get; set; }
        public bool tieneGNC { get; set; }
        public bool cubreGNC { get; set; }
        public double valorGNC { get; set; }


       


    }
}
