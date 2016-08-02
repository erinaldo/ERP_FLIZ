using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqGeneral
    {
        static String xsql = "";

        public static String QR_GetFechaServidor()
        {
            xsql = "select c_fecha = getdate()";
            return xsql;
        }
       
    }
}
