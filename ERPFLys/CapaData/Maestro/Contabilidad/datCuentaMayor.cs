﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Objeto;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.Contabilidad
{
    public class datCuentaMayor
    {
        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCuentaMayor.QR_ListaFormID();
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

        public static DataTable GetFormID(String CuentaMayor)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCuentaMayor.QR_GetFormID();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                Cmd.Parameters.Add(new SqlParameter("@CuentaMayor", SqlDbType.VarChar)).Value = CuentaMayor;

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

        public static DataTable ListaCombo(String Clasificacion,String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCuentaMayor.QR_ListaCombo();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_3;
                Cmd.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar)).Value = Clasificacion;
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

        public static DataTable ListaSearch(String CuentaMayor,String Clasificacion, String Descripcion, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqCuentaMayor.QR_ListaSearch();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_4;
                Cmd.Parameters.Add(new SqlParameter("@CuentaMayor", SqlDbType.VarChar)).Value = CuentaMayor;
                Cmd.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar)).Value = Clasificacion;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Descripcion;
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

        public static entErrores MantFormID(entCuentaMayor Data)
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
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = tsqCuentaMayor.QR_MantFormID(Data.OperMantenimiento);

                    if (Data.OperMantenimiento ==  fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar )
                    {
                            if(Data.OperMantenimiento ==  fnEnum.OperacionMant.Insertar )
                            {
                                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                            }
                            else if(Data.OperMantenimiento ==  fnEnum.OperacionMant.Modificar )
                            {
                                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                            }
                            Cmd.Parameters.Add(new SqlParameter("@CuentaMayor", SqlDbType.VarChar)).Value = Data.CuentaMayor;
                            Cmd.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar)).Value = Data.Clasificacion;
                            Cmd.Parameters.Add(new SqlParameter("@TipoCuenta", SqlDbType.VarChar)).Value = Data.TipoCuenta;
                            Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                            Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                            Cmd.Parameters.Add(new SqlParameter("@DescripcionAnt", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DescripcionAnt, "");
                            Cmd.ExecuteNonQuery();
                            
                        

                    }
                    else if (Data.OperMantenimiento == fnEnum.OperacionMant.Eliminar)
                    {/**/
                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                        Cmd.Parameters.Add(new SqlParameter("@CuentaMayor", SqlDbType.VarChar)).Value = Data.CuentaMayor;
                        Cmd.ExecuteNonQuery();
                    }

                    Trs.Commit();
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
