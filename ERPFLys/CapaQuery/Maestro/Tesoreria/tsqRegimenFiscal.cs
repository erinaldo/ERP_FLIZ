using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Tesoreria
{
    public class tsqRegimenFiscal
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_regfiscal,c_descripcion,c_estado,c_ultimousuariomod,d_ultimafechamod " +
                   "from ma_regimenfiscal";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_regfiscal,a.c_descripcion,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_regimenfiscal a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_regfiscal = @RegFiscal";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_regfiscal,c_descripcion,c_estado " +
                   "from ma_regimenfiscal " +
                   "where c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_regfiscal,c_descripcion,c_estado " +
                   "from ma_regimenfiscal " +
                   "where c_regfiscal like @RegFiscal " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_regimenfiscal(" +
                           "c_regfiscal,c_descripcion,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@RegFiscal,@Descripcion,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_regimenfiscal set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_regfiscal = @RegFiscal ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_regimenfiscal " +
                           "where c_regfiscal = @RegFiscal ";
                    break;
            }
            return xsql;
        }

    }
}
