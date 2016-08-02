using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entTipoActivo : entBase
    {
        private String c_TipoActivo, c_Descripcion, c_Control = "N", c_Estado = "A", c_UltimoUsuario;
        private Decimal n_Porcentaje = 0;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public String TipoActivo
        {
            get { return c_TipoActivo; }
            set { c_TipoActivo = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String Control
        {
            get { return c_Control; }
            set { c_Control = value; }
        }

        public Decimal Porcentaje
        {
            get { return n_Porcentaje; }
            set { n_Porcentaje = value; }
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