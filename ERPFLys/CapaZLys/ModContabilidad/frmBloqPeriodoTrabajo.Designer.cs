namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmBloqPeriodoTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBloqPeriodoTrabajo));
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.gvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.FlagBloqueo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlagBloqueo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.chkSoloBloqueados = new DevExpress.XtraEditors.CheckEdit();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagBloqueo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSoloBloqueados.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnGrabar);
            this.pnMain.Controls.Add(this.btnCerrar);
            this.pnMain.Controls.Add(this.chkEstado);
            this.pnMain.Controls.Add(this.chkSoloBloqueados);
            this.pnMain.Controls.Add(this.grControl);
            this.pnMain.Controls.Add(this.cmbCompania);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Size = new System.Drawing.Size(317, 373);
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(61, 6);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(247, 20);
            this.cmbCompania.TabIndex = 0;
            this.cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Compañía:";
            // 
            // grControl
            // 
            this.grControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControl.Location = new System.Drawing.Point(7, 54);
            this.grControl.MainView = this.gvDatos;
            this.grControl.Name = "grControl";
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.rilueEstado,
            this.riceFlagBloqueo});
            this.grControl.Size = new System.Drawing.Size(304, 278);
            this.grControl.TabIndex = 3;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatos});
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Periodo,
            this.Estado,
            this.FlagBloqueo});
            this.gvDatos.GridControl = this.grControl;
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvDatos_ShowingEditor);
            // 
            // Periodo
            // 
            this.Periodo.AppearanceCell.Options.UseTextOptions = true;
            this.Periodo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Periodo.Caption = "Periodo";
            this.Periodo.FieldName = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.OptionsColumn.AllowEdit = false;
            this.Periodo.OptionsColumn.ReadOnly = true;
            this.Periodo.Visible = true;
            this.Periodo.VisibleIndex = 0;
            this.Periodo.Width = 72;
            // 
            // Estado
            // 
            this.Estado.AppearanceCell.Options.UseTextOptions = true;
            this.Estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.OptionsColumn.ReadOnly = true;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 1;
            this.Estado.Width = 106;
            // 
            // rilueEstado
            // 
            this.rilueEstado.AutoHeight = false;
            this.rilueEstado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueEstado.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueEstado.Name = "rilueEstado";
            // 
            // FlagBloqueo
            // 
            this.FlagBloqueo.AppearanceCell.Options.UseTextOptions = true;
            this.FlagBloqueo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagBloqueo.Caption = "Bloqueado";
            this.FlagBloqueo.ColumnEdit = this.riceFlagBloqueo;
            this.FlagBloqueo.FieldName = "FlagBloqueo";
            this.FlagBloqueo.Name = "FlagBloqueo";
            this.FlagBloqueo.Visible = true;
            this.FlagBloqueo.VisibleIndex = 2;
            this.FlagBloqueo.Width = 89;
            // 
            // riceFlagBloqueo
            // 
            this.riceFlagBloqueo.AutoHeight = false;
            this.riceFlagBloqueo.Name = "riceFlagBloqueo";
            this.riceFlagBloqueo.ValueChecked = "S";
            this.riceFlagBloqueo.ValueUnchecked = "N";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // chkEstado
            // 
            this.chkEstado.EditValue = true;
            this.chkEstado.Location = new System.Drawing.Point(109, 29);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Solo Abiertos";
            this.chkEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEstado.Size = new System.Drawing.Size(90, 19);
            this.chkEstado.TabIndex = 1;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // chkSoloBloqueados
            // 
            this.chkSoloBloqueados.Location = new System.Drawing.Point(205, 29);
            this.chkSoloBloqueados.Name = "chkSoloBloqueados";
            this.chkSoloBloqueados.Properties.Caption = "Solo Bloqueados";
            this.chkSoloBloqueados.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSoloBloqueados.Size = new System.Drawing.Size(106, 19);
            this.chkSoloBloqueados.TabIndex = 2;
            this.chkSoloBloqueados.CheckedChanged += new System.EventHandler(this.chkSoloBloqueados_CheckedChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(66, 338);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(91, 23);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(161, 338);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBloqPeriodoTrabajo
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(317, 373);
            this.Name = "frmBloqPeriodoTrabajo";
            this.Text = "Bloquear Periodo de Trabajo";
            this.Load += new System.EventHandler(this.frmBloqPeriodoTrabajo_Load);
            this.Shown += new System.EventHandler(this.frmBloqPeriodoTrabajo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagBloqueo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSoloBloqueados.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraGrid.GridControl grControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatos;
        private DevExpress.XtraGrid.Columns.GridColumn Periodo;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.CheckEdit chkSoloBloqueados;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn FlagBloqueo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagBloqueo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        protected DevExpress.XtraEditors.SimpleButton btnGrabar;
        protected DevExpress.XtraEditors.SimpleButton btnCerrar;
    }
}
