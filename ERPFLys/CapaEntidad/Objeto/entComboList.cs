using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Objeto
{
    public class entComboList
    {
        private String c_Codigo, c_Nombre;
        
        public String Codigo
        {
            get { return c_Codigo; }
            set { c_Codigo = value; }
        }

        public String Nombre
        {
            get { return c_Nombre; }
            set { c_Nombre = value; }
        }

    }
}
