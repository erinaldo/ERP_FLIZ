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
    public class negParametro
    {
        public static List<entParametro> ListaFormID(String Aplicacion)
        {
            List<entParametro> ListObj = new List<entParametro>();
            ListObj = datParametro.ListaFormID(Aplicacion).ToList<entParametro>();
            return ListObj;
        }

        public static entParametro GetFormID(String Compania, String Aplicacion, String Parametro)
        {
            entParametro EObj = new entParametro();
            List<entParametro> ListObj = new List<entParametro>();
            ListObj = datParametro.GetFormID(Compania, Aplicacion, Parametro).ToList<entParametro>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entParametro> ListaCombo(String Compania, String Aplicacion, String Estado, String[] Def = null)
        {
            List<entParametro> ListObj = new List<entParametro>();
            ListObj = datParametro.ListaCombo(Compania, Aplicacion,Estado).ToList<entParametro>();
            if (Def != null){
                ListObj.Insert(0, new entParametro() { ParametroCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entParametro> ListaSearch(String Compania, String Aplicacion, String Parametro, String Descripcion, String Estado)
        {
            List<entParametro> ListObj = new List<entParametro>();
            ListObj = datParametro.ListaSearch(Compania, Aplicacion, Parametro, Descripcion, Estado).ToList<entParametro>();
            return ListObj;
        }

        public static entErrores MantFormID(entParametro Data)
        {
            return datParametro.MantFormID(Data);
        }

    }
}
