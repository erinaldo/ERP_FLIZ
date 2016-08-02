using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using System.Linq;

namespace FiltroLys.ZLys.Controles.Formulario
{
    public partial class frmMaestro : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==Propiedades=="

        private fnEnum.PanelFormMaestros nPanelForm = fnEnum.PanelFormMaestros.PanelAll;
        private Boolean bIntoPanel = false;
        private String sModulo = "", sNiveles = "";

        public fnEnum.PanelFormMaestros PanelForm
        {
            get { return nPanelForm; }
            set { nPanelForm = value; }
        }

        public Boolean IntoOfPanel
        {
            get { return bIntoPanel; }
            set { bIntoPanel = value; }
        }

        public String Modulo
        {
            get { return sModulo; }
            set { sModulo = value; }
        }

        public String Niveles
        {
            get { return sNiveles; }
            set { sNiveles = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmMaestro()
        {
            InitializeComponent();
        }

        private void frmMaestro_Load(object sender, EventArgs e)
        {
            if (bIntoPanel){
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
                nPanelForm = fnEnum.PanelFormMaestros.PanelList;
            }
            if (nPanelForm == fnEnum.PanelFormMaestros.PanelList) { pnlMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1; }
            if (nPanelForm == fnEnum.PanelFormMaestros.PanelMant) { pnlMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2; }
        }

        #endregion

        #region "==EventHereda=="

        public virtual void ue_nuevo() { }
        public virtual void ue_modificar() { }
        public virtual void ue_eliminar() { }
        public virtual void ue_ver() { }
        public virtual void ue_guardar() { }
        public virtual void ue_cancelar() { }

        #endregion

        #region "==EventObject=="

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ue_guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ue_cancelar();
        }

        #endregion

    }
}
