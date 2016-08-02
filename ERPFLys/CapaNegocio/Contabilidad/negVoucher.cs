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
    public class negVoucher
    {
        public static List<entVoucher> ListVoucherForm(String Cia, String FlagDepartCia, String DepartCia, String FlagPeriodo,
        String Periodo, String FlagEstado, String Estado, String FlagVoucher, String TipoVoucher, String VoucherIni, String VoucherFin)
        {
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.ListVoucherForm(Cia, FlagDepartCia, DepartCia, FlagPeriodo, Periodo, FlagEstado,
                                                 Estado, FlagVoucher, TipoVoucher, VoucherIni, VoucherFin).ToList<entVoucher>();
            
            return ListObj;
        }

        public static entVoucher GetVoucherFormID(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            entVoucher EObj = new entVoucher();
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.GetVoucherFormID(Cia, Periodo, TipoVoucher, NroVoucher).ToList<entVoucher>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entVoucherDet> GetVoucherFormIDDet(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            List<entVoucherDet> ListObj = new List<entVoucherDet>();
            ListObj = datVoucher.GetVoucherFormIDDet(Cia, Periodo, TipoVoucher, NroVoucher).ToList<entVoucherDet>();
            return ListObj;
        }

        public static String GetEstadoVoucher(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            String sEst = "";
            entVoucher EObj = GetVoucherFormID(Cia, Periodo, TipoVoucher, NroVoucher);
            sEst = (EObj.ResultadoBusqueda) ? EObj.Estado : "";
            EObj = null;
            return sEst;
        }

        public static List<entVoucher> ListVoucherToMayor(String Cia, String Periodo, String Estado)
        {
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.ListVoucherToMayor(Cia, Periodo, Estado).ToList<entVoucher>();
            return ListObj;
        }

        public static List<entVoucherDet> ListVoucherDetCiaPerCuenta(String Cia, String Periodo, String Cuenta)
        {
            List<entVoucherDet> ListObj = new List<entVoucherDet>();
            ListObj = datVoucher.ListVoucherDetCiaPerCuenta(Cia, Periodo, Cuenta).ToList<entVoucherDet>();
            return ListObj;
        }

        public static entErrores MantVoucher(entVoucher Data)
        {
            return datVoucher.MantVoucher(Data);
        }

        public static entErrores MantVoucher(List<entVoucher> Data, ref BackgroundWorker worker){
            return datVoucher.MantVoucher(Data, ref worker);
        }

    }
}
