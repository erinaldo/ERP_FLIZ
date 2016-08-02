namespace FiltroLys.ZLys.ModMaestro.RRHH
{
    partial class frmDepartCia
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
            this.Compania = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartamento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.DepartamentoCiaCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbEmpResponsable = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSucursal = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado,
            this.riceFlags});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Compania,
            this.DepartamentoCiaCodigo,
            this.Descripcion,
            this.Estado,
            this.UltimoUsuario,
            this.UltimaFechaModificacion,
            this.Sucursal,
            this.EmpResponsable});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.Size = new System.Drawing.Size(0, 35);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.cmbSucursal);
            this.pnlCuerpo.Controls.Add(this.labelControl10);
            this.pnlCuerpo.Controls.Add(this.cmbEmpResponsable);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.cmbCompania);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbEstado);
            this.pnlCuerpo.Controls.Add(this.txtDescripcion);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtDepartamento);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Compania
            // 
            this.Compania.Caption = "Compania";
            this.Compania.FieldName = "CompaniaNombre";
            this.Compania.Name = "Compania";
            this.Compania.Visible = true;
            this.Compania.VisibleIndex = 0;
            this.Compania.Width = 117;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            this.Descripcion.Width = 267;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 77;
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
            // UltimoUsuario
            // 
            this.UltimoUsuario.Caption = "Ult.Usu.Mod";
            this.UltimoUsuario.FieldName = "UltimoUsuario";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 4;
            this.UltimoUsuario.Width = 88;
            // 
            // UltimaFechaModificacion
            // 
            this.UltimaFechaModificacion.Caption = "Ult.Fec.Mod";
            this.UltimaFechaModificacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModificacion.FieldName = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Name = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Visible = true;
            this.UltimaFechaModificacion.VisibleIndex = 5;
            this.UltimaFechaModificacion.Width = 112;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(110, 36);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Properties.MaxLength = 10;
            this.txtDepartamento.Size = new System.Drawing.Size(62, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(110, 94);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(110, 181);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 7;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(110, 207);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 9;
            // 
            // DepartamentoCiaCodigo
            // 
            this.DepartamentoCiaCodigo.Caption = "Código";
            this.DepartamentoCiaCodigo.FieldName = "DepartamentoCiaCodigo";
            this.DepartamentoCiaCodigo.Name = "DepartamentoCiaCodigo";
            this.DepartamentoCiaCodigo.Visible = true;
            this.DepartamentoCiaCodigo.VisibleIndex = 1;
            this.DepartamentoCiaCodigo.Width = 60;
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 6;
            this.Sucursal.Width = 70;
            // 
            // EmpResponsable
            // 
            this.EmpResponsable.Caption = "Responsable";
            this.EmpResponsable.FieldName = "EmpResponsable";
            this.EmpResponsable.Name = "EmpResponsable";
            this.EmpResponsable.Visible = true;
            this.EmpResponsable.VisibleIndex = 7;
            this.EmpResponsable.Width = 104;
            // 
            // riceFlags
            // 
            this.riceFlags.AutoHeight = false;
            this.riceFlags.Name = "riceFlags";
            this.riceFlags.ValueChecked = "S";
            this.riceFlags.ValueUnchecked = "N";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Compania:";
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(110, 10);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(150, 20);
            this.cmbCompania.TabIndex = 1;
            this.cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            // 
            // cmbEmpResponsable
            // 
            this.cmbEmpResponsable.Location = new System.Drawing.Point(110, 152);
            this.cmbEmpResponsable.Name = "cmbEmpResponsable";
            this.cmbEmpResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmpResponsable.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Empleado", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCompleto", 100, "Nombre")});
            this.cmbEmpResponsable.Properties.PopupWidth = 250;
            this.cmbEmpResponsable.Size = new System.Drawing.Size(150, 20);
            this.cmbEmpResponsable.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 153);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Emp. Responsable:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(110, 122);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sucursal", 45, "Sucursal"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbSucursal.Properties.PopupWidth = 250;
            this.cmbSucursal.Size = new System.Drawing.Size(150, 20);
            this.cmbSucursal.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 123);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 13);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Sucursal:";
            // 
            // txtUltimoUsuarioNombre
            // 
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(224, 181);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 8;
            // 
            // frmDepartCia
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmDepartCia";
            this.Load += new System.EventHandler(this.frmDepartCia_Load);
            this.Shown += new System.EventHandler(this.frmDepartCia_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Compania;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn DepartamentoCiaCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn EmpResponsable;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbEmpResponsable;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbSucursal;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
    }
}
