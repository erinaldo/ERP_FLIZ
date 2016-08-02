using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqTipoGasto
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_tipogasto,c_descripcion,c_estado,c_ultimousuariomod,d_ultimafechamod " +
                   "from ma_tipogasto";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_tipogasto,a.c_descripcion,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tipogasto a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_tipogasto = @TipoGasto ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_tipogasto,c_descripcion,c_estado " +
                   "from ma_tipogasto " +
                   "where c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_tipogasto,c_descripcion,c_estado " +
                   "from ma_tipogasto " +
                   "where c_tipogasto like @TipoGasto " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipogasto(" +
                           "c_tipogasto,c_descripcion,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@TipoGasto,@Descripcion,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipogasto set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_tipogasto = @TipoGasto ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipogasto " +
                           "where c_tipogasto = @TipoGasto ";
                    break;
            }
            return xsql;
        }

    }
}
