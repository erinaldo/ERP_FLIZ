using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negCorrelativoVoucher
    {
        public static List<entCorrelativoVoucher> ListaFormID()
        {
            List<entCorrelativoVoucher> ListObj = new List<entCorrelativoVoucher>();
            ListObj = datCorrelativoVoucher.ListaFormID().ToList<entCorrelativoVoucher>();
            return ListObj;
        }

        public static entCorrelativoVoucher GetFormID(String Compania, Int32 Anual, String TipoVoucher)
        {
            entCorrelativoVoucher EObj = new entCorrelativoVoucher();
            List<entCorrelativoVoucher> ListObj = new List<entCorrelativoVoucher>();
            ListObj = datCorrelativoVoucher.GetFormID(Compania,Anual,TipoVoucher).ToList<entCorrelativoVoucher>();
            if (ListObj.Count > 0)
            {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCorrelativoVoucher> ListaCombo(String Compania, Int32 Anual, String[] Def = null)
        {
            List<entCorrelativoVoucher> ListObj = new List<entCorrelativoVoucher>();
            ListObj = datCorrelativoVoucher.ListaCombo(Compania, Anual).ToList<entCorrelativoVoucher>();
            if (Def != null){
                ListObj.Insert(0, new entCorrelativoVoucher() { TipoVoucher = Def[0]});
            }
            return ListObj;
        }

        public static List<entCorrelativoVoucher> ListaSearch(String Compania, Int32 Anual, String TipoVoucher)
        {
            List<entCorrelativoVoucher> ListObj = new List<entCorrelativoVoucher>();
            ListObj = datCorrelativoVoucher.ListaSearch(Compania, Anual, TipoVoucher).ToList<entCorrelativoVoucher>();
            return ListObj;
        }

        public static entErrores MantFormID(entCorrelativoVoucher Data)
        {
            return datCorrelativoVoucher.MantFormID(Data);
        }

        public static Int32 GetUltimoCorrelativo(String Compania, String Periodo, String Tipo) {
            Int32 nCorrelativo = datCorrelativoVoucher.GetUltimoCorrelativo(Compania,Periodo,Tipo);
            return nCorrelativo;
        }

    }
}
