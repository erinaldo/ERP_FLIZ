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
    public class negCargo
    {
        public static List<entCargo> ListaFormID()
        {
            List<entCargo> ListObj = new List<entCargo>();
            ListObj = datCargo.ListaFormID().ToList<entCargo>();
            return ListObj;
        }

        public static entCargo GetFormID(String Compania, String Cargo)
        {
            entCargo EObj = new entCargo();
            List<entCargo> ListObj = new List<entCargo>();
            ListObj = datCargo.GetFormID(Compania, Cargo).ToList<entCargo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCargo> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entCargo> ListObj = new List<entCargo>();
            ListObj = datCargo.ListaCombo(Compania, Estado).ToList<entCargo>();
            if (Def != null){
                ListObj.Insert(0, new entCargo() { Cargo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entCargo> ListaSearch(String Compania, String Cargo, String Descripcion, String Estado)
        {
            List<entCargo> ListObj = new List<entCargo>();
            ListObj = datCargo.ListaSearch(Compania, Cargo, Descripcion, Estado).ToList<entCargo>();
            return ListObj;
        }

        public static entErrores MantFormID(entCargo Data)
        {
            return datCargo.MantFormID(Data);
        }

    }
}
