using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqPersona
    {
        static String xsql = "";

        public static String QR_GetPersonaFormID()
        {
            xsql = "select c_compania,n_persona,c_tipopersona,c_apellidospaterno,c_apellidosmaterno,c_nombres,c_nombreCompleto, " +
                   "c_nombrebusqueda,c_tipoDocumentopersona,c_documento,c_documentofiscal,c_documentoidentidad,c_carnetextranjeria, " +
                   "c_pasaporte,c_procedencia,c_direccion,c_pais,c_departamentocodigo,c_provinciacodigo,c_distritocodigo,c_mail, " +
                   "c_nacionalidad,d_fechanacimiento,c_educacion,c_sexo,c_telefono,c_fax,c_estadocivil,c_nombreemergencia, " +
                   "c_telefonoemergencia,c_direccionemergencia,c_tipocuenta,c_monedacuenta,c_bancocuenta,c_numerocuenta,c_esempleado, " +
                   "c_esproveedor,c_escliente,c_esotro,n_personaanterior,c_codigousuario,c_tipopersonausuario,c_estado,d_fecharegistro, " +
                   "c_usuarioregistro,c_ultimousuario,d_Ultimafechamodificacion,c_DocumentoMilitarFA,c_codigovia,c_codigozona, " +
                   "c_flagagenteret,c_flagbuencontrib,c_flagagenteper,c_flagvalidoret,c_usuariovalidoret,d_fechavalidoret,c_flagtipoampret, " +
                   "c_flagnohabido,c_flagnohallado,d_fechanohabido,c_usuarioactnohabido,d_fechaactnohabido,c_usuarioactnohallado, " +
                   "d_fechaactnohallado " +
                   "from rh_personas " +
                   "where c_compania = @compania " +
                   "and n_persona = @persona ";
            return xsql;
        }

        public static String QR_ListPersonaSearch()
        {
            xsql = "select n_persona,c_nombrecompleto=rtrim(c_nombrecompleto),c_EsEmpleado,c_EsProveedor,c_EsCliente, " +
                   "c_DocumentoIdentidad,c_Estado,c_DocumentoFiscal " +
                   "from rh_personas " +
                   "where c_compania = @compania " +
                   "and (@codigo = 0 or n_persona = @codigo) " +
                   "and (c_nombrecompleto like @nombre) " +
                   "and (c_DocumentoIdentidad like @docidentidad) " +
                   "and (c_DocumentoFiscal like @docfiscal) " +
                   "and (c_Estado like @estado) " +
                   "and (c_EsEmpleado = @esempleado or " +
                   "     c_EsProveedor = @esproveedor or " +
                   "     c_EsCliente = @escliente or " +
                   "     c_EsOtro = 'S') ";
            return xsql;
        }

    }
}
