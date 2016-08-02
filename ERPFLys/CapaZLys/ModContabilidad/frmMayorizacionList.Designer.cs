namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmMayorizacionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMayorizacionList));
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProceso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.gvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Compania = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompaniaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.labelControl3);
            this.pnMain.Controls.Add(this.grControl);
            this.pnMain.Controls.Add(this.btnCancelar);
            this.pnMain.Controls.Add(this.cmbProceso);
            this.pnMain.Controls.Add(this.labelControl2);
            this.pnMain.Controls.Add(this.cmbCompania);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Size = new System.Drawing.Size(476, 372);
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(62, 8);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(144, 20);
            this.cmbCompania.TabIndex = 3;
            this.cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Compañía:";
            // 
            // cmbProceso
            // 
            this.cmbProceso.Location = new System.Drawing.Point(263, 8);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProceso.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbProceso.Properties.PopupWidth = 250;
            this.cmbProceso.Size = new System.Drawing.Size(91, 20);
            this.cmbProceso.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(217, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Proceso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(400, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grControl
            // 
            this.grControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControl.Location = new System.Drawing.Point(5, 49);
            this.grControl.MainView = this.gvDatos;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(466, 318);
            this.grControl.TabIndex = 12;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatos});
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Compania,
            this.CompaniaNombre,
            this.Periodo});
            this.gvDatos.GridControl = this.grControl;
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
            // 
            // Compania
            // 
            this.Compania.Caption = "Compania";
            this.Compania.FieldName = "Compania";
            this.Compania.Name = "Compania";
            this.Compania.Visible = true;
            this.Compania.VisibleIndex = 0;
            // 
            // CompaniaNombre
            // 
            this.CompaniaNombre.Caption = "Nombre Compania";
            this.CompaniaNombre.FieldName = "CompaniaNombre";
            this.CompaniaNombre.Name = "CompaniaNombre";
            this.CompaniaNombre.Visible = true;
            this.CompaniaNombre.VisibleIndex = 1;
            this.CompaniaNombre.Width = 286;
            // 
            // Periodo
            // 
            this.Periodo.Caption = "Periodo";
            this.Periodo.FieldName = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.Visible = true;
            this.Periodo.VisibleIndex = 2;
            this.Periodo.Width = 66;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(244, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Seleccionar un registro y doble click para operación";
            // 
            // frmMayorizacionList
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(476, 372);
            this.Name = "frmMayorizacionList";
            this.Text = "Compañia - Periodo - Pendiente";
            this.Load += new System.EventHandler(this.frmMayorizacionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbProceso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        protected DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        protected DevExpress.XtraGrid.GridControl grControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatos;
        private DevExpress.XtraGrid.Columns.GridColumn Compania;
        private DevExpress.XtraGrid.Columns.GridColumn CompaniaNombre;
        private DevExpress.XtraGrid.Columns.GridColumn Periodo;
    }
}
