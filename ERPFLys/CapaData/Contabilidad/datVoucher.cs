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
    public class datVoucher{

        public static DataTable ListVoucherForm(String Cia, String FlagDepartCia, String DepartCia, String FlagPeriodo,
        String Periodo,String FlagEstado,String Estado,String FlagVoucher,String TipoVoucher,String VoucherIni,String VoucherFin)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqVoucher.QR_ListVoucherForm(Cia, FlagDepartCia, DepartCia, FlagPeriodo, Periodo, FlagEstado, 
                                                             Estado, FlagVoucher, TipoVoucher, VoucherIni, VoucherFin);
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

        public static DataTable GetVoucherFormID(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqVoucher.QR_GetVoucherFormID(Cia, Periodo, TipoVoucher, NroVoucher);
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

        public static DataTable GetVoucherFormIDDet(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqVoucher.QR_ListVoucherFormIDDet(Cia, Periodo, TipoVoucher, NroVoucher);
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

        public static DataTable ListVoucherToMayor(String Compania, String Periodo, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqVoucher.QR_ListVoucherToMayor();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar)).Value = Estado;
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

        public static DataTable ListVoucherDetCiaPerCuenta(String Compania, String Periodo, String Cuenta)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqVoucher.QR_ListVoucherDetCiaPerCuenta();
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.Add(new SqlParameter("@compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@cuenta", SqlDbType.VarChar)).Value = Cuenta;
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

        public static entErrores MantVoucher(entVoucher Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            Boolean bOk = true;
            int nUltCorr = 0; String sMens = "";

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try
                {
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();                    
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    
                    switch(Data.OperMantenimiento){
                        case fnEnum.OperacionMant.Insertar: 
                        case fnEnum.OperacionMant.Modificar:
                            //Actualizando Nvo Correlativo Voucher
                            if(Data.OperMantenimiento == fnEnum.OperacionMant.Insertar){
                                nUltCorr = datCorrelativoVoucher.GetUltimoCorrelativo(Data.Compania, Data.Periodo, Data.TipoVoucher);
                                nUltCorr++;

                                entCorrelativoVoucher oA = new entCorrelativoVoucher() { 
                                    Compania=Data.Compania,Periodo=Data.Periodo,TipoVoucher=Data.TipoVoucher,Correlativo=nUltCorr,UsuarioSys=Data.UsuarioSys
                                };
                                entErrores oETmp = datCorrelativoVoucher.SetUltimoCorrelativo(oA,Cmd);
                                bOk = oETmp.Resultado;
                                entErr.Errores.AddRange(oETmp.Errores);
                                if (bOk) { Data.NumeroVoucher = nUltCorr.ToString("0000"); }
                                oA = null;
                                oETmp = null;
                            }

                            if(bOk){
                                //Grabando Cabecera Voucher
                                Cmd.CommandType = CommandType.Text;
                                Cmd.Parameters.Clear();
                                Cmd.CommandText = tsqVoucher.QR_MantVoucherCabecera(Data.OperMantenimiento);
                                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                                Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                                Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Data.Departamento;
                                Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Data.Moneda;
                                Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = Data.Fecha;
                                Cmd.Parameters.Add(new SqlParameter("@TipoCambio", SqlDbType.Decimal)).Value = Data.TipoCambio;
                                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                                Cmd.Parameters.Add(new SqlParameter("@UsuarioRegistro", SqlDbType.VarChar)).Value = Data.UsuarioRegistro;
                                Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.DateTime)).Value = Data.FechaRegistro;
                                Cmd.Parameters.Add(new SqlParameter("@UsuarioAprobacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioAprobacion,"");
                                Cmd.Parameters.Add(new SqlParameter("@FechaAprobacion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAprobacion);
                                Cmd.Parameters.Add(new SqlParameter("@Origen", SqlDbType.VarChar)).Value = Data.Origen;
                                Cmd.Parameters.Add(new SqlParameter("@FlagModManual", SqlDbType.VarChar)).Value = Data.FlagModManual;
                                Cmd.Parameters.Add(new SqlParameter("@FlagModRestringida", SqlDbType.VarChar)).Value = Data.FlagModRestringida;
                                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                                Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = Data.UltimoUsuarioMod;
                                Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = Data.UltimaFechaMod;
                                Cmd.ExecuteNonQuery();

                                //Eliminando Detalle Voucher
                                Cmd.Parameters.Clear();
                                Cmd.CommandType = CommandType.Text;
                                Cmd.CommandText = tsqVoucher.QR_MantVoucherDetalle(fnEnum.OperacionMant.EliminarTodos);
                                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                                Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                                Cmd.ExecuteNonQuery();

                                //Grabando Detalle Voucher
                                Cmd.CommandType = CommandType.Text;
                                foreach (entVoucherDet oEnt in Data.DetalleVoucher)
                                {
                                    Cmd.Parameters.Clear();
                                    Cmd.CommandText = tsqVoucher.QR_MantVoucherDetalle(fnEnum.OperacionMant.Insertar);
                                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                                    Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = oEnt.Linea;
                                    Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Persona,0);
                                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CentroCosto,"");
                                    Cmd.Parameters.Add(new SqlParameter("@FlujoCaja", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.FlujoCaja,"");
                                    Cmd.Parameters.Add(new SqlParameter("@OrigenDoc", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.OrigenDoc,String.Empty);
                                    Cmd.Parameters.Add(new SqlParameter("@CodigoDoc", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(oEnt.CodigoDoc,0);
                                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Documento);
                                    Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(oEnt.Fecha);
                                    Cmd.Parameters.Add(new SqlParameter("@Proyecto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Proyecto,"");
                                    Cmd.Parameters.Add(new SqlParameter("@OrdenCompra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.OrdenCompra,"");
                                    Cmd.Parameters.Add(new SqlParameter("@Secuencia_OC", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Secuencia_OC,0);
                                    Cmd.Parameters.Add(new SqlParameter("@MontoLocal", SqlDbType.Decimal)).Value = oEnt.MontoLocal;
                                    Cmd.Parameters.Add(new SqlParameter("@MontoExt", SqlDbType.Decimal)).Value = oEnt.MontoExt;
                                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Descripcion);
                                    Cmd.Parameters.Add(new SqlParameter("@FlagAutomatico", SqlDbType.VarChar)).Value = oEnt.FlagAutomatico;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = oEnt.UltimoUsuarioMod;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = oEnt.UltimaFechaMod;
                                    Cmd.Parameters.Add(new SqlParameter("@CodMaquina", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CodMaquina,"");
                                    Cmd.ExecuteNonQuery();
                                }
                            }
                            break;
                        case fnEnum.OperacionMant.Aprobar:
                            Cmd.CommandType = CommandType.StoredProcedure;
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = tsqVoucher.UP_AprobarVoucher();
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                            Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                            Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                            Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                            Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 250)).Value = "";
                            Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                            Cmd.ExecuteNonQuery();
                            break;
                        case fnEnum.OperacionMant.Pendiente:
                            Cmd.CommandType = CommandType.StoredProcedure;
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = tsqVoucher.UP_PasarPendienteVoucher();
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                            Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                            Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                            Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                            Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 250)).Value = "";
                            Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                            Cmd.ExecuteNonQuery();
                            break;
                    }
                    if (bOk){
                        Trs.Commit();
                        entErr.Resultado = true;
                        entErr.CodigoGeneradoText = Data.NumeroVoucher;
                        
                        //Caso Aprobado
                        if (Data.OperMantenimiento == fnEnum.OperacionMant.Aprobar){
                            sMens = Cmd.Parameters["@Mensaje"].Value.ToString();
                            if (!sMens.Equals("OK")){
                                entErr.Resultado = false;
                                entErr.Errores.Add(new entFail() { Codigo = "SQL", Descripcion = sMens });
                            }
                        }
                    }
                    else { 
                        if (!(Data.OperMantenimiento == fnEnum.OperacionMant.Aprobar || Data.OperMantenimiento == fnEnum.OperacionMant.Pendiente)){ Trs.Rollback(); }
                    }
                }
                catch (Exception ex)
                {
                    Trs.Rollback();                    
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
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
            return entErr;
        }

        public static entErrores MantVoucher(List<entVoucher> Data, ref BackgroundWorker worker)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            Boolean bOk = true;
            String sMens = "", query = "";
            fnEnum.OperacionMant Operacion = Data[0].OperMantenimiento;
            int reg = 1, regtot = Data.Count;

            if (Operacion == fnEnum.OperacionMant.Aprobar) { query = tsqVoucher.UP_AprobarVoucher(); }
            if (Operacion == fnEnum.OperacionMant.Pendiente) { query = tsqVoucher.UP_PasarPendienteVoucher(); }

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try
                {
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = query;

                    reg = 1;
                    foreach(entVoucher objE in Data){
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = objE.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = objE.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = objE.TipoVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = objE.NumeroVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = objE.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 250)).Value = "";
                        Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        Cmd.ExecuteNonQuery();
                        sMens = Cmd.Parameters["@Mensaje"].Value.ToString();
                        if (!sMens.Equals("OK")){
                            entErr.Resultado = false;
                            entErr.Errores.Add(new entFail() { Codigo = "SQL", Descripcion = sMens });
                            bOk = false;
                            break;
                        }
                        Int32 nporc = (reg * 100) / regtot;
                        String sstatus = nporc.ToString();
                        worker.ReportProgress(nporc, sstatus);
                        System.Threading.Thread.Sleep(25);
                        reg++;
                    }

                    if (bOk){
                        Trs.Commit();
                        entErr.Resultado = true;
                    }else{
                        Trs.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
                }
                finally
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                    reg = Data.Count;
                }
            }
            return entErr;
        }

    }
}
