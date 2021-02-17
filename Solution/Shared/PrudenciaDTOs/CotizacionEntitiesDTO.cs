using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.PrudenciaDTOs
{
    public class CotizacionEntitiesDTO
    {
        public MarcasAutos marcasAutos { get; set; }
        public int ano { get; set; }
        public ModelosAutos modelosAutos { get; set; }

        public VersionesAutos versionesAutos { get; set; }
    }
}
