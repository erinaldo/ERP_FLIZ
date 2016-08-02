namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmCierreMensual
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreMensual));
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProceso = new DevExpress.XtraEditors.MemoEdit();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbrir = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetalle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProceso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnDetalle);
            this.pnMain.Controls.Add(this.btnAbrir);
            this.pnMain.Controls.Add(this.btnCerrar);
            this.pnMain.Controls.Add(this.txtProceso);
            this.pnMain.Controls.Add(this.labelControl2);
            this.pnMain.Controls.Add(this.txtPeriodo);
            this.pnMain.Controls.Add(this.cmbCompania);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Size = new System.Drawing.Size(476, 372);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(67, 31);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodo.TabIndex = 11;
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(67, 8);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(214, 20);
            this.cmbCompania.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Compañía:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(11, 55);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(453, 310);
            this.txtProceso.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(137, 30);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(211, 30);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(70, 23);
            this.btnAbrir.TabIndex = 15;
            this.btnAbrir.Text = "&Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalle.Image")));
            this.btnDetalle.Location = new System.Drawing.Point(394, 30);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(70, 23);
            this.btnDetalle.TabIndex = 16;
            this.btnDetalle.Text = "&Detalle";
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmCierreMensual
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(476, 372);
            this.Name = "frmCierreMensual";
            this.Text = "Cierre Mensual";
            this.Load += new System.EventHandler(this.frmCierreMensual_Load);
            this.Shown += new System.EventHandler(this.frmCierreMensual_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProceso.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtProceso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        protected DevExpress.XtraEditors.SimpleButton btnCerrar;
        protected DevExpress.XtraEditors.SimpleButton btnAbrir;
        protected DevExpress.XtraEditors.SimpleButton btnDetalle;
    }
}
