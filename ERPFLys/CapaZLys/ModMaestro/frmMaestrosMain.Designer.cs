namespace FiltroLys.ZLys.ModMaestro
{
    partial class frmMaestrosMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaestrosMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVer = new DevExpress.XtraEditors.SimpleButton();
            this.tvMaestro = new DevExpress.XtraTreeList.TreeList();
            this.tlcMaestro = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgAll = new DevExpress.Utils.ImageCollection(this.components);
            this.pnlContenedor = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnlContenedor);
            this.pnMain.Controls.Add(this.tvMaestro);
            this.pnMain.Controls.Add(this.btnVer);
            this.pnMain.Controls.Add(this.btnEliminar);
            this.pnMain.Controls.Add(this.btnModificar);
            this.pnMain.Controls.Add(this.btnNuevo);
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
            this.label1.Text = "MAESTROS DEL SISTEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(269, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(67, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(339, 31);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(415, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Enabled = false;
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.Location = new System.Drawing.Point(491, 31);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(73, 23);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "&Ver";
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // tvMaestro
            // 
            this.tvMaestro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvMaestro.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcMaestro});
            this.tvMaestro.Location = new System.Drawing.Point(5, 31);
            this.tvMaestro.Name = "tvMaestro";
            this.tvMaestro.OptionsBehavior.Editable = false;
            this.tvMaestro.OptionsBehavior.EnableFiltering = true;
            this.tvMaestro.OptionsBehavior.ReadOnly = true;
            this.tvMaestro.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended;
            this.tvMaestro.OptionsFind.AllowFindPanel = true;
            this.tvMaestro.OptionsView.ShowHorzLines = false;
            this.tvMaestro.SelectImageList = this.imgAll;
            this.tvMaestro.Size = new System.Drawing.Size(260, 368);
            this.tvMaestro.TabIndex = 14;
            this.tvMaestro.TreeLevelWidth = 12;
            this.tvMaestro.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tvMaestro_FocusedNodeChanged);
            // 
            // tlcMaestro
            // 
            this.tlcMaestro.Caption = "Nombre";
            this.tlcMaestro.FieldName = "Nombre";
            this.tlcMaestro.MinWidth = 33;
            this.tlcMaestro.Name = "tlcMaestro";
            this.tlcMaestro.Visible = true;
            this.tlcMaestro.VisibleIndex = 0;
            // 
            // imgAll
            // 
            this.imgAll.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgAll.ImageStream")));
            this.imgAll.InsertGalleryImage("freezetoprow_16x16.png", "images/spreadsheet/freezetoprow_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/freezetoprow_16x16.png"), 0);
            this.imgAll.Images.SetKeyName(0, "freezetoprow_16x16.png");
            this.imgAll.InsertGalleryImage("touchmode_16x16.png", "images/mode/touchmode_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mode/touchmode_16x16.png"), 1);
            this.imgAll.Images.SetKeyName(1, "touchmode_16x16.png");
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Location = new System.Drawing.Point(269, 57);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(339, 342);
            this.pnlContenedor.TabIndex = 15;
            // 
            // frmMaestrosMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(613, 404);
            this.Name = "frmMaestrosMain";
            this.Text = "Maestros del Sistema";
            this.Load += new System.EventHandler(this.frmMaestrosMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.SimpleButton btnNuevo;
        protected DevExpress.XtraEditors.SimpleButton btnVer;
        protected DevExpress.XtraEditors.SimpleButton btnEliminar;
        protected DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraTreeList.TreeList tvMaestro;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcMaestro;
        private DevExpress.Utils.ImageCollection imgAll;
        private DevExpress.XtraEditors.PanelControl pnlContenedor;
    }
}
