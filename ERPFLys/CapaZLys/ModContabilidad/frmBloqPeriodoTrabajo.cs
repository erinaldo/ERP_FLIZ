using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;
using DevExpress.XtraGrid.Views.Grid;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmBloqPeriodoTrabajo : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {
        #region "==EventForm=="

        public frmBloqPeriodoTrabajo()
        {
            InitializeComponent();
        }

        private void frmBloqPeriodoTrabajo_Load(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxAddEvent();
        }

        private void frmBloqPeriodoTrabajo_Shown(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxSetearDatos();
            fxAddEvent();
            fxCargarLista();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxQuitEvent()
        {
            cmbCompania.EditValueChanged -= new System.EventHandler(this.cmbCompania_EditValueChanged);
            chkSoloBloqueados.CheckedChanged -= new EventHandler(chkSoloBloqueados_CheckedChanged);
            chkEstado.CheckedChanged -= new EventHandler(chkEstado_CheckedChanged);
        }

        private void fxAddEvent()
        {
            cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            chkSoloBloqueados.CheckedChanged += new EventHandler(chkSoloBloqueados_CheckedChanged);
            chkEstado.CheckedChanged += new EventHandler(chkEstado_CheckedChanged);
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXAppXUsu(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringN, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxCargarCombosDetalle()
        {
            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF2();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
        }

        private void fxSetearDatos()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : "";
            chkSoloBloqueados.Checked = false;
            chkEstado.Checked = true;
        }

        private void fxCargarLista()
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sBlo = (chkSoloBloqueados.Checked) ? "S" : "%";
            String sEst = (chkEstado.Checked) ? "A" : "%";

            List<entPeriodoCia> Lst = negPeriodoCia.ListaSearch(sCia, fnConst.StringPorc, fnConst.ModContabilidadCod, sEst, sBlo, fnConst.StringPorc);
            grControl.DataSource = Lst;
            Lst = null;            
        }

        private Boolean fxPreUpdate()
        {
            for(int i=1;i<gvDatos.DataRowCount;i++){
                entPeriodoCia oEnt = (entPeriodoCia)gvDatos.GetRow(i);
                if (oEnt.FlagBloqueo.Equals("S")){
                    int nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, oEnt.Compania, oEnt.Periodo);
                    if (nResult <= 0){
                        fnMensaje.MensajeInfo("Periodo no existe o se encuentra cerrado " + oEnt.Periodo.Substring(0, 4) + "-" + oEnt.Periodo.Substring(4, 2) + ". No se puede continuar.");
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion

        #region "==EventObject=="

        private void cmbCompania_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void chkSoloBloqueados_CheckedChanged(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!fxPreUpdate()) { return; }
            List<entPeriodoCia> oData = new List<entPeriodoCia>();
            for (int i = 1; i < gvDatos.DataRowCount;i++){
                oData.Add((entPeriodoCia)gvDatos.GetRow(i));
            }
            entErrores oErr = negPeriodoCia.MantBloqueoPeriodo(oData);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo("[" + oErr.Errores[0].Codigo + "] - " + oErr.Errores[0].Descripcion);
                return;
            }
            fnMensaje.MensajeInfo("Información fue guardada exitosamente.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDatos_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            entPeriodoCia oEnt = (entPeriodoCia)gvDatos.GetRow(view.FocusedRowHandle);
            if (view.FocusedColumn.FieldName == "FlagBloqueo" && oEnt.Estado.Equals("C")){
                e.Cancel = true;
            }
        }

        #endregion
    }
}
