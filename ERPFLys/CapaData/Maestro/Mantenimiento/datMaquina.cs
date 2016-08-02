using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.Mantenimiento;
using FiltroLys.Model.Maestro.Mantenimiento;

namespace FiltroLys.Repository.Maestro.Mantenimiento
{
    public class datMaquina
    {
        public static DataTable GetMaquinaFormID(String Compania,String Maquina)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqMaquina.QR_GetMaquinaFormID();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@maquina", SqlDbType.VarChar)).Value = Maquina;

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

        public static DataTable ListMaquinaSearch(entMaquina oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqMaquina.QR_ListMaquinaSearch();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@maquina", SqlDbType.VarChar)).Value = oEnt.Maquina;
                Cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar)).Value = oEnt.Descripcion;
                Cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar)).Value = oEnt.Estado;

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
