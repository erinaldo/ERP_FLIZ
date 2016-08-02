using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Type;

namespace FiltroLys.Query.Seguridad
{
    public class tsqAuditoria
    {
        static String xsql = "";

        public static String QR_ListAuditoria()
        {
            xsql = "select a.c_estacion,a.c_codigousuario,a.d_fechapcing,a.d_fechapcsal,a.d_fechaserving,a.d_fechaservsal, " +
                   "a.c_ultimousuario,a.d_ultimafechamodificacion,c_NombreUsuario = b.c_nombre,b.c_centrocosto " +
                   "from sys_auditoria a " +
                   "left outer join ma_usuario b on (a.c_codigousuario = b.c_codigousuario) " +
                   "where a.c_codigousuario like @Usuario " +
                   "and a.d_fechapcing >= @FechaInicio " +
                   "and a.d_fechapcing <= @FechaFinal " +
                   "order by a.d_fechapcing";
            return xsql;
        }

        public static String TR_MantAuditoria(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into sys_auditoria(c_estacion,c_codigousuario,d_fechapcing,d_fechaserving," +
                           "                          c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@Estacion,@CodigoUsuario,@FechaPcIng,getdate(),@UltimoUsuario,getdate())";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update sys_auditoria set " +
                           "d_fechapcsal = @FechaPcSal, " +
                           "d_fechaservsal = getdate(), " +
                           "c_ultimousuario = @CodigoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where c_estacion = @Estacion " +
                           "and c_codigousuario = @CodigoUsuario " +
                           "and d_fechapcing = @FechaPcIng ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    break;
            }

            return xsql;
        }

        public static String QR_GetFechaServidor(){
            xsql = "select getdate()";
            return xsql;
        }

    }
}
