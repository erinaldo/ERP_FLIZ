using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Repository.Contabilidad;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Type;

namespace FiltroLys.Domain.Contabilidad
{
    public class negCierreMesCuenta
    {
        public static List<entCierreMesCuenta> ListSaldoCtaMayor(String Compania, String Periodo)
        {
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.ListSaldoCtaMayor(Compania, Periodo).ToList<entCierreMesCuenta>();
            return ListObj;
        }

        public static List<entCierreMesCuenta> ListSaldoCtaMayorDet(String Compania, String Periodo, String Mayor)
        {
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.ListSaldoCtaMayorDet(Compania, Periodo, Mayor).ToList<entCierreMesCuenta>();
            return ListObj;
        }

        public static List<entFail> GetCierreMensualRev(String Compania, String Periodo,String Operacion)
        {
            List<entFail> ListObj = new List<entFail>();
            ListObj = datCierreMesCuenta.GetCierreMensualRev(Compania, Periodo, Operacion).ToList<entFail>();
            return ListObj;
        }

        public static String SetCierreMensualGen(String Compania, String Periodo, String Usuario) {
            return datCierreMesCuenta.SetCierreMensualGen(Compania, Periodo, Usuario);
        }

        public static String SetModificaPeriodo(String Compania, String Periodo, String Usuario, String Operacion) {
            return datCierreMesCuenta.SetModificaPeriodo(Compania, Periodo, Usuario, Operacion);
        }

        public static String GetPeriodoSig(String Periodo) {
            return datCierreMesCuenta.GetPeriodoSig(Periodo);
        }

        public static Int32 SetPeriodoTrabajo(String Compania, String Periodo) {
            Int32 nValPer = 0;
            nValPer = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, Compania, Periodo);
            if (nValPer > 0) {
                nValPer = datCierreMesCuenta.SetPeriodoTrabajo(Compania, Periodo);
            }
            return nValPer;
        }

    }
}
