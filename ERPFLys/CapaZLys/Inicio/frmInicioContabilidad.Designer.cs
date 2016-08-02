namespace FiltroLys.ZLys.Inicio
{
    partial class frmInicioContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioContabilidad));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnListVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.btnMayorizacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaldoCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.btnCierreMes = new DevExpress.XtraEditors.SimpleButton();
            this.btnCierreAnual = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBloquearPeriodo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeleccionarPeriodo = new DevExpress.XtraEditors.SimpleButton();
            this.line1 = new FiltroLys.ZLys.Controles.Objeto.Line();
            this.line2 = new FiltroLys.ZLys.Controles.Objeto.Line();
            this.line3 = new FiltroLys.ZLys.Controles.Objeto.Line();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnCierreAnual);
            this.pnMain.Controls.Add(this.btnCierreMes);
            this.pnMain.Controls.Add(this.line3);
            this.pnMain.Controls.Add(this.btnMayorizacion);
            this.pnMain.Controls.Add(this.line2);
            this.pnMain.Controls.Add(this.btnListVoucher);
            this.pnMain.Controls.Add(this.line1);
            this.pnMain.Controls.Add(this.groupControl1);
            this.pnMain.Controls.Add(this.btnSaldoCuenta);
            this.pnMain.Controls.Add(this.labelControl4);
            this.pnMain.Controls.Add(this.labelControl3);
            this.pnMain.Controls.Add(this.labelControl2);
            this.pnMain.Controls.Add(this.panelControl1);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Size = new System.Drawing.Size(693, 426);
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "<size=+6><b><i>Contabilidad</i>&nbsp;<color=red>Aplicacion</color></b></size>";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Location = new System.Drawing.Point(10, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(670, 4);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Control de Voucher...";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mayorizar/Desmayorizar...";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Saldos de Cuenta x Periodo..";
            // 
            // btnListVoucher
            // 
            this.btnListVoucher.Image = ((System.Drawing.Image)(resources.GetObject("btnListVoucher.Image")));
            this.btnListVoucher.Location = new System.Drawing.Point(161, 45);
            this.btnListVoucher.Name = "btnListVoucher";
            this.btnListVoucher.Size = new System.Drawing.Size(99, 30);
            this.btnListVoucher.TabIndex = 9;
            this.btnListVoucher.Text = "&Reg. Voucher";
            this.btnListVoucher.Click += new System.EventHandler(this.btnListVoucher_Click);
            // 
            // btnMayorizacion
            // 
            this.btnMayorizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnMayorizacion.Image")));
            this.btnMayorizacion.Location = new System.Drawing.Point(161, 105);
            this.btnMayorizacion.Name = "btnMayorizacion";
            this.btnMayorizacion.Size = new System.Drawing.Size(99, 30);
            this.btnMayorizacion.TabIndex = 10;
            this.btnMayorizacion.Text = "&Mayorización";
            this.btnMayorizacion.Click += new System.EventHandler(this.btnMayorizacion_Click);
            // 
            // btnSaldoCuenta
            // 
            this.btnSaldoCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldoCuenta.Image")));
            this.btnSaldoCuenta.Location = new System.Drawing.Point(161, 167);
            this.btnSaldoCuenta.Name = "btnSaldoCuenta";
            this.btnSaldoCuenta.Size = new System.Drawing.Size(99, 30);
            this.btnSaldoCuenta.TabIndex = 11;
            this.btnSaldoCuenta.Text = "&Saldos Cuenta";
            this.btnSaldoCuenta.Click += new System.EventHandler(this.btnSaldoCuenta_Click);
            // 
            // btnCierreMes
            // 
            this.btnCierreMes.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreMes.Image")));
            this.btnCierreMes.Location = new System.Drawing.Point(304, 105);
            this.btnCierreMes.Name = "btnCierreMes";
            this.btnCierreMes.Size = new System.Drawing.Size(99, 30);
            this.btnCierreMes.TabIndex = 12;
            this.btnCierreMes.Text = "&Cierre Mes";
            this.btnCierreMes.Click += new System.EventHandler(this.btnCierreMes_Click);
            // 
            // btnCierreAnual
            // 
            this.btnCierreAnual.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreAnual.Image")));
            this.btnCierreAnual.Location = new System.Drawing.Point(439, 105);
            this.btnCierreAnual.Name = "btnCierreAnual";
            this.btnCierreAnual.Size = new System.Drawing.Size(99, 30);
            this.btnCierreAnual.TabIndex = 13;
            this.btnCierreAnual.Text = "&Cierre Anual";
            this.btnCierreAnual.Click += new System.EventHandler(this.btnCierreAnual_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnBloquearPeriodo);
            this.groupControl1.Controls.Add(this.btnSeleccionarPeriodo);
            this.groupControl1.Location = new System.Drawing.Point(553, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(127, 120);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Herramientas";
            // 
            // btnBloquearPeriodo
            // 
            this.btnBloquearPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("btnBloquearPeriodo.Image")));
            this.btnBloquearPeriodo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnBloquearPeriodo.Location = new System.Drawing.Point(11, 72);
            this.btnBloquearPeriodo.Name = "btnBloquearPeriodo";
            this.btnBloquearPeriodo.Size = new System.Drawing.Size(107, 40);
            this.btnBloquearPeriodo.TabIndex = 15;
            this.btnBloquearPeriodo.Text = "&Bloq Per. Trabajo";
            this.btnBloquearPeriodo.Click += new System.EventHandler(this.btnBloquearPeriodo_Click);
            // 
            // btnSeleccionarPeriodo
            // 
            this.btnSeleccionarPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarPeriodo.Image")));
            this.btnSeleccionarPeriodo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSeleccionarPeriodo.Location = new System.Drawing.Point(11, 26);
            this.btnSeleccionarPeriodo.Name = "btnSeleccionarPeriodo";
            this.btnSeleccionarPeriodo.Size = new System.Drawing.Size(107, 40);
            this.btnSeleccionarPeriodo.TabIndex = 14;
            this.btnSeleccionarPeriodo.Text = "&Sel. Periodo Trabajo";
            this.btnSeleccionarPeriodo.Click += new System.EventHandler(this.btnSeleccionarPeriodo_Click);
            // 
            // line1
            // 
            this.line1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.line1.Dark3dColor = System.Drawing.SystemColors.ControlDark;
            this.line1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.line1.Light3dColor = System.Drawing.SystemColors.ControlLightLight;
            this.line1.Location = new System.Drawing.Point(209, 74);
            this.line1.Name = "line1";
            this.line1.Orientation = FiltroLys.ZLys.Controles.Objeto.LineOrientation.Vertical;
            this.line1.Size = new System.Drawing.Size(1, 35);
            this.line1.TabIndex = 15;
            this.line1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BorderColor = System.Drawing.SystemColors.ControlText;
            this.line2.Dark3dColor = System.Drawing.SystemColors.ControlDark;
            this.line2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.line2.Light3dColor = System.Drawing.SystemColors.ControlLightLight;
            this.line2.Location = new System.Drawing.Point(258, 120);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(50, 1);
            this.line2.TabIndex = 16;
            this.line2.TabStop = false;
            // 
            // line3
            // 
            this.line3.BorderColor = System.Drawing.SystemColors.ControlText;
            this.line3.Dark3dColor = System.Drawing.SystemColors.ControlDark;
            this.line3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.line3.Light3dColor = System.Drawing.SystemColors.ControlLightLight;
            this.line3.Location = new System.Drawing.Point(400, 120);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(50, 1);
            this.line3.TabIndex = 17;
            this.line3.TabStop = false;
            // 
            // frmInicioContabilidad
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(693, 426);
            this.Name = "frmInicioContabilidad";
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.frmInicioContabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnListVoucher;
        private DevExpress.XtraEditors.SimpleButton btnSaldoCuenta;
        private DevExpress.XtraEditors.SimpleButton btnMayorizacion;
        private DevExpress.XtraEditors.SimpleButton btnCierreAnual;
        private DevExpress.XtraEditors.SimpleButton btnCierreMes;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarPeriodo;
        private DevExpress.XtraEditors.SimpleButton btnBloquearPeriodo;
        private Controles.Objeto.Line line1;
        private Controles.Objeto.Line line3;
        private Controles.Objeto.Line line2;
    }
}
