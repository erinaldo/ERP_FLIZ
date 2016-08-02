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
    public class negGrupoElementoGasto
    {
        public static List<entGrupoElementoGasto> ListaFormID()
        {
            List<entGrupoElementoGasto> ListObj = new List<entGrupoElementoGasto>();
            ListObj = datGrupoElementoGasto.ListaFormID().ToList<entGrupoElementoGasto>();
            return ListObj;
        }

        public static entGrupoElementoGasto GetFormID(String Grupo)
        {
            entGrupoElementoGasto EObj = new entGrupoElementoGasto();
            List<entGrupoElementoGasto> ListObj = new List<entGrupoElementoGasto>();
            ListObj = datGrupoElementoGasto.GetFormID(Grupo).ToList<entGrupoElementoGasto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entGrupoElementoGasto> ListaCombo(String Estado, String[] Def = null)
        {
            List<entGrupoElementoGasto> ListObj = new List<entGrupoElementoGasto>();
            ListObj = datGrupoElementoGasto.ListaCombo(Estado).ToList<entGrupoElementoGasto>();
            if (Def != null){
                ListObj.Insert(0, new entGrupoElementoGasto() { Grupo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entGrupoElementoGasto> ListaSearch(String Grupo, String Descripcion, String Estado)
        {
            List<entGrupoElementoGasto> ListObj = new List<entGrupoElementoGasto>();
            ListObj = datGrupoElementoGasto.ListaSearch(Grupo, Descripcion, Estado).ToList<entGrupoElementoGasto>();
            return ListObj;
        }

        public static entErrores MantFormID(entGrupoElementoGasto Data)
        {
            return datGrupoElementoGasto.MantFormID(Data);
        }

    }
}
