using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.RRHH
{
    public class entCargo : entBase
    {
        private String c_Compania, c_Cargo, c_Descripcion, c_Estado = "A", c_Grupo, c_Organo, c_Educacion, c_NivelSupervision, c_Experiencia, c_ObjetivoCargo;
        private String c_AutoridadCargo, c_ExperienciaCargo, c_UltimoUsuario, c_FlagPonderacion_c = "N", c_FlagsInformacion = "N", c_FlagsInhabilidad = "N";
        private String c_FlagsInactitud = "N",c_FlagsIncompgeneral = "N", c_FlagReqImpSeg = "N";
        private int n_EdadMaxina;
        private Decimal n_Formacion_c = 0, n_Habilidad_c = 0, n_Actitud_c = 0, n_GradoEducacion_c = 0, n_CompetenciaGeneral_c = 0;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre,c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Cargo
        {
            get { return c_Cargo; }
            set { c_Cargo = value; }
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

        public String Grupo
        {
            get { return c_Grupo; }
            set { c_Grupo = value; }
        }

        public String Organo
        {
            get { return c_Organo; }
            set { c_Organo = value; }
        }

        public String Educacion
        {
            get { return c_Educacion; }
            set { c_Educacion = value; }
        }

        public String NivelSupervision
        {
            get { return c_NivelSupervision; }
            set { c_NivelSupervision = value; }
        }

        public String Experiencia
        {
            get { return c_Experiencia; }
            set { c_Experiencia = value; }
        }

        public String ObjetivoCargo
        {
            get { return c_ObjetivoCargo; }
            set { c_ObjetivoCargo = value; }
        }

        public Int32 EdadMaxina
        {
            get { return n_EdadMaxina; }
            set { n_EdadMaxina = value; }
        }

        public String AutoridadCargo
        {
            get { return c_AutoridadCargo; }
            set { c_AutoridadCargo = value; }
        }

        public String ExperienciaCargo
        {
            get { return c_ExperienciaCargo; }
            set { c_ExperienciaCargo = value; }
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

        public String FlagPonderacion_c
        {
            get { return c_FlagPonderacion_c; }
            set { c_FlagPonderacion_c = value; }
        }

        public Decimal Formacion_c
        {
            get { return n_Formacion_c; }
            set { n_Formacion_c = value; }
        }

        public Decimal Habilidad_c
        {
            get { return n_Habilidad_c; }
            set { n_Habilidad_c = value; }
        }

        public Decimal Actitud_c
        {
            get { return n_Actitud_c; }
            set { n_Actitud_c = value; }
        }

        public Decimal GradoEducacion_c
        {
            get { return n_GradoEducacion_c; }
            set { n_GradoEducacion_c = value; }
        }

        public String FlagsInformacion
        {
            get { return c_FlagsInformacion; }
            set { c_FlagsInformacion = value; }
        }

        public String FlagsInhabilidad
        {
            get { return c_FlagsInhabilidad; }
            set { c_FlagsInhabilidad = value; }
        }

        public String FlagsInactitud
        {
            get { return c_FlagsInactitud; }
            set { c_FlagsInactitud = value; }
        }

        public Decimal CompetenciaGeneral_c
        {
            get { return n_CompetenciaGeneral_c; }
            set { n_CompetenciaGeneral_c = value; }
        }

        public String FlagsIncompgeneral
        {
            get { return c_FlagsIncompgeneral; }
            set { c_FlagsIncompgeneral = value; }
        }

        public String FlagReqImpSeg
        {
            get { return c_FlagReqImpSeg; }
            set { c_FlagReqImpSeg = value; }
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