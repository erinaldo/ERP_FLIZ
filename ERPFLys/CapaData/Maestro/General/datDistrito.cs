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
    public class datDistrito
    {
        static String sMsj = "";
        static String sProc = "UP_MA_MANT_DISTRITO";

        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTMAE";

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

        public static DataTable GetFormID(String Pais, String Departamento, String Provincia, String Distrito)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "GETID";
                Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Pais;
                Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Departamento;
                Cmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.VarChar)).Value = Provincia;
                Cmd.Parameters.Add(new SqlParameter("@Distrito", SqlDbType.VarChar)).Value = Distrito;

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

        public static DataTable ListaCombo(String Pais, String Departamento, String Provincia, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTCMB";
                Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Pais;
                Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Departamento;
                Cmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.VarChar)).Value = Provincia;
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

        public static DataTable ListaSearch(String Pais, String Departamento, String Provincia, String Distrito, String Descripcion, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTBUS";
                Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Pais;
                Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Departamento;
                Cmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.VarChar)).Value = Provincia;
                Cmd.Parameters.Add(new SqlParameter("@Distrito", SqlDbType.VarChar)).Value = Distrito;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Descripcion;
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

        public static entErrores MantFormID(entDistrito Data)
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
                    Cmd.CommandText = sProc;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Data.Pais;
                    Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Data.DepartamentoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.VarChar)).Value = Data.ProvinciaCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Distrito", SqlDbType.VarChar)).Value = Data.DistritoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@CodigoDistFedd", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoDistFedd,"");
                    Cmd.Parameters.Add(new SqlParameter("@Ubigeo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Ubigeo,"");
                    Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar,250));
                    Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                    Cmd.ExecuteNonQuery();

                    sMsj = Cmd.Parameters["@Mensaje"].Value.ToString();
                    if(sMsj.Substring(0,3).Equals("OKS")){
                        Trs.Commit();
                        entErr.Resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    sMsj = (sMsj.Equals("") || sMsj==null) ? sMsj = ex.Message : sMsj;
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sMsj });
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
    }
}