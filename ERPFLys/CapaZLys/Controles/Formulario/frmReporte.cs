using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace FiltroLys.ZLys.Controles.Formulario
{
    public partial class frmReporte : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==Propiedades=="

        protected String xQuery = "";

        #endregion

        #region "==EventForm=="

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmRptLibroDiario_Load(object sender, EventArgs e){}

        #endregion
        
        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (uf_validarBuscar()){
                try{
                    SplashScreenManager.ShowForm(this, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
                    ue_Buscar();
                }finally{
                    SplashScreenManager.CloseForm(false);
                }
            }
        }

        private void ppbiExpExcelDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (uf_validarExpExcel()){
                try{
                    SplashScreenManager.ShowForm(this, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
                    ue_ExportarDat();
                }finally{
                    SplashScreenManager.CloseForm(false);
                }
            }
        }

        private void dvReport_DocumentChanged(object sender, EventArgs e)
        {
            ue_DocumentChanged();
        }

        #endregion

        #region "==EventInherit=="

        public virtual Boolean uf_validarBuscar() {
            return true;
        }
        public virtual Boolean uf_validarExpExcel(){
            if (String.IsNullOrEmpty(xQuery)) { return false; }
            return true;
        }
        public virtual void ue_Buscar() {
            
        }
        public virtual void ue_ExportarDat() { 

        }
        public virtual void ue_DocumentChanged() {
            ppbiExpExcelDat.Enabled = true;
        }

        #endregion

    }
}
