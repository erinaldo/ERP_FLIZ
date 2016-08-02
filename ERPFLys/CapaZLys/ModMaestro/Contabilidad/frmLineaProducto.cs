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
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Busqueda.General;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmLineaProducto : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entLineaProducto entMain = new entLineaProducto();
        private String xOperacion = "";
        private String xCompania = "", xLineaProducto = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmLineaProducto()
        {
            InitializeComponent();
        }

        private void frmLineaProducto_Load(object sender, EventArgs e)
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

        private void frmLineaProducto_Shown(object sender, EventArgs e)
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
            List<entLineaProducto> Lst = negLineaProducto.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Tipo Bien
            rilueTipoBien.DataSource = fnListasDat.ListTipoBien();
            rilueTipoBien.DisplayMember = "Nombre";
            rilueTipoBien.ValueMember = "Codigo";
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            
        }

        private void fxAddEvent() {
            
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //Tipo Activo
            List<entTipoActivo> LstB = negTipoActivo.ListaCombo(fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbTipoActivo.Properties.DataSource = LstB;
            cmbTipoActivo.Properties.DisplayMember = "Descripcion";
            cmbTipoActivo.Properties.ValueMember = "TipoActivo";
            LstB = null;

            //Tipo Bien
            cmbTipoBien.Properties.DataSource = fnListasDat.ListTipoBien();
            cmbTipoBien.Properties.DisplayMember = "Nombre";
            cmbTipoBien.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xLineaProducto = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "LINEA PRODUCTO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbTipoActivo.EditValue = fnConst.TextNingunoCod;
            cmbTipoBien.EditValue = fnConst.TextNingunoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCodigo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negLineaProducto.GetFormID(xCompania,xLineaProducto);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania.Trim();
                txtCodigo.Text = entMain.TipoActivo.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbTipoActivo.EditValue = entMain.TipoActivo.Trim();
                cmbTipoBien.EditValue = entMain.TipoBien.Trim();
                txtCtaContable.Text = entMain.CuentaContable.Trim();
                txtCtaDepreciacion.Text = entMain.CtaDepreciacion.Trim();
                txtUltimoUsuario.Text = entMain.UltimoUsuario;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaModificacion);
                txtDescripcion.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            cmbCompania.ReadOnly = !sHabilitado;
            txtCodigo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbTipoActivo.ReadOnly = !sHabilitado;
            cmbTipoBien.ReadOnly = !sHabilitado;
            txtCtaContable.ReadOnly = !sHabilitado;
            txtCtaDepreciacion.ReadOnly = !sHabilitado;
            btnCtaContable.Enabled = true;
            btnCtaDepreciacion.Enabled = true;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtCodigo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) {
                btnCtaContable.Enabled = false;
                btnCtaDepreciacion.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbCompania.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString().Trim();
            String sLProd = txtCodigo.Text.ToString().Trim();
            String sDescripcion = txtDescripcion.Text.ToString().Trim();
            String sTipoAct = cmbTipoActivo.EditValue.ToString();
            String sTipoBien = cmbTipoBien.EditValue.ToString();
            String sCtaCont = txtCtaContable.Text.ToString();
            String sCtaDepr = txtCtaDepreciacion.Text.ToString();

            if (String.IsNullOrEmpty(sCia)||sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sLProd)){
                fnMensaje.MensajeInfo("Debe ingresar Código por favor.");
                txtCodigo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTipoAct) || sTipoAct.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Ingresar Tipo de Activo por favor.");
                cmbTipoActivo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTipoBien) || sTipoBien.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Ingresar Tipo de Bien por favor.");
                cmbTipoBien.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.LineaProducto = sLProd;
            entMain.Descripcion = sDescripcion;
            entMain.TipoActivo = sTipoAct;
            entMain.TipoBien = sTipoBien;
            entMain.CuentaContable = sCtaCont;
            entMain.CtaDepreciacion = sCtaDepr;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xLineaProducto = sLProd;

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

            oErr = negLineaProducto.MantFormID(entMain);
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
            Contabilidad.frmLineaProducto frm = new Contabilidad.frmLineaProducto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "A";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            frm = null;
        }

        public override void ue_modificar()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entLineaProducto oEnt = (entLineaProducto)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmLineaProducto frm = new Contabilidad.frmLineaProducto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.LineaProducto);
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
            entLineaProducto oEnt = (entLineaProducto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negLineaProducto.MantFormID(oEnt);
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
            entLineaProducto oEnt = (entLineaProducto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmLineaProducto frm = new Contabilidad.frmLineaProducto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.LineaProducto);
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

        #region "==EventObjectMant"

        private void txtCtaContable_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCtaContable.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtCtaContable.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtCtaContable.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
            }
        }

        private void txtCtaDepreciacion_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCtaDepreciacion.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtCtaDepreciacion.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtCtaDepreciacion.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
            }
        }

        private void btnCtaContable_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtCtaContable.Text = oEnt.Cuenta.Trim();
                oEnt = null;
            }
            frm = null;
        }

        private void btnCtaDepreciacion_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtCtaDepreciacion.Text = oEnt.Cuenta.Trim();                
                oEnt = null;
            }
            frm = null;
        }

        #endregion

    }
}
