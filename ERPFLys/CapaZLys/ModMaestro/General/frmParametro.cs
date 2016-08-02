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

namespace FiltroLys.ZLys.ModMaestro.General
{
    public partial class frmParametro : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entParametro entMain = new entParametro();
        private String xOperacion = "";
        private String xCompania = "", xAplicacion = "", xParametro = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmParametro()
        {
            InitializeComponent();
        }

        private void frmParametro_Load(object sender, EventArgs e)
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

        private void frmParametro_Shown(object sender, EventArgs e)
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
            List<entParametro> Lst = negParametro.ListaFormID(fnConst.ModContabilidadCod);
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF1();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";

            //Tipo
            rilueTipo.DataSource = fnListasDat.ListParametroTipo();
            rilueTipo.DisplayMember = "Nombre";
            rilueTipo.ValueMember = "Codigo";
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

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";

            //Tipo Bien
            cmbTipo.Properties.DataSource = fnListasDat.ListParametroTipo();
            cmbTipo.Properties.DisplayMember = "Nombre";
            cmbTipo.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xAplicacion = this.EstructuraForm.StrX[1];
                xParametro = this.EstructuraForm.StrX[2];
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
            this.lblTitulo.Text = "PARAMETRO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbTipo.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCodigo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negParametro.GetFormID(xCompania,xAplicacion,xParametro);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania.Trim();
                txtAplicacion.Text = entMain.Aplicacion.Trim();
                txtCodigo.Text = entMain.ParametroCodigo.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                txtExplicacion.Text = (!String.IsNullOrEmpty(entMain.Explicacion))? entMain.Explicacion.Trim():String.Empty;
                cmbTipo.EditValue = entMain.Tipo.Trim();
                txtTexto.Text = (!String.IsNullOrEmpty(entMain.Texto)) ? entMain.Texto.Trim() : String.Empty;
                txtNumero.Text = entMain.Numero.ToString();
                txtFecha.Text = (!(entMain.Fecha == null || entMain.Fecha == DateTime.MinValue)) ? entMain.Fecha.ToString() : String.Empty;
                cmbEstado.EditValue = entMain.Estado.Trim();
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
            txtAplicacion.ReadOnly = !sHabilitado;
            txtCodigo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            txtExplicacion.ReadOnly = !sHabilitado;
            cmbTipo.ReadOnly = !sHabilitado;
            txtTexto.ReadOnly = !sHabilitado;
            txtNumero.ReadOnly = !sHabilitado;
            txtFecha.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtAplicacion.ReadOnly = true;
                txtCodigo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) {
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
            String sApli = txtAplicacion.Text.Trim();
            String sPrmCod = txtCodigo.Text.Trim();
            String sDescripcion = txtDescripcion.Text.Trim();
            String sExplic = txtExplicacion.Text.Trim();
            String sTipo = cmbTipo.EditValue.ToString();
            String sTexto = txtTexto.Text.Trim();
            String sNumero = txtNumero.Text.Trim();
            String sFecha = txtFecha.Text.Trim();
            Decimal nNumero = 0;
            DateTime dFecha = DateTime.MinValue;

            Decimal.TryParse(sNumero, out nNumero);
            DateTime.TryParse(sFecha, out dFecha);

            if (String.IsNullOrEmpty(sCia)||sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sApli)){
                fnMensaje.MensajeInfo("Debe ingresar Aplicación por favor.");
                txtAplicacion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sPrmCod)){
                fnMensaje.MensajeInfo("Debe ingresar Parametro Código por favor.");
                txtCodigo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTipo)||sTipo.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Debe ingresar Tipo por favor.");
                cmbTipo.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.Aplicacion = sApli;
            entMain.ParametroCodigo = sPrmCod;
            entMain.Descripcion = sDescripcion;
            entMain.Explicacion = sExplic;
            entMain.Tipo = sTipo;
            entMain.Texto = sTexto;
            entMain.Numero = nNumero;
            entMain.Fecha = dFecha;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xAplicacion = sApli;
            xParametro = sPrmCod;

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

            oErr = negParametro.MantFormID(entMain);
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
            General.frmParametro frm = new General.frmParametro();
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
            entParametro oEnt = (entParametro)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            General.frmParametro frm = new General.frmParametro();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Aplicacion);
            frm.EstructuraForm.StrX.Insert(2, oEnt.ParametroCodigo);
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
            entParametro oEnt = (entParametro)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negParametro.MantFormID(oEnt);
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
            entParametro oEnt = (entParametro)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            General.frmParametro frm = new General.frmParametro();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Aplicacion);
            frm.EstructuraForm.StrX.Insert(2, oEnt.ParametroCodigo);
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

        private void btnBorrarFecha_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
        }

        #endregion
    }
}
