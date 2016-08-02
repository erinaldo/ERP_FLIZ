using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Objeto
{
    public class entErrores
    {
        private Boolean b_resultado;
        private List<entFail> s_error = new List<entFail>();
        private String s_CodigoGen;
        private Int32 n_CodigoGen;

        public Boolean Resultado {
            get { return b_resultado; }
            set { b_resultado = value; }
        }

        public List<entFail> Errores
        {
            get { return s_error; }
            set { s_error = value; }
        }

        public String CodigoGeneradoText {
            get { return s_CodigoGen; }
            set { s_CodigoGen = value; }
        }

        public Int32 CodigoGeneradoInt {
            get { return n_CodigoGen; }
            set { n_CodigoGen = value; }
        }

    }

    public class entFail {
        private String s_coderr, s_txterr;
        private Int32 n_coderr;
        private Int32 n_Linea;
        private String c_Mensaje;

        public String Codigo {
            get { return s_coderr; }
            set { s_coderr = value; }
        }

        public Int32 IdReg {
            get { return n_coderr; }
            set { n_coderr = value; }
        }

        public String Descripcion
        {
            get { return s_txterr; }
            set { s_txterr = value; }
        }

        public Int32 Linea
        {
            get { return n_Linea; }
            set { n_Linea = value; }
        }

        public String Mensaje
        {
            get { return c_Mensaje; }
            set { c_Mensaje = value; }
        }

    }

}
