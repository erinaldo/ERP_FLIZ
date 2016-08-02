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
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.RRHH
{
    public partial class frmCentroCosto : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {

        #region "==Propiedades=="

        private entCentroCosto entMain = new entCentroCosto();
        private String xOperacion = "";
        private String xCompania = "", xCentroCosto = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmCentroCosto()
        {
            InitializeComponent();
        }

        private void frmCentroCosto_Load(object sender, EventArgs e)
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

        private void frmCentroCosto_Shown(object sender, EventArgs e)
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
            List<entCentroCosto> Lst = negCentroCosto.ListCentroCostoForm();
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
            this.cmbCompania.EditValueChanged -= new EventHandler(cmbCompania_EditValueChanged);
        }

        private void fxAddEvent() {
            this.cmbCompania.EditValueChanged += new EventHandler(cmbCompania_EditValueChanged);
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT,fnConst.TextRaya3,fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //Usuario
            List<entUsuario> LstB = negUsuario.ListUsuarioXEstCombo(fnConst.StringPorc,fnConst.TextNingunoCod,fnConst.TextNingunoNom);
            cmbUsuarioResponsable.Properties.DataSource = LstB;
            cmbUsuarioResponsable.Properties.DisplayMember = "Nombre";
            cmbUsuarioResponsable.Properties.ValueMember = "CodigoUsuario";
            LstB = null;

            //RepTipo            
            cmbReporteTipo.Properties.DataSource = fnListasDat.ListRepTipoRH();
            cmbReporteTipo.Properties.DisplayMember = "Nombre";
            cmbReporteTipo.Properties.ValueMember = "Codigo";

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() { 
            String sCia = fnConst.TextRaya3;
            if(cmbCompania.EditValue!=null){
                sCia = cmbCompania.EditValue.ToString();
            }
            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                sCia = xCompania;
            }

            //Clasificacion
            List<entClasificacionCentroCosto> LstA = negClasificacionCentroCosto.ListaCombo(sCia,fnConst.StringPorc,new String[] { fnConst.TextNingunoCod,fnConst.TextNingunoNom});
            cmbClasificacion.Properties.DataSource = LstA;
            cmbClasificacion.Properties.DisplayMember = "Descripcion";
            cmbClasificacion.Properties.ValueMember = "Clasificacion";
            cmbClasificacion.EditValue = fnConst.TextNingunoCod;
            LstA = null;

            //Cargo
            List<entCargo> LstB = negCargo.ListaCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCargoResponsable.Properties.DataSource = LstB;
            cmbCargoResponsable.Properties.DisplayMember = "Descripcion";
            cmbCargoResponsable.Properties.ValueMember = "Cargo";
            cmbCargoResponsable.EditValue = fnConst.TextNingunoCod;
            LstB = null;

            //DepartamentoCia
            List<entDepartCia> LstC = negDepartCia.ListaCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbDepartamento.Properties.DataSource = LstC;
            cmbDepartamento.Properties.DisplayMember = "Descripcion";
            cmbDepartamento.Properties.ValueMember = "DepartamentoCiaCodigo";
            cmbDepartamento.EditValue = fnConst.TextNingunoCod;
            LstC = null;

            //Centro Costo Next
            List<entCentroCosto> LstD = negCentroCosto.ListaCentroCostoCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCCostoSup.Properties.DataSource = LstD;
            cmbCCostoSup.Properties.DisplayMember = "Nombres";
            cmbCCostoSup.Properties.ValueMember = "CentroCosto";
            cmbCCostoSup.EditValue = fnConst.TextNingunoCod;
            LstD = null;

            //Clasificacion GCCosto
            List<entClasifiGCCosto> LstE = negClasifiGCCosto.ListaCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbClasificacionGCC.Properties.DataSource = LstE;
            cmbClasificacionGCC.Properties.DisplayMember = "Descripcion";
            cmbClasificacionGCC.Properties.ValueMember = "ClasificacionGCC";
            cmbClasificacionGCC.EditValue = fnConst.TextNingunoCod;
            LstE = null;

            //Grupo CCosto
            List<entGrupoCCosto> LstF = negGrupoCCosto.ListaCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbGrupoGCC.Properties.DataSource = LstF;
            cmbGrupoGCC.Properties.DisplayMember = "Descripcion";
            cmbGrupoGCC.Properties.ValueMember = "GrupoCC";
            cmbGrupoGCC.EditValue = fnConst.TextNingunoCod;
            LstF = null;

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xCentroCosto = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "CENTRO COSTO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbUsuarioResponsable.EditValue = fnConst.TextNingunoCod;
            cmbReporteTipo.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbCompania.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCentroCosto.GetCentroCostoFormID(xCompania,xCentroCosto);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania.Trim();
                txtCCosto.Text = entMain.CentroCosto.Trim();
                txtNombres.Text = entMain.Nombres.Trim();
                cmbClasificacion.EditValue = (String.IsNullOrEmpty(entMain.Clasificacion)) ? fnConst.TextNingunoCod : entMain.Clasificacion.Trim();
                cmbUsuarioResponsable.EditValue = (String.IsNullOrEmpty(entMain.UsuarioResponsable)) ? fnConst.TextNingunoCod : entMain.UsuarioResponsable.Trim();
                cmbCargoResponsable.EditValue = (String.IsNullOrEmpty(entMain.CargoResponsable)) ? fnConst.TextNingunoCod : entMain.CargoResponsable.Trim();
                cmbReporteTipo.EditValue = (String.IsNullOrEmpty(entMain.RepTipo)) ? fnConst.TextNingunoCod : entMain.RepTipo.Trim();
                cmbDepartamento.EditValue = (String.IsNullOrEmpty(entMain.DepartamentoCiaCodigo)) ? fnConst.TextNingunoCod : entMain.DepartamentoCiaCodigo.Trim();
                cmbCCostoSup.EditValue = (String.IsNullOrEmpty(entMain.CentroCostoNext)) ? fnConst.TextNingunoCod : entMain.CentroCostoNext.Trim();
                cmbClasificacionGCC.EditValue = (String.IsNullOrEmpty(entMain.ClasificacionGCC)) ? fnConst.TextNingunoCod : entMain.ClasificacionGCC.Trim();
                cmbGrupoGCC.EditValue = (String.IsNullOrEmpty(entMain.GrupoCC)) ? fnConst.TextNingunoCod : entMain.GrupoCC.Trim();
                chkGerencia.Checked = (entMain.FlagGerencia.Equals("S")) ? true : false;
                chkCostoDirecto.Checked = (entMain.CostoDirecto.Equals("S")) ? true : false;
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuario;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaModificacion);
                txtNombres.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            cmbCompania.ReadOnly = !sHabilitado;
            txtCCosto.ReadOnly = !sHabilitado;
            txtNombres.ReadOnly = !sHabilitado;
            cmbClasificacion.ReadOnly = !sHabilitado;
            cmbUsuarioResponsable.ReadOnly = !sHabilitado;
            cmbCargoResponsable.ReadOnly = !sHabilitado;
            cmbReporteTipo.ReadOnly = !sHabilitado;
            cmbDepartamento.ReadOnly = !sHabilitado;
            cmbCCostoSup.ReadOnly = !sHabilitado;
            cmbClasificacionGCC.ReadOnly = !sHabilitado;
            cmbGrupoGCC.ReadOnly = !sHabilitado;
            chkGerencia.ReadOnly = !sHabilitado;
            chkCostoDirecto.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtCCosto.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbCompania.Focus(); }
            if (xOperacion.Equals("M")) { txtNombres.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString().Trim();
            String sCCosto = txtCCosto.Text.ToString().Trim();
            String sDescripcion = txtNombres.Text.ToString().Trim();
            String sClasif = cmbClasificacion.EditValue.ToString().Trim();
            String sUsuaResp = cmbUsuarioResponsable.EditValue.ToString().Trim();
            String sCargResp = cmbCargoResponsable.EditValue.ToString().Trim();
            String sTipoRep = cmbReporteTipo.EditValue.ToString().Trim();
            String sDepart = cmbDepartamento.EditValue.ToString().Trim();
            String sCCostoSup = cmbCCostoSup.EditValue.ToString().Trim();
            String sClasifGCC = cmbClasificacionGCC.EditValue.ToString().Trim();
            String sGrupoCC = cmbGrupoGCC.EditValue.ToString().Trim();
            String sFLagGeren = (chkGerencia.Checked)?"S":"N";
            String sFlagCostDir = (chkCostoDirecto.Checked) ? "S" : "N";
            String sEstado = cmbEstado.EditValue.ToString();

            if (String.IsNullOrEmpty(sCia)|| sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Debe ingresar Compañia por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sCCosto)){
                fnMensaje.MensajeInfo("Debe ingresar el Código de C.Costo.");
                txtCCosto.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar el Nombre de C.Costo.");
                txtNombres.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sClasif)){
                fnMensaje.MensajeInfo("Debe ingresar Clasificación por favor.");
                cmbClasificacion.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.CentroCosto = sCCosto;
            entMain.Nombres = sDescripcion;
            entMain.Clasificacion = sClasif;
            entMain.UsuarioResponsable = sUsuaResp;
            entMain.CargoResponsable = sCargResp;
            entMain.RepTipo = sTipoRep;
            entMain.DepartamentoCiaCodigo = sDepart;
            entMain.CentroCostoNext = sCCostoSup;
            entMain.ClasificacionGCC = sClasifGCC;
            entMain.GrupoCC = sGrupoCC;
            entMain.FlagGerencia = sFLagGeren;
            entMain.CostoDirecto = sFlagCostDir;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xCentroCosto = sCCosto;

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

            oErr = negCentroCosto.MantCentroCostoForm(entMain);
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
            RRHH.frmCentroCosto frm = new RRHH.frmCentroCosto();
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
            entCentroCosto oEnt = (entCentroCosto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            RRHH.frmCentroCosto frm = new RRHH.frmCentroCosto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.CentroCosto);
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
            entCentroCosto oEnt = (entCentroCosto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCentroCosto.MantCentroCostoForm(oEnt);
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
            entCentroCosto oEnt = (entCentroCosto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            RRHH.frmCentroCosto frm = new RRHH.frmCentroCosto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.CentroCosto);
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

        private void cmbCompania_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarCombosXCia();
        }

        #endregion
    }
}
