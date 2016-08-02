namespace FiltroLys.ZLys.ModReporte
{
    partial class frmReportesMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.tvReporte = new DevExpress.XtraTreeList.TreeList();
            this.tlcNombreReporte = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgAll = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiltrarPor = new DevExpress.XtraEditors.TextEdit();
            this.btnEjecutar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrarPor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnEjecutar);
            this.pnMain.Controls.Add(this.txtFiltrarPor);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Controls.Add(this.tvReporte);
            this.pnMain.Controls.Add(this.btnFiltrar);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Size = new System.Drawing.Size(613, 404);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTES DEL SISTEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(486, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(73, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tvReporte
            // 
            this.tvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvReporte.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcNombreReporte,
            this.tlcDescripcion});
            this.tvReporte.Location = new System.Drawing.Point(8, 57);
            this.tvReporte.Name = "tvReporte";
            this.tvReporte.OptionsBehavior.Editable = false;
            this.tvReporte.OptionsBehavior.EnableFiltering = true;
            this.tvReporte.OptionsBehavior.ReadOnly = true;
            this.tvReporte.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended;
            this.tvReporte.OptionsFind.AllowFindPanel = true;
            this.tvReporte.OptionsView.ShowHorzLines = false;
            this.tvReporte.SelectImageList = this.imgAll;
            this.tvReporte.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.tvReporte.Size = new System.Drawing.Size(600, 339);
            this.tvReporte.TabIndex = 14;
            this.tvReporte.TreeLevelWidth = 12;
            this.tvReporte.DoubleClick += new System.EventHandler(this.tvReporte_DoubleClick);
            // 
            // tlcNombreReporte
            // 
            this.tlcNombreReporte.Caption = "Nombre";
            this.tlcNombreReporte.FieldName = "NombreReporte";
            this.tlcNombreReporte.MinWidth = 33;
            this.tlcNombreReporte.Name = "tlcNombreReporte";
            this.tlcNombreReporte.OptionsColumn.FixedWidth = true;
            this.tlcNombreReporte.Visible = true;
            this.tlcNombreReporte.VisibleIndex = 0;
            this.tlcNombreReporte.Width = 320;
            // 
            // tlcDescripcion
            // 
            this.tlcDescripcion.Caption = "Descripcion";
            this.tlcDescripcion.FieldName = "Descripcion";
            this.tlcDescripcion.Name = "tlcDescripcion";
            this.tlcDescripcion.Visible = true;
            this.tlcDescripcion.VisibleIndex = 1;
            this.tlcDescripcion.Width = 500;
            // 
            // imgAll
            // 
            this.imgAll.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgAll.ImageStream")));
            this.imgAll.InsertGalleryImage("freezetoprow_16x16.png", "images/spreadsheet/freezetoprow_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/freezetoprow_16x16.png"), 0);
            this.imgAll.Images.SetKeyName(0, "freezetoprow_16x16.png");
            this.imgAll.InsertGalleryImage("touchmode_16x16.png", "images/mode/touchmode_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mode/touchmode_16x16.png"), 1);
            this.imgAll.Images.SetKeyName(1, "touchmode_16x16.png");
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Texto a Filtrar";
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Location = new System.Drawing.Point(79, 34);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltrarPor.Size = new System.Drawing.Size(328, 20);
            this.txtFiltrarPor.TabIndex = 16;
            this.txtFiltrarPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltrarPor_KeyDown);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutar.Image")));
            this.btnEjecutar.Location = new System.Drawing.Point(410, 32);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(73, 23);
            this.btnEjecutar.TabIndex = 17;
            this.btnEjecutar.Text = "&Ejecutar";
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmReportesMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(613, 404);
            this.Name = "frmReportesMain";
            this.Text = "Reportes del Sistema";
            this.Load += new System.EventHandler(this.frmReportesMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrarPor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraTreeList.TreeList tvReporte;
        private DevExpress.Utils.ImageCollection imgAll;
        protected DevExpress.XtraEditors.SimpleButton btnEjecutar;
        private DevExpress.XtraEditors.TextEdit txtFiltrarPor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcNombreReporte;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDescripcion;
    }
}
