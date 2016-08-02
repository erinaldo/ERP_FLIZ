using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.Tesoreria;
using FiltroLys.Domain.Maestro.Tesoreria;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.Tesoreria
{
    public partial class frmTipoServicio : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entTipoServicio entMain = new entTipoServicio();
        private String xOperacion = "";
        private String xTipoServicio = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmTipoServicio()
        {
            InitializeComponent();
        }

        private void frmTipoServicio_Load(object sender, EventArgs e)
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

        private void frmTipoServicio_Shown(object sender, EventArgs e)
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
            List<entTipoServicio> Lst = negTipoServicio.ListaFormID();
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
            //Sucursal
            List<entRegimenFiscal> LstA = negRegimenFiscal.ListaCombo(fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbRegFiscal.Properties.DataSource = LstA;
            cmbRegFiscal.Properties.DisplayMember = "Descripcion";
            cmbRegFiscal.Properties.ValueMember = "RegFiscal";            
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
                xTipoServicio = this.EstructuraForm.StrX[0];
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
            this.lblTitulo.Text = "TIPO SERVICIO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbRegFiscal.EditValue = fnConst.TextNingunoCod;
            chkFlagNoDomiciliado.Checked = false;
            chkFlag4ta.Checked = false;
            chkFlag4taPension.Checked = false;
            chkFlag4taPensionAFE.Checked = false;
            chkFlagValida4ta.Checked = false;
            chkFlag2daCategoria.Checked = false;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCodigo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negTipoServicio.GetFormID(xTipoServicio);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCodigo.Text = entMain.TipoServicio.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbRegFiscal.EditValue = entMain.RegFiscal.Trim();
                chkFlagNoDomiciliado.Checked = (entMain.FlagNoDomic.Equals("S")) ? true : false;
                chkFlag4ta.Checked = (entMain.Flag4ta.Equals("S")) ? true : false;
                chkFlag4taPension.Checked = (entMain.Flag4taPension.Equals("S")) ? true : false;
                chkFlag4taPensionAFE.Checked = (entMain.Flag4taPensionAFE.Equals("S")) ? true : false;
                chkFlagValida4ta.Checked = (entMain.FlagValida4ta.Equals("S")) ? true : false;
                chkFlag2daCategoria.Checked = (entMain.Flag2daCategoria.Equals("S")) ? true : false;
                cmbEstado.EditValue = entMain.Estado.Trim();
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtDescripcion.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCodigo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbRegFiscal.ReadOnly = !sHabilitado;
            chkFlagNoDomiciliado.ReadOnly = !sHabilitado;
            chkFlag4ta.ReadOnly = !sHabilitado;
            chkFlag4taPension.ReadOnly = !sHabilitado;
            chkFlag4taPensionAFE.ReadOnly = !sHabilitado;
            chkFlagValida4ta.ReadOnly = !sHabilitado;
            chkFlag2daCategoria.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtCodigo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCodigo.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sTServ = txtCodigo.Text.Trim();
            String sDescripcion = txtDescripcion.Text.Trim();
            String sRegFisc = cmbRegFiscal.EditValue.ToString();
            String sFlagNoDomic = (chkFlagNoDomiciliado.Checked == true) ? "S" : "N";
            String sFlag4ta = (chkFlag4ta.Checked == true) ? "S" : "N";
            String sFlag4taPens = (chkFlag4taPension.Checked == true) ? "S" : "N";
            String sFlag4taPensAFE = (chkFlag4taPensionAFE.Checked == true) ? "S" : "N";
            String sFlagvalida4ta = (chkFlagValida4ta.Checked == true) ? "S" : "N";
            String sFlag2da = (chkFlag2daCategoria.Checked == true) ? "S" : "N";
            String sEst = cmbEstado.EditValue.ToString();

            if (String.IsNullOrEmpty(sTServ)){
                fnMensaje.MensajeInfo("Debe ingresar Código por favor.");
                txtCodigo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sRegFisc)){
                fnMensaje.MensajeInfo("Debe ingresar Tipo Reg. Fiscal por favor.");
                cmbRegFiscal.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.TipoServicio = sTServ;
            entMain.Descripcion = sDescripcion;
            entMain.RegFiscal = sRegFisc;
            entMain.FlagNoDomic = sFlagNoDomic;
            entMain.Flag4ta = sFlag4ta;
            entMain.Flag4taPension = sFlag4taPens;
            entMain.Flag4taPensionAFE = sFlag4taPensAFE;
            entMain.FlagValida4ta = sFlagvalida4ta;
            entMain.Flag2daCategoria = sFlag2da;
            entMain.Estado = sEst;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xTipoServicio = sTServ;
            
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

            oErr = negTipoServicio.MantFormID(entMain);
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
            Tesoreria.frmTipoServicio frm = new Tesoreria.frmTipoServicio();
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
            entTipoServicio oEnt = (entTipoServicio)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Tesoreria.frmTipoServicio frm = new Tesoreria.frmTipoServicio();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoServicio);
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
            entTipoServicio oEnt = (entTipoServicio)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negTipoServicio.MantFormID(oEnt);
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
            entTipoServicio oEnt = (entTipoServicio)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Tesoreria.frmTipoServicio frm = new Tesoreria.frmTipoServicio();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoServicio);
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
