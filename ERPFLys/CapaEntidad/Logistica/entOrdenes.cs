using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Logistica
{
    public class entOrdenes : entBase
    {
        private String c_Compania, c_NumeroOrden, c_Razonsocial, c_DocumentoFiscal, c_ClasificacionCodigo, c_FormaPago, c_FlagAdelanto = "N";
        private String c_TipoServicio, c_Procedencia, c_AlmacenCodigo, c_Moneda, c_RazonAnulacion, c_Observacion, c_Contrato, c_Estado, c_PreparadoPor;
        private String c_AprobadoPor, c_UltimoUsuario, c_FlagImpresion, c_UsuarioImpresion, c_FlagImpresionAdelanto, c_UsuarioImpresionAdelanto;
        private String c_IncotermCodigo, c_RazonCierre, c_TipoCierre, c_FlagFlete = "N", c_UsuarioFlete, c_FlagOrigen = "O", c_FlagReplicado = "N";
        private String c_CompaniaRep, c_NumeroOrdenRep, c_RazonOriginal, c_Garantia_Cab, c_Operatividad_Cab, c_EstadoFirma = "PE", c_UsuarioFirma;
        private String c_Via;
        private int n_Ampliacion, n_Proveedor, n_NumeroAdelanto, n_Proveedor_Original, n_OrdenFirma;
        private Decimal n_MontoBruto = 0, n_MontoIGV = 0, n_MontoTotal = 0, n_MontoGastado = 0, n_TipoDeCambio = 0, n_MontoFlete = 0;
        private Decimal n_AdelantoFlete, n_FleteInt_Imp = 0, n_Flete_Imp = 0, n_Seguro_Imp = 0;
        private DateTime d_FechaEntrega, d_FechaPreparacion, d_FechaAprobacion, d_UltimaFechaModificacion = DateTime.Now;
        private DateTime d_FechaCierre, d_FechaEmbarque, d_FechaLlegada, d_FechaFlete, d_FechaCanalRojo, d_FechaCanalNaranja;
        private DateTime d_FechaFirma, d_FechaPagoIni;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String NumeroOrden
        {
            get { return c_NumeroOrden; }
            set { c_NumeroOrden = value; }
        }

        public Int32 Ampliacion
        {
            get { return n_Ampliacion; }
            set { n_Ampliacion = value; }
        }

        public Int32 Proveedor
        {
            get { return n_Proveedor; }
            set { n_Proveedor = value; }
        }

        public String Razonsocial
        {
            get { return c_Razonsocial; }
            set { c_Razonsocial = value; }
        }

        public String DocumentoFiscal
        {
            get { return c_DocumentoFiscal; }
            set { c_DocumentoFiscal = value; }
        }

        public String ClasificacionCodigo
        {
            get { return c_ClasificacionCodigo; }
            set { c_ClasificacionCodigo = value; }
        }

        public String FormaPago
        {
            get { return c_FormaPago; }
            set { c_FormaPago = value; }
        }

        public String FlagAdelanto
        {
            get { return c_FlagAdelanto; }
            set { c_FlagAdelanto = value; }
        }

        public Int32 NumeroAdelanto
        {
            get { return n_NumeroAdelanto; }
            set { n_NumeroAdelanto = value; }
        }

        public String TipoServicio
        {
            get { return c_TipoServicio; }
            set { c_TipoServicio = value; }
        }

        public String Procedencia
        {
            get { return c_Procedencia; }
            set { c_Procedencia = value; }
        }

        public DateTime FechaEntrega
        {
            get { return d_FechaEntrega; }
            set { d_FechaEntrega = value; }
        }

        public String AlmacenCodigo
        {
            get { return c_AlmacenCodigo; }
            set { c_AlmacenCodigo = value; }
        }

        public String Moneda
        {
            get { return c_Moneda; }
            set { c_Moneda = value; }
        }

        public Decimal MontoBruto
        {
            get { return n_MontoBruto; }
            set { n_MontoBruto = value; }
        }

        public Decimal MontoIGV
        {
            get { return n_MontoIGV; }
            set { n_MontoIGV = value; }
        }

        public Decimal MontoTotal
        {
            get { return n_MontoTotal; }
            set { n_MontoTotal = value; }
        }

        public Decimal MontoGastado
        {
            get { return n_MontoGastado; }
            set { n_MontoGastado = value; }
        }

        public Decimal TipoDeCambio
        {
            get { return n_TipoDeCambio; }
            set { n_TipoDeCambio = value; }
        }

        public String RazonAnulacion
        {
            get { return c_RazonAnulacion; }
            set { c_RazonAnulacion = value; }
        }

        public String Observacion
        {
            get { return c_Observacion; }
            set { c_Observacion = value; }
        }

        public String Contrato
        {
            get { return c_Contrato; }
            set { c_Contrato = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String PreparadoPor
        {
            get { return c_PreparadoPor; }
            set { c_PreparadoPor = value; }
        }

        public DateTime FechaPreparacion
        {
            get { return d_FechaPreparacion; }
            set { d_FechaPreparacion = value; }
        }

        public String AprobadoPor
        {
            get { return c_AprobadoPor; }
            set { c_AprobadoPor = value; }
        }

        public DateTime FechaAprobacion
        {
            get { return d_FechaAprobacion; }
            set { d_FechaAprobacion = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String FlagImpresion
        {
            get { return c_FlagImpresion; }
            set { c_FlagImpresion = value; }
        }

        public String UsuarioImpresion
        {
            get { return c_UsuarioImpresion; }
            set { c_UsuarioImpresion = value; }
        }

        public String FlagImpresionAdelanto
        {
            get { return c_FlagImpresionAdelanto; }
            set { c_FlagImpresionAdelanto = value; }
        }

        public String UsuarioImpresionAdelanto
        {
            get { return c_UsuarioImpresionAdelanto; }
            set { c_UsuarioImpresionAdelanto = value; }
        }

        public String IncotermCodigo
        {
            get { return c_IncotermCodigo; }
            set { c_IncotermCodigo = value; }
        }

        public String RazonCierre
        {
            get { return c_RazonCierre; }
            set { c_RazonCierre = value; }
        }

        public DateTime FechaCierre
        {
            get { return d_FechaCierre; }
            set { d_FechaCierre = value; }
        }

        public String TipoCierre
        {
            get { return c_TipoCierre; }
            set { c_TipoCierre = value; }
        }

        public DateTime FechaEmbarque
        {
            get { return d_FechaEmbarque; }
            set { d_FechaEmbarque = value; }
        }

        public DateTime FechaLlegada
        {
            get { return d_FechaLlegada; }
            set { d_FechaLlegada = value; }
        }

        public String FlagFlete
        {
            get { return c_FlagFlete; }
            set { c_FlagFlete = value; }
        }

        public Decimal MontoFlete
        {
            get { return n_MontoFlete; }
            set { n_MontoFlete = value; }
        }

        public String UsuarioFlete
        {
            get { return c_UsuarioFlete; }
            set { c_UsuarioFlete = value; }
        }

        public DateTime FechaFlete
        {
            get { return d_FechaFlete; }
            set { d_FechaFlete = value; }
        }

        public Decimal AdelantoFlete
        {
            get { return n_AdelantoFlete; }
            set { n_AdelantoFlete = value; }
        }

        public Decimal FleteInt_Imp
        {
            get { return n_FleteInt_Imp; }
            set { n_FleteInt_Imp = value; }
        }

        public Decimal Flete_Imp
        {
            get { return n_Flete_Imp; }
            set { n_Flete_Imp = value; }
        }

        public Decimal Seguro_Imp
        {
            get { return n_Seguro_Imp; }
            set { n_Seguro_Imp = value; }
        }

        public String FlagOrigen
        {
            get { return c_FlagOrigen; }
            set { c_FlagOrigen = value; }
        }

        public String FlagReplicado
        {
            get { return c_FlagReplicado; }
            set { c_FlagReplicado = value; }
        }

        public String CompaniaRep
        {
            get { return c_CompaniaRep; }
            set { c_CompaniaRep = value; }
        }

        public String NumeroOrdenRep
        {
            get { return c_NumeroOrdenRep; }
            set { c_NumeroOrdenRep = value; }
        }

        public Int32 Proveedor_Original
        {
            get { return n_Proveedor_Original; }
            set { n_Proveedor_Original = value; }
        }

        public String RazonOriginal
        {
            get { return c_RazonOriginal; }
            set { c_RazonOriginal = value; }
        }

        public String Garantia_Cab
        {
            get { return c_Garantia_Cab; }
            set { c_Garantia_Cab = value; }
        }

        public String Operatividad_Cab
        {
            get { return c_Operatividad_Cab; }
            set { c_Operatividad_Cab = value; }
        }

        public DateTime FechaCanalRojo
        {
            get { return d_FechaCanalRojo; }
            set { d_FechaCanalRojo = value; }
        }

        public DateTime FechaCanalNaranja
        {
            get { return d_FechaCanalNaranja; }
            set { d_FechaCanalNaranja = value; }
        }

        public Int32 OrdenFirma
        {
            get { return n_OrdenFirma; }
            set { n_OrdenFirma = value; }
        }

        public String EstadoFirma
        {
            get { return c_EstadoFirma; }
            set { c_EstadoFirma = value; }
        }

        public String UsuarioFirma
        {
            get { return c_UsuarioFirma; }
            set { c_UsuarioFirma = value; }
        }

        public DateTime FechaFirma
        {
            get { return d_FechaFirma; }
            set { d_FechaFirma = value; }
        }

        public String Via
        {
            get { return c_Via; }
            set { c_Via = value; }
        }

        public DateTime FechaPagoIni
        {
            get { return d_FechaPagoIni; }
            set { d_FechaPagoIni = value; }
        }

    }
}