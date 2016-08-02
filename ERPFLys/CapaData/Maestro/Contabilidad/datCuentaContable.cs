using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.Contabilidad
{
    public class datCuentaContable
    {
        public const string sProc = "UP_MANT_CUENTA_CONTABLE";

        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.SelectCommand.Parameters.AddWithValue("@Accion", Constans.LISTA);
                adapter.SelectCommand.Parameters.AddWithValue("@Opcion", Constans.OPCION_1);
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

        public static DataTable GetFormID(String Cuenta)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Cuenta;

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

        public static DataTable ListaCombo(String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_3;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
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

        public static DataTable ListaSearch(String Cuenta, String Nombres, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = sProc;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_4;
                Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Cuenta;
                Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = Nombres;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
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

        public static entErrores MantFormID(entCuentaContable Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();

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
                    Cmd.CommandText = tsqCuentaContable.QR_MantFormID(Data.OperMantenimiento);

                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                    {
                        if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar)
                        {
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                        }
                        else if (Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                        {
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                        }
                                 
                        Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Data.Cuenta;
                        Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = Data.Nombres;
                        Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                        Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@FlagDesaduanaje", SqlDbType.VarChar)).Value = Data.FlagDesaduanaje;
                        Cmd.Parameters.Add(new SqlParameter("@CodRubro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodRubro, "");
                        Cmd.Parameters.Add(new SqlParameter("@FlagEdificio", SqlDbType.VarChar)).Value = Data.FlagEdificio;
                        Cmd.Parameters.Add(new SqlParameter("@CuentaMayor", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaMayor, "");
                        Cmd.Parameters.Add(new SqlParameter("@TipoGasto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoGasto, "");
                        Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Data.Moneda;
                        Cmd.Parameters.Add(new SqlParameter("@FlagCuentaTrans", SqlDbType.VarChar)).Value = Data.FlagCuentaTrans;
                        Cmd.Parameters.Add(new SqlParameter("@CuentaDebeTrans", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaDebeTrans, "");
                        Cmd.Parameters.Add(new SqlParameter("@CuentaHaberTrans", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaHaberTrans, "");
                        Cmd.Parameters.Add(new SqlParameter("@FlagPermiteAjuste", SqlDbType.VarChar)).Value = Data.FlagPermiteAjuste;
                        Cmd.Parameters.Add(new SqlParameter("@FlagCierreAnual13", SqlDbType.VarChar)).Value = Data.FlagCierreAnual13;
                        Cmd.Parameters.Add(new SqlParameter("@FlagCierreAnual14", SqlDbType.VarChar)).Value = Data.FlagCierreAnual14;
                        Cmd.Parameters.Add(new SqlParameter("@ReqPersona", SqlDbType.VarChar)).Value = Data.ReqPersona;
                        Cmd.Parameters.Add(new SqlParameter("@TipoPersonaGen", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPersonaGen, "");
                        Cmd.Parameters.Add(new SqlParameter("@TipoPersonaEsp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPersonaEsp, "");
                        Cmd.Parameters.Add(new SqlParameter("@ReqProyecto", SqlDbType.VarChar)).Value = Data.ReqProyecto;
                        Cmd.Parameters.Add(new SqlParameter("@ReqOrdenCompra", SqlDbType.VarChar)).Value = Data.ReqOrdenCompra;
                        Cmd.Parameters.Add(new SqlParameter("@ReqDocumento", SqlDbType.VarChar)).Value = Data.ReqDocumento;
                        Cmd.Parameters.Add(new SqlParameter("@ReqFecha", SqlDbType.VarChar)).Value = Data.ReqFecha;
                        Cmd.Parameters.Add(new SqlParameter("@ReqCCosto", SqlDbType.VarChar)).Value = Data.ReqCCosto;
                        Cmd.Parameters.Add(new SqlParameter("@ReqDescripcion", SqlDbType.VarChar)).Value = Data.ReqDescripcion;
                        Cmd.Parameters.Add(new SqlParameter("@ReqFlujoCaja", SqlDbType.VarChar)).Value = Data.ReqFlujoCaja;
                        Cmd.Parameters.Add(new SqlParameter("@FlagSaldoPersona", SqlDbType.VarChar)).Value = Data.FlagSaldoPersona;
                        Cmd.Parameters.Add(new SqlParameter("@FlagSaldoDocumento", SqlDbType.VarChar)).Value = Data.FlagSaldoDocumento;
                        Cmd.Parameters.Add(new SqlParameter("@LibroCaja", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.LibroCaja, "");
                        Cmd.Parameters.Add(new SqlParameter("@ClasificacionGasto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ClasificacionGasto, "");
                        Cmd.Parameters.Add(new SqlParameter("@RubroGasto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RubroGasto, "");
                        Cmd.Parameters.Add(new SqlParameter("@TipoCuenta", SqlDbType.VarChar)).Value = Data.TipoCuenta;
                        Cmd.Parameters.Add(new SqlParameter("@CuentaMayor04", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaMayor04, "");
                        Cmd.Parameters.Add(new SqlParameter("@CuentaMayor05", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaMayor05, "");
                        Cmd.Parameters.Add(new SqlParameter("@ElmentoGasto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ElmentoGasto, "");
                        Cmd.Parameters.Add(new SqlParameter("@NivelCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NivelCuenta, "");
                        Cmd.ExecuteNonQuery();
                         
                    }
                    else if (Data.OperMantenimiento == fnEnum.OperacionMant.Eliminar)
                    {
                        Cmd.CommandText = tsqCompCContable.QR_MantFormID(fnEnum.OperacionMant.EliminarTodos);
                        Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Data.Cuenta; 
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;    
                        Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;    
                        Cmd.ExecuteNonQuery();

                        Cmd.Parameters.Clear();
                        Cmd.CommandText = tsqCuentaContable.QR_MantFormID(fnEnum.OperacionMant.Eliminar);
                        Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Data.Cuenta;     
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;    
                        Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_1;    
                        Cmd.ExecuteNonQuery();
                    }

                    //Grabando Detalle Cuenta Contable
                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                    {
                        foreach (entCompCContable oEnt in Data.DetalleCuentaxCompania)
                        {
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = tsqCompCContable.QR_MantFormID(oEnt.OperMantenimiento);

                            if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                            {
                                if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar)
                                {
                                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                                }
                                else if (Data.OperMantenimiento == fnEnum.OperacionMant.Modificar)
                                {
                                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                                }

                                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                                Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = oEnt.Estado;
                                Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = oEnt.UltimoUsuarioMod;
                                Cmd.ExecuteNonQuery();
                            }
                            else if (Data.OperMantenimiento == fnEnum.OperacionMant.Eliminar)
                            {
                                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                                Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                                Cmd.ExecuteNonQuery();
                            }
                        }
                        Trs.Commit(); 
                    }

                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Eliminar)
                    {
                        Trs.Commit();
                    }
                    entErr.Resultado = true;
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
                    Data = null;
                    GC.SuppressFinalize(Cnx);
                }
            }
            return entErr;
        }
    }
}