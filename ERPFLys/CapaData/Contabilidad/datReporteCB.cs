using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using FiltroLys.Query.Contabilidad;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Repository.Objeto;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using System.Transactions;

namespace FiltroLys.Repository.Contabilidad
{
    public class datReporteCB{

        public static DataTable RptLibroDiario(String Cia, String Periodo, String Moneda, String TipoCuenta,String IncPerRel,String TipoRep)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptLibroDiario();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Moneda;
                Cmd.Parameters.Add(new SqlParameter("@TipoCta", SqlDbType.VarChar)).Value = TipoCuenta;
                Cmd.Parameters.Add(new SqlParameter("@IncPerRel", SqlDbType.VarChar)).Value = IncPerRel;
                Cmd.Parameters.Add(new SqlParameter("@TipoRep", SqlDbType.VarChar)).Value = TipoRep;

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

        public static DataTable RptLibroMayor(String Cia, String Periodo, String Moneda, String CuentaIni, String CuentaFin, String TipoCuenta, String IncPerRel, String TipoRep)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptLibroMayor();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Moneda;
                Cmd.Parameters.Add(new SqlParameter("@CuentaIni", SqlDbType.VarChar)).Value = CuentaIni;
                Cmd.Parameters.Add(new SqlParameter("@CuentaFin", SqlDbType.VarChar)).Value = CuentaFin;
                Cmd.Parameters.Add(new SqlParameter("@TipoPlan", SqlDbType.VarChar)).Value = TipoCuenta;
                Cmd.Parameters.Add(new SqlParameter("@IncPerRel", SqlDbType.VarChar)).Value = IncPerRel;
                Cmd.Parameters.Add(new SqlParameter("@TipoRep", SqlDbType.VarChar)).Value = TipoRep;

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

        public static DataTable RptRegistroCompra(String Cia, String PerIni, String PerFin, String RegOB, String RegCChica, String RegRGasto, 
        String FlagProv, String Proveedor, String FlagDatoProv, String DatoProv, String TipoRep){
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptRegistroCompra();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@PeriodoIni", SqlDbType.VarChar)).Value = PerIni;
                Cmd.Parameters.Add(new SqlParameter("@PeriodoFin", SqlDbType.VarChar)).Value = PerFin;
                Cmd.Parameters.Add(new SqlParameter("@RegObligacion", SqlDbType.VarChar)).Value = RegOB;
                Cmd.Parameters.Add(new SqlParameter("@RegCajaChica", SqlDbType.VarChar)).Value = RegCChica;
                Cmd.Parameters.Add(new SqlParameter("@RegRepGasto", SqlDbType.VarChar)).Value = RegRGasto;
                Cmd.Parameters.Add(new SqlParameter("@FlagProveedor", SqlDbType.VarChar)).Value = FlagProv;
                Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.VarChar)).Value = Proveedor;
                Cmd.Parameters.Add(new SqlParameter("@FlagDatoProv", SqlDbType.VarChar)).Value = FlagDatoProv;
                Cmd.Parameters.Add(new SqlParameter("@DatoProv", SqlDbType.VarChar)).Value = DatoProv;
                Cmd.Parameters.Add(new SqlParameter("@TipoReporte", SqlDbType.VarChar)).Value = TipoRep;
                
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

        public static DataTable RptRegistroRetencion(String Cia, String FlagPeriodo, String Periodo, String FlagProveedor, Int32 Proveedor,
        String FlagFecha, DateTime FechaPagoIni, DateTime FechaPagoFin, String FlagTipo, String Tipo, Int32 Retencion, String FlagEstado,
        String Estado, String ExcluirAnulado, String FlagOrigenRet, String OrigenRet, String SunatTXT){
            
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptRegistroRetencion();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@FlagPeriodo", SqlDbType.VarChar)).Value = FlagPeriodo;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@FlagProveedor", SqlDbType.VarChar)).Value = FlagProveedor;
                Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.Int)).Value = Proveedor;
                Cmd.Parameters.Add(new SqlParameter("@FlagFecha", SqlDbType.VarChar)).Value = FlagFecha;
                Cmd.Parameters.Add(new SqlParameter("@FechaPagoIni", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(FechaPagoIni);
                Cmd.Parameters.Add(new SqlParameter("@FechaPagoFin", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(FechaPagoFin);
                Cmd.Parameters.Add(new SqlParameter("@FlagTipo", SqlDbType.VarChar)).Value = FlagTipo;
                Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = Tipo;
                Cmd.Parameters.Add(new SqlParameter("@Retencion", SqlDbType.Int)).Value = Retencion;
                Cmd.Parameters.Add(new SqlParameter("@FlagEstado", SqlDbType.VarChar)).Value = FlagEstado;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@ExcluirAnulado", SqlDbType.VarChar)).Value = ExcluirAnulado;
                Cmd.Parameters.Add(new SqlParameter("@FlagTipoReg", SqlDbType.VarChar)).Value = FlagOrigenRet;
                Cmd.Parameters.Add(new SqlParameter("@TipoReg", SqlDbType.VarChar)).Value = OrigenRet;
                Cmd.Parameters.Add(new SqlParameter("@SunatTXT", SqlDbType.VarChar)).Value = SunatTXT;

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

        public static DataTable RptRegistroDaotVenta(String Cia, String Periodo, String FlagSupera, String Tipo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptRegistroDaotVenta();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@FlagSupera", SqlDbType.VarChar)).Value = FlagSupera;
                Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = Tipo;
                
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

        public static DataTable RptRegistroDaotCompra(String Cia, String Periodo, String FlagSupera, String Tipo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptRegistroDaotCompra();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@FlagSupera", SqlDbType.VarChar)).Value = FlagSupera;
                Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = Tipo;

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

        public static DataTable RptPlanCuenta(String Cia, String Periodo, String TipoPlan, String FlagCuenta, String Mayor02,
        String Mayor03, String Mayor04, String Mayor05, String FlagEstado, String Estado, String TipoRep)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqReporteCB.UP_RptPlanCuenta();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Cia;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@TipoPlan", SqlDbType.VarChar)).Value = TipoPlan;
                Cmd.Parameters.Add(new SqlParameter("@FlagCta", SqlDbType.VarChar)).Value = FlagCuenta;
                Cmd.Parameters.Add(new SqlParameter("@Mayor02", SqlDbType.VarChar)).Value = Mayor02;
                Cmd.Parameters.Add(new SqlParameter("@Mayor03", SqlDbType.VarChar)).Value = Mayor03;
                Cmd.Parameters.Add(new SqlParameter("@Mayor04", SqlDbType.VarChar)).Value = Mayor04;
                Cmd.Parameters.Add(new SqlParameter("@Mayor05", SqlDbType.VarChar)).Value = Mayor05;
                Cmd.Parameters.Add(new SqlParameter("@FlagEstado", SqlDbType.VarChar)).Value = FlagEstado;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@TipoRep", SqlDbType.VarChar)).Value = TipoRep;
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
