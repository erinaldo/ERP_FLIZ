using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqTipoActivo
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "UP_MANT_TIPO_CAMBIO";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "UP_MANT_TIPO_CAMBIO";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "UP_MANT_TIPO_CAMBIO";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "UP_MANT_TIPO_CAMBIO";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipoactivo(" +
                           "c_tipoactivo,c_descripcion,c_control,n_porcentaje,c_estado,c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@TipoActivo,@Descripcion,@Control,@Porcentaje,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipoactivo set " +
                           "c_descripcion = @Descripcion, " +
                           "c_control = @Control, " +
                           "n_porcentaje = @Porcentaje, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where c_tipoactivo = @TipoActivo ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipoactivo " +
                           "where c_tipoactivo = @TipoActivo ";
                    break;
            }
            return xsql;
        }

    }
}
