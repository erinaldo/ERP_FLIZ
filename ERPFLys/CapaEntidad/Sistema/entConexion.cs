using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{
    public class entConexion
    {
        private String c_server,c_datasource,c_login,c_password,c_cadconex;

        public String Server {
            get { return c_server; }
            set { c_server = value; }
        }

        public String DataSource
        {
            get { return c_datasource; }
            set { c_datasource = value; }
        }

        public String Login
        {
            get { return c_login; }
            set { c_login = value; }
        }

        public String Password
        {
            get { return c_password; }
            set { c_password = value; }
        }

        public String ConeccionString
        {
            get { return c_cadconex; }
            set { c_cadconex = value; }
        }

    }
}
