using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entCuentaContable : entBase
    {
        private String c_Cuenta, c_Nombres, c_Estado = "A", c_UltimoUsuario, c_FlagDesaduanaje = "N", c_CodRubro, c_FlagEdificio = "N";
        private String c_CuentaMayor, c_TipoGasto, c_Moneda = "M", c_FlagCuentaTrans = "N", c_CuentaDebeTrans, c_CuentaHaberTrans;
        private String c_FlagPermiteAjuste = "N", c_FlagCierreAnual13 = "N", c_FlagCierreAnual14 = "N", c_ReqPersona = "N", c_TipoPersonaGen;
        private String c_TipoPersonaEsp, c_ReqProyecto = "N", c_ReqOrdenCompra = "N", c_ReqDocumento = "N", c_ReqFecha = "N", c_ReqCCosto = "N";
        private String c_ReqDescripcion = "N", c_ReqFlujoCaja = "N", c_FlagSaldoPersona = "N", c_FlagSaldoDocumento = "N", c_LibroCaja;
        private String c_ClasificacionGasto, c_RubroGasto, c_TipoCuenta = "G", c_CuentaMayor04, c_CuentaMayor05, c_ElmentoGasto, c_NivelCuenta;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CuentaMayorNombre;
        private String c_UserNombreForm;
        private List<entCompCContable> xDetCompCContable = new List<entCompCContable>();

        public String Cuenta
        {
            get { return c_Cuenta; }
            set { c_Cuenta = value; }
        }

        public String Nombres
        {
            get { return c_Nombres; }
            set { c_Nombres = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
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

        public String FlagDesaduanaje
        {
            get { return c_FlagDesaduanaje; }
            set { c_FlagDesaduanaje = value; }
        }

        public String CodRubro
        {
            get { return c_CodRubro; }
            set { c_CodRubro = value; }
        }

        public String FlagEdificio
        {
            get { return c_FlagEdificio; }
            set { c_FlagEdificio = value; }
        }

        public String CuentaMayor
        {
            get { return c_CuentaMayor; }
            set { c_CuentaMayor = value; }
        }

        public String TipoGasto
        {
            get { return c_TipoGasto; }
            set { c_TipoGasto = value; }
        }

        public String Moneda
        {
            get { return c_Moneda; }
            set { c_Moneda = value; }
        }

        public String FlagCuentaTrans
        {
            get { return c_FlagCuentaTrans; }
            set { c_FlagCuentaTrans = value; }
        }

        public String CuentaDebeTrans
        {
            get { return c_CuentaDebeTrans; }
            set { c_CuentaDebeTrans = value; }
        }

        public String CuentaHaberTrans
        {
            get { return c_CuentaHaberTrans; }
            set { c_CuentaHaberTrans = value; }
        }

        public String FlagPermiteAjuste
        {
            get { return c_FlagPermiteAjuste; }
            set { c_FlagPermiteAjuste = value; }
        }

        public String FlagCierreAnual13
        {
            get { return c_FlagCierreAnual13; }
            set { c_FlagCierreAnual13 = value; }
        }

        public String FlagCierreAnual14
        {
            get { return c_FlagCierreAnual14; }
            set { c_FlagCierreAnual14 = value; }
        }

        public String ReqPersona
        {
            get { return c_ReqPersona; }
            set { c_ReqPersona = value; }
        }

        public String TipoPersonaGen
        {
            get { return c_TipoPersonaGen; }
            set { c_TipoPersonaGen = value; }
        }

        public String TipoPersonaEsp
        {
            get { return c_TipoPersonaEsp; }
            set { c_TipoPersonaEsp = value; }
        }

        public String ReqProyecto
        {
            get { return c_ReqProyecto; }
            set { c_ReqProyecto = value; }
        }

        public String ReqOrdenCompra
        {
            get { return c_ReqOrdenCompra; }
            set { c_ReqOrdenCompra = value; }
        }

        public String ReqDocumento
        {
            get { return c_ReqDocumento; }
            set { c_ReqDocumento = value; }
        }

        public String ReqFecha
        {
            get { return c_ReqFecha; }
            set { c_ReqFecha = value; }
        }

        public String ReqCCosto
        {
            get { return c_ReqCCosto; }
            set { c_ReqCCosto = value; }
        }

        public String ReqDescripcion
        {
            get { return c_ReqDescripcion; }
            set { c_ReqDescripcion = value; }
        }

        public String ReqFlujoCaja
        {
            get { return c_ReqFlujoCaja; }
            set { c_ReqFlujoCaja = value; }
        }

        public String FlagSaldoPersona
        {
            get { return c_FlagSaldoPersona; }
            set { c_FlagSaldoPersona = value; }
        }

        public String FlagSaldoDocumento
        {
            get { return c_FlagSaldoDocumento; }
            set { c_FlagSaldoDocumento = value; }
        }

        public String LibroCaja
        {
            get { return c_LibroCaja; }
            set { c_LibroCaja = value; }
        }

        public String ClasificacionGasto
        {
            get { return c_ClasificacionGasto; }
            set { c_ClasificacionGasto = value; }
        }

        public String RubroGasto
        {
            get { return c_RubroGasto; }
            set { c_RubroGasto = value; }
        }

        public String TipoCuenta
        {
            get { return c_TipoCuenta; }
            set { c_TipoCuenta = value; }
        }

        public String CuentaMayor04
        {
            get { return c_CuentaMayor04; }
            set { c_CuentaMayor04 = value; }
        }

        public String CuentaMayor05
        {
            get { return c_CuentaMayor05; }
            set { c_CuentaMayor05 = value; }
        }

        public String ElmentoGasto
        {
            get { return c_ElmentoGasto; }
            set { c_ElmentoGasto = value; }
        }

        public String NivelCuenta
        {
            get { return c_NivelCuenta; }
            set { c_NivelCuenta = value; }
        }

        public String CuentaMayorNombre
        {
            get { return c_CuentaMayorNombre; }
            set { c_CuentaMayorNombre = value; }
        }

        public List<entCompCContable> DetalleCuentaxCompania
        {
            get { return xDetCompCContable; }
            set { xDetCompCContable = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}