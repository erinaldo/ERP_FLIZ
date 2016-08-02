using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqTipoVoucher
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_tipovoucher,c_descripcion,c_correlativomanual,c_flagsistema,c_estado, " +
                   "c_ultimousuariomod,d_ultimafechamod " +
                   "from cb_tipovoucher";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_tipovoucher,a.c_descripcion,a.c_correlativomanual,a.c_flagsistema,a.c_estado, " +
                   "a.c_ultimousuariomod,a.d_ultimafechamod,c_usernombreform = b.c_nombre " +
                   "from cb_tipovoucher a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_tipovoucher = @TipoVoucher ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_tipovoucher,c_descripcion,c_estado " +
                   "from cb_tipovoucher " +
                   "where c_correlativomanual like @CorrelativoManual " +
                   "and c_flagsistema like @FlagSistema " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_tipovoucher,c_descripcion,c_correlativomanual,c_flagsistema,c_estado " +
                   "from cb_tipovoucher " +
                   "where c_tipovoucher like @TipoVoucher " +
                   "and c_descripcion like @Descripcion " +
                   "and c_correlativomanual like @CorrelativoManual " +
                   "and c_flagsistema like @FlagSistema " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into cb_tipovoucher(" +
                           "c_tipovoucher,c_descripcion,c_correlativomanual,c_flagsistema,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@TipoVoucher,@Descripcion,@CorrelativoManual,@FlagSistema,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update cb_tipovoucher set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_correlativomanual = @CorrelativoManual, " +
                           "c_flagsistema = @FlagSistema, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_tipovoucher = @TipoVoucher ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete cb_tipovoucher " +
                           "where c_tipovoucher = @TipoVoucher ";
                    break;
            }
            return xsql;
        }
        
    }
}
