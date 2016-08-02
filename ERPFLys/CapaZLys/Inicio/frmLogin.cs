using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FiltroLys.Domain.Seguridad;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Seguridad;
using FiltroLys.Type;
using DevExpress.XtraSplashScreen;

namespace FiltroLys.ZLys.Inicio
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        int _nroVeces = 0;

        #region "==EventForm=="

        public frmLogin()
        {
            InitializeComponent();
            fxLecturaVariables();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0.87;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Funciones.fnControl.KeyNextFocus);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Funciones.fnControl.KeyNextFocus);

            txtClave.Text = "MGMON";
        }

        #endregion

        #region "==EventObject=="

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sUsuario = "", sClave = "", sErr = "";
            int nErr = 1;

            sUsuario = txtUsuario.Text.Trim().ToUpper();
            sClave = txtClave.Text.Trim().ToUpper();

            if (String.IsNullOrWhiteSpace(sUsuario))
            {
                errorForm.SetError(txtUsuario, "Ingresar Usuario por favor.");
                return;
            }
            errorForm.SetError(txtUsuario, null);

            if (String.IsNullOrWhiteSpace(sClave))
            {
                errorForm.SetError(txtClave, "Ingresar Clave por favor.");
                return;
            }

            nErr = negSeguridad.GetValidarAcceso(sUsuario, sClave);
            switch (nErr)
            {
                case -1:
                    sErr = "Usuario No Existe";
                    break;
                case -2:
                    sErr = "Usuario se encuentra Inactivo";
                    break;
                case -3:
                    sErr = "Clave Invalida";
                    break;
            }

            if (sErr.Length > 0)
            {
                lblError.Text = sErr.ToUpper();
                _nroVeces++;
                if (_nroVeces > 3) { this.Close(); }
            }
            else
            {
                GlobalVar.UsuarioLogeo = sUsuario;
                GlobalVar.Estacion = Environment.MachineName;
                GlobalVar.FechaIng = DateTime.Now;
                entErrores objE = fxIniciarAuditoria();
                if (objE.Resultado == false)
                {
                    lblError.Text = objE.Errores[0].Codigo + "-" + objE.Errores[0].Descripcion;
                    objE = null;
                    return;
                }
                objE = null;
                this.Hide();

                SplashScreenManager.ShowForm((Form)null, typeof(frmSplash), true, true);
                frmMdi frm = new frmMdi();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxLecturaVariables()
        {
            Funciones.fnReadIni Rx = new Funciones.fnReadIni("inidata.ini");
            txtUsuario.Text = Rx.Read("Usuario", "Inicio");
            GlobalVar.Servidor = Rx.Read("ServerName", "ConexionLYS");
            GlobalVar.Compania = Rx.Read("Compania", "Inicio");
            GlobalVar.DirReporte = Rx.Read("DirReporte", "Rutas");
            GlobalVar.DirRegSunat = Rx.Read("DirRegSunat", "Rutas");
            GlobalVar.DirDAOT = Rx.Read("DirDAOT", "Rutas");
        }

        private entErrores fxIniciarAuditoria()
        {
            entAuditoria objE = new entAuditoria();
            objE.Estacion = GlobalVar.Estacion;
            objE.CodigoUsuario = GlobalVar.UsuarioLogeo;
            objE.FechaPcIng = GlobalVar.FechaIng;
            objE.UltimoUsuario = GlobalVar.UsuarioLogeo;
            entErrores entErr = negAuditoria.MantAuditoria(fnEnum.OperacionMant.Insertar, objE);
            objE = null;
            return entErr;
        }

        #endregion

    }
}