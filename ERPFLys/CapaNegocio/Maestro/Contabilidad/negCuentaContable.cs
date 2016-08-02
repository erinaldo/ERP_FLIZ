using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Domain.Tesoreria;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Contabilidad;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negCuentaContable
    {
        public static List<entCuentaContable> ListaFormID()
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaFormID().ToList<entCuentaContable>();
            return ListObj;
        }

        public static entCuentaContable GetFormID(String Cuenta)
        {
            entCuentaContable EObj = new entCuentaContable();
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.GetFormID(Cuenta).ToList<entCuentaContable>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaContable> ListaCombo(String Estado, String[] Def = null)
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaCombo(Estado).ToList<entCuentaContable>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaContable() { Cuenta = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaContable> ListaSearch(String Cuenta, String Nombre, String Estado)
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaSearch(Cuenta, Nombre, Estado).ToList<entCuentaContable>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaContable Data)
        {
            return datCuentaContable.MantFormID(Data);
        }

        public static entErrores GetValidaEstructuraCuenta(String Compania, List<entVoucherDet> ELst)
        {
            entErrores oErr = new entErrores();
            foreach (entVoucherDet oVC in ELst)
            {
                String sCuenta = (oVC.Cuenta != null) ? oVC.Cuenta : "";
                entCuentaContable oCta = negCuentaContable.GetFormID(sCuenta);

                //Obteniendo información detallada de cuenta contable
                if (oCta.ResultadoBusqueda){
                    if (oCta.Estado.Equals("A")){
                        //Revisar requerimiento de persona
                        if (oCta.ReqPersona.Equals("R") || oCta.ReqPersona.Equals("O")){
                            if (oVC.Persona == 0 || oVC.Persona == Int32.MinValue){
                                if (oCta.ReqPersona.Equals("R")){
                                    oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido un número de persona." });
                                }
                            }else{
                                if (oCta.TipoPersonaGen != null && !oCta.TipoPersonaGen.Trim().Equals("")){
                                    switch (oCta.TipoPersonaGen){
                                        case "A": //Empleado o Proveedor
                                            if (!(negEmpleado.GetExisteEmpleado(Compania, oVC.Persona) || negProveedor.GetExisteProveedor(Compania, oVC.Persona))){
                                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Persona debe ser un Empleado o Proveedor." });
                                            }
                                            break;
                                        case "C": //Cliente
                                            if (!negCliente.GetExisteCliente(Compania, oVC.Persona)){
                                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Persona debe ser un cliente registrado." });
                                            }
                                            break;
                                        case "P": //Proveedor
                                            if (!negProveedor.GetExisteProveedor(Compania, oVC.Persona)){
                                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Persona debe ser un proveedor registrado." });
                                            }
                                            break;
                                        case "E": //Empleado
                                            if (!negEmpleado.GetExisteEmpleado(Compania, oVC.Persona)){
                                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Persona debe ser un empleado registrado." });
                                            }
                                            break;
                                    }
                                }

                                if (oCta.TipoPersonaEsp != null && !oCta.TipoPersonaEsp.Trim().Equals("")){
                                    entPersona oPers = negPersona.GetPersonaFormID(Compania, oVC.Persona);
                                    if (!oPers.TipoPersonaUsuario.Equals(oCta.TipoPersonaEsp)){
                                        entTipoPersonaUsuario oTPers = negTipoPersonaUsuario.GetFormID(oCta.TipoPersonaEsp);
                                        oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Persona debe ser del tipo : " + oTPers.Descripcion.Trim() });
                                        oTPers = null;
                                    }
                                    oPers = null;
                                }
                            }
                        }else{
                            if (oVC.Persona != 0 && oVC.Persona != Int32.MinValue){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido un número de persona." });
                            }
                        }

                        //Revisando requerimiento de proyecto
                        if (oCta.ReqProyecto.Equals("R")){
                            if (oVC.Proyecto == null || oVC.Proyecto.Trim().Equals("")){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido código de proyecto." });
                            }
                        }

                        if (oCta.ReqProyecto.Equals("N")){
                            if (!(oVC.Proyecto == null || oVC.Proyecto.Trim().Equals(""))){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido código de proyecto." });
                            }
                        }

                        //Revisando requerimiento de Orden Compra
                        if (oCta.ReqOrdenCompra.Equals("R")){
                            if (oVC.OrdenCompra == null || oVC.OrdenCompra.Trim().Equals("")){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido número de Orden de Compra." });
                            }
                        }

                        if (oCta.ReqOrdenCompra.Equals("N")){
                            if (!(oVC.OrdenCompra == null || oVC.OrdenCompra.Trim().Equals(""))){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido número de Orden de Compra." });
                            }
                        }

                        //Revisando requerimiento de Documento
                        if (oCta.ReqDocumento.Equals("R") || oCta.ReqDocumento.Equals("O")){
                            if (oVC.Documento == null || oVC.Documento.Trim().Equals("")){
                                if (oCta.ReqDocumento.Equals("R")){
                                    oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido registrar un documento." });
                                }
                            }else{
                                if (oVC.OrigenDoc.Equals("TR")){
                                    entObligacion oOB = new entObligacion();
                                    oOB.Compania = Compania;
                                    oOB.CodProveedor = oVC.Persona;
                                    oOB.TipoDocumento = oVC.Documento.Substring(0, 2);
                                    oOB.NumeroDocumento = oVC.Documento.Substring(2, oVC.Documento.Length - 2);
                                    Decimal nOb = negObligacion.GetCodigoObligacion(oOB);
                                    if (nOb == 0){
                                        oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Documento de Tesorería es inválido." });
                                    }
                                    oOB = null;
                                }
                            }
                        }else{
                            if (oCta.ReqDocumento.Equals("N")){
                                if (oVC.Documento != null && !oVC.Documento.Trim().Equals("")){
                                    oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido número de documento." });
                                }
                            }
                        }

                        //Revisando requerimiento de fecha
                        if (oCta.ReqFecha.Equals("R")){
                            if (oVC.Fecha == null || oVC.Fecha == DateTime.MinValue){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido el registro de la fecha." });
                            }
                        }

                        if (oCta.ReqFecha.Equals("N")){
                            if (!(oVC.Fecha == null || oVC.Fecha == DateTime.MinValue)){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido el ingreso de la fecha." });
                            }
                        }

                        //Revisando requerimiento de Centro de Costo
                        if (oCta.ReqCCosto.Equals("R")){
                            if (oVC.CentroCosto == null || oVC.CentroCosto.Trim().Equals("")){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido el centro de costo." });
                            }
                        }

                        if (oCta.ReqCCosto.Equals("N")){
                            if (!(oVC.CentroCosto == null || oVC.CentroCosto.Trim().Equals(""))){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido el centro de costo." });
                            }
                        }

                        //Revisando requerimiento de Descripción del detalle
                        if (oCta.ReqDescripcion.Equals("R")){
                            if (oVC.Descripcion == null || oVC.Descripcion.Trim().Equals("")){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerida una descripción." });
                            }
                        }

                        if (oCta.ReqDescripcion.Equals("N")){
                            if (!(oVC.Descripcion == null || oVC.Descripcion.Trim().Equals(""))){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerida una descripción." });
                            }
                        }

                        //Revisando requerimiento de flujo de caja
                        if (oCta.ReqFlujoCaja.Equals("R")){
                            if (oVC.FlujoCaja == null || oVC.FlujoCaja.Trim().Equals("")){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Es requerido el flujo de caja." });
                            }
                        }

                        if (oCta.ReqFlujoCaja.Equals("N")){
                            if (!(oVC.FlujoCaja == null || oVC.FlujoCaja.Trim().Equals(""))){
                                oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "No es requerido el flujo de caja." });
                            }
                        }
                    }else{
                        oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Cuenta Contable es inválida." });
                    }
                }else{
                    oErr.Errores.Add(new entFail() { IdReg = oVC.Linea, Descripcion = "Cuenta Contable es inválida." });
                }

                oCta = null;
            }
            return oErr;
        }

    }
}
