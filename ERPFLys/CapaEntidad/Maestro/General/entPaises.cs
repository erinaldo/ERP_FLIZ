using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entPaises : entBase
    {
        private String c_Pais, c_Descripcion, c_Estado = "A", c_UltimoUsuario, c_CodAduana;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
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
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String CodAduana
        {
            get { return c_CodAduana; }
            set { c_CodAduana = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}