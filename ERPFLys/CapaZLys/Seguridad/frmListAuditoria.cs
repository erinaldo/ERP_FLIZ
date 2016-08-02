using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.Type;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace FiltroLys.ZLys.Seguridad
{
    public partial class frmListAuditoria : FiltroLys.ZLys.Controles.Formulario.frmList
    {
        #region "==EventForm=="

        public frmListAuditoria()
        {
            InitializeComponent();
        }

        private void frmListAuditoria_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxValoresDefault();           
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Usuario
            List<entUsuario> Lst = negUsuario.ListUsuarioXEstCombo(fnConst.StringPorc, fnConst.StringPorc, fnConst.TextSeleccioneNom);
            cmbUsuario.Properties.DataSource = Lst;
            cmbUsuario.Properties.DisplayMember = "Nombre";
            cmbUsuario.Properties.ValueMember = "CodigoUsuario";
            Lst = null;
        }

        private void fxValoresDefault()
        {
            txtFechaIni.DateTime = DateTime.Today;
            txtFechaFin.DateTime = DateTime.Today;
            cmbUsuario.EditValue = "%";
        }

        private Boolean fxValidarCriterio()
        {
            return true;
        }

        #endregion

        #region "==Event Object=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sUsuario;
            DateTime dFechaIni, dFechaFin;

            if (!fxValidarCriterio()) { return; }

            sUsuario = ((entUsuario)cmbUsuario.GetSelectedDataRow()).CodigoUsuario;
            dFechaIni = txtFechaIni.DateTime;
            dFechaFin = txtFechaFin.DateTime.AddDays(1).AddSeconds(-1);

            List<entAuditoria> Ls = negAuditoria.ListAuditoria(new entAuditoria()
            {
                CodigoUsuario = sUsuario,
                FechaInicio = dFechaIni,
                FechaTermino = dFechaFin
            });

            grControl.DataSource = Ls;     
            
        }

        #endregion

    }
}
