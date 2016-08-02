using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.Errores;
using System.Linq;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmCierreMensual : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {
        #region "==Propiedades=="

        entErrores OErrores = new entErrores();

        #endregion

        #region "==EventForm=="

        public frmCierreMensual()
        {
            InitializeComponent();
        }

        private void frmCierreMensual_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
        }

        private void frmCierreMensual_Shown(object sender, EventArgs e)
        {
            fxSetearDatos();
        }

        #endregion

        #region "==EventObject=="

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Replace("-", "");
            Int32 nResult = 0; String sResult = "";
            StringBuilder sProceso = new StringBuilder();
            OErrores = new entErrores();

            txtProceso.Text = String.Empty;
            btnDetalle.Enabled = false;

            //Validación Basica
            if (String.IsNullOrEmpty(sCia)){
                fnMensaje.MensajeInfo("Debe seleccionar una compañía.");
                return;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return;
            }

            nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, sCia, sPer);
            if (nResult <= 0){
                fnMensaje.MensajeInfo("Periodo no existe o se encuentra cerrado. No se puede realizar el cierre mensual.");
                return;
            }

            /************************/
            /* Ejecutando el cierre */
            /************************/
            sProceso.Append("Iniciando proceso de cierre ...\n");
            sProceso.Append("Revisando información\n");

            //Revisando Cierre
            List<entFail> oFail = negCierreMesCuenta.GetCierreMensualRev(sCia, sPer, "C");
            OErrores.Errores = oFail;
            if (oFail.Count > 0)
            {
                sProceso.Append("   Se han encontrado problemas.\n");
                sProceso.Append("Fin de proceso con errores, revisar detalle.\n");
                btnDetalle.Enabled = true;
                return;
            }

            //Generando saldo de cuentas contables
            sProceso.Append("Generando saldo de cuentas ...\n");
            sResult = negCierreMesCuenta.SetCierreMensualGen(sCia, sPer, GlobalVar.UsuarioLogeo);
            if (!sResult.Equals("OK")){
                OErrores.Errores.Add(new entFail() { Linea = 1, Mensaje = sResult });
                sProceso.Append("Ocurrio un error generando saldo de cuentas ...\n");
                sProceso.Append("Fin de proceso con errores, revisar detalle.\n");
                btnDetalle.Enabled = true;
                return;
            }

            //Cerrando Periodo//            
            sResult = negCierreMesCuenta.SetModificaPeriodo(sCia, sPer, GlobalVar.UsuarioLogeo, "C");
            if (!sResult.Equals("OK")){
                OErrores.Errores.Add(new entFail() { Linea = 1, Mensaje = sResult });
                sProceso.Append("Ocurrio un error cerrando periodo ...\n");
                sProceso.Append("Fin de proceso con errores, revisar detalle.\n");
                btnDetalle.Enabled = true;
                return;
            }

            sProceso.Append("Proceso finalizado.\n");
            txtProceso.Text = sProceso.ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Replace("-", ""), sPerSig = "";
            Int32 nResult = 0; String sResult = "";
            StringBuilder sProceso = new StringBuilder();
            OErrores = new entErrores();

            txtProceso.Text = String.Empty;
            btnDetalle.Enabled = false;

            //Validación Basica
            if (String.IsNullOrEmpty(sCia)){
                fnMensaje.MensajeInfo("Debe seleccionar una compañía.");
                return;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return;
            }

            nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, sCia, sPer);
            if (nResult == 1 || nResult < 0){
                fnMensaje.MensajeInfo("Periodo no existe o ya se encuentra abierto. No se puede realizar la apertura del periodo.");
                return;
            }

            sPerSig = negCierreMesCuenta.GetPeriodoSig(sPer);
            if (String.IsNullOrEmpty(sPerSig)){
                fnMensaje.MensajeInfo("Error obteniendo periodo siguiente.");
                return;
            }

            nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, sCia, sPerSig);
            if (nResult == 0){
                fnMensaje.MensajeInfo("Periodo siguiente esta cerrado. No se puede realizar la apertura del periodo.");
                return;
            }

            /************************/
            /* Ejecutando el cierre */
            /************************/


            sProceso.Append("Iniciando proceso de apertura ...\n");
            sProceso.Append("Revisando información\n");

            //Revisando Cierre
            List<entFail> oFail = negCierreMesCuenta.GetCierreMensualRev(sCia, sPer, "A");
            OErrores.Errores = oFail;
            if (oFail.Count > 0){
                sProceso.Append("   Se han encontrado problemas.\n");
                sProceso.Append("Fin de proceso con errores, revisar detalle.\n");
                btnDetalle.Enabled = true;
                return;
            }

            //Cerrando Periodo//            
            sResult = negCierreMesCuenta.SetModificaPeriodo(sCia, sPer, GlobalVar.UsuarioLogeo, "A");
            if (!sResult.Equals("OK")){
                OErrores.Errores.Add(new entFail() { Linea = 1, Mensaje = sResult });
                sProceso.Append("Ocurrio un error cerrando periodo ...\n");
                sProceso.Append("Fin de proceso con errores, revisar detalle.\n");
                btnDetalle.Enabled = true;
                return;
            }
            sProceso.Append("Proceso finalizado.\n");
            txtProceso.Text = sProceso.ToString();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            foreach (entFail oEnt in OErrores.Errores){
                oEnt.IdReg = oEnt.Linea;
                oEnt.Descripcion = oEnt.Mensaje;
            }

            frmErrMain oFrm = new frmErrMain();
            oFrm.ListErrores = OErrores;
            oFrm.ShowDialog();
            oFrm = null;
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXAppXUsu(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringN, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxSetearDatos()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : "";
            txtPeriodo.Text = negPeriodoCia.GetPerTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
        }

        #endregion
    }
}
