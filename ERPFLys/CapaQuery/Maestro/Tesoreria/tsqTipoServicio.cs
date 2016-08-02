using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Tesoreria
{
    public class tsqTipoServicio
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_tiposervicio,c_descripcion,c_regfiscal,c_estado,c_ultimousuariomod,d_ultimafechamod, " +
                   "c_flagnodomic,c_flag4ta,c_flag4tapension,c_flag4tapensionAFE,c_flagvalida4ta,c_flag2dacategoria " +
                   "from ma_tiposervicio";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_tiposervicio,a.c_descripcion,a.c_regfiscal,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "a.c_flagnodomic,a.c_flag4ta,a.c_flag4tapension,a.c_flag4tapensionAFE,a.c_flagvalida4ta,a.c_flag2dacategoria, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tiposervicio a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_tiposervicio = @TipoServicio";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_tiposervicio,c_descripcion,c_estado " +
                   "from ma_tiposervicio " +
                   "where c_regfiscal like @RegFiscal " +
                   "and c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_tiposervicio,c_descripcion,c_estado " +
                   "from ma_tiposervicio " +
                   "where c_tiposervicio like @TipoServicio " +
                   "and c_descripcion like @Descripcion " +
                   "and c_regfiscal like @RegFiscal " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tiposervicio(" +
                           "c_tiposervicio,c_descripcion,c_regfiscal,c_estado,c_ultimousuariomod,d_ultimafechamod, " +
                           "c_flagnodomic,c_flag4ta,c_flag4tapension,c_flag4tapensionAFE,c_flagvalida4ta,c_flag2dacategoria) " +
                           "values(@TipoServicio,@Descripcion,@RegFiscal,@Estado,@UltimoUsuario,getdate(), " + 
                           "@FlagNoDomic,@Flag4ta,@Flag4taPension,@Flag4taPensionAFE,@FlagValida4ta,@Flag2daCategoria) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tiposervicio set " +
                           "c_descripcion = @Descripcion, " +
                           "c_regfiscal = @RegFiscal, " +
                           "c_flagnodomic = @FlagNoDomic, " +
                           "c_flag4ta = @Flag4ta, " +
                           "c_flag4tapension = @Flag4taPension, " +
                           "c_flag4tapensionAFE = @Flag4taPensionAFE, " +
                           "c_flagvalida4ta = @FlagValida4ta, " +
                           "c_flag2dacategoria = @Flag2daCategoria, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_tiposervicio = @TipoServicio ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tiposervicio " +
                           "where c_tiposervicio = @TipoServicio ";
                    break;
            }
            return xsql;
        }

    }
}
