using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.RRHH
{
    public class entTipoPersonaUsuario : entBase
    {
        private String c_TipoPersonaUsuario, c_Descripcion, c_FlagCliente = "N", c_FlagEmpleado = "N", c_FlagProveedor = "N", c_Estado = "A", c_UltimoUsuario;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public String TipoPersonaUsuario
        {
            get { return c_TipoPersonaUsuario; }
            set { c_TipoPersonaUsuario = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String FlagCliente
        {
            get { return c_FlagCliente; }
            set { c_FlagCliente = value; }
        }

        public String FlagEmpleado
        {
            get { return c_FlagEmpleado; }
            set { c_FlagEmpleado = value; }
        }

        public String FlagProveedor
        {
            get { return c_FlagProveedor; }
            set { c_FlagProveedor = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}