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
    public class datCliente
    {
        public static Boolean GetExisteCliente(String Compania, Int32 Cliente)
        {
            Int32 nCount = 0;
            SqlDataReader dr = null;
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = tsqCliente.QR_GetExisteCliente();
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.Int)).Value = Cliente;

                dr = Cmd.ExecuteReader();
                if (dr.Read()){
                    nCount = dr.GetInt32(0);
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
            return (nCount>0);
        }

    }
}
