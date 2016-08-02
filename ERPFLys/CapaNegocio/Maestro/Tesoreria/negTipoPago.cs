using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Tesoreria;
using FiltroLys.Repository.Maestro.Tesoreria;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Tesoreria
{
    public class negTipoPago
    {
        public static List<entTipoPago> ListaFormID()
        {
            List<entTipoPago> ListObj = new List<entTipoPago>();
            ListObj = datTipoPago.ListaFormID().ToList<entTipoPago>();
            return ListObj;
        }

        public static entTipoPago GetFormID(String TipoPago)
        {
            entTipoPago EObj = new entTipoPago();
            List<entTipoPago> ListObj = new List<entTipoPago>();
            ListObj = datTipoPago.GetFormID(TipoPago).ToList<entTipoPago>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoPago> ListaCombo(String FlagSistema,String Estado,String[] Def = null)
        {
            List<entTipoPago> ListObj = new List<entTipoPago>();
            ListObj = datTipoPago.ListaCombo(FlagSistema,Estado).ToList<entTipoPago>();
            if (Def != null){
                ListObj.Insert(0, new entTipoPago() { TipoPago = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoPago> ListaSearch(String TipoPago,String FlagSistema, String Descripcion, String Estado)
        {
            List<entTipoPago> ListObj = new List<entTipoPago>();
            ListObj = datTipoPago.ListaSearch(TipoPago,FlagSistema, Descripcion, Estado).ToList<entTipoPago>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoPago Data)
        {
            return datTipoPago.MantFormID(Data);
        }

    }
}
