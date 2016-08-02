using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Seguridad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Seguridad
{
    public class datAuditoria{

        public static DataTable ListAuditoria(entAuditoria Data)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = tsqAuditoria.QR_ListAuditoria();
                Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Data.CodigoUsuario;
                Cmd.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.DateTime)).Value = Data.FechaInicio;
                Cmd.Parameters.Add(new SqlParameter("@FechaFinal", SqlDbType.DateTime)).Value = Data.FechaTermino;
                
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

        public static entErrores MantAuditoria(fnEnum.OperacionMant Operacion, entAuditoria Data)
        { 
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = tsqAuditoria.TR_MantAuditoria(Operacion);
                    switch (Operacion)
                    {
                        case fnEnum.OperacionMant.Insertar:
                            Cmd.Parameters.Add(new SqlParameter("@Estacion", SqlDbType.VarChar)).Value = Data.Estacion;
                            Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Data.CodigoUsuario;
                            Cmd.Parameters.Add(new SqlParameter("@FechaPcIng", SqlDbType.DateTime)).Value = Data.FechaPcIng;
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UltimoUsuario;
                            break;
                        case fnEnum.OperacionMant.Modificar:
                            Cmd.Parameters.Add(new SqlParameter("@Estacion", SqlDbType.VarChar)).Value = Data.Estacion;
                            Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Data.CodigoUsuario;
                            Cmd.Parameters.Add(new SqlParameter("@FechaPcIng", SqlDbType.DateTime)).Value = Data.FechaPcIng;
                            Cmd.Parameters.Add(new SqlParameter("@FechaPcSal", SqlDbType.DateTime)).Value = Data.FechaPcSal;
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UltimoUsuario;
                            break;
                    }                    
                    Cmd.ExecuteNonQuery();
                    Trs.Commit();
                    entErr.Resultado = true;
                }catch(Exception ex){
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail(){ Codigo= ex.GetHashCode().ToString(),Descripcion=ex.Message});
                }finally{
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

        public static DateTime GetFechaServidor()
        {
            DateTime dFecha = DateTime.MinValue;
            SqlDataReader dr = null;
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = tsqAuditoria.QR_GetFechaServidor();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    dFecha = dr.GetDateTime(0);
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
            return dFecha;
        }

    }
}
