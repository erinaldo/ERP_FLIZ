using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entDepartamento : entBase
    {
        private String c_Pais, c_DepartamentoCodigo, c_Descripcion, c_Estado = "A", c_UltimoUsuario, c_CodigoDepFedd;
        private String c_Provincia = "N", c_Ubigeo;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
        }

        public String DepartamentoCodigo
        {
            get { return c_DepartamentoCodigo; }
            set { c_DepartamentoCodigo = value; }
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

        public String CodigoDepFedd
        {
            get { return c_CodigoDepFedd; }
            set { c_CodigoDepFedd = value; }
        }

        public String Provincia
        {
            get { return c_Provincia; }
            set { c_Provincia = value; }
        }

        public String Ubigeo
        {
            get { return c_Ubigeo; }
            set { c_Ubigeo = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}