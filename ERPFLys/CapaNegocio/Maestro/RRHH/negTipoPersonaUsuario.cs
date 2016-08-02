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
    public class negTipoPersonaUsuario
    {
        public static List<entTipoPersonaUsuario> ListaFormID()
        {
            List<entTipoPersonaUsuario> ListObj = new List<entTipoPersonaUsuario>();
            ListObj = datTipoPersonaUsuario.ListaFormID().ToList<entTipoPersonaUsuario>();
            return ListObj;
        }

        public static entTipoPersonaUsuario GetFormID(String TipoPersonaUsuario)
        {
            entTipoPersonaUsuario EObj = new entTipoPersonaUsuario();
            List<entTipoPersonaUsuario> ListObj = new List<entTipoPersonaUsuario>();
            ListObj = datTipoPersonaUsuario.GetFormID(TipoPersonaUsuario).ToList<entTipoPersonaUsuario>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoPersonaUsuario> ListaCombo(String Estado, String[] Def = null)
        {
            List<entTipoPersonaUsuario> ListObj = new List<entTipoPersonaUsuario>();
            ListObj = datTipoPersonaUsuario.ListaCombo( Estado).ToList<entTipoPersonaUsuario>();
            if (Def != null){
                ListObj.Insert(0, new entTipoPersonaUsuario() { TipoPersonaUsuario = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoPersonaUsuario> ListaSearch(String TipoPersonaUsuario, String Descripcion, String Estado)
        {
            List<entTipoPersonaUsuario> ListObj = new List<entTipoPersonaUsuario>();
            ListObj = datTipoPersonaUsuario.ListaSearch(TipoPersonaUsuario, Descripcion, Estado).ToList<entTipoPersonaUsuario>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoPersonaUsuario Data)
        {
            return datTipoPersonaUsuario.MantFormID(Data);
        }

    }
}
