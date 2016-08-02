using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Funciones
{
    public class fnListasDat
    {
        #region "==Lista General=="

        public static List<entComboList> ListEstadoF1() {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoActivoCod, Nombre=fnConst.EstadoActivoNom});
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoInactivoCod, Nombre = fnConst.EstadoInactivoNom });
            return Lista;
        }

        public static List<entComboList> ListEstadoF2()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoAbiertoCod, Nombre = fnConst.EstadoAbiertoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoCerradoCod, Nombre = fnConst.EstadoCerradoNom });
            return Lista;
        }

        public static List<entComboList> ListMoneda()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            return Lista;
        }

        public static List<entComboList> ListMonedaTodos()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.StringT, Nombre = fnConst.TextTodos });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            return Lista;
        }

        public static List<entComboList> ListMonedaNinguno()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            return Lista;
        }

        public static List<entComboList> ListFormatoReporte()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.FormatoDetalladoCod, Nombre = fnConst.FormatoDetalladoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.FormatoResumidoCod, Nombre = fnConst.FormatoResumidoNom });
            return Lista;
        }

        public static List<entComboList> ListEstadoSiNoAmbos()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.StringSiCod, Nombre = fnConst.StringSiNom });
            Lista.Add(new entComboList() { Codigo = fnConst.StringNoCod, Nombre = fnConst.StringNoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.StringAmbosCod, Nombre = fnConst.StringAmbosNom });
            return Lista;
        }

        public static List<entComboList> ListEstadoSiNoNinguno()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.StringSiCod, Nombre = fnConst.StringSiNom });
            Lista.Add(new entComboList() { Codigo = fnConst.StringNoCod, Nombre = fnConst.StringNoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            return Lista;
        }

        public static List<entComboList> ListEstadoSiNoRaya()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.StringSiCod, Nombre = fnConst.StringSiNom });
            Lista.Add(new entComboList() { Codigo = fnConst.StringNoCod, Nombre = fnConst.StringNoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextRaya3 });
            return Lista;
        }

        public static List<entComboList> ListParametroTipo()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ParametroTextoCod, Nombre = fnConst.ParametroTextoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ParametroNumeroCod, Nombre = fnConst.ParametroNumeroNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ParametroFechaCod, Nombre = fnConst.ParametroFechaNom });
            return Lista;
        }

        #endregion

        #region "==Lista Tesoreria=="

        public static List<entComboList> ListEstadoObligacion()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegPendienteCod, Nombre = fnConst.EstadoRegPendienteNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegAprobadoCod, Nombre = fnConst.EstadoRegAprobadoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegRechazadoCod, Nombre = fnConst.EstadoRegRechazadoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegAnuladoCod, Nombre = fnConst.EstadoRegAnuladoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegPagadoParcialCod, Nombre = fnConst.EstadoRegPagadoParcialNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegPagadoCod, Nombre = fnConst.EstadoRegPagadoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EstadoRegCanjeadoCod, Nombre = fnConst.EstadoRegCanjeadoNom });
            return Lista;
        }

        #endregion

        #region "==Lista Contabilidad=="

        public static List<entComboList> ListTipoCuentaContable()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TipoCuentaGenCod, Nombre = fnConst.TipoCuentaGenNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoCuentaEmpCod, Nombre = fnConst.TipoCuentaEmpNom });
            return Lista;
        }

        public static List<entComboList> ListGrupoCuentaRep()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = "M", Nombre = "Cta Mayor." });
            Lista.Add(new entComboList() { Codigo = "C", Nombre = "Cuentas" });
            return Lista;
        }

        public static List<entComboList> ListIngresoEgresoF1()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.IngresoCod, Nombre = fnConst.IngresoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.EgresoCod, Nombre = fnConst.EgresoNom });
            return Lista;
        }

        public static List<entComboList> ListMonedaMulti()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            Lista.Add(new entComboList() { Codigo = fnConst.MonedaMulCod, Nombre = fnConst.MonedaMulNom });
            return Lista;
        }

        public static List<entComboList> ListRequeridoOpcion()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.ReqTipoOpcionalCod, Nombre = fnConst.ReqTipoOpcionalNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ReqTipoRequeridoCod, Nombre = fnConst.ReqTipoRequeridoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ReqTipoNoRequeridoCod, Nombre = fnConst.ReqTipoNoRequeridoNom });
            return Lista;
        }

        public static List<entComboList> ListNivelCuenta()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.NivelCuentaBalanceGenCod, Nombre = fnConst.NivelCuentaBalanceGenNom });
            Lista.Add(new entComboList() { Codigo = fnConst.NivelCuentaIngresoCod, Nombre = fnConst.NivelCuentaIngresoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.NivelCuentaEgresoCod, Nombre = fnConst.NivelCuentaEgresoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.NivelCuentaOrdenCod, Nombre = fnConst.NivelCuentaOrdenNom });
            Lista.Add(new entComboList() { Codigo = fnConst.NivelCuentaOtroCod, Nombre = fnConst.NivelCuentaOtroNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            return Lista;
        }

        public static List<entComboList> ListClasificacionGasto()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.ClasificaGastoFijoCod, Nombre = fnConst.ClasificaGastoFijoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.ClasificaGastoVariableCod, Nombre = fnConst.ClasificaGastoVariableNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            return Lista;
        }

        public static List<entComboList> ListTipoPersonaGeneral()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TipoPersGenEmpProvCod, Nombre = fnConst.TipoPersGenEmpProvNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoPersGenEmpleadoCod, Nombre = fnConst.TipoPersGenEmpleadoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoPersGenProveedorCod, Nombre = fnConst.TipoPersGenProveedorNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoPersGenClienteCod, Nombre = fnConst.TipoPersGenClienteNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            return Lista;
        }

        public static List<entComboList> ListUsoSubCuenta()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.UsoSubCuentaTransfCod, Nombre = fnConst.UsoSubCuentaTransfNom });
            Lista.Add(new entComboList() { Codigo = fnConst.UsoSubCuentaAjusteCod, Nombre = fnConst.UsoSubCuentaAjusteNom });
            return Lista;
        }

        public static List<entComboList> ListTipoBien()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoBienTangibleCod, Nombre = fnConst.TipoBienTangibleNom });
            Lista.Add(new entComboList() { Codigo = fnConst.TipoBienInTangibleCod, Nombre = fnConst.TipoBienInTangibleNom });
            return Lista;
        }

        public static List<entComboList> ListRptGrupoCCosto()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.RepCCostoGrupoXCCostoCod, Nombre = fnConst.RepCCostoGrupoXCCostoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.RepCCostoGrupoXCGrupoCod, Nombre = fnConst.RepCCostoGrupoXCGrupoNom });
            return Lista;
        }

        public static List<entComboList> ListRptLBContableVersion()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.RepVersionLBContableV409Cod, Nombre = fnConst.RepVersionLBContableV409Nom });
            Lista.Add(new entComboList() { Codigo = fnConst.RepVersionLBContableV500Cod, Nombre = fnConst.RepVersionLBContableV500Nom });
            return Lista;
        }

        #endregion

        #region =="Lista RRHH=="

        public static List<entComboList> ListRepTipoRH()
        {
            List<entComboList> Lista = new List<entComboList>();
            Lista.Add(new entComboList() { Codigo = fnConst.TextNingunoCod, Nombre = fnConst.TextNingunoNom });
            Lista.Add(new entComboList() { Codigo = fnConst.RepTipoRHMarketingCod, Nombre = fnConst.RepTipoRHMarketingNom });
            Lista.Add(new entComboList() { Codigo = fnConst.RepTipoRHVentaNom, Nombre = fnConst.RepTipoRHVentaNom });
            return Lista;
        }

        #endregion

    }
}
