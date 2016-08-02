using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.RRHH
{
    public class tsqClasifiGCCosto
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select a.c_compania,a.c_clasificaciongcc,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_companiaNombre = b.c_nombres " +
                   "from rh_clasifigccosto a,ma_compania b " +
                   "where a.c_compania = b.c_compania";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_compania,a.c_clasificaciongcc,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_usernombreform = b.c_nombre " +
                   "from rh_clasifigccosto a, ma_usuario b " +
                   "where a.c_ultimousuario *= b.c_codigousuario " +
                   "and a.c_compania = @Compania " +
                   "and a.c_clasificaciongcc = @ClasificacionGCC ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_compania,c_clasificaciongcc,c_descripcion,c_estado " +
                   "from rh_clasifigccosto " +
                   "where c_compania = @Compania " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_compania,c_clasificaciongcc,c_descripcion,c_estado " +
                   "from rh_clasifigccosto " +
                   "where c_compania = @Compania " +
                   "and c_clasificaciongcc like @ClasificacionGCC " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into rh_clasifigccosto(" +
                           "c_compania,c_clasificaciongcc,c_descripcion,c_estado,c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@Compania,@ClasificacionGCC,@Descripcion,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update rh_clasifigccosto set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where c_compania = @Compania " +
                           "and c_clasificaciongcc = @ClasificacionGCC ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete rh_clasifigccosto " +
                           "where c_compania = @Compania " +
                           "and c_clasificaciongcc = @ClasificacionGCC ";
                    break;
            }
            return xsql;
        }

    }
}
