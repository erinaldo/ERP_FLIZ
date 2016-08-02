namespace FiltroLys.ZLys.ModMaestro.Tesoreria
{
    partial class frmTipoServicio
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
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.TipoServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.riceFlagProv = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rilueSiNo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RegFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.chkFlagNoDomiciliado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkFlag4ta = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.chkFlag4taPension = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.chkFlag4taPensionAFE = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.chkFlag2daCategoria = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.chkFlagValida4ta = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbRegFiscal = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagNoDomiciliado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4ta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4taPension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4taPensionAFE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag2daCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagValida4ta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRegFiscal.Properties)).BeginInit();
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
            this.riceFlags,
            this.riceFlagProv,
            this.rilueSiNo});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoServicio,
            this.Descripcion,
            this.RegFiscal,
            this.Estado,
            this.UltimoUsuario,
            this.UltimaFechaModificacion});
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
            this.pnlCuerpo.Controls.Add(this.cmbRegFiscal);
            this.pnlCuerpo.Controls.Add(this.labelControl12);
            this.pnlCuerpo.Controls.Add(this.labelControl11);
            this.pnlCuerpo.Controls.Add(this.chkFlag2daCategoria);
            this.pnlCuerpo.Controls.Add(this.labelControl10);
            this.pnlCuerpo.Controls.Add(this.chkFlag4taPensionAFE);
            this.pnlCuerpo.Controls.Add(this.labelControl9);
            this.pnlCuerpo.Controls.Add(this.chkFlag4taPension);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.chkFlag4ta);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.chkFlagNoDomiciliado);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Controls.Add(this.cmbEstado);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.txtDescripcion);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtCodigo);
            this.pnlCuerpo.Controls.Add(this.panelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 385;
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
            this.UltimoUsuario.FieldName = "UltimoUsuarioMod";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 4;
            this.UltimoUsuario.Width = 103;
            // 
            // UltimaFechaModificacion
            // 
            this.UltimaFechaModificacion.Caption = "Ult.Fec.Mod";
            this.UltimaFechaModificacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModificacion.FieldName = "UltimaFechaMod";
            this.UltimaFechaModificacion.Name = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Visible = true;
            this.UltimaFechaModificacion.VisibleIndex = 5;
            this.UltimaFechaModificacion.Width = 114;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(98, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Properties.MaxLength = 6;
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 225);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(98, 200);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 11;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(98, 226);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 13;
            // 
            // TipoServicio
            // 
            this.TipoServicio.Caption = "Tipo Servicio";
            this.TipoServicio.FieldName = "TipoServicio";
            this.TipoServicio.Name = "TipoServicio";
            this.TipoServicio.Visible = true;
            this.TipoServicio.VisibleIndex = 0;
            this.TipoServicio.Width = 70;
            // 
            // riceFlags
            // 
            this.riceFlags.AutoHeight = false;
            this.riceFlags.Name = "riceFlags";
            this.riceFlags.ValueChecked = "S";
            this.riceFlags.ValueUnchecked = "N";
            // 
            // txtUltimoUsuarioNombre
            // 
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(214, 200);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 12;
            // 
            // riceFlagProv
            // 
            this.riceFlagProv.AutoHeight = false;
            this.riceFlagProv.Name = "riceFlagProv";
            this.riceFlagProv.ValueChecked = "S";
            this.riceFlagProv.ValueUnchecked = "N";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 17);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Tipo Servicio:";
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Reg Fiscal:";
            // 
            // rilueSiNo
            // 
            this.rilueSiNo.AutoHeight = false;
            this.rilueSiNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueSiNo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueSiNo.Name = "rilueSiNo";
            // 
            // RegFiscal
            // 
            this.RegFiscal.Caption = "Reg Fiscal";
            this.RegFiscal.FieldName = "RegFiscal";
            this.RegFiscal.Name = "RegFiscal";
            this.RegFiscal.Visible = true;
            this.RegFiscal.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(98, 96);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 4;
            // 
            // chkFlagNoDomiciliado
            // 
            this.chkFlagNoDomiciliado.Location = new System.Drawing.Point(98, 130);
            this.chkFlagNoDomiciliado.Name = "chkFlagNoDomiciliado";
            this.chkFlagNoDomiciliado.Properties.Caption = "";
            this.chkFlagNoDomiciliado.Size = new System.Drawing.Size(19, 19);
            this.chkFlagNoDomiciliado.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "No Domiciliado:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(187, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Flag 4ta:";
            // 
            // chkFlag4ta
            // 
            this.chkFlag4ta.Location = new System.Drawing.Point(235, 130);
            this.chkFlag4ta.Name = "chkFlag4ta";
            this.chkFlag4ta.Properties.Caption = "";
            this.chkFlag4ta.Size = new System.Drawing.Size(19, 19);
            this.chkFlag4ta.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(330, 130);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 13);
            this.labelControl9.TabIndex = 29;
            this.labelControl9.Text = "Flag 4ta Pensión:";
            // 
            // chkFlag4taPension
            // 
            this.chkFlag4taPension.Location = new System.Drawing.Point(418, 130);
            this.chkFlag4taPension.Name = "chkFlag4taPension";
            this.chkFlag4taPension.Properties.Caption = "";
            this.chkFlag4taPension.Size = new System.Drawing.Size(19, 19);
            this.chkFlag4taPension.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(308, 158);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(108, 13);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Flag 4ta Pensión AFE: ";
            // 
            // chkFlag4taPensionAFE
            // 
            this.chkFlag4taPensionAFE.Location = new System.Drawing.Point(418, 157);
            this.chkFlag4taPensionAFE.Name = "chkFlag4taPensionAFE";
            this.chkFlag4taPensionAFE.Properties.Caption = "";
            this.chkFlag4taPensionAFE.Size = new System.Drawing.Size(19, 19);
            this.chkFlag4taPensionAFE.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(135, 158);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(95, 13);
            this.labelControl11.TabIndex = 33;
            this.labelControl11.Text = "Flag 2da Categoria:";
            // 
            // chkFlag2daCategoria
            // 
            this.chkFlag2daCategoria.Location = new System.Drawing.Point(235, 157);
            this.chkFlag2daCategoria.Name = "chkFlag2daCategoria";
            this.chkFlag2daCategoria.Properties.Caption = "";
            this.chkFlag2daCategoria.Size = new System.Drawing.Size(19, 19);
            this.chkFlag2daCategoria.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(20, 158);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(74, 13);
            this.labelControl12.TabIndex = 35;
            this.labelControl12.Text = "Flag Valida 4ta:";
            // 
            // chkFlagValida4ta
            // 
            this.chkFlagValida4ta.Location = new System.Drawing.Point(85, 35);
            this.chkFlagValida4ta.Name = "chkFlagValida4ta";
            this.chkFlagValida4ta.Properties.Caption = "";
            this.chkFlagValida4ta.Size = new System.Drawing.Size(19, 19);
            this.chkFlagValida4ta.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkFlagValida4ta);
            this.panelControl1.Location = new System.Drawing.Point(13, 122);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(440, 61);
            this.panelControl1.TabIndex = 36;
            // 
            // cmbRegFiscal
            // 
            this.cmbRegFiscal.Location = new System.Drawing.Point(97, 70);
            this.cmbRegFiscal.Name = "cmbRegFiscal";
            this.cmbRegFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRegFiscal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegFiscal", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbRegFiscal.Size = new System.Drawing.Size(289, 20);
            this.cmbRegFiscal.TabIndex = 3;
            // 
            // frmTipoServicio
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmTipoServicio";
            this.Load += new System.EventHandler(this.frmTipoServicio_Load);
            this.Shown += new System.EventHandler(this.frmTipoServicio_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagNoDomiciliado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4ta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4taPension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag4taPensionAFE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlag2daCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagValida4ta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbRegFiscal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn TipoServicio;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagProv;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueSiNo;
        private DevExpress.XtraGrid.Columns.GridColumn RegFiscal;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkFlagNoDomiciliado;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit chkFlag4taPension;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit chkFlag4ta;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit chkFlag2daCategoria;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit chkFlag4taPensionAFE;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.CheckEdit chkFlagValida4ta;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbRegFiscal;
    }
}
