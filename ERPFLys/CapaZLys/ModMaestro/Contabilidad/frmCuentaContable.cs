using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Busqueda.General;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmCuentaContable : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entCuentaContable entMain = new entCuentaContable();
        private List<entCompCContable> LstDet = new List<entCompCContable>();
        private String xOperacion = "";
        private String xCuentaContable = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmCuentaContable()
        {
            InitializeComponent();
        }

        private void frmCuentaContable_Load(object sender, EventArgs e)
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
                fxCargarCombosXCia();
                fxCargarComboMayor04();
                fxCargarComboMayor05();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmCuentaContable_Shown(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxFocusInicial();
            }
        }

        private void frmCuentaContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            entMain = null;
            LstDet = null;
            GC.SuppressFinalize(this);
        }

        #endregion

        #region "==FuncionesList=="

        private void fxCargarLista()
        {
            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)) { return; }
            List<entCuentaContable> Lst = negCuentaContable.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Tipo Cuenta
            rilueTipoCuenta.DataSource = fnListasDat.ListTipoCuentaContable();
            rilueTipoCuenta.DisplayMember = "Nombre";
            rilueTipoCuenta.ValueMember = "Codigo";

            //Clasificacion Gasto
            rilueClasificacionGasto.DataSource = fnListasDat.ListClasificacionGasto();
            rilueClasificacionGasto.DisplayMember = "Nombre";
            rilueClasificacionGasto.ValueMember = "Codigo";

            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF1();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            this.cmbCuentaMayor.EditValueChanged -= new EventHandler(cmbCuentaMayor_EditValueChanged);
            this.cmbCuentaMayor04.EditValueChanged -= new EventHandler(cmbCuentaMayor04_EditValueChanged);
        }

        private void fxAddEvent() {
            this.cmbCuentaMayor.EditValueChanged += new EventHandler(cmbCuentaMayor_EditValueChanged);
            this.cmbCuentaMayor04.EditValueChanged += new EventHandler(cmbCuentaMayor04_EditValueChanged);
        }

        private void fxPreCargar()
        {
            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                entMain = negCuentaContable.GetFormID(xCuentaContable);
            }
        }

        private void fxCargarCombos()
        {
            String sEstadoGen = fnConst.StringA;
            if (xOperacion.Equals("V")) { sEstadoGen = fnConst.StringPorc; }

            //Cuenta Mayor
            List<entCuentaMayor> LstA = negCuentaMayor.ListaCombo(fnConst.StringPorc,sEstadoGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCuentaMayor.Properties.DataSource = LstA;
            cmbCuentaMayor.Properties.DisplayMember = "Descripcion";
            cmbCuentaMayor.Properties.ValueMember = "CuentaMayor";
            LstA = null;

            //Cod Rubro
            List<entRubroCtaContable> LstB = negRubroCtaContable.ListaCombo(sEstadoGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCodRubro.Properties.DataSource = LstB;
            cmbCodRubro.Properties.DisplayMember = "Descripcion";
            cmbCodRubro.Properties.ValueMember = "CodRubro";
            LstB = null;

            //Tipo Gasto
            List<entTipoGasto> LstC = negTipoGasto.ListaCombo(sEstadoGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbTipoGasto.Properties.DataSource = LstC;
            cmbTipoGasto.Properties.DisplayMember = "Descripcion";
            cmbTipoGasto.Properties.ValueMember = "TipoGasto";
            LstC = null;

            //Rubro Gasto
            List<entRubroGasto> LstD = negRubroGasto.ListaCombo(new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbRubroGasto.Properties.DataSource = LstD;
            cmbRubroGasto.Properties.DisplayMember = "Descripcion";
            cmbRubroGasto.Properties.ValueMember = "RubroGasto";
            LstD = null;

            //Elemento Gasto
            List<entElementoGasto> LstE = negElementoGasto.ListaCombo(fnConst.StringPorc,new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbElmentoGasto.Properties.DataSource = LstE;
            cmbElmentoGasto.Properties.DisplayMember = "Descripcion";
            cmbElmentoGasto.Properties.ValueMember = "Elemento";
            LstE = null;

            //Tipo Persona Usuario
            List<entTipoPersonaUsuario> LstF = negTipoPersonaUsuario.ListaCombo(sEstadoGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbTipoPersonaEsp.Properties.DataSource = LstF;
            cmbTipoPersonaEsp.Properties.DisplayMember = "Descripcion";
            cmbTipoPersonaEsp.Properties.ValueMember = "TipoPersonaUsuario";
            LstF = null;

            //Tipo Cuenta
            cmbTipoCuenta.Properties.DataSource = fnListasDat.ListTipoCuentaContable();
            cmbTipoCuenta.Properties.DisplayMember = "Nombre";
            cmbTipoCuenta.Properties.ValueMember = "Codigo";

            //Nivel Cuenta(Clasificacion Cta)
            cmbNivelCuenta.Properties.DataSource = fnListasDat.ListNivelCuenta();
            cmbNivelCuenta.Properties.DisplayMember = "Nombre";
            cmbNivelCuenta.Properties.ValueMember = "Codigo";

            //Moneda
            cmbMoneda.Properties.DataSource = fnListasDat.ListMonedaMulti();
            cmbMoneda.Properties.DisplayMember = "Nombre";
            cmbMoneda.Properties.ValueMember = "Codigo";

            //Clasificacion Gasto
            cmbClasificacionGasto.Properties.DataSource = fnListasDat.ListClasificacionGasto();
            cmbClasificacionGasto.Properties.DisplayMember = "Nombre";
            cmbClasificacionGasto.Properties.ValueMember = "Codigo";

            //Req Persona
            cmbReqPersona.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqPersona.Properties.DisplayMember = "Nombre";
            cmbReqPersona.Properties.ValueMember = "Codigo";

            //Req Tipo Persona Gen
            cmbTipoPersonaGen.Properties.DataSource = fnListasDat.ListTipoPersonaGeneral();
            cmbTipoPersonaGen.Properties.DisplayMember = "Nombre";
            cmbTipoPersonaGen.Properties.ValueMember = "Codigo";

            //Req Proyecto
            cmbReqProyecto.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqProyecto.Properties.DisplayMember = "Nombre";
            cmbReqProyecto.Properties.ValueMember = "Codigo";

            //Uso Sub Cuenta
            cmbReqFlujoCaja.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqFlujoCaja.Properties.DisplayMember = "Nombre";
            cmbReqFlujoCaja.Properties.ValueMember = "Codigo";

            //Flag Saldo Persaona
            cmbFlagSaldoPersona.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbFlagSaldoPersona.Properties.DisplayMember = "Nombre";
            cmbFlagSaldoPersona.Properties.ValueMember = "Codigo";

            //Req Orden Compra
            cmbReqOrdenCompra.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqOrdenCompra.Properties.DisplayMember = "Nombre";
            cmbReqOrdenCompra.Properties.ValueMember = "Codigo";

            //Req Documento
            cmbReqDocumento.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqDocumento.Properties.DisplayMember = "Nombre";
            cmbReqDocumento.Properties.ValueMember = "Codigo";

            //Req Fecha
            cmbReqFecha.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqFecha.Properties.DisplayMember = "Nombre";
            cmbReqFecha.Properties.ValueMember = "Codigo";

            //Req Centro Costo
            cmbReqCCosto.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqCCosto.Properties.DisplayMember = "Nombre";
            cmbReqCCosto.Properties.ValueMember = "Codigo";

            //Req Descripcion
            cmbReqDescripcion.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbReqDescripcion.Properties.DisplayMember = "Nombre";
            cmbReqDescripcion.Properties.ValueMember = "Codigo";

            //Req Saldo Documento
            cmbFlagSaldoDocumento.Properties.DataSource = fnListasDat.ListRequeridoOpcion();
            cmbFlagSaldoDocumento.Properties.DisplayMember = "Nombre";
            cmbFlagSaldoDocumento.Properties.ValueMember = "Codigo";

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";

        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() {
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
            rilueCompaniaDet.DataSource = LstA;
            rilueCompaniaDet.DisplayMember = "Nombres";
            rilueCompaniaDet.ValueMember = "Compania";
            LstA = null;
        }

        private void fxCargarComboMayor04()
        {
            String sMay = fnConst.TextNingunoCod;
            String sEstGen = fnConst.StringA;
            if (xOperacion.Equals("V")) { sEstGen = fnConst.StringPorc; }

            if (cmbCuentaMayor.EditValue != null){
                sMay = cmbCuentaMayor.EditValue.ToString();
            }

            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                if (entMain.ResultadoBusqueda){
                    sMay = String.IsNullOrEmpty(entMain.CuentaMayor) ? fnConst.TextNingunoCod : entMain.CuentaMayor;
                }
            }

            //Cuenta Mayor 04
            List<entCuentaMayor04> LstA = negCuentaMayor04.ListaCombo(sMay,sEstGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCuentaMayor04.Properties.DataSource = LstA;
            cmbCuentaMayor04.Properties.DisplayMember = "Descripcion";
            cmbCuentaMayor04.Properties.ValueMember = "CuentaMayor04";
            cmbCuentaMayor04.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxCargarComboMayor05()
        {
            String sMay = fnConst.TextNingunoCod;
            String sMay04 = fnConst.TextNingunoCod;
            String sEstGen = fnConst.StringA;
            if (xOperacion.Equals("V")) { sEstGen = fnConst.StringPorc; }

            if (cmbCuentaMayor.EditValue != null) {sMay = cmbCuentaMayor.EditValue.ToString();}
            if (cmbCuentaMayor04.EditValue != null) { sMay04 = cmbCuentaMayor04.EditValue.ToString(); }

            if (xOperacion.Equals("M") || xOperacion.Equals("V")){
                if (entMain.ResultadoBusqueda){
                    sMay = String.IsNullOrEmpty(entMain.CuentaMayor) ? fnConst.TextNingunoCod : entMain.CuentaMayor;
                    sMay04 = String.IsNullOrEmpty(entMain.CuentaMayor04) ? fnConst.TextNingunoCod : entMain.CuentaMayor04;
                }
            }

            //Cuenta Mayor 05
            List<entCuentaMayor05> LstA = negCuentaMayor05.ListaCombo(sMay04, sEstGen, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbCuentaMayor05.Properties.DataSource = LstA;
            cmbCuentaMayor05.Properties.DisplayMember = "Descripcion";
            cmbCuentaMayor05.Properties.ValueMember = "CuentaMayor05";
            cmbCuentaMayor05.EditValue = fnConst.TextNingunoCod;
            LstA = null;
        }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCuentaContable = this.EstructuraForm.StrX[0];
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
            this.lblTitulo.Text = "PLAN DE CUENTAS";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCuentaMayor.EditValue = fnConst.TextNingunoCod;
            cmbTipoCuenta.EditValue = fnConst.TipoCuentaGenCod;
            cmbNivelCuenta.EditValue = fnConst.TextNingunoCod;
            cmbMoneda.EditValue = fnConst.MonedaMulCod;
            cmbCodRubro.EditValue = fnConst.TextNingunoCod;
            cmbTipoGasto.EditValue = fnConst.TextNingunoCod;
            cmbClasificacionGasto.EditValue = fnConst.TextNingunoCod;
            cmbRubroGasto.EditValue = fnConst.TextNingunoCod;
            cmbElmentoGasto.EditValue = fnConst.TextNingunoCod;
            cmbReqPersona.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbTipoPersonaGen.EditValue = fnConst.TextNingunoCod;
            cmbTipoPersonaEsp.EditValue = fnConst.TextNingunoCod;
            cmbReqProyecto.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbReqFlujoCaja.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbFlagSaldoPersona.EditValue = fnConst.ReqTipoNoRequeridoCod;
            cmbReqOrdenCompra.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbReqDocumento.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbReqFecha.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbReqCCosto.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbReqDescripcion.EditValue = fnConst.ReqTipoOpcionalCod;
            cmbFlagSaldoDocumento.EditValue = fnConst.ReqTipoNoRequeridoCod;            
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCuenta.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCuentaContable.GetFormID(xCuentaContable);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCuenta.Text = entMain.Cuenta.Trim();
                txtNombres.Text = entMain.Nombres.Trim();
                cmbTipoCuenta.EditValue = entMain.TipoCuenta.Trim();
                cmbCuentaMayor.EditValue = (!String.IsNullOrEmpty(entMain.CuentaMayor))? entMain.CuentaMayor.Trim():fnConst.TextNingunoCod;
                cmbCuentaMayor04.EditValue = (!String.IsNullOrEmpty(entMain.CuentaMayor04))? entMain.CuentaMayor04.Trim():fnConst.TextNingunoCod;
                cmbCuentaMayor05.EditValue = (!String.IsNullOrEmpty(entMain.CuentaMayor05))? entMain.CuentaMayor05.Trim():fnConst.TextNingunoCod;
                cmbNivelCuenta.EditValue = (!String.IsNullOrEmpty(entMain.NivelCuenta))? entMain.NivelCuenta.Trim():fnConst.TextNingunoCod;
                cmbMoneda.EditValue = entMain.Moneda.Trim();
                cmbCodRubro.EditValue = (!String.IsNullOrEmpty(entMain.CodRubro))? entMain.CodRubro.Trim():fnConst.TextNingunoCod;
                cmbTipoGasto.EditValue = (!String.IsNullOrEmpty(entMain.TipoGasto))? entMain.TipoGasto.Trim():fnConst.TextNingunoCod;
                ChkFlagCuentaTrans.Checked = (entMain.FlagCuentaTrans.Equals("S")) ? true : false;
                txtCuentaDebeTrans.Text = (!String.IsNullOrEmpty(entMain.CuentaDebeTrans))?entMain.CuentaDebeTrans.Trim():String.Empty;
                txtCuentaHaberTrans.Text = (!String.IsNullOrEmpty(entMain.CuentaHaberTrans)) ? entMain.CuentaHaberTrans.Trim() : String.Empty;
                cmbClasificacionGasto.EditValue = (!String.IsNullOrEmpty(entMain.ClasificacionGasto))?entMain.ClasificacionGasto.Trim():String.Empty;
                cmbRubroGasto.EditValue = (!String.IsNullOrEmpty(entMain.RubroGasto))?entMain.RubroGasto.Trim():String.Empty;
                cmbElmentoGasto.EditValue = (!String.IsNullOrEmpty(entMain.ElmentoGasto))? entMain.ElmentoGasto.Trim():fnConst.TextNingunoCod;
                chkFlagDesaduanaje.Checked = (entMain.FlagDesaduanaje.Equals("S")) ? true : false;
                chkFlagEdificio.Checked = (entMain.FlagEdificio.Equals("S")) ? true : false;
                chkFlagPermiteAjuste.Checked = (entMain.FlagPermiteAjuste.Equals("S")) ? true : false;
                chkFlagCierreAnual13.Checked = (entMain.FlagCierreAnual13.Equals("S")) ? true : false;
                chkFlagCierreAnual14.Checked = (entMain.FlagCierreAnual14.Equals("S")) ? true : false;
                chkLibroCaja.Checked = (!String.IsNullOrEmpty(entMain.LibroCaja))? ((entMain.LibroCaja.Equals("S")) ? true : false):false;
                cmbReqPersona.EditValue = entMain.ReqPersona.Trim();
                cmbTipoPersonaGen.EditValue = (!String.IsNullOrEmpty(entMain.TipoPersonaGen))?entMain.TipoPersonaGen.Trim():String.Empty;
                cmbTipoPersonaEsp.EditValue = (!String.IsNullOrEmpty(entMain.TipoPersonaEsp))?entMain.TipoPersonaEsp.Trim():String.Empty;
                cmbReqProyecto.EditValue = entMain.ReqProyecto.Trim();
                cmbReqFlujoCaja.EditValue = entMain.ReqFlujoCaja.Trim();
                cmbFlagSaldoPersona.EditValue = entMain.FlagSaldoPersona.Trim();
                cmbReqOrdenCompra.EditValue = entMain.ReqOrdenCompra.Trim();
                cmbReqDocumento.EditValue = entMain.ReqDocumento.Trim();
                cmbReqFecha.EditValue = entMain.ReqFecha.Trim();
                cmbReqCCosto.EditValue = entMain.ReqCCosto.Trim();
                cmbReqDescripcion.EditValue = entMain.ReqDescripcion.Trim();
                cmbFlagSaldoDocumento.EditValue = entMain.FlagSaldoDocumento.Trim();
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuario;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaModificacion);
                txtNombres.Focus();
                fxCargarDet();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCuenta.ReadOnly = !sHabilitado;
            txtNombres.ReadOnly = !sHabilitado;
            cmbTipoCuenta.ReadOnly = !sHabilitado;
            cmbCuentaMayor.ReadOnly = !sHabilitado;
            cmbCuentaMayor04.ReadOnly = !sHabilitado;
            cmbCuentaMayor05.ReadOnly = !sHabilitado;
            cmbNivelCuenta.ReadOnly = !sHabilitado;
            cmbMoneda.ReadOnly = !sHabilitado;
            cmbCodRubro.ReadOnly = !sHabilitado;
            cmbTipoGasto.ReadOnly = !sHabilitado;
            ChkFlagCuentaTrans.ReadOnly = !sHabilitado;
            txtCuentaDebeTrans.ReadOnly = !sHabilitado;
            txtCuentaHaberTrans.ReadOnly = !sHabilitado;
            cmbClasificacionGasto.ReadOnly = !sHabilitado;
            cmbRubroGasto.ReadOnly = !sHabilitado;
            cmbElmentoGasto.ReadOnly = !sHabilitado;
            chkFlagDesaduanaje.ReadOnly = !sHabilitado;
            chkFlagEdificio.ReadOnly = !sHabilitado;
            chkFlagPermiteAjuste.ReadOnly = !sHabilitado;
            chkFlagCierreAnual13.ReadOnly = !sHabilitado;
            chkFlagCierreAnual14.ReadOnly = !sHabilitado;
            chkLibroCaja.ReadOnly = !sHabilitado;
            cmbReqPersona.ReadOnly = !sHabilitado;
            cmbTipoPersonaGen.ReadOnly = !sHabilitado;
            cmbTipoPersonaEsp.ReadOnly = !sHabilitado;
            cmbReqProyecto.ReadOnly = !sHabilitado;
            cmbReqFlujoCaja.ReadOnly = !sHabilitado;
            cmbFlagSaldoPersona.ReadOnly = !sHabilitado;
            cmbReqOrdenCompra.ReadOnly = !sHabilitado;
            cmbReqDocumento.ReadOnly = !sHabilitado;
            cmbReqFecha.ReadOnly = !sHabilitado;
            cmbReqCCosto.ReadOnly = !sHabilitado;
            cmbReqDescripcion.ReadOnly = !sHabilitado;
            cmbFlagSaldoDocumento.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            btnCuentaDebeTrans.Enabled = true;
            btnCuentaHaberTrans.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;
            chkFlagTodasCompania.ReadOnly = !sHabilitado;
            gvDetalle.OptionsBehavior.Editable = sHabilitado;
            gvDetalle.OptionsBehavior.ReadOnly = !sHabilitado;

            if (!xOperacion.Equals("V")) {
                ChkFlagCuentaTrans_CheckedChanged(null, null);
            }

            if (xOperacion.Equals("M")){
                txtCuenta.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) {
                btnCuentaDebeTrans.Enabled = false;
                btnCuentaHaberTrans.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false; 
            }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCuenta.Focus(); }
            if (xOperacion.Equals("M")) { txtNombres.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCuenta = txtCuenta.Text.Trim();
            String sNombre = txtNombres.Text.Trim();
            String sTipCta = cmbTipoCuenta.EditValue.ToString().Trim();
            String sMayor = cmbCuentaMayor.EditValue.ToString().Trim();
            String sMay04 = cmbCuentaMayor04.EditValue.ToString().Trim();
            String sMay05 = cmbCuentaMayor05.EditValue.ToString().Trim();
            String sNivCta = cmbNivelCuenta.EditValue.ToString().Trim();
            String sMoned = cmbMoneda.EditValue.ToString().Trim();
            String sCodRub = cmbCodRubro.EditValue.ToString().Trim();
            String sTipGas = cmbTipoGasto.EditValue.ToString().Trim();
            String sFlagCtaTrans = (ChkFlagCuentaTrans.Checked) ? "S" : "N";
            String sCtaTransDeb = txtCuentaDebeTrans.Text.Trim();
            String sCtaTransHab = txtCuentaHaberTrans.Text.Trim();
            String sClasGast = cmbClasificacionGasto.EditValue.ToString().Trim();
            String sRubGast = cmbRubroGasto.EditValue.ToString().Trim();
            String sElemGast = cmbElmentoGasto.EditValue.ToString().Trim();
            String sFlagDes = (chkFlagDesaduanaje.Checked) ? "S" : "N";
            String sFlagEdi = (chkFlagEdificio.Checked) ? "S" : "N";
            String sFlagPermAju = (chkFlagPermiteAjuste.Checked) ? "S" : "N";
            String sFlagCierre13 = (chkFlagCierreAnual13.Checked) ? "S" : "N";
            String sFlagCierre14 = (chkFlagCierreAnual14.Checked) ? "S" : "N";
            String sFlagLibroCaja = (chkLibroCaja.Checked) ? "S" : "N";
            String sReqPers = cmbReqPersona.EditValue.ToString().Trim();
            String sTipoPersGen = cmbTipoPersonaGen.EditValue.ToString().Trim();
            String sTipoPersEsp = cmbTipoPersonaEsp.EditValue.ToString().Trim();
            String sReqProy = cmbReqProyecto.EditValue.ToString().Trim();
            String sReqFlujoCaja = cmbReqFlujoCaja.EditValue.ToString().Trim();
            String sFlagSaldPers = cmbFlagSaldoPersona.EditValue.ToString().Trim();
            String sReqOCompra = cmbReqOrdenCompra.EditValue.ToString().Trim();
            String sReqDoc = cmbReqDocumento.EditValue.ToString().Trim();
            String sReqFech = cmbReqFecha.EditValue.ToString().Trim();
            String sReqCCost = cmbReqCCosto.EditValue.ToString().Trim();
            String sReqDesc = cmbReqDescripcion.EditValue.ToString().Trim();
            String sFlagSaldDoc = cmbFlagSaldoDocumento.EditValue.ToString().Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            String sCuentaMay03 = (sMayor.Length >= 3) ? sCuenta.Substring(0, 3) : String.Empty;
            String sCuentaMay04 = (sMay04.Length >= 4) ? sCuenta.Substring(0, 4) : String.Empty;
            String sCuentaMay05 = (sMay05.Length >= 5) ? sCuenta.Substring(0, 5) : String.Empty;

            if (String.IsNullOrEmpty(sCuenta)){
                fnMensaje.MensajeInfo("Ingresar código de cuenta contable por favor.");
                txtCuenta.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sNombre)){
                fnMensaje.MensajeInfo("Ingresar Descripción por favor.");
                txtNombres.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTipCta)){
                fnMensaje.MensajeInfo("Ingresar Tipo de Cuenta por favor.");
                cmbTipoCuenta.Focus();
                return bOk;
            }

            if (sTipCta.Equals("G")) {
                if (String.IsNullOrEmpty(sMayor)) {
                    fnMensaje.MensajeInfo("Seleccionar Mayor de 3 digitos por favor.");
                    cmbCuentaMayor.Focus();
                    return bOk;
                }

                if (sCuenta.Length > 6) {
                    fnMensaje.MensajeInfo("Cuenta no es válida, ingresar máximo 6 digitos.");
                    txtCuenta.Focus();
                    return bOk;
                }

                if (!sCuentaMay03.Equals(sMayor)){
                    fnMensaje.MensajeInfo("Cuenta no es identica a Nomenclatura del Mayor de 3 digitos, revisar por favor.");
                    cmbCuentaMayor.Focus();
                    return bOk;
                }

                if (!String.IsNullOrEmpty(sMay04)) {
                    fnMensaje.MensajeInfo("Cuenta Mayor(4 digitos) no debe definirse en Tipo de Cuenta General.");
                    cmbCuentaMayor04.Focus();
                    return bOk;
                }

                if (!String.IsNullOrEmpty(sMay05)){
                    fnMensaje.MensajeInfo("Cuenta Mayor(5 digitos) no debe definirse en Tipo de Cuenta General.");
                    cmbCuentaMayor05.Focus();
                    return bOk;
                }
            }

            if (sTipCta.Equals("E")){
                if (String.IsNullOrEmpty(sMayor)){
                    fnMensaje.MensajeInfo("Seleccionar Mayor de 3 digitos por favor.");
                    cmbCuentaMayor.Focus();
                    return bOk;
                }

                if (sCuenta.Length != 7){
                    fnMensaje.MensajeInfo("Cuenta no es válida, ingresar 7 digitos.");
                    txtCuenta.Focus();
                    return bOk;
                }

                if (!sCuentaMay03.Equals(sMayor)){
                    fnMensaje.MensajeInfo("Cuenta no es identica a Nomenclatura del Mayor de 3 digitos, revisar por favor.");
                    cmbCuentaMayor.Focus();
                    return bOk;
                }

                if (String.IsNullOrEmpty(sMay04)){
                    fnMensaje.MensajeInfo("Seleccionar Mayor de 4 digitos por favor.");
                    cmbCuentaMayor04.Focus();
                    return bOk;
                }

                if (!sCuentaMay04.Equals(sMay04)){
                    fnMensaje.MensajeInfo("Cuenta no es identica a Nomenclatura del Mayor de 4 digitos, revisar por favor.");
                    cmbCuentaMayor04.Focus();
                    return bOk;
                }

                if (String.IsNullOrEmpty(sMay05)){
                    fnMensaje.MensajeInfo("Seleccionar Mayor de 5 digitos por favor.");
                    cmbCuentaMayor05.Focus();
                    return bOk;
                }

                if (!sCuentaMay05.Equals(sMay05)){
                    fnMensaje.MensajeInfo("Cuenta no es identica a Nomenclatura del Mayor de 5 digitos, revisar por favor.");
                    cmbCuentaMayor05.Focus();
                    return bOk;
                }
            }

            if (String.IsNullOrEmpty(sMoned) || sMoned.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Seleccionar moneda por favor.");
                cmbMoneda.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sCodRub) || sCodRub.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Seleccionar Codigo Rubro por favor.");
                cmbCodRubro.Focus();
                return bOk;
            }

            entCuentaContable oCta = new entCuentaContable();
            if (sFlagCtaTrans.Equals("S")){
                //Cuenta Debe
                if (String.IsNullOrEmpty(sCtaTransDeb)) {
                    fnMensaje.MensajeInfo("Registrar cuenta debe transferencia por favor.");
                    txtCuentaDebeTrans.Focus(); oCta = null;
                    return bOk;
                }

                if (sCtaTransDeb.Equals(sCuenta)){
                    fnMensaje.MensajeInfo("Cuenta debe de transferencia no puede ser igual a cuenta contable general.");
                    txtCuentaDebeTrans.Focus(); oCta = null;
                    return bOk;
                }

                oCta = negCuentaContable.GetFormID(sCtaTransDeb);
                if (!(oCta.ResultadoBusqueda && oCta.Estado.Equals("A"))) {
                    fnMensaje.MensajeInfo("Cuenta debe de transferencia es inválida.");
                    txtCuentaDebeTrans.Focus(); oCta = null;
                    return bOk;
                }

                //Cuenta Haber
                if (String.IsNullOrEmpty(sCtaTransHab)){
                    fnMensaje.MensajeInfo("Registrar cuenta haber transferencia por favor.");
                    txtCuentaHaberTrans.Focus(); oCta = null;
                    return bOk;
                }

                if (sCtaTransHab.Equals(sCuenta)){
                    fnMensaje.MensajeInfo("Cuenta haber de transferencia no puede ser igual a cuenta contable general.");
                    txtCuentaHaberTrans.Focus(); oCta = null;
                    return bOk;
                }

                oCta = negCuentaContable.GetFormID(sCtaTransHab);
                if (!(oCta.ResultadoBusqueda && oCta.Estado.Equals("A"))){
                    fnMensaje.MensajeInfo("Cuenta haber de transferencia es inválida.");
                    txtCuentaHaberTrans.Focus(); oCta = null;
                    return bOk;
                }
            }
            else {
                if (!String.IsNullOrEmpty(sCtaTransDeb)){
                    fnMensaje.MensajeInfo("No Registrar cuenta debe transferencia por favor.");
                    txtCuentaDebeTrans.Focus(); oCta = null;
                    return bOk;
                }

                if (!String.IsNullOrEmpty(sCtaTransHab)){
                    fnMensaje.MensajeInfo("No Registrar cuenta haber transferencia por favor.");
                    txtCuentaHaberTrans.Focus(); oCta = null;
                    return bOk;
                }
            }
            oCta = null;

            if (sReqPers.Equals("R")) {
                if (String.IsNullOrEmpty(sTipoPersGen) || sTipoPersGen.Equals(fnConst.TextNingunoCod)){
                    fnMensaje.MensajeInfo("Por favor, en las validaciones registrar la cuenta genérica de la persona requerida.");
                    cmbTipoPersonaGen.Focus();
                    return bOk;
                }

                if (String.IsNullOrEmpty(sTipoPersEsp) || sTipoPersEsp.Equals(fnConst.TextNingunoCod)){
                    fnMensaje.MensajeInfo("Por favor, en las validaciones registrar la cuenta especifica de la persona requerida.");
                    cmbTipoPersonaEsp.Focus();
                    return bOk;
                }
            }

            if (String.IsNullOrEmpty(sElemGast) || sElemGast.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Registrar un elemento de gasto por favor.");
                cmbElmentoGasto.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Cuenta = sCuenta;
            entMain.Nombres = sNombre;
            entMain.TipoCuenta = sTipCta;
            entMain.CuentaMayor = sMayor;
            entMain.CuentaMayor04 = sMay04;
            entMain.CuentaMayor05 = sMay05;
            entMain.NivelCuenta = sNivCta;
            entMain.Moneda = sMoned;
            entMain.CodRubro = sCodRub;
            entMain.TipoGasto = sTipGas;
            entMain.FlagCuentaTrans = sFlagCtaTrans;
            entMain.CuentaDebeTrans = sCtaTransDeb;
            entMain.CuentaHaberTrans = sCtaTransHab;
            entMain.ClasificacionGasto = sClasGast;
            entMain.RubroGasto = sRubGast;
            entMain.ElmentoGasto = sElemGast;
            entMain.FlagDesaduanaje = sFlagDes;
            entMain.FlagEdificio = sFlagEdi;
            entMain.FlagPermiteAjuste = sFlagPermAju;
            entMain.FlagCierreAnual13 = sFlagCierre13;
            entMain.FlagCierreAnual14 = sFlagCierre14;
            entMain.LibroCaja = sFlagLibroCaja;
            entMain.ReqPersona = sReqPers;
            entMain.TipoPersonaGen = sTipoPersGen;
            entMain.TipoPersonaEsp = sTipoPersEsp;
            entMain.ReqProyecto = sReqProy;
            entMain.ReqFlujoCaja = sReqFlujoCaja;
            entMain.FlagSaldoPersona = sFlagSaldPers;
            entMain.ReqOrdenCompra = sReqOCompra;
            entMain.ReqDocumento = sReqDoc;
            entMain.ReqFecha = sReqFech;
            entMain.ReqCCosto = sReqCCost;
            entMain.ReqDescripcion = sReqDesc;
            entMain.FlagSaldoDocumento = sFlagSaldDoc;
            entMain.Estado = sEstado;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;
            entMain.DetalleCuentaxCompania = LstDet;

            xCuentaContable = sCuenta;
            
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

            oErr = negCuentaContable.MantFormID(entMain);
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

        #region "==FuncionesDet=="

        private void fxCargarDet()
        {
            LstDet = negCompCContable.ListaFormID(xCuentaContable);
            fxLinkDet();
        }

        private void fxLinkDet()
        {
            grDetalle.DataSource = null;
            if (LstDet.Count > 0){
                grDetalle.DataSource = LstDet.FindAll(p => p.RegVer == fnEnum.RegVer.Si);
            }
            gvDetalle.Focus();
        }

        private Boolean fxValidarDetalle()
        {
            Boolean bOk = false;
            
            DateTime dFechaServ = negGeneral.GetFechaServidor();
            foreach (entCompCContable oEnt in LstDet)
            {
                if (String.IsNullOrEmpty(oEnt.Compania)||oEnt.Compania.Equals(fnConst.TextRaya3)) {
                    fnMensaje.MensajeInfo("Ingresar compania en Detalle por favor. Linea " + oEnt.Linea.ToString());
                    return bOk;
                }

                foreach (entCompCContable oEntDet in LstDet) {
                    if (oEnt.Compania.Equals(oEntDet.Compania) && oEnt.Linea != oEntDet.Linea) {
                        fnMensaje.MensajeInfo("Ha Ingresado compañía repetidas. Lineas: " + oEnt.Linea.ToString() + "-" + oEntDet.Linea.ToString());
                        return bOk;
                    }
                }

                if (oEnt.RegExistente == fnEnum.RegExistente.Si && oEnt.RegEditado == fnEnum.RegEditado.Si){
                    oEnt.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                }

                if (oEnt.OperMantenimiento == fnEnum.OperacionMant.Insertar || oEnt.OperMantenimiento == fnEnum.OperacionMant.Modificar){
                    oEnt.Cuenta = txtCuenta.Text.Trim();
                    oEnt.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
                    oEnt.UsuarioSys = GlobalVar.UsuarioLogeo;
                    oEnt.UltimaFechaMod = dFechaServ;
                }
            }

            bOk = true;
            return bOk;
        }

        #endregion

        #region "==EventInherit=="

        public override void ue_nuevo()
        {
            Contabilidad.frmCuentaContable frm = new Contabilidad.frmCuentaContable();
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
            entCuentaContable oEnt = (entCuentaContable)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmCuentaContable frm = new Contabilidad.frmCuentaContable();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Cuenta);
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
            entCuentaContable oEnt = (entCuentaContable)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCuentaContable.MantFormID(oEnt);
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
            entCuentaContable oEnt = (entCuentaContable)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmCuentaContable frm = new Contabilidad.frmCuentaContable();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Cuenta); 
            frm.ShowDialog();
            oEnt = null;
            frm = null;
        }

        public override void ue_guardar()
        {
            if (!fxValidar()) { return; };
            if (!fxValidarDetalle()) { return; };
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
        
        private void cmbCuentaMayor_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarComboMayor04();
        }

        private void cmbCuentaMayor04_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarComboMayor05();
        }

        private void ChkFlagCuentaTrans_CheckedChanged(object sender, EventArgs e)
        {
            Boolean bVal = ChkFlagCuentaTrans.Checked;

            txtCuentaDebeTrans.ReadOnly = !bVal;
            txtCuentaHaberTrans.ReadOnly = !bVal;
            btnCuentaDebeTrans.Enabled = bVal;
            btnCuentaHaberTrans.Enabled = bVal;
            if (!bVal){
                txtCuentaDebeTrans.Text = String.Empty;
                txtCuentaHaberTrans.Text = String.Empty;
            }
        }

        private void btnCuentaDebeTrans_Click(object sender, EventArgs e)
        {
            if (!(xOperacion.Equals("M") || xOperacion.Equals("A"))) { return; }
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                txtCuentaDebeTrans.Text = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0].Cuenta;
                txtCuentaDebeTrans.Focus();
            }
            frm = null;
        }

        private void btnCuentaHaberTrans_Click(object sender, EventArgs e)
        {
            if (!(xOperacion.Equals("M") || xOperacion.Equals("A"))) { return; }
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                txtCuentaHaberTrans.Text = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0].Cuenta;
                txtCuentaHaberTrans.Focus();
            }
            frm = null;
        }

        #endregion

        #region "==EventObjectDet=="

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Int64 nLinea = 0;
            if (LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Count() > 0){
                nLinea = (Int64) LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Max(p => p.Linea);
            }
            nLinea++;
            entCompCContable objE = new entCompCContable();            
            objE.Linea = nLinea;
            objE.Compania = fnConst.TextRaya3;
            objE.Estado = fnConst.EstadoActivoCod;
            objE.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            objE.RegExistente = fnEnum.RegExistente.No;
            objE.UsuarioSys = GlobalVar.UsuarioLogeo;
            objE.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
            objE.UltimaFechaMod = DateTime.Now;
            LstDet.Add(objE);
            objE = null;
            fxLinkDet();
            gvDetalle.Focus();
            gvDetalle.FocusedRowHandle = gvDetalle.RowCount - 1;
            gvDetalle.FocusedColumn = gvDetalle.Columns["CompaniaDet"];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0) { return; }
            entCompCContable oEnt = (entCompCContable)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            oEnt.RegVer = fnEnum.RegVer.No;
            oEnt.OperMantenimiento = (oEnt.OperMantenimiento == fnEnum.OperacionMant.Insertar) ? fnEnum.OperacionMant.Ninguno : fnEnum.OperacionMant.Eliminar;
            fxLinkDet();
        }

        private void gvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            entCompCContable objE = (entCompCContable)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            objE.RegEditado = fnEnum.RegEditado.Si;
            gvDetalle.UpdateCurrentRow();
            objE = null;
        }

        private void chkFlagTodasCompania_CheckedChanged(object sender, EventArgs e)
        {
            Boolean bFlagTCia = chkFlagTodasCompania.Checked;

            if (bFlagTCia) {
                List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
                foreach (entCompania oEnt in LstA){
                    if (LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si && x.Compania.Equals(oEnt.Compania)).Count() == 0){
                        Int64 nLinea = 0;
                        if (LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Count() > 0){
                            nLinea = (Int64)LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Max(p => p.Linea);
                        }
                        nLinea++;
                        entCompCContable objE = new entCompCContable();
                        objE.Linea = nLinea;
                        objE.Compania = oEnt.Compania.Trim();
                        objE.Estado = oEnt.Estado;
                        objE.OperMantenimiento = fnEnum.OperacionMant.Insertar;
                        objE.RegExistente = fnEnum.RegExistente.No;
                        objE.UsuarioSys = GlobalVar.UsuarioLogeo;
                        objE.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
                        objE.UltimaFechaMod = DateTime.Now;
                        LstDet.Add(objE);
                        objE = null;
                    }else{
                        oEnt.RegVer = fnEnum.RegVer.No;
                        oEnt.OperMantenimiento = (oEnt.OperMantenimiento == fnEnum.OperacionMant.Insertar) ? fnEnum.OperacionMant.Ninguno : fnEnum.OperacionMant.Eliminar;
                    }
                }
                fxLinkDet();
                LstA = null;
            }

            
        }

        #endregion

    }
}
