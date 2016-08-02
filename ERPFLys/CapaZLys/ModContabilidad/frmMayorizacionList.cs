using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmMayorizacionList : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {
        #region "==Propiedades=="

        private String sCia, sPer, sTPro, sCiaF;
        private Boolean bInicio;

        public String XCompaniaReg
        {
            get { return sCia; }
            set { sCia = value; }
        }

        public String XPeriodoReg
        {
            get { return sPer; }
            set { sPer = value; }
        }

        public String XCompaniaFil
        {
            get { return sCiaF; }
            set { sCiaF = value; }
        }

        public String XProcesoFil
        {
            get { return sTPro; }
            set { sTPro = value; }
        }

        public Boolean XInicioAnt
        {
            get { return bInicio; }
            set { bInicio = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmMayorizacionList()
        {
            InitializeComponent();
        }

        private void frmMayorizacionList_Load(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxCargarCombos();
            fxSetearDatos();
            fxCargarLista();
            fxAddEvent();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxQuitEvent()
        {
            cmbCompania.EditValueChanged -= new System.EventHandler(this.cmbCompania_EditValueChanged);
        }

        private void fxAddEvent()
        {
            cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXAppXUsu(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringT, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;

            //Proceso
            List<entComboList> Lst2 = new List<entComboList>();
            Lst2.Add(new entComboList() { Codigo = fnConst.StringT, Nombre = fnConst.TextSeleccioneNom });
            Lst2.Add(new entComboList() { Codigo = fnConst.MayorizacionCod, Nombre = fnConst.MayorizacionNom });
            Lst2.Add(new entComboList() { Codigo = fnConst.DesMayorizacionCod, Nombre = fnConst.DesMayorizacionNom });
            cmbProceso.Properties.DataSource = Lst2;
            cmbProceso.Properties.DisplayMember = "Nombre";
            cmbProceso.Properties.ValueMember = "Codigo";            
            Lst2 = null;
        }

        private void fxCargarLista()
        {
            String xcia = cmbCompania.EditValue.ToString();
            xcia = (xcia.Length > 0) ? xcia : "%";
            List<entPeriodoCia> Lst = negPeriodoCia.ListaSearch(xcia, fnConst.StringPorc, fnConst.ModContabilidadCod, fnConst.StringA, fnConst.StringPorc, fnConst.StringPorc);
            grControl.DataSource = Lst;            
        }

        private void fxSetearDatos()
        {
            if (XInicioAnt){
                cmbCompania.EditValue = XCompaniaFil;
                cmbProceso.EditValue = XProcesoFil;
            }
            else {
                cmbCompania.EditValue = fnConst.TextVacio;
                cmbProceso.EditValue = fnConst.StringT;
            }
        }

        #endregion

        #region "==EventObject=="

        private void cmbCompania_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void gvDatos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                int cont = 0, row = 0;
                cont = gvDatos.DataRowCount;
                if (cont == 0) { return; }
                row = gvDatos.SelectedRowsCount;
                if (row == 0) { return; }

                String CiaX = (cmbCompania.EditValue != null) ? cmbCompania.EditValue.ToString() : "T";
                String TipoProc = cmbProceso.EditValue.ToString();
                entPeriodoCia objE = (entPeriodoCia)gvDatos.GetRow(gvDatos.FocusedRowHandle);

                if (TipoProc.Equals("T")){
                    fnMensaje.MensajeInfo("Seleccionar Tipo de Proceso por favor.");
                    return;
                }

                if (XInicioAnt){
                    XCompaniaReg = objE.Compania;
                    XPeriodoReg = objE.Periodo;
                    XCompaniaFil = CiaX;
                    XProcesoFil = TipoProc;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }else{
                    ModContabilidad.frmMayorizacionGene frm = new ModContabilidad.frmMayorizacionGene();
                    frm.XCompaniaReg = objE.Compania;
                    frm.XPeriodoReg = objE.Periodo;
                    frm.XCompaniaFil = CiaX;
                    frm.XProcesoFil = TipoProc;
                    Funciones.fnAddTab.FormOpen(frm, "Procesar");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #endregion

    }
}
