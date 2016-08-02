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
using FiltroLys.Type;
using FiltroLys.Repository.Objeto;

namespace FiltroLys.Repository.Maestro.Contabilidad
{
    public class datAsientoModelo
    {

        public static string sProc = "UP_MANT_ASIENTO_MODELO";

        public static DataTable ListAsientoModelo(entAsientoModelo oEnt)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = tsqAsientoModelo.QR_ListAsientoModelo();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.LISTA;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_1;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = oEnt.Modelo;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = oEnt.Descripcion;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = oEnt.Estado;
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

        public static DataTable ListAsientoModeloDet(entAsientoModeloDet oEnt)
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
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = oEnt.Modelo;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = oEnt.Descripcion;
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

        public static DataTable ListAsientoModeloSearch(String compania)
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
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = compania;
                
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

        public static DataTable ListAsientoModeloDetSearch(String compania, String Modelo)
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
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = compania;
                Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = Modelo;

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

        public static entErrores MantAsientoModelo(entAsientoModelo Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = tsqAsientoModelo.QR_MantAsientoModelo(Data.OperMantenimiento);

                    //Cabecera
                    switch (Data.OperMantenimiento){
                        case fnEnum.OperacionMant.Insertar:
                       
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                            Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_1;
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = Data.Modelo;
                            Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                            Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                            Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Anual, "");
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = Data.UltimoUsuarioMod;
                            Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = Data.UltimaFechaMod;
                            Cmd.ExecuteNonQuery();
                            break;
                        case fnEnum.OperacionMant.Modificar:
                             Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                             Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_1;
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = Data.Modelo;
                            Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                            Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                            Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Anual, "");
                            Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = Data.UltimoUsuarioMod;
                            Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = Data.UltimaFechaMod;
                            Cmd.ExecuteNonQuery();
                            break;

                            
                        case fnEnum.OperacionMant.Eliminar:
                            Cmd.CommandText = tsqAsientoModelo.QR_MantAsientoModeloDetalle(fnEnum.OperacionMant.EliminarTodos);
                             Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                            Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.ELIMINARTODO;
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = Data.Modelo;                       
                            Cmd.ExecuteNonQuery();

                            Cmd.Parameters.Clear();
                            Cmd.CommandText = tsqAsientoModelo.QR_MantAsientoModelo(fnEnum.OperacionMant.Eliminar);
                            Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                            Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.ELIMINAR;
                            Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                            Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = Data.Modelo;                       
                            Cmd.ExecuteNonQuery();
                            break;
                    }
                    
                    //Grabando Detalle Voucher
                    if(Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar){                        
                        foreach (entAsientoModeloDet oEnt in Data.DetalleAsientoModelo){
                            Cmd.Parameters.Clear();
                            Cmd.CommandText = tsqAsientoModelo.QR_MantAsientoModeloDetalle(oEnt.OperMantenimiento);

                            switch (oEnt.OperMantenimiento){
                                case fnEnum.OperacionMant.Insertar:
                                     Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.INSERTAR;
                                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                                    Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = oEnt.Modelo;
                                    Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = oEnt.Linea;
                                    Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CentroCosto, "");
                                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Persona, 0);
                                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Documento, "");
                                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Descripcion);
                                    Cmd.Parameters.Add(new SqlParameter("@Porcentaje", SqlDbType.Decimal)).Value = oEnt.Porcentaje;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = oEnt.UltimoUsuarioMod;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = oEnt.UltimaFechaMod;
                                    Cmd.Parameters.Add(new SqlParameter("@Cuenta_Ant", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Cuenta_Ant, "");
                                    break;
                                case fnEnum.OperacionMant.Modificar:
                                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.ACTUALIZAR;
                                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_2;
                                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                                    Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = oEnt.Modelo;
                                    Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = oEnt.Linea;
                                    Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CentroCosto, "");
                                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Persona, 0);
                                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Documento, "");
                                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Descripcion);
                                    Cmd.Parameters.Add(new SqlParameter("@Porcentaje", SqlDbType.Decimal)).Value = oEnt.Porcentaje;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = oEnt.UltimoUsuarioMod;
                                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = oEnt.UltimaFechaMod;
                                    Cmd.Parameters.Add(new SqlParameter("@Cuenta_Ant", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Cuenta_Ant, "");                            
                                    Cmd.ExecuteNonQuery();
                                    break;
                                case fnEnum.OperacionMant.Eliminar:
                                    Cmd.CommandText = tsqAsientoModelo.QR_MantAsientoModeloDetalle(oEnt.OperMantenimiento);
                                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = Constans.DELETE;
                                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Constans.OPCION_3;
                                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                                    Cmd.Parameters.Add(new SqlParameter("@Modelo", SqlDbType.VarChar)).Value = oEnt.Modelo;
                                    Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = oEnt.Linea;
                                    Cmd.ExecuteNonQuery();
                                    break;
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
                catch (Exception ex){
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
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

    }
}
