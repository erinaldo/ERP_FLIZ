using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Repository.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Contabilidad
{
    public class negReporteCB
    {
        public static List<String> RptLibroDiarioTXT(String Cia, String Periodo, String Moneda, String TipoCuenta, String IncPerRel, String TipoRep)
        {
            DataTable oDT = datReporteCB.RptLibroDiario(Cia, Periodo, Moneda, TipoCuenta, IncPerRel, TipoRep);
            List<String> oTxt = new List<String>();
            foreach(DataRow oDr in oDT.Rows){
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptLibroMayorTXT(String Cia, String Periodo, String Moneda, String CuentaIni, String CuentaFin, String TipoCuenta, String IncPerRel, String TipoRep)
        {
            DataTable oDT = datReporteCB.RptLibroMayor(Cia, Periodo, Moneda, CuentaIni, CuentaFin, TipoCuenta, IncPerRel, TipoRep);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows){
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptRegistroCompra(String Cia, String PerIni, String PerFin, String RegOB, String RegCChica, String RegRGasto,
        String FlagProv, String Proveedor, String FlagDatoProv, String DatoProv, String TipoRep){

            DataTable oDT = datReporteCB.RptRegistroCompra(Cia, PerIni, PerFin, RegOB, RegCChica, RegRGasto,
                FlagProv, Proveedor, FlagDatoProv, DatoProv, TipoRep);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows){
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptRegistroRetencion(String Cia, String FlagPeriodo, String Periodo, String FlagProveedor, Int32 Proveedor,
        String FlagFecha, DateTime FechaPagoIni, DateTime FechaPagoFin, String FlagTipo, String Tipo, Int32 Retencion, String FlagEstado,
        String Estado, String ExcluirAnulado, String FlagOrigenRet, String OrigenRet, String SunatTXT){

                DataTable oDT = datReporteCB.RptRegistroRetencion(Cia, FlagPeriodo, Periodo, FlagProveedor, Proveedor,
                                FlagFecha, FechaPagoIni, FechaPagoFin, FlagTipo, Tipo, Retencion, FlagEstado,
                                Estado, ExcluirAnulado, FlagOrigenRet, OrigenRet, SunatTXT);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows){
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptRegistroDaotVenta(String Cia, String Periodo, String FlagSupera, String Tipo)
        {
            DataTable oDT = datReporteCB.RptRegistroDaotVenta(Cia, Periodo, FlagSupera, Tipo);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows)
            {
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptRegistroDaotCompra(String Cia, String Periodo, String FlagSupera, String Tipo)
        {
            DataTable oDT = datReporteCB.RptRegistroDaotCompra(Cia, Periodo, FlagSupera, Tipo);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows)
            {
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

        public static List<String> RptPlanCuenta(String Cia, String Periodo, String TipoPlan, String FlagCuenta, String Mayor02,
        String Mayor03, String Mayor04, String Mayor05, String FlagEstado, String Estado, String TipoRep){
            DataTable oDT = datReporteCB.RptPlanCuenta(Cia, Periodo, TipoPlan, FlagCuenta, Mayor02,
                                Mayor03, Mayor04, Mayor05, FlagEstado, Estado, TipoRep);
            List<String> oTxt = new List<String>();
            foreach (DataRow oDr in oDT.Rows){
                oTxt.Add(oDr[0].ToString());
            }
            return oTxt;
        }

    }
}
