using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.General;
using FiltroLys.Model.Maestro.General;

namespace FiltroLys.Repository.Maestro.General
{
    public class datPersona
    {
        public static DataTable GetPersonaFormID(String Compania,Int32 Persona)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPersona.QR_GetPersonaFormID();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@persona", SqlDbType.Int)).Value = Persona;
                
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

        public static DataTable ListPersonaSearch(entPersona oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqPersona.QR_ListPersonaSearch();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int)).Value = oEnt.Persona;
                Cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar)).Value = oEnt.NombreCompleto;
                Cmd.Parameters.Add(new SqlParameter("@docidentidad", SqlDbType.VarChar)).Value = oEnt.DocumentoIdentidad;
                Cmd.Parameters.Add(new SqlParameter("@docfiscal", SqlDbType.VarChar)).Value = oEnt.DocumentoFiscal;
                Cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar)).Value = oEnt.Estado;
                Cmd.Parameters.Add(new SqlParameter("@esempleado", SqlDbType.VarChar)).Value = oEnt.EsEmpleado;
                Cmd.Parameters.Add(new SqlParameter("@esproveedor", SqlDbType.VarChar)).Value = oEnt.EsProveedor;
                Cmd.Parameters.Add(new SqlParameter("@escliente", SqlDbType.VarChar)).Value = oEnt.EsCliente;
                
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
