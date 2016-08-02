using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Seguridad
{
    public class tsqUsuario
    {
        static String xsql = "";

        public static String QR_ListUsuarioXEstCombo(String Estado)
        {
            xsql = "select c_codigousuario=Rtrim(c_codigousuario),n_persona,c_nombre,c_centrocosto " +
                   "from ma_usuario " +
                   "where c_estado like '" + Estado + "' " +
                   "order by c_nombre ";                   
            return xsql;
        }

    }
}
