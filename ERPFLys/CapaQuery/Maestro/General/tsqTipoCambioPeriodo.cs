using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqTipoCambioPeriodo
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_sistema,c_periodo,n_valorcierre,n_valorcompra,n_valorventa,c_estado,c_ultimousuariomod,d_ultimafechamod " +
                   "from ma_tipocambioperiodo " +
                   "where c_sistema = @Sistema " +
                   "order by c_periodo desc";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_sistema,a.c_periodo,a.n_valorcierre,a.n_valorcompra,a.n_valorventa,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " + 
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tipocambioperiodo a,ma_usuario b " +
                   "where a.c_ultimousuariomod = b.c_codigousuario " +
                   "and a.c_sistema = @Sistema " +
                   "and a.c_periodo = @Periodo";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_sistema,c_periodo,n_valorcierre,n_valorcompra,n_valorventa,c_estado " +
                   "from ma_tipocambioperiodo " +
                   "where c_sistema = @Sistema " + 
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_sistema,c_periodo,n_valorcierre,n_valorcompra,n_valorventa,c_estado " +
                   "from ma_tipocambioperiodo " +
                   "where c_sistema like @Sistema " +
                   "and c_periodo like @Periodo " +
                   "and c_estado like @Estado " +
                   "order by c_periodo desc";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipocambioperiodo(" +
                           "c_sistema,c_periodo,n_valorcierre,n_valorcompra,n_valorventa,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@Sistema,@Periodo,@ValorCierre,@ValorCompra,@ValorVenta,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipocambioperiodo set " +
                           "n_valorcierre = @ValorCierre, " +
                           "n_valorcompra = @ValorCompra, " +
                           "n_valorventa = @ValorVenta, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_sistema = @Sistema " + 
                           "and c_periodo = @Periodo";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipocambioperiodo " +
                           "where c_sistema = @Sistema " +
                           "and c_periodo = @Periodo";
                    break;
            }
            return xsql;
        }
        
    }
}
