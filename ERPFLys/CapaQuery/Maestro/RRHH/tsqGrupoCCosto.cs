using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.RRHH
{
    public class tsqGrupoCCosto
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select a.c_compania,a.c_grupocc,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_companiaNombre = b.c_nombres " +
                   "from rh_grupoccosto a,ma_compania b " +
                   "where a.c_compania = b.c_compania";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_compania,a.c_grupocc,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_usernombreform = b.c_nombre " +
                   "from rh_grupoccosto a, ma_usuario b " +
                   "where a.c_ultimousuario *= b.c_codigousuario " +
                   "and a.c_compania = @Compania " +
                   "and a.c_grupocc = @GrupoCC ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_compania,c_grupocc,c_descripcion,c_estado " +
                   "from rh_grupoccosto " +
                   "where c_compania = @Compania " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_compania,c_grupocc,c_descripcion,c_estado " +
                   "from rh_grupoccosto " +
                   "where c_compania = @Compania " +
                   "and c_grupocc like @GrupoCC " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into rh_grupoccosto(" +
                           "c_compania,c_grupocc,c_descripcion,c_estado,c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@Compania,@GrupoCC,@Descripcion,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update rh_grupoccosto set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where c_compania = @Compania " +
                           "and c_grupocc = @GrupoCC ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete rh_grupoccosto " +
                           "where c_compania = @Compania " +
                           "and c_grupocc = @GrupoCC ";
                    break;
            }
            return xsql;
        }

    }
}
