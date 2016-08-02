using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.General;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.General
{
    public class datCompania{

        public static DataTable ListCompaniaForm(String Compania, String Estado, String Nombre)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCompania.QR_ListCompaniaForm();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = Nombre;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static DataTable GetCompaniaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCompania.QR_GetCompaniaFormID();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static DataTable ListCiaComboXAppXUsu(String App,String Usuario,String SoloActivo)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCompania.UP_ListCiaComboXAppXUsu();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar, 2)).Value = App;
                Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar, 20)).Value = Usuario;
                Cmd.Parameters.Add(new SqlParameter("@FlagSoloActivo", SqlDbType.VarChar, 1)).Value = SoloActivo;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);                
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static entErrores MantCompania(entCompania Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();            

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = tsqCompania.QR_MantCompaniaForm(Data.OperMantenimiento);

                    switch (Data.OperMantenimiento){
                        case fnEnum.OperacionMant.Insertar:
                        case fnEnum.OperacionMant.Modificar:                            
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar)).Value = Data.Nombres;
                            Cmd.Parameters.Add(new SqlParameter("@NombreTeleCredito", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NombreTelecredito, "");
                            Cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Telefono, "");
                            Cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Direccion, "");
                            Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal, "");
                            Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pais, "");
                            Cmd.Parameters.Add(new SqlParameter("@DepartamentoCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DepartamentoCodigo, "");
                            Cmd.Parameters.Add(new SqlParameter("@ProvinciaCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ProvinciaCodigo, "");
                            Cmd.Parameters.Add(new SqlParameter("@DistritoCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DistritoCodigo, "");
                            Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value =  Data.UsuarioSys;
                            Cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Fax, "");
                            Cmd.Parameters.Add(new SqlParameter("@ActividadEconomica", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ActividadEconomica, "");
                            Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Condicion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Condicion, "");
                            Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Via", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Via, "");
                            Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Zona", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Zona, "");
                            Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_TipoEstab", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_TipoEstab, "");
                            Cmd.Parameters.Add(new SqlParameter("@SectorCompania", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.SectorCompania, "");
                            Cmd.ExecuteNonQuery();
                            break;
                        case fnEnum.OperacionMant.Eliminar:                            
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.ExecuteNonQuery();
                            break;
                        
                    }
                    
                    Trs.Commit();
                    entErr.Resultado = true;                    
                }
                catch (Exception ex){
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
                }finally{
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return entErr;
        }

    }
}
