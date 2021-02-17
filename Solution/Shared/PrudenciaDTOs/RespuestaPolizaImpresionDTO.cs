using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    public class RespuestaPolizaImpresionDTO
    {
        public Int32 id { get; set; }
        public string transID { get; set; }
        public Int32 transPolizaID { get; set; }
        public Int32 productorID { get; set; }
        public string ramo { get; set; }
        public string descripcionRamo { get; set; }
        public Int32 poliza { get; set; }
        public Int32 endoso { get; set; }
        public string fechaEmision { get; set; }
        public Decimal sumaAsegurada { get; set; }
        public string productoID { get; set; }
        public string cobertura { get; set; }
        public Int32? numeroFactura { get; set; }
        public Int32 tomadorID { get; set; }
        public string nombreTomador { get; set; }
        public Int32 aseguradoID { get; set; }
        public string nombreAsegurado { get; set; }
        public string certificado { get; set; }
        public string numeroDocumento { get; set; }
        public Int32? renovadoPor { get; set; }
        public Int32? transPolizaRenovadaID { get; set; }
        public string anulada { get; set; }
        public Decimal premio { get; set; }
        public Int32? propuestaID { get; set; }
        public string inicioVigencia { get; set; }
        public string finVigencia { get; set; }
        public string mailEnvioPoliza { get; set; }
        public string medioPagoID { get; set; }
        public Int32 titularTarjeta { get; set; }
        public string vencimientoMedioPago { get; set; }
        public string numeroMedioPago { get; set; }
        public string nombreTitularTarjeta { get; set; }
        public string tipoDocTitularTarjeta { get; set; }
        public string nroDocTitularTarjeta { get; set; }
        public string siniestro { get; set; }
        public Decimal primaComisionable { get; set; }
        public string fechaFinFacturacion { get; set; }

        public RespuestaPolizaCuotaDTO[]  cuotas { get; set; }
}
}
