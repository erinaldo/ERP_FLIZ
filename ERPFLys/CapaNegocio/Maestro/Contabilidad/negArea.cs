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
    public class negArea
    {
        public static List<entArea> ListAreaForm()
        {
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.ListAreaForm().ToList<entArea>();
            return ListObj;
        }

        public static entArea GetAreaFormID(String Area)
        {
            entArea EObj = new entArea();
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.GetAreaFormID(Area).ToList<entArea>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantAreaForm(entArea Data){
            return datArea.MantAreaForm(Data);
        }

    }
}
