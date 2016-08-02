using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entFlujoCaja : entBase
    {
        private String c_FlujoCaja, c_GrupoFlujoCaja, c_Descripcion, c_IngresoEgreso, c_Estado, c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm;

        public String FlujoCaja
        {
            get { return c_FlujoCaja; }
            set { c_FlujoCaja = value; }
        }

        public String GrupoFlujoCaja
        {
            get { return c_GrupoFlujoCaja; }
            set { c_GrupoFlujoCaja = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String IngresoEgreso
        {
            get { return c_IngresoEgreso; }
            set { c_IngresoEgreso = value; }
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

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}