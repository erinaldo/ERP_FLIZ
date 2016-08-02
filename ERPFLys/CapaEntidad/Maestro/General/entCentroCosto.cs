using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entCentroCosto : entBase
    {
        private String c_CentroCosto, c_Compania, c_Nombres, c_Clasificacion, c_Estado = "A", c_UltimoUsuario, c_UsuarioResponsable;
        private String c_RepTipo, c_CargoResponsable, c_DepartamentoCiaCodigo, c_CentroCostoNext, c_Ubicacion, c_FlagGerencia = "N";
        private String c_CostoDirecto = "N", c_Mision, c_GrupoCC, c_ClasificacionGCC;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre,c_ClasifCCNombre,c_CargoNombre,c_DepartCiaNombre,c_GrupoCCNombre, c_ClasificacionGCCNombre;
        private String c_UserNombreForm;

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Nombres
        {
            get { return c_Nombres; }
            set { c_Nombres = value; }
        }

        public String Clasificacion
        {
            get { return c_Clasificacion; }
            set { c_Clasificacion = value; }
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

        public String UsuarioResponsable
        {
            get { return c_UsuarioResponsable; }
            set { c_UsuarioResponsable = value; }
        }

        public String RepTipo
        {
            get { return c_RepTipo; }
            set { c_RepTipo = value; }
        }

        public String CargoResponsable
        {
            get { return c_CargoResponsable; }
            set { c_CargoResponsable = value; }
        }

        public String DepartamentoCiaCodigo
        {
            get { return c_DepartamentoCiaCodigo; }
            set { c_DepartamentoCiaCodigo = value; }
        }

        public String CentroCostoNext
        {
            get { return c_CentroCostoNext; }
            set { c_CentroCostoNext = value; }
        }

        public String Ubicacion
        {
            get { return c_Ubicacion; }
            set { c_Ubicacion = value; }
        }

        public String FlagGerencia
        {
            get { return c_FlagGerencia; }
            set { c_FlagGerencia = value; }
        }

        public String CostoDirecto
        {
            get { return c_CostoDirecto; }
            set { c_CostoDirecto = value; }
        }

        public String Mision
        {
            get { return c_Mision; }
            set { c_Mision = value; }
        }

        public String GrupoCC
        {
            get { return c_GrupoCC; }
            set { c_GrupoCC = value; }
        }

        public String ClasificacionGCC
        {
            get { return c_ClasificacionGCC; }
            set { c_ClasificacionGCC = value; }
        }

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String ClasifCCNombre
        {
            get { return c_ClasifCCNombre; }
            set { c_ClasifCCNombre = value; }
        }

        public String CargoNombre
        {
            get { return c_CargoNombre; }
            set { c_CargoNombre = value; }
        }

        public String DepartCiaNombre
        {
            get { return c_DepartCiaNombre; }
            set { c_DepartCiaNombre = value; }
        }

        public String GrupoCCNombre
        {
            get { return c_GrupoCCNombre; }
            set { c_GrupoCCNombre = value; }
        }

        public String ClasificacionGCCNombre
        {
            get { return c_ClasificacionGCCNombre; }
            set { c_ClasificacionGCCNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}