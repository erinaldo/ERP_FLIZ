using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{
    public class entColumna
    {
        private String c_Nombre,c_Tipo,c_Propiedad,c_VB,c_Default;
        private int n_Posicion;

        public String Nombre {
            get { return c_Nombre; }
            set { c_Nombre = value; }
        }

        public String Tipo
        {
            get { return c_Tipo; }
            set { c_Tipo = value; }
        }

        public String Propiedad
        {
            get { return c_Propiedad; }
            set { c_Propiedad = value; }
        }

        public String VB
        {
            get { return c_VB; }
            set { c_VB = value; }
        }

        public String Default
        {
            get { return c_Default; }
            set { c_Default = value; }
        }

        public int Posicion
        {
            get { return n_Posicion; }
            set { n_Posicion = value; }
        }

    }
}
