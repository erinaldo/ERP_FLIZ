using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entDepartCia : entBase
    {
        private String c_Compania, c_DepartamentoCiaCodigo, c_Descripcion, c_Estado;
        private String c_UltimoUsuario, c_Sucursal;
        private int n_EmpResponsable;
        private DateTime d_UltimaFechaModificacion;
        private String c_CompaniaNombre, c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String DepartamentoCiaCodigo
        {
            get { return c_DepartamentoCiaCodigo; }
            set { c_DepartamentoCiaCodigo = value; }
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

        public String Sucursal
        {
            get { return c_Sucursal; }
            set { c_Sucursal = value; }
        }

        public int EmpResponsable
        {
            get { return n_EmpResponsable; }
            set { n_EmpResponsable = value; }
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
