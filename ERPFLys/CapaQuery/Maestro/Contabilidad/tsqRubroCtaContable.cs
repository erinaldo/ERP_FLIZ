using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqRubroCtaContable
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_codrubro,c_descripcion,c_clasificacion,c_estado,c_ultimousuariomod,d_ultimafechamod " +
                   "from ma_rubroctacontable";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_codrubro,a.c_descripcion,a.c_clasificacion,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_rubroctacontable a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_codrubro = @CodRubro ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_codrubro,c_descripcion,c_estado " +
                   "from ma_rubroctacontable " +
                   "where c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_codrubro,c_clasificacion,c_descripcion,c_estado " +
                   "from ma_rubroctacontable " +
                   "where c_codrubro like @CodRubro " +
                   "and c_clasificacion like @Clasificacion " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_rubroctacontable(" +
                           "c_codrubro,c_descripcion,c_clasificacion,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@CodRubro,@Descripcion,@Clasificacion,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_rubroctacontable set " +
                           "c_descripcion = @Descripcion, " +
                           "c_clasificacion = @Clasificacion, " +                           
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_codrubro = @CodRubro ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_rubroctacontable " +
                           "where c_codrubro = @CodRubro ";
                    break;
            }
            return xsql;
        }

    }
}
