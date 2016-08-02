namespace FiltroLys.ZLys.Seguridad
{
    partial class frmListAuditoria
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFechaIni = new DevExpress.XtraEditors.DateEdit();
            this.txtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.Estacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPcIng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPcSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ridFechaPcSal = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.FechaServIng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaServSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ridFechaServSal = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbUsuario = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaPcSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaPcSal.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaServSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaServSal.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Controls.Add(this.cmbUsuario);
            this.gpFiltrar.Controls.Add(this.txtFechaFin);
            this.gpFiltrar.Controls.Add(this.txtFechaIni);
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(554, 30);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(577, 33);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Text = "AUDITORIA DE USUARIO";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(261, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha Ingreso:";
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.EditValue = null;
            this.txtFechaIni.Location = new System.Drawing.Point(341, 5);
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaIni.Size = new System.Drawing.Size(100, 20);
            this.txtFechaIni.TabIndex = 1;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.EditValue = null;
            this.txtFechaFin.Location = new System.Drawing.Point(448, 5);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txtFechaFin.TabIndex = 2;
            // 
            // Estacion
            // 
            this.Estacion.Caption = "Estacion";
            this.Estacion.FieldName = "Estacion";
            this.Estacion.Name = "Estacion";
            this.Estacion.Visible = true;
            this.Estacion.VisibleIndex = 0;
            this.Estacion.Width = 80;
            // 
            // CodigoUsuario
            // 
            this.CodigoUsuario.Caption = "Usuario";
            this.CodigoUsuario.FieldName = "CodigoUsuario";
            this.CodigoUsuario.Name = "CodigoUsuario";
            this.CodigoUsuario.Visible = true;
            this.CodigoUsuario.VisibleIndex = 1;
            this.CodigoUsuario.Width = 100;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Caption = "Nombre";
            this.NombreUsuario.FieldName = "NombreUsuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreUsuario", "{0}  Fila(s).")});
            this.NombreUsuario.Visible = true;
            this.NombreUsuario.VisibleIndex = 2;
            this.NombreUsuario.Width = 180;
            // 
            // CentroCosto
            // 
            this.CentroCosto.Caption = "CCosto";
            this.CentroCosto.FieldName = "CentroCosto";
            this.CentroCosto.Name = "CentroCosto";
            this.CentroCosto.Visible = true;
            this.CentroCosto.VisibleIndex = 3;
            this.CentroCosto.Width = 60;
            // 
            // FechaPcIng
            // 
            this.FechaPcIng.Caption = "F.Ing.PC";
            this.FechaPcIng.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaPcIng.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaPcIng.FieldName = "FechaPcIng";
            this.FechaPcIng.Name = "FechaPcIng";
            this.FechaPcIng.Visible = true;
            this.FechaPcIng.VisibleIndex = 4;
            this.FechaPcIng.Width = 120;
            // 
            // FechaPcSal
            // 
            this.FechaPcSal.Caption = "F.Sal.PC";
            this.FechaPcSal.ColumnEdit = this.ridFechaPcSal;
            this.FechaPcSal.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaPcSal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaPcSal.FieldName = "FechaPcSal";
            this.FechaPcSal.Name = "FechaPcSal";
            this.FechaPcSal.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaPcSal.Visible = true;
            this.FechaPcSal.VisibleIndex = 5;
            this.FechaPcSal.Width = 120;
            // 
            // ridFechaPcSal
            // 
            this.ridFechaPcSal.AutoHeight = false;
            this.ridFechaPcSal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridFechaPcSal.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridFechaPcSal.Name = "ridFechaPcSal";
            this.ridFechaPcSal.NullDate = new System.DateTime(((long)(0)));
            // 
            // FechaServIng
            // 
            this.FechaServIng.Caption = "F.Ing.Serv";
            this.FechaServIng.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaServIng.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaServIng.FieldName = "FechaServIng";
            this.FechaServIng.Name = "FechaServIng";
            this.FechaServIng.Visible = true;
            this.FechaServIng.VisibleIndex = 6;
            this.FechaServIng.Width = 120;
            // 
            // FechaServSal
            // 
            this.FechaServSal.Caption = "F.Sal.Serv";
            this.FechaServSal.ColumnEdit = this.ridFechaServSal;
            this.FechaServSal.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaServSal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaServSal.FieldName = "FechaServSal";
            this.FechaServSal.Name = "FechaServSal";
            this.FechaServSal.Visible = true;
            this.FechaServSal.VisibleIndex = 7;
            this.FechaServSal.Width = 120;
            // 
            // ridFechaServSal
            // 
            this.ridFechaServSal.AutoHeight = false;
            this.ridFechaServSal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridFechaServSal.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ridFechaServSal.Name = "ridFechaServSal";
            this.ridFechaServSal.NullDate = new System.DateTime(((long)(0)));
            // 
            // UltimoUsuario
            // 
            this.UltimoUsuario.Caption = "Ultimo Usuario";
            this.UltimoUsuario.FieldName = "UltimoUsuario";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 8;
            this.UltimoUsuario.Width = 100;
            // 
            // UltimaFechaModificacion
            // 
            this.UltimaFechaModificacion.Caption = "Ultima Modificacion";
            this.UltimaFechaModificacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModificacion.FieldName = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Name = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Visible = true;
            this.UltimaFechaModificacion.VisibleIndex = 9;
            this.UltimaFechaModificacion.Width = 120;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Location = new System.Drawing.Point(51, 4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoUsuario", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbUsuario.Properties.PopupWidth = 250;
            this.cmbUsuario.Size = new System.Drawing.Size(190, 20);
            this.cmbUsuario.TabIndex = 0;
            // 
            // frmListAuditoria
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Name = "frmListAuditoria";
            this.Text = "Auditoria Usuario";
            this.Load += new System.EventHandler(this.frmListAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaPcSal.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaPcSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaServSal.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridFechaServSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtFechaFin;
        private DevExpress.XtraEditors.DateEdit txtFechaIni;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;        
        private DevExpress.XtraGrid.Columns.GridColumn Estacion;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn NombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn CentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPcIng;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPcSal;
        private DevExpress.XtraGrid.Columns.GridColumn FechaServIng;
        private DevExpress.XtraGrid.Columns.GridColumn FechaServSal;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ridFechaPcSal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ridFechaServSal;
        private DevExpress.XtraEditors.LookUpEdit cmbUsuario;
    }
}
