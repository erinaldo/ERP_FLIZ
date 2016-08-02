using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.General;

namespace FiltroLys.Repository.Maestro.General
{
    public class datGeneral
    {
        public static DateTime GetFechaServidor()
        {
            SqlCommand Cmd = new SqlCommand();
            DateTime Fecha = DateTime.MinValue;

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqGeneral.QR_GetFechaServidor();
                Cmd.CommandType = CommandType.Text;

                SqlDataReader dr = Cmd.ExecuteReader();
                if (dr.Read()) { Fecha = dr.GetDateTime(0);}
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
                dr = null;
            }
            return Fecha;
        }

    }
}
