using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.General
{
    public class negDepartamento
    {
        public static List<entDepartamento> ListaFormID()
        {
            List<entDepartamento> ListObj = new List<entDepartamento>();
            ListObj = datDepartamento.ListaFormID().ToList<entDepartamento>();
            return ListObj;
        }

        public static entDepartamento GetFormID(String Pais, String Departamento)
        {
            entDepartamento EObj = new entDepartamento();
            List<entDepartamento> ListObj = new List<entDepartamento>();
            ListObj = datDepartamento.GetFormID(Pais,Departamento).ToList<entDepartamento>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entDepartamento> ListaCombo(String Pais, String Estado, String[] Def = null)
        {
            List<entDepartamento> ListObj = new List<entDepartamento>();
            ListObj = datDepartamento.ListaCombo(Pais, Estado).ToList<entDepartamento>();
            if (Def != null){
                ListObj.Insert(0, new entDepartamento() { DepartamentoCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entDepartamento> ListaSearch(String Pais, String Departamento, String Descripcion, String Estado)
        {
            List<entDepartamento> ListObj = new List<entDepartamento>();
            ListObj = datDepartamento.ListaSearch(Pais,Departamento, Descripcion, Estado).ToList<entDepartamento>();
            return ListObj;
        }

        public static entErrores MantFormID(entDepartamento Data)
        {
            return datDepartamento.MantFormID(Data);
        }
        
    }
}
