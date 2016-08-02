using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqArea
    {
        static String xsql = "";

        public static String QR_ListAreaForm() {
            string xsql = "UP_MANT_AREAS";
            return xsql;
        }

        public static String QR_GetAreaFormID()
        {
            xsql = "select a.c_areas,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.c_ultimafechamodificacion, " +
                   "c_ultimousuariomodnombre = isnull(b.c_nombre,'') " +
                   "from ma_areas a,ma_usuario b " +
                   "where a.c_areas = @area " +
                   "and a.c_ultimousuario *= b.c_codigousuario" ;
            return xsql;
        }
                
        public static String QR_MantAreaForm(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_areas(c_areas,c_descripcion,c_estado,c_ultimousuario,c_ultimafechamodificacion) " +
                           "values(@Area,@Descripcion,@Estado,@UltimoUsuario,getdate())";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_areas set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +                           
                           "c_ultimousuario = @UltimoUsuario, " +
                           "c_ultimafechamodificacion = getdate() " +
                           "where c_areas = @Area ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_areas where c_areas = @Area ";
                    break;
            }
            return xsql;
        }

    }
}
