using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Contabilidad;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Repository.Contabilidad
{
    public class datCierreMesCuenta{

        public static DataTable ListSaldoCtaMayor(String Compania, String Periodo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCierreMesCuenta.UP_ListSaldoCtaMayor();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@c_compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@c_periodo", SqlDbType.VarChar)).Value = Periodo;
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

        public static DataTable ListSaldoCtaMayorDet(String Compania, String Periodo, String Mayor)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCierreMesCuenta.UP_ListSaldoCtaMayorDet();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@c_compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@c_periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@c_mayor", SqlDbType.VarChar)).Value = Mayor;
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

        public static DataTable GetCierreMensualRev(String Compania, String Periodo, String Operacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCierreMesCuenta.UP_GetCierreMensualRev();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Operacion", SqlDbType.VarChar)).Value = Operacion;
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

        public static String SetCierreMensualGen(String Compania, String Periodo, String Usuario)
        {
            String sResult = "";
            SqlCommand Cmd = new SqlCommand();            

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandText = tsqCierreMesCuenta.UP_SetCierreMensualGen();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;
                    sResult = (String)Cmd.ExecuteScalar();
                    Trs.Commit();
                    if (!sResult.Equals("OK")){
                        Trs.Rollback();
                    }
                }catch (Exception ex){
                    Trs.Rollback();
                    sResult = "[" + ex.GetHashCode().ToString() + "] - " + ex.Message;
                }
                finally {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return sResult;
        }

        public static String SetModificaPeriodo(String Compania, String Periodo, String Usuario, String Operacion)
        {
            String sResult = "";
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandText = tsqCierreMesCuenta.QR_SetModificaPeriodo(Operacion);
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;
                    Cmd.ExecuteNonQuery();
                    Trs.Commit();
                    sResult = "OK";
                }
                catch (Exception ex){
                    Trs.Rollback();
                    sResult = "[" + ex.GetHashCode().ToString() + "] - " + ex.Message;
                }
                finally{
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return sResult;
        }

        public static String GetPeriodoSig(String Periodo)
        {
            String sPeriodoSig = "";
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = tsqCierreMesCuenta.UP_GetPeriodoSig();
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@PeriodoSig", SqlDbType.VarChar,6)).Value = "";
                Cmd.Parameters["@PeriodoSig"].Direction = ParameterDirection.Output;
                Cmd.ExecuteNonQuery();
                sPeriodoSig = (String) Cmd.Parameters["@PeriodoSig"].Value;

                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
                Cmd = null;                
            }
            return sPeriodoSig;
        }

        public static Int32 SetPeriodoTrabajo(String Compania, String Periodo)
        {
            Int32 nResult = 0;
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try
                {
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandText = tsqCierreMesCuenta.QR_SetPeriodoTrabajo("A");
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                    Cmd.ExecuteNonQuery();

                    Cmd.Parameters.Clear();
                    Cmd.CommandText = tsqCierreMesCuenta.QR_SetPeriodoTrabajo("B");
                    Cmd.CommandType = CommandType.Text;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                    Cmd.ExecuteNonQuery();
                    
                    Trs.Commit();
                    nResult = 1;
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    nResult = -1;
                }
                finally
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return nResult;
        }

    }
}
