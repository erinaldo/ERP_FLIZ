using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entPeriodoCia : entBase
    {
        private String c_Compania, c_Periodo, c_Sistema, c_Estado = "A", c_UltimoUsuario, c_FlagBloqueo = "N", c_FlagTrabajo = "N";
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre, c_NombreSistema;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Periodo
        {
            get { return c_Periodo; }
            set { c_Periodo = value; }
        }

        public String Sistema
        {
            get { return c_Sistema; }
            set { c_Sistema = value; }
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

        public String FlagBloqueo
        {
            get { return c_FlagBloqueo; }
            set { c_FlagBloqueo = value; }
        }

        public String FlagTrabajo
        {
            get { return c_FlagTrabajo; }
            set { c_FlagTrabajo = value; }
        }

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String NombreSistema
        {
            get { return c_NombreSistema; }
            set { c_NombreSistema = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}