using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entClasificacionMayor : entBase
    {
        private String c_Clasificacion, c_Descripcion, c_Estado, c_UltimoUsuarioMod, c_DescripcionAnt;
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm;

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

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public String DescripcionAnt
        {
            get { return c_DescripcionAnt; }
            set { c_DescripcionAnt = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}