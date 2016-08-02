using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Sistema;
using FiltroLys.Repository;
using FiltroLys.Repository.Sistema;
using FiltroLys.Type;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Sistema
{
    public class negConexion
    {
        public static entConexion getEntConexion(fnEnum.ConexionSQL conn = fnEnum.ConexionSQL.Lys)
        {
            return Configuracion.getEntConexion(conn);            
        }
        
    }
}
