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

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmSaldoxCuentaDet : FiltroLys.ZLys.Controles.Formulario.frmList
    {

        #region "==Propiedades=="

        private entEstructForm xestruct = new entEstructForm();
        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmSaldoxCuentaDet()
        {
            InitializeComponent();
        }

        private void frmSaldoxCuentaDet_Load(object sender, EventArgs e)
        {
            fxCargarCombos();            
        }

        private void frmSaldoxCuentaDet_Shown(object sender, EventArgs e)
        {
            fxSetearDatos();
            fxCargarLista();
        }

        #endregion

        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void gvDatos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2){
                int cont = 0; String tagFrm = "";
                String sCia = "", sPer = "", sTV = "", sNro = "";
                cont = gvDatos.DataRowCount;
                if (cont == 0) { return; }

                entVoucherDet objT = (entVoucherDet)gvDatos.GetRow(e.RowHandle);
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

        private void gvDatos_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.CellValue is Decimal && (Decimal)e.CellValue < 0)
                e.Appearance.ForeColor = Color.Red;
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCompaniaForm("T", "T", "%");
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxCargarLista()
        {
            String scia = cmbCompania.EditValue.ToString();
            String sper = txtPeriodo.Text.Replace("-", "");
            String scta = txtCuenta.Text.Trim();

            List<entVoucherDet> Lst = negVoucher.ListVoucherDetCiaPerCuenta(scia, sper, scta);
            grControl.DataSource = Lst;
            Lst = null;
        }

        private void fxSetearDatos()
        {
            cmbCompania.EditValue = this.EstructuraForm.StrX[0];
            txtPeriodo.Text = this.EstructuraForm.StrX[1];
            txtCuenta.Text = this.EstructuraForm.StrX[2];
            txtCuentaNombre.Text = this.EstructuraForm.StrX[3];            
        }

        #endregion

    }
}
