using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entArea : entBase
    {
        private String c_Areas, c_Descripcion, c_Estado = "A", c_UltimoUsuario;
        private DateTime c_UltimaFechaModificacion = DateTime.Now;
        private String c_UltimoUsuarioModNombre = "";
        
        public String Areas
        {
            get { return c_Areas; }
            set { c_Areas = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
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
            get { return c_UltimaFechaModificacion; }
            set { c_UltimaFechaModificacion = value; }
        }

        public String UltimoUsuarioModNombre
        {
            get { return c_UltimoUsuarioModNombre; }
            set { c_UltimoUsuarioModNombre = value; }
        }

    }
}