using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Sistema;
using FiltroLys.Repository.Sistema;
using FiltroLys.Type;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Sistema
{
    public class negTabla
    {
        public static List<entTabla> ListTabla()
        {
            List<entTabla> ListObj = new List<entTabla>();
            ListObj = datTabla.ListTabla().ToList<entTabla>();
            ListObj.Insert(0, new entTabla() { TableName=fnConst.TextSeleccioneNom });            
            return ListObj;
        }

        public static List<entColumna> ListColumna(String Tabla)
        {
            List<entColumna> ListObj = new List<entColumna>();
            ListObj = datTabla.ListColumna(Tabla).ToList<entColumna>();            
            return ListObj;
        }

    }
}
