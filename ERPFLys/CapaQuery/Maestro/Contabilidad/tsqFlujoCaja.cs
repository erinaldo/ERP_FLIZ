using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqFlujoCaja
    {
        static String xsql = "";

        public static String QR_GetFlujoCajaFormID()
        {
            xsql = "select c_flujocaja,c_grupoflujocaja,c_descripcion=rtrim(c_descripcion),c_ingresoegreso,c_estado, " +
                   "c_ultimousuariomod,d_ultimafechamod " +
                   "from cb_flujocaja " +
                   "where c_flujocaja = @flujocaja";
            return xsql;
        }

        public static String QR_ListFlujoCajaSearch()
        {
            xsql = "select c_flujocaja,c_descripcion=rtrim(c_descripcion),c_estado,c_grupoflujocaja,c_ingresoegreso " +
                   "from cb_flujocaja " +
                   "where c_flujocaja like @codigo " +
                   "and c_descripcion like @descripcion " +
                   "and c_estado like @estado ";
            return xsql;
        }

    }
}
