using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class DatosAuto
    {
        public int marcaID { get; set; }
        public string descripcionMarca { get; set; }
        public int modeloID { get; set; }
        public string descripcion { get; set; }
        public int tipoVehiculoID { get; set; }
        public double sumaAsegurada { get; set; }
        public TipoUsoAutoDTO[] tiposUso { get; set; }
    }
}
