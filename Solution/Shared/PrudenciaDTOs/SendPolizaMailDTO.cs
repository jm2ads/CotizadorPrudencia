using Project.Shared.Entidades;
using Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.PrudenciaDTOs
{
    public class SendPolizaMailDTO
    {
       



        public MailApp mailApp { get; set; }
        public CotizacionAutoDTO cotizacionAutoDTO { get; set; }
        public CotizacionEntitiesDTO cotizacionEntitiesDTO { get; set; }
        public List<RespuestaReporteDTO> respuestaReporteDTOList { get; set; }
        public Partner partner { get; set; }
    }
}
