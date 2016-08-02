using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.Mantenimiento
{
    public class tsqMaquina
    {
        static String xsql = "";

        public static String QR_GetMaquinaFormID()
        {
            xsql = "select c_compania,c_maquina,c_descripcion,c_tipomaquina,c_centrocosto,n_potencia,n_piezasmax,n_costomaquinahora, " +
                   "c_codmarca,c_codmodelo,c_numeroserie,n_anofabricacion,n_anopuestamarcha,n_provfabricante,n_provrepresentante, " +
                   "n_pesototal,n_largo,n_ancho,n_altura,n_potencialtotal,n_promediohoradia,c_monedacosto,n_costo,c_monedacostoparada, " +
                   "n_costoparada,c_criticidad,c_tiempogarantia,c_informaciontecnica,c_planos,c_caracteristicasoperacion,c_estado, " +
                   "c_ultimousuario,d_ultimafechamodificacion,n_turno1,n_turno2,n_turno3,n_tiempopreparacion,n_tiemporegulacion, " +
                   "c_gas,c_otrorepresentante,d_anopuestamarcha,c_critica,n_nivelcriticidad,c_paralelo,c_alquiler,c_opAU,c_opSA,c_opMN, "+
                   "c_codigobarra,c_familiainspeccion " +
                   "from mt_maquina " +
                   "where c_compania = @compania " +
                   "and c_maquina = @maquina ";
            return xsql;
        }

        public static String QR_ListMaquinaSearch()
        {
            xsql = "select c_compania,c_maquina=rtrim(c_maquina),c_descripcion=rtrim(c_descripcion),c_estado " +
                   "from mt_maquina " +
                   "where c_compania = @compania " +
                   "and c_maquina like @maquina " +
                   "and c_descripcion like @descripcion " +
                   "and c_estado like @estado ";
            return xsql;
        }

    }
}
