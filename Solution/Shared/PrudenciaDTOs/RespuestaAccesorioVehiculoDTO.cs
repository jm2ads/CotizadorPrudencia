using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaAccesorioVehiculoDTO
    {

        public int accesorioVehiculoID { get; set; }
        public int accesorioID { get; set; }
        public Decimal valor { get; set; }
        public string descripcion { get; set; }


    }
}
