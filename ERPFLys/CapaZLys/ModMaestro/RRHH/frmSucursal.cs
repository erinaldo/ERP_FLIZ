using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.RRHH
{
    public partial class frmSucursal : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entSucursal entMain = new entSucursal();
        private String xOperacion = "";
        private String xCompania = "", xSucursal = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmSucursal()
        {
            InitializeComponent();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelList){
                fxCargarComboListaDet();
                fxCargarLista();
            }

            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxSetearIni();
                fxQuitEvent();
                fxPreCargar();
                fxCargarCombos();
                fxCargarCombosDetalle();
                fxCargarComboDepartamento();
                fxCargarComboProvincia();
                fxCargarComboDistrito();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmSucursal_Shown(object sender, EventArgs e)
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
            List<entSucursal> Lst = negSucursal.ListaFormID();
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
            this.cmbDepartamento.EditValueChanged -= new EventHandler(cmbDepartamento_EditValueChanged);
            this.cmbProvincia.EditValueChanged -= new EventHandler(cmbProvincia_EditValueChanged);
        }

        private void fxAddEvent() {
            this.cmbPais.EditValueChanged += new EventHandler(cmbPais_EditValueChanged);
            this.cmbDepartamento.EditValueChanged += new EventHandler(cmbDepartamento_EditValueChanged);
            this.cmbProvincia.EditValueChanged += new EventHandler(cmbProvincia_EditValueChanged);
        }

        private void fxPreCargar() {
            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                entMain = negSucursal.GetFormID(xCompania, xSucursal);
            }
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //Pais
            List<entPaises> LstB = negPaises.ListaCombo(fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbPais.Properties.DataSource = LstB;
            cmbPais.Properties.DisplayMember = "Descripcion";
            cmbPais.Properties.ValueMember = "Pais";
            LstB = null;
             
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
                if(entMain.ResultadoBusqueda){
                    sPais = String.IsNullOrEmpty(entMain.Pais) ? fnConst.TextNingunoCod : entMain.Pais;                   
                }
            }

            //Departamento
            List<entDepartamento> LstA = negDepartamento.ListaCombo(sPais, fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbDepartamento.Properties.DataSource = LstA;
            cmbDepartamento.Properties.DisplayMember = "Descripcion";
            cmbDepartamento.Properties.ValueMember = "DepartamentoCodigo";
            cmbDepartamento.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxCargarComboProvincia()
        {
            String sPais = fnConst.TextNingunoCod;
            String sDepa = fnConst.TextNingunoCod;
            if (cmbPais.EditValue != null){ sPais = cmbPais.EditValue.ToString(); }
            if (cmbDepartamento.EditValue != null) { sDepa = cmbDepartamento.EditValue.ToString(); }

            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                if (entMain.ResultadoBusqueda){
                    sPais = String.IsNullOrEmpty(entMain.Pais) ? fnConst.TextNingunoCod : entMain.Pais;
                    sDepa = String.IsNullOrEmpty(entMain.DepartamentoCodigo) ? fnConst.TextNingunoCod : entMain.DepartamentoCodigo;
                }
            }

            //Provincia
            List<entProvincia> LstA = negProvincia.ListaCombo(sPais,sDepa, fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbProvincia.Properties.DataSource = LstA;
            cmbProvincia.Properties.DisplayMember = "Descripcion";
            cmbProvincia.Properties.ValueMember = "ProvinciaCodigo";
            cmbProvincia.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxCargarComboDistrito()
        {
            String sPais = fnConst.TextNingunoCod;
            String sDepa = fnConst.TextNingunoCod;
            String sProv = fnConst.TextNingunoCod;
            if (cmbPais.EditValue != null) { sPais = cmbPais.EditValue.ToString(); }
            if (cmbDepartamento.EditValue != null) { sDepa = cmbDepartamento.EditValue.ToString(); }
            if (cmbProvincia.EditValue != null) { sProv = cmbProvincia.EditValue.ToString(); }

            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                if (entMain.ResultadoBusqueda){
                    sPais = String.IsNullOrEmpty(entMain.Pais) ? fnConst.TextNingunoCod : entMain.Pais;
                    sDepa = String.IsNullOrEmpty(entMain.DepartamentoCodigo) ? fnConst.TextNingunoCod : entMain.DepartamentoCodigo;
                    sProv = String.IsNullOrEmpty(entMain.ProvinciaCodigo) ? fnConst.TextNingunoCod : entMain.ProvinciaCodigo;
                }
            }

            //Provincia
            List<entDistrito> LstA = negDistrito.ListaCombo(sPais, sDepa, sProv, fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbDistrito.Properties.DataSource = LstA;
            cmbDistrito.Properties.DisplayMember = "Descripcion";
            cmbDistrito.Properties.ValueMember = "DistritoCodigo";
            cmbDistrito.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xSucursal = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "SUCURSAL";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbPais.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbCompania.Focus();
        }

        private void fxCargarReg()
        {
            //entMain = negSucursal.GetFormID(xCompania,xSucursal);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania;
                txtSucursal.Text = entMain.Sucursal.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                txtDireccion.Text = (!String.IsNullOrEmpty(entMain.Direccion)) ? entMain.Direccion.Trim() : String.Empty;
                cmbPais.EditValue = (!String.IsNullOrEmpty(entMain.Pais))? entMain.Pais.Trim():String.Empty;
                cmbDepartamento.EditValue = (!String.IsNullOrEmpty(entMain.DepartamentoCodigo)) ? entMain.DepartamentoCodigo.Trim() : String.Empty;
                cmbProvincia.EditValue = (!String.IsNullOrEmpty(entMain.ProvinciaCodigo)) ? entMain.ProvinciaCodigo.Trim() : String.Empty;
                cmbDistrito.EditValue = (!String.IsNullOrEmpty(entMain.DistritoCodigo)) ? entMain.DistritoCodigo.Trim() : String.Empty;
                cmbEstado.EditValue = entMain.Estado;
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
            txtSucursal.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            txtDireccion.ReadOnly = !sHabilitado;
            cmbPais.ReadOnly = !sHabilitado;
            cmbDepartamento.ReadOnly = !sHabilitado;
            cmbProvincia.ReadOnly = !sHabilitado;
            cmbDistrito.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtSucursal.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbCompania.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString();
            String sSuc = txtSucursal.Text.Trim();
            String sDes = txtDescripcion.Text.Trim();
            String sDir = txtDireccion.Text.Trim();
            String sPais = cmbPais.EditValue.ToString();
            String sDep = cmbDepartamento.EditValue.ToString();
            String sProv = cmbProvincia.EditValue.ToString();
            String sDist = cmbDistrito.EditValue.ToString();
            String sEstado = cmbEstado.EditValue.ToString();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Debe ingresar Compañia por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sSuc)){
                fnMensaje.MensajeInfo("Debe Ingresar sucursal por favor.");
                txtSucursal.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDes)){
                fnMensaje.MensajeInfo("Debe Ingresar descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }
                       
            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.Sucursal = sSuc;
            entMain.Descripcion = sDes;
            entMain.Direccion = sDir;
            entMain.Pais = sPais;
            entMain.DepartamentoCodigo = sDep;
            entMain.ProvinciaCodigo = sProv;
            entMain.DistritoCodigo = sDist;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xSucursal = sSuc;
            
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

            oErr = negSucursal.MantFormID(entMain);
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
            RRHH.frmSucursal frm = new RRHH.frmSucursal ();
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
            entSucursal oEnt = (entSucursal)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            RRHH.frmSucursal frm = new RRHH.frmSucursal ();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Sucursal);
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
            entSucursal oEnt = (entSucursal)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negSucursal.MantFormID(oEnt);
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
            entSucursal oEnt = (entSucursal)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            RRHH.frmSucursal frm = new RRHH.frmSucursal ();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Sucursal);
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

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarComboProvincia();
        }

        private void cmbProvincia_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarComboDistrito();
        }

        #endregion
        
    }
}
