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
    public class negTipoVoucher
    {
        public static List<entTipoVoucher> ListaFormID()
        {
            List<entTipoVoucher> ListObj = new List<entTipoVoucher>();
            ListObj = datTipoVoucher.ListaFormID().ToList<entTipoVoucher>();
            return ListObj;
        }

        public static entTipoVoucher GetFormID(String TipoVoucher)
        {
            entTipoVoucher EObj = new entTipoVoucher();
            List<entTipoVoucher> ListObj = new List<entTipoVoucher>();
            ListObj = datTipoVoucher.GetFormID(TipoVoucher).ToList<entTipoVoucher>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoVoucher> ListaCombo(String CorrelativoManual, String FlagSistema, String Estado, String[] Def = null)
        {
            List<entTipoVoucher> ListObj = new List<entTipoVoucher>();
            ListObj = datTipoVoucher.ListaCombo(CorrelativoManual, FlagSistema,Estado).ToList<entTipoVoucher>();
            if (Def != null){
                ListObj.Insert(0, new entTipoVoucher() { TipoVoucher = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoVoucher> ListaSearch(String TipoVoucher, String Descripcion, String CorrelativoManual, String FlagSistema, String Estado)
        {
            List<entTipoVoucher> ListObj = new List<entTipoVoucher>();
            ListObj = datTipoVoucher.ListaSearch(TipoVoucher, Descripcion, CorrelativoManual, FlagSistema,Estado).ToList<entTipoVoucher>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoVoucher Data)
        {
            return datTipoVoucher.MantFormID(Data);
        }

    }
}
