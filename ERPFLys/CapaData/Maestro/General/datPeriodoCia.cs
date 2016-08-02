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
    public class datPeriodoCia
    {
        public static DataTable ListaFormID(String Sistema)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPeriodoCia.QR_ListaFormID();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Sistema;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.SelectCommand.Parameters.AddWithValue("@Accion", Constans.LISTA);
                adapter.SelectCommand.Parameters.AddWithValue("@Opcion", Constans.OPCION_1);
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

        public static DataTable GetFormID(String Compania, String Periodo, String Sistema)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPeriodoCia.QR_GetFormID();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Sistema;

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

        public static DataTable ListaCombo(String Compania, String Periodo, String Sistema, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPeriodoCia.QR_ListaCombo();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_3;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Sistema;
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

        public static DataTable ListaSearch(String Compania, String Periodo, String Sistema, String Estado, String FlagBloqueo, String FlagTrabajo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPeriodoCia.QR_ListaSearch();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_4;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Sistema;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@FlagBloqueo", SqlDbType.VarChar)).Value = FlagBloqueo;
                Cmd.Parameters.Add(new SqlParameter("@FlagTrabajo", SqlDbType.VarChar)).Value = FlagTrabajo;
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

        public static entErrores MantFormID(entPeriodoCia Data)
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
                    Cmd.CommandText = tsqPeriodoCia.QR_MantFormID(Data.OperMantenimiento);

                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                    {
                        if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar)
                        {
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                        }
                        else if (Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                        {
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                            Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_1;
                        }
                   
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Data.Sistema;
                        Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                        Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@FlagBloqueo", SqlDbType.VarChar)).Value = Data.FlagBloqueo;
                        Cmd.Parameters.Add(new SqlParameter("@FlagTrabajo", SqlDbType.VarChar)).Value = Data.FlagTrabajo;
                        Cmd.ExecuteNonQuery();
                        
                    }
                    else if (Data.OperMantenimiento == fnEnum.OperacionMant.Eliminar)
                    {
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ELIMINAR;
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Data.Sistema;
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
                    Data = null;
                    GC.SuppressFinalize(Cnx);
                }
            }
            return entErr;
        }

        public static String GetPeriodoTrabajo(String Compania, String Sistema)
        {
            String sPeriodo = "";
            SqlDataReader dr = null;
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPeriodoCia.QR_GetPeriodoTrabajo();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_5;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = Sistema;                
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    sPeriodo = dr.GetString(0);
                }
                dr.Close();
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
                Cmd = null;                
                dr = null;
            }
            return sPeriodo;
        }

        public static entErrores MantBloqueoPeriodo(List<entPeriodoCia> Data)
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
                    Cmd.CommandText = tsqPeriodoCia.QR_MantBloqueoPeriodo();

                    foreach (entPeriodoCia objE in Data)
                    {
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                        Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = objE.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = objE.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@Sistema", SqlDbType.VarChar)).Value = objE.Sistema;
                        Cmd.Parameters.Add(new SqlParameter("@FlagBloqueo", SqlDbType.VarChar)).Value = objE.FlagBloqueo;
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