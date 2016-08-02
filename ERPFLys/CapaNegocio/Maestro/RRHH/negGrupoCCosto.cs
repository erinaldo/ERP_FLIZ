using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Repository.Maestro.RRHH;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.RRHH
{
    public class negGrupoCCosto
    {
        public static List<entGrupoCCosto> ListaFormID()
        {
            List<entGrupoCCosto> ListObj = new List<entGrupoCCosto>();
            ListObj = datGrupoCCosto.ListaFormID().ToList<entGrupoCCosto>();
            return ListObj;
        }

        public static entGrupoCCosto GetFormID(String Compania, String Grupo)
        {
            entGrupoCCosto EObj = new entGrupoCCosto();
            List<entGrupoCCosto> ListObj = new List<entGrupoCCosto>();
            ListObj = datGrupoCCosto.GetFormID(Compania, Grupo).ToList<entGrupoCCosto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entGrupoCCosto> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entGrupoCCosto> ListObj = new List<entGrupoCCosto>();
            ListObj = datGrupoCCosto.ListaCombo(Compania, Estado).ToList<entGrupoCCosto>();
            if (Def != null){
                ListObj.Insert(0, new entGrupoCCosto() { GrupoCC = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entGrupoCCosto> ListaSearch(String Compania, String Grupo, String Descripcion, String Estado)
        {
            List<entGrupoCCosto> ListObj = new List<entGrupoCCosto>();
            ListObj = datGrupoCCosto.ListaSearch(Compania, Grupo, Descripcion, Estado).ToList<entGrupoCCosto>();
            return ListObj;
        }

        public static entErrores MantFormID(entGrupoCCosto Data)
        {
            return datGrupoCCosto.MantFormID(Data);
        }

    }
}
