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
    public partial class frmProvincia : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entProvincia entMain = new entProvincia();
        private String xOperacion = "";
        private String xPais = "", xDepartamento = "", xProvincia = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmProvincia()
        {
            InitializeComponent();
        }

        private void frmProvincia_Load(object sender, EventArgs e)
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
                fxCargarComboDepartamento();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmProvincia_Shown(object sender, EventArgs e)
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
            List<entProvincia> Lst = negProvincia.ListaFormID();
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
            this.cmbPais.EditValueChanged -= new EventHandler(cmbPais_EditValueChanged);
        }

        private void fxAddEvent() {
            this.cmbPais.EditValueChanged += new EventHandler(cmbPais_EditValueChanged);
        }

        private void fxCargarCombos()
        {
            //Pais
            List<entPaises> LstA = negPaises.ListaCombo(fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbPais.Properties.DataSource = LstA;
            cmbPais.Properties.DisplayMember = "Descripcion";
            cmbPais.Properties.ValueMember = "Pais";
            LstA = null;

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarComboDepartamento(){
            String sPais = fnConst.TextNingunoCod;
            if (cmbPais.EditValue != null){
                sPais = cmbPais.EditValue.ToString();
            }
            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                sPais = xPais;
            }

            //Departamento
            List<entDepartamento> LstA = negDepartamento.ListaCombo(sPais, fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbDepartamento.Properties.DataSource = LstA;
            cmbDepartamento.Properties.DisplayMember = "Descripcion";
            cmbDepartamento.Properties.ValueMember = "DepartamentoCodigo";
            cmbDepartamento.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xPais = this.EstructuraForm.StrX[0];
                xDepartamento = this.EstructuraForm.StrX[1];
                xProvincia = this.EstructuraForm.StrX[2];
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
            this.lblTitulo.Text = "PROVINCIA";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbPais.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtProvincia.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negProvincia.GetFormID(xPais,xDepartamento,xProvincia);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbPais.EditValue = entMain.Pais.Trim();
                cmbDepartamento.EditValue = entMain.DepartamentoCodigo.Trim();
                txtProvincia.Text = entMain.ProvinciaCodigo.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbEstado.EditValue = entMain.Estado;
                txtCodigoProvf.Text = (!String.IsNullOrEmpty(entMain.CodigoProvFedd)) ? entMain.CodigoProvFedd.Trim() : String.Empty;
                txtUbigeo.Text = (!String.IsNullOrEmpty(entMain.Ubigeo)) ? entMain.Ubigeo.Trim() : String.Empty;
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

            cmbPais.ReadOnly = !sHabilitado;
            cmbDepartamento.ReadOnly = !sHabilitado;
            txtProvincia.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            txtCodigoProvf.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            txtUbigeo.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbPais.ReadOnly = true;
                cmbDepartamento.ReadOnly = true;
                txtProvincia.ReadOnly = true;                
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbPais.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sPais = cmbPais.EditValue.ToString();
            String sDep = cmbDepartamento.EditValue.ToString();
            String sProv = txtProvincia.Text.ToString().Trim();
            String sDescripcion = txtDescripcion.Text.ToString().Trim();
            String sCodProvf = txtCodigoProvf.Text.ToString().Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            String sUbig = txtUbigeo.Text.ToString().Trim();
            
            if (String.IsNullOrEmpty(sPais)){
                fnMensaje.MensajeInfo("Debe Seleccionar País por favor.");
                cmbPais.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDep)){
                fnMensaje.MensajeInfo("Debe Seleccionar Departamento por favor.");
                cmbDepartamento.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sProv)){
                fnMensaje.MensajeInfo("Debe ingresar Código de Provincia por favor.");
                txtProvincia.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Pais = sPais;
            entMain.DepartamentoCodigo = sDep;
            entMain.ProvinciaCodigo = sProv;
            entMain.Descripcion = sDescripcion;
            entMain.Estado = sEstado;
            entMain.CodigoProvFedd = sCodProvf;
            entMain.Ubigeo = sUbig;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xPais = sPais;
            xDepartamento = sDep;
            xProvincia = sProv;

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

            oErr = negProvincia.MantFormID(entMain);
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
            General.frmProvincia frm = new General.frmProvincia();
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
            entProvincia oEnt = (entProvincia)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            General.frmProvincia frm = new General.frmProvincia();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Pais);
            frm.EstructuraForm.StrX.Insert(1, oEnt.DepartamentoCodigo);
            frm.EstructuraForm.StrX.Insert(2, oEnt.ProvinciaCodigo);
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
            entProvincia oEnt = (entProvincia)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negProvincia.MantFormID(oEnt);
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
            entProvincia oEnt = (entProvincia)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            General.frmProvincia frm = new General.frmProvincia();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Pais);
            frm.EstructuraForm.StrX.Insert(1, oEnt.DepartamentoCodigo);
            frm.EstructuraForm.StrX.Insert(2, oEnt.ProvinciaCodigo);
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

        #region "==EventObjectMant=="

        private void cmbPais_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarComboDepartamento();
        }

        #endregion

    }
}
