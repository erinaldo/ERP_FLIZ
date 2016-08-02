using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.ModContabilidad;

namespace FiltroLys.ZLys.Inicio
{
    public partial class frmInicioContabilidad : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==EventForm=="

        public frmInicioContabilidad()
        {
            InitializeComponent();
        }

        private void frmInicioContabilidad_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region "==EventObject=="

        private void btnListVoucher_Click(object sender, EventArgs e)
        {
            frmVoucherList frm = new frmVoucherList();
            fnAddTab.FormOpen(frm);
        }

        private void btnMayorizacion_Click(object sender, EventArgs e)
        {
            frmMayorizacionList frm = new frmMayorizacionList();
            frm.ShowDialog();            
        }        

        private void btnSaldoCuenta_Click(object sender, EventArgs e)
        {
            frmSaldoxCuenta frm = new frmSaldoxCuenta();
            fnAddTab.FormOpen(frm);
        }

        private void btnCierreMes_Click(object sender, EventArgs e)
        {
            frmCierreMensual frm = new frmCierreMensual();
            frm.ShowDialog();
        }

        private void btnCierreAnual_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarPeriodo_Click(object sender, EventArgs e)
        {
            frmSelPeriodoTrabajo frm = new frmSelPeriodoTrabajo();
            frm.ShowDialog();
        }

        private void btnBloquearPeriodo_Click(object sender, EventArgs e)
        {
            frmBloqPeriodoTrabajo frm = new frmBloqPeriodoTrabajo();
            frm.ShowDialog();
        }

        #endregion
    }
}
