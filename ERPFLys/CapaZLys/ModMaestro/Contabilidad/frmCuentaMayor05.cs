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

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmCuentaMayor05 : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entCuentaMayor05 entMain = new entCuentaMayor05();
        private String xOperacion = "";
        private String xCuentaMayor05 = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmCuentaMayor05()
        {
            InitializeComponent();
        }

        private void frmCuentaMayor05_Load(object sender, EventArgs e)
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

        private void frmCuentaMayor05_Shown(object sender, EventArgs e)
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
            List<entCuentaMayor05> Lst = negCuentaMayor05.ListaFormID();
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
            //Cuenta Mayor
            List<entCuentaMayor04> LstA = negCuentaMayor04.ListaCombo(fnConst.StringPorc,fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCuentaMayor04.Properties.DataSource = LstA;
            cmbCuentaMayor04.Properties.DisplayMember = "Descripcion";
            cmbCuentaMayor04.Properties.ValueMember = "CuentaMayor04";
            LstA = null;

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
                xCuentaMayor05 = this.EstructuraForm.StrX[0];
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
            this.lblTitulo.Text = "CUENTA MAYOR 05";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCuentaMayor04.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbCuentaMayor04.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCuentaMayor05.GetFormID(xCuentaMayor05);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCuentaMayor05.Text = entMain.CuentaMayor05.Trim();
                cmbCuentaMayor04.EditValue = entMain.CuentaMayor04.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                cmbCuentaMayor04.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCuentaMayor05.ReadOnly = !sHabilitado;
            cmbCuentaMayor04.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;
            
            if (xOperacion.Equals("M")){
                txtCuentaMayor05.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCuentaMayor05.Focus(); }
            if (xOperacion.Equals("M")) { cmbCuentaMayor04.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCtaMay05 = txtCuentaMayor05.Text.ToString().Trim();
            String sCtaMay04 = cmbCuentaMayor04.EditValue.ToString().Trim();
            String sDescripcion = txtDescripcion.Text.ToString().Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            String sMay4 = (sCtaMay05.Length == 5) ? sCtaMay05.Substring(0,4) : String.Empty;

            if (String.IsNullOrEmpty(sCtaMay05)){
                fnMensaje.MensajeInfo("Ingresar la Cuenta Mayor de 5 Digitos. Revisar por favor.");
                txtCuentaMayor05.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sCtaMay04) || sCtaMay04.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Seleccione la Cuenta Mayor de 4 Digitos. Revisar por favor.");
                cmbCuentaMayor04.Focus();
                return bOk;
            }

            if (!sMay4.Equals(sCtaMay04)){
                fnMensaje.MensajeInfo("Cta Mayor de 5 digitos Ingresado no corresponde a Jerarquia de 4 Digitos. Revisar por favor.");
                cmbCuentaMayor04.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Ingrese la descripción. Revisar por favor.");
                txtDescripcion.Focus();
                return bOk;
            }
            
            //Actualizando Datos Entidad
            entMain.CuentaMayor05 = sCtaMay05;
            entMain.CuentaMayor04 = sCtaMay04;
            entMain.Descripcion = sDescripcion;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCuentaMayor05 = sCtaMay04;

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

            oErr = negCuentaMayor05.MantFormID(entMain);
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
            Contabilidad.frmCuentaMayor05 frm = new Contabilidad.frmCuentaMayor05();
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
            entCuentaMayor05 oEnt = (entCuentaMayor05)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmCuentaMayor05 frm = new Contabilidad.frmCuentaMayor05();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaMayor05);
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
            entCuentaMayor05 oEnt = (entCuentaMayor05)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCuentaMayor05.MantFormID(oEnt);
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
            entCuentaMayor05 oEnt = (entCuentaMayor05)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmCuentaMayor05 frm = new Contabilidad.frmCuentaMayor05();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaMayor05);
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
