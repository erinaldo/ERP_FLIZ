namespace FiltroLys.ZLys.Busqueda.General
{
    partial class frmBusqMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusqMain));
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.grControl = new DevExpress.XtraGrid.GridControl();
            this.gvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnCancelar);
            this.pnMain.Controls.Add(this.btnAceptar);
            this.pnMain.Controls.Add(this.chkActivo);
            this.pnMain.Controls.Add(this.grControl);
            this.pnMain.Controls.Add(this.btnBuscar);
            this.pnMain.Controls.Add(this.txtDescripcion);
            this.pnMain.Controls.Add(this.txtCodigo);
            this.pnMain.Size = new System.Drawing.Size(482, 379);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(79, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(324, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(406, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "&Buscar";
            // 
            // grControl
            // 
            this.grControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControl.Location = new System.Drawing.Point(6, 29);
            this.grControl.MainView = this.gvDatos;
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(471, 315);
            this.grControl.TabIndex = 11;
            this.grControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatos});
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.GridControl = this.grControl;
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.LostFocus += new System.EventHandler(this.gvDatos_LostFocus);
            this.gvDatos.GotFocus += new System.EventHandler(this.gvDatos_GotFocus);
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkActivo.EditValue = true;
            this.chkActivo.Location = new System.Drawing.Point(6, 348);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(332, 348);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "&Aceptar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(406, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBusqMain
            // 
            this.AcceptButton = this.btnBuscar;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Name = "frmBusqMain";
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl grControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatos;
        protected DevExpress.XtraEditors.TextEdit txtCodigo;
        protected DevExpress.XtraEditors.TextEdit txtDescripcion;
        protected DevExpress.XtraEditors.SimpleButton btnBuscar;
        protected DevExpress.XtraEditors.SimpleButton btnCancelar;
        protected DevExpress.XtraEditors.SimpleButton btnAceptar;
        protected DevExpress.XtraEditors.CheckEdit chkActivo;
    }
}
