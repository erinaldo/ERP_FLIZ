namespace FiltroLys.ZLys.Sistema
{
    partial class frmListTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTabla));
            this.cmbTabla = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFolder = new DevExpress.XtraEditors.TextEdit();
            this.txtEntidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenEntidad = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuery = new DevExpress.XtraEditors.MemoEdit();
            this.Posicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Default = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Propiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricVB = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTabla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricVB)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Controls.Add(this.btnGenEntidad);
            this.gpFiltrar.Controls.Add(this.txtEntidad);
            this.gpFiltrar.Controls.Add(this.labelControl3);
            this.gpFiltrar.Controls.Add(this.txtFolder);
            this.gpFiltrar.Controls.Add(this.cmbTabla);
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(558, 57);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(570, 37);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Text = "TABLAS DE SISTEMA";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.txtQuery);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.gpFiltrar, 0);
            this.pnMain.Controls.SetChildIndex(this.label1, 0);
            this.pnMain.Controls.SetChildIndex(this.txtQuery, 0);
            // 
            // cmbTabla
            // 
            this.cmbTabla.Location = new System.Drawing.Point(46, 5);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTabla.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", 120, "Tabla")});
            this.cmbTabla.Properties.PopupWidth = 250;
            this.cmbTabla.Size = new System.Drawing.Size(190, 20);
            this.cmbTabla.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(250, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Folder";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Tabla:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(286, 5);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(100, 20);
            this.txtFolder.TabIndex = 14;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(447, 4);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(405, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Entidad";
            // 
            // btnGenEntidad
            // 
            this.btnGenEntidad.Image = ((System.Drawing.Image)(resources.GetObject("btnGenEntidad.Image")));
            this.btnGenEntidad.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenEntidad.Location = new System.Drawing.Point(11, 29);
            this.btnGenEntidad.Name = "btnGenEntidad";
            this.btnGenEntidad.Size = new System.Drawing.Size(108, 23);
            this.btnGenEntidad.TabIndex = 17;
            this.btnGenEntidad.Text = "Generar Entidad";
            this.btnGenEntidad.Click += new System.EventHandler(this.btnGenEntidad_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(508, 94);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(137, 345);
            this.txtQuery.TabIndex = 11;
            // 
            // Posicion
            // 
            this.Posicion.Caption = "#";
            this.Posicion.FieldName = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.OptionsColumn.AllowEdit = false;
            this.Posicion.OptionsColumn.ReadOnly = true;
            this.Posicion.Visible = true;
            this.Posicion.VisibleIndex = 0;
            this.Posicion.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsColumn.ReadOnly = true;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.OptionsColumn.ReadOnly = true;
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 2;
            this.Tipo.Width = 80;
            // 
            // Default
            // 
            this.Default.Caption = "Default";
            this.Default.FieldName = "Default";
            this.Default.Name = "Default";
            this.Default.OptionsColumn.AllowEdit = false;
            this.Default.OptionsColumn.ReadOnly = true;
            this.Default.Visible = true;
            this.Default.VisibleIndex = 3;
            this.Default.Width = 70;
            // 
            // Propiedad
            // 
            this.Propiedad.Caption = "Propiedad";
            this.Propiedad.FieldName = "Propiedad";
            this.Propiedad.Name = "Propiedad";
            this.Propiedad.Visible = true;
            this.Propiedad.VisibleIndex = 4;
            this.Propiedad.Width = 120;
            // 
            // VB
            // 
            this.VB.Caption = "VB";
            this.VB.ColumnEdit = this.ricVB;
            this.VB.FieldName = "VB";
            this.VB.Name = "VB";
            this.VB.Visible = true;
            this.VB.VisibleIndex = 5;
            this.VB.Width = 40;
            // 
            // ricVB
            // 
            this.ricVB.AutoHeight = false;
            this.ricVB.Name = "ricVB";
            this.ricVB.ValueChecked = "S";
            this.ricVB.ValueUnchecked = "N";
            // 
            // frmListTabla
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Name = "frmListTabla";
            this.Text = "Tablas Sistema";
            this.Load += new System.EventHandler(this.frmListTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTabla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricVB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbTabla;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEntidad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFolder;
        private DevExpress.XtraEditors.SimpleButton btnGenEntidad;
        private DevExpress.XtraEditors.MemoEdit txtQuery;
        private DevExpress.XtraGrid.Columns.GridColumn Posicion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Default;
        private DevExpress.XtraGrid.Columns.GridColumn Propiedad;
        private DevExpress.XtraGrid.Columns.GridColumn VB;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricVB;
    }
}
