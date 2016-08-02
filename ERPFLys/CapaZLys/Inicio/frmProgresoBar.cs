using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiltroLys.ZLys.Inicio
{
    public partial class frmProgresoBar : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {

        #region "==Propiedades=="

        private DoWorkEventHandler oProceso;
        private String sTextoProgreso = String.Empty;
        private Boolean bVerTitle = true;
        private Int32 nMax = 100;
        private Int32 nStep = 1;

        public DoWorkEventHandler Proceso
        {
            get { return oProceso; }
            set { oProceso = value; }
        }

        public String TextoProgreso
        {
            get { return sTextoProgreso; }
            set { sTextoProgreso = value; }
        }

        public Boolean VerTitle
        {
            get { return bVerTitle; }
            set { bVerTitle = value; }
        }

        public Int32 MaximoValor
        {
            get { return nMax; }
            set { nMax = value; }
        }

        public Int32 StepPB
        {
            get { return nStep; }
            set { nStep = value; }
        }

        #endregion

        #region "==Event Form=="

        public frmProgresoBar()
        {
            InitializeComponent();
        }

        private void frmProgresoBar_Load(object sender, EventArgs e)
        {
            barAvance.Properties.Step = StepPB;
            barAvance.Properties.PercentView = true;
            barAvance.Properties.Maximum = MaximoValor;
            barAvance.Properties.Minimum = 0;
            barAvance.Text = " " + sTextoProgreso + " 1%";
            lblTitulo.Text = " " + sTextoProgreso + " 1%";
            bWorker.DoWork += Proceso;

            if (VerTitle){
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }else{
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            bWorker.RunWorkerAsync();
        }

        #endregion

        #region "==Event Proces=="

        private void bWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int nPorc = e.ProgressPercentage;
            barAvance.EditValue = nPorc;
            barAvance.Refresh();
            
            barAvance.Text = " " + sTextoProgreso + " " + nPorc.ToString() + "%";
            lblTitulo.Text = " " + sTextoProgreso + " " + nPorc.ToString() + "%";
            barAvance.Update();
            barAvance.PerformStep();
        }

        private void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
