using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqCompCContable
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_compania,c_cuenta,c_estado,c_ultimousuariomod,d_ultimafechamod, " +
                   "n_linea = ROW_NUMBER() OVER( ORDER BY c_compania ) " +
                   "from ma_compccontable " + 
                   "where c_cuenta = @Cuenta " + 
                   "order by c_compania";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_compania,a.c_cuenta,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_compccontable a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_compania = @Compania " + 
                   "and a.c_cuenta = @Cuenta";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_compania,c_cuenta,c_estado " +
                   "from ma_compccontable " +
                   "where c_compania = @Compania " + 
                   "and c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_compania,c_cuenta,c_estado " +
                   "from ma_compccontable " +
                   "where c_compania = @Compania " +
                   "and c_cuenta like @Cuenta " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            
                    xsql = "UP_MANT_COMP_CUENTA_CONTABLE";
            
            return xsql;
        }

    }
}
