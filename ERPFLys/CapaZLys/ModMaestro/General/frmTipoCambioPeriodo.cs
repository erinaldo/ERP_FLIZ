using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.General
{
    public partial class frmTipoCambioPeriodo : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entTipoCambioPeriodo entMain = new entTipoCambioPeriodo();
        private String xOperacion = "";
        private String xSistema = "", xPeriodo = "";
        private entEstructForm xestruct = new entEstructForm();

        public String SistemaPK
        {
            get { return xSistema; }
            set { xSistema = value; }
        }

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmTipoCambioPeriodo()
        {
            InitializeComponent();
        }

        private void frmTipoCambioPeriodo_Load(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelList){
                fxCargarComboListaDet();
                fxCargarLista();
            }

            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxSetearIni();
                fxQuitEvent();
                fxCargarCombos();
                fxCargarCombosDetalle();
                fxCargarCombosXCia();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmTipoCambioPeriodo_Shown(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxFocusInicial();
            }
        }

        #endregion

        #region "==FuncionesList=="

        private void fxCargarLista()
        {
            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)) { return; }
            List<entTipoCambioPeriodo> Lst = negTipoCambioPeriodo.ListaFormID(xSistema);
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF1();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            
        }

        private void fxAddEvent() {
            
        }

        private void fxCargarCombos()
        {
            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xSistema = this.EstructuraForm.StrX[0];
                xPeriodo = this.EstructuraForm.StrX[1];
            }
        }

        private void fxPreOpen()
        {
            String sTitle = "Actualizar";
            switch (xOperacion){
                case "A":
                    sTitle = " - Nuevo";
                    fxNuevoReg();
                    fxHabilitarOCX();
                    break;
                case "M":
                    sTitle = " - Modificar";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "V":
                    sTitle = " - Ver";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
            }
            this.Text = this.Text + sTitle;
            this.lblTitulo.Text = "TIPO CAMBIO PERIODO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            txtValorCierre.Text = "0";
            txtValorCompra.Text = "0";
            txtValorVenta.Text = "0";
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtPeriodo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negTipoCambioPeriodo.GetFormID(xSistema,xPeriodo);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtPeriodo.Text = entMain.Periodo.ToString();
                txtValorCierre.Text = entMain.ValorCierre.ToString();
                txtValorCompra.Text = entMain.ValorCompra.ToString();
                txtValorVenta.Text = entMain.ValorVenta.ToString();
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtValorCompra.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtPeriodo.ReadOnly = !sHabilitado;
            txtValorCierre.ReadOnly = !sHabilitado;
            txtValorCompra.ReadOnly = !sHabilitado;
            txtValorVenta.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtPeriodo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtPeriodo.Focus(); }
            if (xOperacion.Equals("M")) { txtValorCierre.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sPer = txtPeriodo.Text.Trim().Replace("-","");
            String sValCier = txtValorCierre.Text;
            String sValComp = txtValorCompra.Text;
            String sValVent = txtValorVenta.Text;
            String sEst = cmbEstado.EditValue.ToString();
            Decimal nValCier = 0; Decimal.TryParse(sValCier, out nValCier);
            Decimal nValComp = 0; Decimal.TryParse(sValComp, out nValComp);
            Decimal nValVent = 0; Decimal.TryParse(sValVent, out nValVent);

            if (String.IsNullOrEmpty(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar Periodo por favor.");
                txtPeriodo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sValCier) || nValCier < 0){
                fnMensaje.MensajeInfo("Debe ingresar Valor Cierre correctamente por favor.");
                txtValorCierre.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sValComp) || nValComp < 0){
                fnMensaje.MensajeInfo("Debe ingresar Valor Compra correctamente por favor.");
                txtValorCompra.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sValVent) || nValVent < 0){
                fnMensaje.MensajeInfo("Debe ingresar Valor Venta correctamente por favor.");
                txtValorVenta.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Sistema = xSistema;
            entMain.Periodo = sPer;
            entMain.ValorCierre = nValCier;
            entMain.ValorCompra = nValComp;
            entMain.ValorVenta = nValVent;
            entMain.Estado = sEst;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xPeriodo = sPer;

            bOk = true;
            return bOk;
        }

        private Boolean fxPreUpdate()
        {
            entErrores oErr = new entErrores();
            Boolean bOK = true;

            switch (xOperacion){
                case "A":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
                    break;
                case "M":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                    break;
            }

            oErr = negTipoCambioPeriodo.MantFormID(entMain);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
                bOK = false;
            }
            oErr = null;
            return bOK;
        }

        private void fxPostUpdate()
        {
            fxCargarLista();
        }

        #endregion

        #region "==EventInherit=="

        public override void ue_nuevo()
        {
            General.frmTipoCambioPeriodo frm = new General.frmTipoCambioPeriodo();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "A";
            frm.SistemaPK = xSistema;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            frm = null;
        }

        public override void ue_modificar()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoCambioPeriodo oEnt = (entTipoCambioPeriodo)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            General.frmTipoCambioPeriodo frm = new General.frmTipoCambioPeriodo();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Sistema);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Periodo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            oEnt = null;
            frm = null;
        }

        public override void ue_eliminar()
        {
            if (MessageBox.Show(fnConst.MensajeDeleteMaestro, fnConst.MessageTitleAviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoCambioPeriodo oEnt = (entTipoCambioPeriodo)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negTipoCambioPeriodo.MantFormID(oEnt);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
            }
            else { fxCargarLista(); }
            oErr = null;
            oEnt = null;
        }

        public override void ue_ver()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoCambioPeriodo oEnt = (entTipoCambioPeriodo)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            General.frmTipoCambioPeriodo frm = new General.frmTipoCambioPeriodo();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Sistema);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Periodo);
            frm.ShowDialog();
            oEnt = null;
            frm = null;
        }

        public override void ue_guardar()
        {
            if (!fxValidar()) { return; };
            if (!fxPreUpdate()) { return; };
            fxPostUpdate();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public override void ue_cancelar()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion

    }
}
