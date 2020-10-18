using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaPolizaAutoDTO
    {
        public Int32 productorID { get; set; }
        public string ramo { get; set; }
        public string descripcionRamo { get; set; }
        public Int32 poliza { get; set; }
        public Int32 endoso { get; set; }
        public string fechaEmision { get; set; }
        public double sumaAsegurada { get; set; }
        public string productoID { get; set; }
        public string cobertura { get; set; }
        public Int32 aseguradoID { get; set; }
        public string nombreAsegurado { get; set; }
        public string numeroDocumento { get; set; }
        public double premio { get; set; }
        public string inicioVigencia { get; set; }
        public string finVigencia { get; set; }
        public string medioPagoID { get; set; }
        public Int32 titularTarjeta { get; set; }
        public string vencimientoMedioPago { get; set; }
        public string numeroMedioPago { get; set; }
        public string nombreTitularTarjeta { get; set; }
        public string tipoDocTitularTarjeta { get; set; }
        public string nroDocTitularTarjeta { get; set; }
        public string urlImpresion { get; set; }
        public Int32 polizaID { get; set; }
    }
}
