using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using FiltroLys.ZLys.Inicio;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmMayorizacionGene : FiltroLys.ZLys.Controles.Formulario.frmList
    {

        #region "==Propiedades=="

        private String sCia, sPer, sTPro, sCiaF;
        private Decimal nTotLocal, nTotExt;
        private frmProgresoBar frmPB = null;

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

        #endregion

        #region "==EventForm=="

        public frmMayorizacionGene()
        {
            InitializeComponent();
        }

        private void frmMayorizacionGene_Load(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxSetearDatos();
            fxCargarLista();
            fxAddEvent();
        }

        #endregion

        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmMayorizacionList frm = new frmMayorizacionList();
            frm.XInicioAnt = true;
            frm.XCompaniaFil = XCompaniaFil;
            frm.XProcesoFil = XProcesoFil;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XCompaniaReg = frm.XCompaniaReg;
                XPeriodoReg = frm.XPeriodoReg;
                XCompaniaFil = frm.XCompaniaFil;
                XProcesoFil = frm.XProcesoFil;
                fxSetearDatos();
                fxCargarLista();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (gvDatos.SelectedRowsCount > 0){
                if (MessageBox.Show("Procesará información, desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                    frmPB = new frmProgresoBar();
                    frmPB.Proceso = ProcesarDatos;
                    frmPB.StepPB = 1;
                    frmPB.TextoProgreso = "Avance del";
                    frmPB.VerTitle = false;
                    frmPB.MaximoValor = 100;
                    frmPB.ShowDialog();
                    fxCargarLista();
                }
            }
            else
            {
                fnMensaje.MensajeInfo("No existen registros seleccionados.");
            }
        }

        private void chkSelTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelTodos.Checked)
                gvDatos.SelectRows(0, gvDatos.DataRowCount - 1);
            else{
                gvDatos.ClearSelection();
            }
        }

        private void gvDatos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2){
                int cont = 0; String tagFrm = "";
                String sCia = "", sPer = "", sTV = "", sNro = "";
                cont = gvDatos.DataRowCount;
                if (cont == 0) { return; }

                entVoucher objT = (entVoucher)gvDatos.GetRow(e.RowHandle);
                sCia = objT.Compania;
                sPer = objT.Periodo;
                sTV = objT.TipoVoucher;
                sNro = objT.NumeroVoucher;
                objT = null;

                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "V";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "Ver";
                fnAddTab.FormOpen(frm, tagFrm);
            }
        }

        private void gvDatos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gvDatos.UpdateTotalSummary();
        }

        private void gvDatos_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridSummaryItem xColumn = (GridSummaryItem)e.Item;
            GridView view = (GridView)sender;

            //Inicio Variables
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start){
                nTotLocal = 0;
                nTotExt = 0;
            }

            //Calculado
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                Decimal xLocal = (Decimal)view.GetRowCellValue(e.RowHandle, "MontoLocal");
                Decimal xExt = (Decimal)view.GetRowCellValue(e.RowHandle, "MontoExt");

                if(view.IsRowSelected(e.RowHandle)){
                    nTotLocal = nTotLocal + xLocal;
                    nTotExt = nTotExt + xExt;
                }
            }

            //Finaliacion
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                switch (xColumn.FieldName)
                {
                    case "MontoLocal":
                        e.TotalValue = nTotLocal.ToString("N2");
                        break;
                    case "MontoExt":
                        e.TotalValue = nTotExt.ToString("N2");
                        break;                    
                }
            }
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxQuitEvent()
        {
        }

        private void fxAddEvent()
        {
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCompaniaForm(fnConst.StringT,fnConst.StringT,fnConst.StringPorc);
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

        private void fxCargarCombosDetalle()
        {
            //Moneda
            List<entComboList> LstA = new List<entComboList>();
            LstA.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            LstA.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            
            rilueMoneda.DataSource = LstA;
            rilueMoneda.DisplayMember = "Nombre";
            rilueMoneda.ValueMember = "Codigo";
            LstA = null;

            //Origen
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = fnConst.ManualMNCod, Nombre = fnConst.ManualMNNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModActivoFijoCod, Nombre = fnConst.ModActivoFijoNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModComercialCod, Nombre = fnConst.ModComercialNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModContabilidadCod, Nombre = fnConst.ModContabilidadNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModLogisticaCod, Nombre = fnConst.ModLogisticaNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModProduccionCod, Nombre = fnConst.ModProduccionNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModRRHHCod, Nombre = fnConst.ModRRHHNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModTesoreriaCod, Nombre = fnConst.ModTesoreriaNom });

            rilueOrigen.DataSource = LstB;
            rilueOrigen.DisplayMember = "Nombre";
            rilueOrigen.ValueMember = "Codigo";
            LstB = null;

        }

        private void fxSetearDatos()
        {
            cmbCompania.EditValue = XCompaniaReg;            
            cmbProceso.EditValue = XProcesoFil;
            txtPeriodoProc.Text = XPeriodoReg.Substring(0, 4) + "-" + XPeriodoReg.Substring(4, 2);
            String xPerAct = negPeriodoCia.GetPerTrabajo(XCompaniaReg, fnConst.ModContabilidadCod);
            if (xPerAct.Length > 0){
                txtPeriodoAct.Text = xPerAct.Substring(0, 4) + "-" + xPerAct.Substring(4, 2);
            }
        }

        private void fxCargarLista()
        {
            String sEst = XProcesoFil.Equals("M") ? "PE" : "AP";
            List<entVoucher> Lst = negVoucher.ListVoucherToMayor(XCompaniaReg, XPeriodoReg, sEst);
            grControl.DataSource = Lst;
            gvDatos.UnselectRow(0);            
        }

        private void ProcesarDatos(object sender, DoWorkEventArgs e)
        {
            List<entVoucher> objDat = new List<entVoucher>();
            int[] rowSel = gvDatos.GetSelectedRows();
            for (int i = 0; i < rowSel.Length; i++){
                entVoucher objT = (entVoucher)gvDatos.GetRow(rowSel[i]);
                objT.OperMantenimiento = XProcesoFil.Equals("M") ? fnEnum.OperacionMant.Aprobar : fnEnum.OperacionMant.Pendiente;
                objT.UsuarioSys = GlobalVar.UsuarioLogeo;
                objDat.Add(objT);
            }

            if (objDat.Count > 0){
                BackgroundWorker worker = sender as BackgroundWorker;
                entErrores err = negVoucher.MantVoucher(objDat, ref worker);
                if (err.Resultado == false){
                    fnMensaje.MensajeInfo(err.Errores[0].Descripcion);
                    return;
                }
            }
        }

        #endregion
                         
    }
}
