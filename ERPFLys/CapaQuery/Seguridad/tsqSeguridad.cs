using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Seguridad
{
    public class tsqSeguridad
    {
        static String xsql = "";

        public static String QR_GetUsuarioClaveSi(String Usuario,String Clave){
            xsql = "select count(1) " +
                   "from ma_usuario " +
                   "where c_codigousuario ='" + Usuario + "' " +
                   "and c_clave = '" + Clave + "'";
            return xsql;
        }

        public static String QR_GetUsuarioExiste(String Usuario)
        {
            xsql = "select count(1) " +
                   "from ma_usuario " +
                   "where c_codigousuario ='" + Usuario + "'";
            return xsql;
        }

        public static String QR_GetUsuarioActivo(String Usuario)
        {
            xsql = "select count(1) " +
                   "from ma_usuario " +
                   "where c_codigousuario ='" + Usuario + "' " +
                   "and c_estado ='A'";
            return xsql;
        }

        public static String QR_ListAccesoUsuApp(String Usuario,String Aplicacion)
        {
            switch (Aplicacion)
            {
                case "TR": case "CB": case "IS": case "PT": case "IN":
                    xsql = "select c_niveles,c_acceso,c_nuevo,c_modificar,c_eliminar,c_otros " +
                           "from sys_acceso " +
                           "where c_usuario = '" + Usuario + "' " +
                           "and c_aplicacion = '" + Aplicacion + "'";
                    break;

                case "LO":
                    xsql = "select c_niveles,c_acceso,c_nuevo,c_modificar,c_eliminar,c_otros " +
                           "from lo_accesos " +
                           "where c_usuario = '" + Usuario + "' ";
                    break;

                case "CO":
                    xsql = "select c_niveles,c_acceso,c_nuevo,c_modificar,c_eliminar,c_otros " +
                           "from co_accesos " +
                           "where c_usuario = '" + Usuario + "' ";
                    break;

                case "PC":
                    xsql = "select c_niveles=niveles,c_acceso=acceso,c_nuevo=nuevo,c_modificar=modificar,c_eliminar=eliminar,c_otros=otros " +
                           "from pc_accesos " +
                           "where usuario = '" + Usuario + "' ";
                    break;

                case "RH":
                    xsql = "select c_niveles,c_acceso,c_nuevo,c_modificar,c_eliminar,c_otros " +
                           "from rh_accesos " +
                           "where c_usuario = '" + Usuario + "' ";
                    break;

                case "CA":
                    xsql = "select c_niveles,c_acceso,c_nuevo,c_modificar,c_eliminar,c_otros " +
                           "from ca_accesos " +
                           "where c_codigousuario = '" + Usuario + "' ";
                    break;
            }
            return xsql;
        }

        public static String UP_ListMenuMaestros() {
            xsql = "SP_SYS_MENUOPCIONNET";
            return xsql;
        }

        public static String UP_ListMenuReportes()
        {
            xsql = "SP_SYS_REPORTOPCIONNET";
            return xsql;
        }

    }
}
