using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Tesoreria
{
    public class entObligacion : entBase
    {
        private String c_Compania, c_TipoDocumento, c_NumeroDocumento, c_NumDocFiscal, c_NombreProveedor, c_PagoANombre, c_CentroCosto, c_CodIng;
        private String c_CodAPrueba, c_MonedaDoc, c_TipoServicio, c_MonedaPago, c_TipoPago, c_FlujoCaja, c_FlujoCajaPago, c_Compania_Rel;
        private String c_TipoDocumento_Rel, c_NumeroDoc_Rel, c_BancoCodigoPago, c_CtaBancariaPago, c_CptoContable, c_BancoCodigoCobro;
        private String c_CAgenciaCobro, c_FlagGenPago = "N", c_FlagAgruparPago, c_FlagPagoDiferido, c_FlagContabilizado, c_FlagAdelanto;
        private String c_PeriodoVoucher, c_Voucher, c_PeriodoVoucherAn, c_VoucherAnulacion, c_Origen, c_PeriodoRegCompra, c_EstadoDoc;
        private String c_GlosaVoucher, c_CObservacion, c_ObsAnulacion, c_FlagImportacion = "N", c_BancoCustodia, c_NumeroBanco, c_TipoNegociacion;
        private String c_VoucherPend, c_ObsPendiente, c_FlagPercepcion = "N", c_NumeroImportacion, c_FlagDetraccion = "N", c_FlagMontoRefDet = "N";
        private String c_UltimoUsuarioMod, c_FlagHabilitaVisto = "N", c_FlagVisto = "N", c_FlagRecepcionDoc = "N", c_PeriodoPlanilla;
        private String c_FactoryAnt = "N", c_DocSunatDet, c_UsuarioConstDetraccion, c_FlagConstancia = "N", c_DocSunatDet_Otro;
        private String c_UsuarioConstDetraccion_Otro, c_FlagConstancia_Otro = "N", c_FlagFactorIng = "N", c_TipoDocumento_Fact;
        private String c_NumeroDocumento_Fact, c_UsuarioSubida_Fact;
        private Decimal n_Obligacion;
        private Int32 n_CodProveedor, n_CodPagaraNombre, n_SecuenciaPago, n_CodBienServDet, n_CodTipoOpeDet;
        private Decimal n_TipoCambio, n_MontoAfecto, n_MontoNoAfecto, n_MontoIgv, n_MontoOtroImpuesto, n_MontoTotal;
        private Decimal n_MontoAdelanto, n_MontoPagoParcial, n_Mora, n_SaldoAPagar, n_Saldo = 0, n_Obligacion_Rel, n_NumeroPago;
        private Decimal n_TipoCambioProv, n_Advalorem = 0, n_RegistroOb = 0, n_PorcentajeDet, n_MontoRefDet, n_BaseImponible = 0;
        private Decimal n_MontoIvgImp = 0, n_MontoRetencion = 0, n_DiasPlazo, n_MontoFactorIng, n_ImporteSunatDet = 0, n_ImporteSunatDet_otro = 0;
        private DateTime d_FechaRegistro, d_FechaEmision, d_FechaRecepcion, d_FechaVencimiento, d_FechaPago, d_FechaAprobacion;
        private DateTime d_FechaVencOrigen, d_FechaProvision, d_FechaEnvioBanco, d_UltimaFechaMod, d_FechaConstDetraccion;
        private DateTime d_FechaConstDetraccion_Otro, d_FechaSunatDet, d_FechaSunatDet_Otro, d_FechaVencimiento_Fact, d_FechaRecepcion_Fact;
        private DateTime d_FechaSubida_Fact;
        private String c_DocumentoCompleto;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Decimal Obligacion
        {
            get { return n_Obligacion; }
            set { n_Obligacion = value; }
        }

        public String TipoDocumento
        {
            get { return c_TipoDocumento; }
            set { c_TipoDocumento = value; }
        }

        public String NumeroDocumento
        {
            get { return c_NumeroDocumento; }
            set { c_NumeroDocumento = value; }
        }

        public Int32 CodProveedor
        {
            get { return n_CodProveedor; }
            set { n_CodProveedor = value; }
        }

        public Int32 CodPagaraNombre
        {
            get { return n_CodPagaraNombre; }
            set { n_CodPagaraNombre = value; }
        }

        public String NumDocFiscal
        {
            get { return c_NumDocFiscal; }
            set { c_NumDocFiscal = value; }
        }

        public String NombreProveedor
        {
            get { return c_NombreProveedor; }
            set { c_NombreProveedor = value; }
        }

        public String PagoANombre
        {
            get { return c_PagoANombre; }
            set { c_PagoANombre = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public String CodIng
        {
            get { return c_CodIng; }
            set { c_CodIng = value; }
        }

        public String CodAPrueba
        {
            get { return c_CodAPrueba; }
            set { c_CodAPrueba = value; }
        }

        public DateTime FechaRegistro
        {
            get { return d_FechaRegistro; }
            set { d_FechaRegistro = value; }
        }

        public DateTime FechaEmision
        {
            get { return d_FechaEmision; }
            set { d_FechaEmision = value; }
        }

        public DateTime FechaRecepcion
        {
            get { return d_FechaRecepcion; }
            set { d_FechaRecepcion = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return d_FechaVencimiento; }
            set { d_FechaVencimiento = value; }
        }

        public DateTime FechaPago
        {
            get { return d_FechaPago; }
            set { d_FechaPago = value; }
        }

        public DateTime FechaAprobacion
        {
            get { return d_FechaAprobacion; }
            set { d_FechaAprobacion = value; }
        }

        public DateTime FechaVencOrigen
        {
            get { return d_FechaVencOrigen; }
            set { d_FechaVencOrigen = value; }
        }

        public String MonedaDoc
        {
            get { return c_MonedaDoc; }
            set { c_MonedaDoc = value; }
        }

        public Decimal TipoCambio
        {
            get { return n_TipoCambio; }
            set { n_TipoCambio = value; }
        }

        public Decimal MontoAfecto
        {
            get { return n_MontoAfecto; }
            set { n_MontoAfecto = value; }
        }

        public Decimal MontoNoAfecto
        {
            get { return n_MontoNoAfecto; }
            set { n_MontoNoAfecto = value; }
        }

        public Decimal MontoIgv
        {
            get { return n_MontoIgv; }
            set { n_MontoIgv = value; }
        }

        public Decimal MontoOtroImpuesto
        {
            get { return n_MontoOtroImpuesto; }
            set { n_MontoOtroImpuesto = value; }
        }

        public Decimal MontoTotal
        {
            get { return n_MontoTotal; }
            set { n_MontoTotal = value; }
        }

        public Decimal MontoAdelanto
        {
            get { return n_MontoAdelanto; }
            set { n_MontoAdelanto = value; }
        }

        public Decimal MontoPagoParcial
        {
            get { return n_MontoPagoParcial; }
            set { n_MontoPagoParcial = value; }
        }

        public Decimal Mora
        {
            get { return n_Mora; }
            set { n_Mora = value; }
        }

        public Decimal SaldoAPagar
        {
            get { return n_SaldoAPagar; }
            set { n_SaldoAPagar = value; }
        }

        public Decimal Saldo
        {
            get { return n_Saldo; }
            set { n_Saldo = value; }
        }

        public String TipoServicio
        {
            get { return c_TipoServicio; }
            set { c_TipoServicio = value; }
        }

        public String MonedaPago
        {
            get { return c_MonedaPago; }
            set { c_MonedaPago = value; }
        }

        public String TipoPago
        {
            get { return c_TipoPago; }
            set { c_TipoPago = value; }
        }

        public String FlujoCaja
        {
            get { return c_FlujoCaja; }
            set { c_FlujoCaja = value; }
        }

        public String FlujoCajaPago
        {
            get { return c_FlujoCajaPago; }
            set { c_FlujoCajaPago = value; }
        }

        public String Compania_Rel
        {
            get { return c_Compania_Rel; }
            set { c_Compania_Rel = value; }
        }

        public Decimal Obligacion_Rel
        {
            get { return n_Obligacion_Rel; }
            set { n_Obligacion_Rel = value; }
        }

        public String TipoDocumento_Rel
        {
            get { return c_TipoDocumento_Rel; }
            set { c_TipoDocumento_Rel = value; }
        }

        public String NumeroDoc_Rel
        {
            get { return c_NumeroDoc_Rel; }
            set { c_NumeroDoc_Rel = value; }
        }

        public String BancoCodigoPago
        {
            get { return c_BancoCodigoPago; }
            set { c_BancoCodigoPago = value; }
        }

        public String CtaBancariaPago
        {
            get { return c_CtaBancariaPago; }
            set { c_CtaBancariaPago = value; }
        }

        public String CptoContable
        {
            get { return c_CptoContable; }
            set { c_CptoContable = value; }
        }

        public String BancoCodigoCobro
        {
            get { return c_BancoCodigoCobro; }
            set { c_BancoCodigoCobro = value; }
        }

        public String CAgenciaCobro
        {
            get { return c_CAgenciaCobro; }
            set { c_CAgenciaCobro = value; }
        }

        public Decimal NumeroPago
        {
            get { return n_NumeroPago; }
            set { n_NumeroPago = value; }
        }

        public Int32 SecuenciaPago
        {
            get { return n_SecuenciaPago; }
            set { n_SecuenciaPago = value; }
        }

        public String FlagGenPago
        {
            get { return c_FlagGenPago; }
            set { c_FlagGenPago = value; }
        }

        public String FlagAgruparPago
        {
            get { return c_FlagAgruparPago; }
            set { c_FlagAgruparPago = value; }
        }

        public String FlagPagoDiferido
        {
            get { return c_FlagPagoDiferido; }
            set { c_FlagPagoDiferido = value; }
        }

        public String FlagContabilizado
        {
            get { return c_FlagContabilizado; }
            set { c_FlagContabilizado = value; }
        }

        public String FlagAdelanto
        {
            get { return c_FlagAdelanto; }
            set { c_FlagAdelanto = value; }
        }

        public String PeriodoVoucher
        {
            get { return c_PeriodoVoucher; }
            set { c_PeriodoVoucher = value; }
        }

        public DateTime FechaProvision
        {
            get { return d_FechaProvision; }
            set { d_FechaProvision = value; }
        }

        public Decimal TipoCambioProv
        {
            get { return n_TipoCambioProv; }
            set { n_TipoCambioProv = value; }
        }

        public String Voucher
        {
            get { return c_Voucher; }
            set { c_Voucher = value; }
        }

        public String PeriodoVoucherAn
        {
            get { return c_PeriodoVoucherAn; }
            set { c_PeriodoVoucherAn = value; }
        }

        public String VoucherAnulacion
        {
            get { return c_VoucherAnulacion; }
            set { c_VoucherAnulacion = value; }
        }

        public String Origen
        {
            get { return c_Origen; }
            set { c_Origen = value; }
        }

        public String PeriodoRegCompra
        {
            get { return c_PeriodoRegCompra; }
            set { c_PeriodoRegCompra = value; }
        }

        public String EstadoDoc
        {
            get { return c_EstadoDoc; }
            set { c_EstadoDoc = value; }
        }

        public String GlosaVoucher
        {
            get { return c_GlosaVoucher; }
            set { c_GlosaVoucher = value; }
        }

        public String CObservacion
        {
            get { return c_CObservacion; }
            set { c_CObservacion = value; }
        }

        public String ObsAnulacion
        {
            get { return c_ObsAnulacion; }
            set { c_ObsAnulacion = value; }
        }

        public Decimal Advalorem
        {
            get { return n_Advalorem; }
            set { n_Advalorem = value; }
        }

        public String FlagImportacion
        {
            get { return c_FlagImportacion; }
            set { c_FlagImportacion = value; }
        }

        public String BancoCustodia
        {
            get { return c_BancoCustodia; }
            set { c_BancoCustodia = value; }
        }

        public String NumeroBanco
        {
            get { return c_NumeroBanco; }
            set { c_NumeroBanco = value; }
        }

        public String TipoNegociacion
        {
            get { return c_TipoNegociacion; }
            set { c_TipoNegociacion = value; }
        }

        public DateTime FechaEnvioBanco
        {
            get { return d_FechaEnvioBanco; }
            set { d_FechaEnvioBanco = value; }
        }

        public Decimal RegistroOb
        {
            get { return n_RegistroOb; }
            set { n_RegistroOb = value; }
        }

        public String VoucherPend
        {
            get { return c_VoucherPend; }
            set { c_VoucherPend = value; }
        }

        public String ObsPendiente
        {
            get { return c_ObsPendiente; }
            set { c_ObsPendiente = value; }
        }

        public String FlagPercepcion
        {
            get { return c_FlagPercepcion; }
            set { c_FlagPercepcion = value; }
        }

        public String NumeroImportacion
        {
            get { return c_NumeroImportacion; }
            set { c_NumeroImportacion = value; }
        }

        public String FlagDetraccion
        {
            get { return c_FlagDetraccion; }
            set { c_FlagDetraccion = value; }
        }

        public Int32 CodBienServDet
        {
            get { return n_CodBienServDet; }
            set { n_CodBienServDet = value; }
        }

        public Int32 CodTipoOpeDet
        {
            get { return n_CodTipoOpeDet; }
            set { n_CodTipoOpeDet = value; }
        }

        public Decimal PorcentajeDet
        {
            get { return n_PorcentajeDet; }
            set { n_PorcentajeDet = value; }
        }

        public String FlagMontoRefDet
        {
            get { return c_FlagMontoRefDet; }
            set { c_FlagMontoRefDet = value; }
        }

        public Decimal MontoRefDet
        {
            get { return n_MontoRefDet; }
            set { n_MontoRefDet = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public Decimal BaseImponible
        {
            get { return n_BaseImponible; }
            set { n_BaseImponible = value; }
        }

        public Decimal MontoIvgImp
        {
            get { return n_MontoIvgImp; }
            set { n_MontoIvgImp = value; }
        }

        public String FlagHabilitaVisto
        {
            get { return c_FlagHabilitaVisto; }
            set { c_FlagHabilitaVisto = value; }
        }

        public String FlagVisto
        {
            get { return c_FlagVisto; }
            set { c_FlagVisto = value; }
        }

        public String FlagRecepcionDoc
        {
            get { return c_FlagRecepcionDoc; }
            set { c_FlagRecepcionDoc = value; }
        }

        public String PeriodoPlanilla
        {
            get { return c_PeriodoPlanilla; }
            set { c_PeriodoPlanilla = value; }
        }

        public String FactoryAnt
        {
            get { return c_FactoryAnt; }
            set { c_FactoryAnt = value; }
        }

        public Decimal MontoRetencion
        {
            get { return n_MontoRetencion; }
            set { n_MontoRetencion = value; }
        }

        public String DocSunatDet
        {
            get { return c_DocSunatDet; }
            set { c_DocSunatDet = value; }
        }

        public String UsuarioConstDetraccion
        {
            get { return c_UsuarioConstDetraccion; }
            set { c_UsuarioConstDetraccion = value; }
        }

        public DateTime FechaConstDetraccion
        {
            get { return d_FechaConstDetraccion; }
            set { d_FechaConstDetraccion = value; }
        }

        public String FlagConstancia
        {
            get { return c_FlagConstancia; }
            set { c_FlagConstancia = value; }
        }

        public String DocSunatDet_Otro
        {
            get { return c_DocSunatDet_Otro; }
            set { c_DocSunatDet_Otro = value; }
        }

        public String UsuarioConstDetraccion_Otro
        {
            get { return c_UsuarioConstDetraccion_Otro; }
            set { c_UsuarioConstDetraccion_Otro = value; }
        }

        public DateTime FechaConstDetraccion_Otro
        {
            get { return d_FechaConstDetraccion_Otro; }
            set { d_FechaConstDetraccion_Otro = value; }
        }

        public String FlagConstancia_Otro
        {
            get { return c_FlagConstancia_Otro; }
            set { c_FlagConstancia_Otro = value; }
        }

        public DateTime FechaSunatDet
        {
            get { return d_FechaSunatDet; }
            set { d_FechaSunatDet = value; }
        }

        public DateTime FechaSunatDet_Otro
        {
            get { return d_FechaSunatDet_Otro; }
            set { d_FechaSunatDet_Otro = value; }
        }

        public String FlagFactorIng
        {
            get { return c_FlagFactorIng; }
            set { c_FlagFactorIng = value; }
        }

        public Decimal DiasPlazo
        {
            get { return n_DiasPlazo; }
            set { n_DiasPlazo = value; }
        }

        public DateTime FechaVencimiento_Fact
        {
            get { return d_FechaVencimiento_Fact; }
            set { d_FechaVencimiento_Fact = value; }
        }

        public Decimal MontoFactorIng
        {
            get { return n_MontoFactorIng; }
            set { n_MontoFactorIng = value; }
        }

        public DateTime FechaRecepcion_Fact
        {
            get { return d_FechaRecepcion_Fact; }
            set { d_FechaRecepcion_Fact = value; }
        }

        public String TipoDocumento_Fact
        {
            get { return c_TipoDocumento_Fact; }
            set { c_TipoDocumento_Fact = value; }
        }

        public String NumeroDocumento_Fact
        {
            get { return c_NumeroDocumento_Fact; }
            set { c_NumeroDocumento_Fact = value; }
        }

        public String UsuarioSubida_Fact
        {
            get { return c_UsuarioSubida_Fact; }
            set { c_UsuarioSubida_Fact = value; }
        }

        public DateTime FechaSubida_Fact
        {
            get { return d_FechaSubida_Fact; }
            set { d_FechaSubida_Fact = value; }
        }

        public Decimal ImporteSunatDet
        {
            get { return n_ImporteSunatDet; }
            set { n_ImporteSunatDet = value; }
        }

        public Decimal ImporteSunatDet_otro
        {
            get { return n_ImporteSunatDet_otro; }
            set { n_ImporteSunatDet_otro = value; }
        }

        public String DocumentoCompleto
        {
            get { return c_DocumentoCompleto; }
            set { c_DocumentoCompleto = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}