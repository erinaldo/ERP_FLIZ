using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Seguridad;

namespace FiltroLys.Repository.Seguridad
{
    public class datSeguridad{       

        public static int GetValidarAcceso(String Usuario,String Clave)
        {
            int nReturn=1;
            SqlDataReader dr = null;
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.Text;

                if(nReturn == 1){          
                    Cmd.CommandText = tsqSeguridad.QR_GetUsuarioExiste(Usuario);
                    dr = Cmd.ExecuteReader();
                    if (dr.Read()){
                        if (dr.GetInt32(0) == 0) { nReturn = -1; }
                    }
                    dr.Close();
                }
            
                if(nReturn == 1){
                    Cmd.CommandText = tsqSeguridad.QR_GetUsuarioActivo(Usuario);
                    dr = Cmd.ExecuteReader();
                    if (dr.Read()){
                        if (dr.GetInt32(0) == 0) { nReturn = -2; }
                    }
                    dr.Close();
                }

                if(nReturn == 1){
                    Cmd.CommandText = tsqSeguridad.QR_GetUsuarioClaveSi(Usuario, datEncriptar.fnEncriptar(Clave));
                    dr = Cmd.ExecuteReader();
                    if (dr.Read()){
                        if (dr.GetInt32(0) == 0) { nReturn = -3; }
                    }
                    dr.Close();
                }

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
            return nReturn;
        }

        public static DataTable ListAccesoUsuApp(String Usuario, String Aplicacion)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqSeguridad.QR_ListAccesoUsuApp(Usuario, Aplicacion);
                Cmd.CommandType = CommandType.Text;

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

        public static DataTable ListMenuMaestros(String Usuario)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqSeguridad.UP_ListMenuMaestros();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;

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

        public static DataTable ListMenuReportes(String Usuario)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqSeguridad.UP_ListMenuReportes();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;

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

    }
}
