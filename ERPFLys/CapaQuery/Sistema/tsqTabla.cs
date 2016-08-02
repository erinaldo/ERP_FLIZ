using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Sistema
{
    public class tsqTabla
    {
        static String xsql = "";

        public static String QR_ListTabla()
        {
            xsql = "select c_tablename = upper(table_name) from INFORMATION_SCHEMA.TABLES " +
                   "ORDER BY table_name";
            return xsql;
        }

        public static String QR_ListColumna(String Tabla)
        {
            xsql = "select n_posicion = ordinal_position,c_nombre = column_name,c_tipo = data_type,c_vb='S', " +
                   "c_propiedad = upper(substring(column_name,3,1)) + substring(column_name,4,len(column_name)), " +
                   "c_default = isnull(replace(replace(replace(column_default,'(',''),')',''),char(39),''),'') " +
                   "from INFORMATION_SCHEMA.COLUMNS " +
                   "where table_name = @Tabla";                   
            return xsql;
        }

    }
}
