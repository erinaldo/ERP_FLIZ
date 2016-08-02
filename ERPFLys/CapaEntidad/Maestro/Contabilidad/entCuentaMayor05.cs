using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entCuentaMayor05 : entBase
    {
        private String c_CuentaMayor05, c_CuentaMayor04, c_Descripcion, c_Estado = "A", c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod = DateTime.Now;
        private String c_UserNombreForm;

        public String CuentaMayor05
        {
            get { return c_CuentaMayor05; }
            set { c_CuentaMayor05 = value; }
        }

        public String CuentaMayor04
        {
            get { return c_CuentaMayor04; }
            set { c_CuentaMayor04 = value; }
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

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}