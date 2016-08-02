using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqTipoCambio
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select d_fechacambio,n_valorcompra,n_valorventa,c_estado,c_ultimousuario,d_ultimafechamodificacion " +
                   "from ma_tipocambio " +
                   "order by d_fechacambio desc";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.d_fechacambio,a.n_valorcompra,a.n_valorventa,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " + 
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tipocambio a,ma_usuario b " +
                   "where a.c_ultimousuario = b.c_codigousuario " +
                   "and a.d_fechacambio = @FechaCambio";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select d_fechacambio,n_valorcompra,n_valorventa,c_estado " +
                   "from ma_tipocambio " +
                   "where c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select d_fechacambio,n_valorcompra,n_valorventa,c_estado " +
                   "from ma_tipocambio " +
                   "where d_fechacambio like @FechaCambio " +
                   "and c_estado like @Estado " +
                   "order by d_fechacambio desc";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipocambio(" +
                           "d_fechacambio,n_valorcompra,n_valorventa,c_estado,c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@FechaCambio,@ValorCompra,@ValorVenta,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipocambio set " +
                           "n_valorcompra = @ValorCompra, " +
                           "n_valorventa = @ValorVenta, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where d_fechacambio = @FechaCambio";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipocambio " +
                           "where d_fechacambio = @FechaCambio";
                    break;
            }
            return xsql;
        }
        
    }
}
