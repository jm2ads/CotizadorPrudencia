using Project.Shared.PrudenciaDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Client
{
    public class ServicioSingleton
    {
        public int Valor { get; set; }
        public CotizacionAutoDTO oCotizacionAutoDTO { get; set; }
        public string oCotizacionAutoDTOJson { get; set; }
    }

    public class ServicioTransient
    {
        public int Valor { get; set; }
    }
}
