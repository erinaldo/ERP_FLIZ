using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.RRHH
{
    public class tsqCargo
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select a.c_compania,a.c_cargo,a.c_descripcion,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_companiaNombre = b.c_nombres " +
                   "from rh_cargo a,ma_compania b " +
                   "where a.c_ultimousuario = b.c_codigousuario";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_compania,a.c_cargo,a.c_descripcion,a.c_estado,a.c_grupo,a.c_organo,a.c_educacion,a.c_nivelsupervision,a.c_experiencia, " +
                   "a.c_objetivocargo,a.n_edadmaxina,a.c_autoridadcargo,a.c_experienciacargo,a.c_ultimousuario,a.d_ultimafechamodificacion,a.c_flagponderacion_c, " +
                   "a.n_formacion_c,a.n_habilidad_c,a.n_actitud_c,a.n_gradoeducacion_c,a.c_flagsinformacion,a.c_flagsinhabilidad,a.c_flagsinactitud, " +
                   "a.n_competenciageneral_c,a.c_flagsincompgeneral,a.c_flagreqimpseg,c_usernombreform = b.c_nombre " +
                   "from rh_cargo a, ma_usuario b " +
                   "where a.c_ultimousuario *= b.c_codigousuario " +
                   "and a.c_compania = @Compania " +
                   "and a.c_cargo = @Cargo ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_compania,c_cargo,c_descripcion,c_estado " +
                   "from rh_cargo " +
                   "where c_compania = @Compania " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_compania,c_cargo,c_descripcion,c_estado " +
                   "from rh_cargo " +
                   "where c_compania = @Compania " +
                   "and c_cargo like @Clasificacion " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into rh_cargo(" + 
                           "c_compania,c_cargo,c_descripcion,c_estado,c_grupo,c_organo,c_educacion,c_nivelsupervision,c_experiencia,c_objetivocargo, " +
                           "n_edadmaxina,c_autoridadcargo,c_experienciacargo,c_ultimousuario,d_ultimafechamodificacion,c_flagponderacion_c,n_formacion_c, " +
                           "n_habilidad_c,n_actitud_c,n_gradoeducacion_c,c_flagsinformacion,c_flagsinhabilidad,c_flagsinactitud,n_competenciageneral_c, " +
                           "c_flagsincompgeneral,c_flagreqimpseg) " +
                           "values(@Compania,@Cargo,@Descripcion,@Estado,@Grupo,@Organo,@Educacion,@NivelSupervision,@Experiencia,@ObjetivoCargo, " +
                           "@EdadMaxima,@AutoriadadCargo,@ExperenciaCargo,@UltimoUsuario,getdate(),@FlagPonderacionC,@FormacionC, " +
                           "@HabilidadC,@ActitudC,@GradoEducacionC,@FlagSinFormacion,@FlagSinHabilidad,@FlagSinActitud,@CompetenciaGeneralC, " +
                           "@FlagSinCompGeneral,@FlagReqImpSeG) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update rh_cargo set " +
                           "c_descripcion = @Descripcion, " +
                           "c_estado = @Estado, " +
                           "c_grupo = @Grupo, " +
                           "c_organo = @Organo, " +
                           "c_educacion = @Educacion, " +
                           "c_nivelsupervision = @NivelSupervision, " +
                           "c_experiencia = @Experiencia, " +
                           "c_objetivocargo = @ObjetivoCargo, " +
                           "n_edadmaxina = @EdadMaxima, " +
                           "c_autoridadcargo = @AutoriadadCargo, " +
                           "c_experienciacargo = @ExperenciaCargo, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "c_flagponderacion_c = @FlagPonderacionC, " +
                           "n_formacion_c = @FormacionC, " +
                           "n_habilidad_c = @HabilidadC, " +
                           "n_actitud_c = @ActitudC, " +
                           "n_gradoeducacion_c = @GradoEducacionC, " +
                           "c_flagsinformacion = @FlagSinFormacion, " +
                           "c_flagsinhabilidad = @FlagSinHabilidad, " +
                           "c_flagsinactitud = @FlagSinActitud, " +
                           "n_competenciageneral_c = @CompetenciaGeneralC, " +
                           "c_flagsincompgeneral = @FlagSinCompGeneral, " +
                           "c_flagreqimpseg = @FlagReqImpSeG " +
                           "where c_compania = @Compania " +
                           "and c_cargo = @Cargo ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete rh_cargo " +
                           "where c_compania = @Compania " +
                           "and c_cargo = @Cargo ";
                    break;
            }
            return xsql;
        }

    }
}
