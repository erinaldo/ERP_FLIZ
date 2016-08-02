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
    public class datUsuario{

        public static DataTable ListUsuarioXEstCombo(String Estado)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqUsuario.QR_ListUsuarioXEstCombo(Estado);
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

    }
}
