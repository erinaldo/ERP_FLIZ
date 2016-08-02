using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Busqueda.General
{
    public partial class frmBusqCtaContable : FiltroLys.ZLys.Busqueda.General.frmBusqMain
    {
        #region "==EventForm=="

        public frmBusqCtaContable()
        {
            InitializeComponent();
        }

        private void frmBusqCtaContable_Load(object sender, EventArgs e)
        {
            fxCargarCombosDetalle();
            fxValoresDefault();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxValoresDefault()
        {
            gvDatos.OptionsSelection.MultiSelect = MultipleSelect;
            chkActivo.Enabled = !SoloActivo;
        }

        private void fxCargarLista() {
            String sCodigo = txtCodigo.Text.Trim();
            String sNombre = txtDescripcion.Text.Trim();
            String sEstado = (chkActivo.Checked) ? "A" : "%";

            sCodigo = (sCodigo.Length > 0) ? sCodigo + "%" : "%";
            sNombre = "%" + sNombre + "%";
            grControl.DataSource = negCuentaContable.ListaSearch(sCodigo, sNombre, sEstado);
        }

        private void fxRecuperarData(){
            if (gvDatos.SelectedRowsCount == 0) { return; }
            List<entCuentaContable> Lst = new List<entCuentaContable>();
            int[] rowSel = gvDatos.GetSelectedRows();
            for (int i = 0; i < rowSel.Length; i++){
                Lst.Add((entCuentaContable)gvDatos.GetRow(rowSel[i]));
            }
            EstructuraForm.ObjX = Funciones.fnConvert.EntityToObject<entCuentaContable, Object>(Lst);
            this.DialogResult = DialogResult.OK;
        }

        private void fxCargarCombosDetalle(){

            //Estado
            List<entComboList> LstA = fnListasDat.ListEstadoF1();
            rilueEstado.DataSource = LstA;
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
            LstA = null;
        }

        #endregion

        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fxCargarLista();
            if (gvDatos.RowCount > 0){
                gvDatos.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            fxRecuperarData();
        }

        private void gvDatos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2){
                if (MultipleSelect == false){
                    fxRecuperarData();
                }
            }
        }

        private void gvDatos_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter){
                e.SuppressKeyPress = true;
                if (MultipleSelect == false){
                    fxRecuperarData();
                }
            }
        }

        #endregion

    }
}
