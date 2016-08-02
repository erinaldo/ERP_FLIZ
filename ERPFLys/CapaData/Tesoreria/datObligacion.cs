using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Tesoreria;
using FiltroLys.Model.Tesoreria;

namespace FiltroLys.Repository.Tesoreria
{
    public class datObligacion{

        public static DataTable ListObligacionToMantVoucherSearch(entObligacion oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqObligacion.QR_ListObligacionToMantVoucherSearch();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@proveedor", SqlDbType.Int)).Value = oEnt.CodProveedor;
                Cmd.Parameters.Add(new SqlParameter("@tipodoc", SqlDbType.VarChar)).Value = oEnt.TipoDocumento;
                Cmd.Parameters.Add(new SqlParameter("@numroc", SqlDbType.VarChar)).Value = oEnt.NumeroDocumento;
                Cmd.Parameters.Add(new SqlParameter("@estadodoc", SqlDbType.VarChar)).Value = oEnt.EstadoDoc;

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

        public static DataTable GetObligacionXProvYDoc(entObligacion oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqObligacion.QR_GetObligacionXProvYDoc();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@proveedor", SqlDbType.Int)).Value = oEnt.CodProveedor;
                Cmd.Parameters.Add(new SqlParameter("@tipodoc", SqlDbType.VarChar)).Value = oEnt.TipoDocumento;
                Cmd.Parameters.Add(new SqlParameter("@numroc", SqlDbType.VarChar)).Value = oEnt.NumeroDocumento;
                
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
