using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.RRHH
{
    public class entClasificacionCentroCosto : entBase
    {
        private String c_Compania, c_Clasificacion, c_Descripcion, c_Estado = "A", c_UltimoUsuario;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre,c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Clasificacion
        {
            get { return c_Clasificacion; }
            set { c_Clasificacion = value; }
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

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}