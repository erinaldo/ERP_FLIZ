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
    public class negElementoGasto
    {
        public static List<entElementoGasto> ListaFormID()
        {
            List<entElementoGasto> ListObj = new List<entElementoGasto>();
            ListObj = datElementoGasto.ListaFormID().ToList<entElementoGasto>();
            return ListObj;
        }

        public static entElementoGasto GetFormID(String Elemento)
        {
            entElementoGasto EObj = new entElementoGasto();
            List<entElementoGasto> ListObj = new List<entElementoGasto>();
            ListObj = datElementoGasto.GetFormID(Elemento).ToList<entElementoGasto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entElementoGasto> ListaCombo(String Estado, String[] Def = null)
        {
            List<entElementoGasto> ListObj = new List<entElementoGasto>();
            ListObj = datElementoGasto.ListaCombo(Estado).ToList<entElementoGasto>();
            if (Def != null){
                ListObj.Insert(0, new entElementoGasto() { Elemento = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entElementoGasto> ListaSearch(String Elemento, String Descripcion, String Estado)
        {
            List<entElementoGasto> ListObj = new List<entElementoGasto>();
            ListObj = datElementoGasto.ListaSearch(Elemento, Descripcion, Estado).ToList<entElementoGasto>();
            return ListObj;
        }

        public static entErrores MantFormID(entElementoGasto Data)
        {
            return datElementoGasto.MantFormID(Data);
        }

    }
}
