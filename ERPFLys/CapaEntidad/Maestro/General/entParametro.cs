using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entParametro : entBase
    {
        private String c_Compania, c_Aplicacion, c_ParametroCodigo, c_Descripcion, c_Explicacion, c_Tipo, c_Texto, c_Estado = "A";
        private String c_UltimoUsuario, c_Texto2;
        private Decimal n_Numero;
        private DateTime d_Fecha, d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre,c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Aplicacion
        {
            get { return c_Aplicacion; }
            set { c_Aplicacion = value; }
        }

        public String ParametroCodigo
        {
            get { return c_ParametroCodigo; }
            set { c_ParametroCodigo = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String Explicacion
        {
            get { return c_Explicacion; }
            set { c_Explicacion = value; }
        }

        public String Tipo
        {
            get { return c_Tipo; }
            set { c_Tipo = value; }
        }

        public String Texto
        {
            get { return c_Texto; }
            set { c_Texto = value; }
        }

        public Decimal Numero
        {
            get { return n_Numero; }
            set { n_Numero = value; }
        }

        public DateTime Fecha
        {
            get { return d_Fecha; }
            set { d_Fecha = value; }
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

        public String Texto2
        {
            get { return c_Texto2; }
            set { c_Texto2 = value; }
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