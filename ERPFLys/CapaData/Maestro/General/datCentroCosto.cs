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
    public class datCentroCosto
    {
        public static DataTable ListCentroCostoForm()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCentroCosto.QR_ListCentroCostoForm();
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.SelectCommand.Parameters.AddWithValue("Accion", Constans.LISTA);
                adapter.SelectCommand.Parameters.AddWithValue("Opcion", Constans.OPCION_1);

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

        public static DataTable GetCentroCostoFormID(String Compania,String CentroCosto)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCentroCosto.QR_GetCentroCostoFormID();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@CCosto", SqlDbType.VarChar)).Value = CentroCosto;
                
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

        public static DataTable ListaCentroCostoCombo(String Compania, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCentroCosto.QR_ListaCentroCostoCombo();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_3;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
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

        public static DataTable ListCentroCostoSearch(entCentroCosto oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCentroCosto.QR_ListCentroCostoSearch();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_4;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar)).Value = oEnt.CentroCosto;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = oEnt.Nombres;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = oEnt.Estado;                

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

        public static entErrores MantCentroCostoForm(entCentroCosto Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try
                {
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = tsqCentroCosto.QR_MantCentroCostoForm(Data.OperMantenimiento);

                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento==fnEnum.OperacionMant.Modificar)
                    {
                        if  (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar )
                        {/**/
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                         

                        }
                        else if (Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                        {
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                        }
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = Data.CentroCosto;
                            Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = Data.Nombres;
                            Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                            Cmd.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Clasificacion, "");
                            Cmd.Parameters.Add(new SqlParameter("@UsuarioResponsable", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioResponsable, "");
                            Cmd.Parameters.Add(new SqlParameter("@RetTipo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RepTipo, "");
                            Cmd.Parameters.Add(new SqlParameter("@CargoResponsable", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CargoResponsable, "");
                            Cmd.Parameters.Add(new SqlParameter("@DepartamentoCia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DepartamentoCiaCodigo, "");
                            Cmd.Parameters.Add(new SqlParameter("@CCostoSup", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CentroCostoNext, "");
                            Cmd.Parameters.Add(new SqlParameter("@Ubicacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Ubicacion, "");
                            Cmd.Parameters.Add(new SqlParameter("@FlagGerencia", SqlDbType.VarChar)).Value = Data.FlagGerencia;
                            Cmd.Parameters.Add(new SqlParameter("@CostoDirecto", SqlDbType.VarChar)).Value = Data.CostoDirecto;
                            Cmd.Parameters.Add(new SqlParameter("@Mision", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Mision, "");
                            Cmd.Parameters.Add(new SqlParameter("@GrupoCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.GrupoCC, "");
                            Cmd.Parameters.Add(new SqlParameter("@ClasificacionGCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ClasificacionGCC, "");
                            Cmd.ExecuteNonQuery();
                           
                           
                           

                    }

                    if (Data.OperMantenimiento== fnEnum.OperacionMant.Eliminar){/**/
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = Data.CentroCosto;
                            Cmd.ExecuteNonQuery();
                    }
                    Trs.Commit();
                    entErr.Resultado = true;
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
                }
                finally
                {
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
