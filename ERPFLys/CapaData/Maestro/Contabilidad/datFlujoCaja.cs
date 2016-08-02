using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;

namespace FiltroLys.Repository.Maestro.Contabilidad
{
    public class datFlujoCaja
    {
        public static DataTable GetFlujoCajaFormID(String FlujoCaja)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqFlujoCaja.QR_GetFlujoCajaFormID();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@flujocaja", SqlDbType.VarChar)).Value = FlujoCaja;
                
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

        public static DataTable ListFlujoCajaSearch(entFlujoCaja oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqFlujoCaja.QR_ListFlujoCajaSearch();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar)).Value = oEnt.FlujoCaja;
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
