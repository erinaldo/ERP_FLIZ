using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using DevExpress.XtraTreeList.Nodes;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.ModMaestro
{
    public partial class frmMaestrosMain : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==EventForm=="

        public frmMaestrosMain()
        {
            InitializeComponent();
        }

        private void frmMaestrosMain_Load(object sender, EventArgs e)
        {
            fxTreeViewMaestro();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxTreeViewMaestro()
        {
            List<entAcceso> oList = negSeguridad.ListMenuMaestros(GlobalVar.UsuarioLogeo);
            tvMaestro.BeginUnboundLoad();
            foreach (entAcceso oEnt in oList){
                if (oEnt.OrdenPk == 0){
                    TreeListNode xNodePadre = null;
                    TreeListNode xNodeHijo = tvMaestro.AppendNode(new object[] { oEnt.NombreFin }, xNodePadre);
                    xNodeHijo.Tag = oEnt;
                    xNodeHijo.ImageIndex = 0;
                    fxTreeViewMaestroChild(oList, xNodeHijo);
                }
            }
            tvMaestro.EndUnboundLoad();
        }

        private void fxTreeViewMaestroChild(List<entAcceso> oList, TreeListNode xNode)
        {
            foreach (entAcceso oEnt in oList){
                if (oEnt.OrdenPk > 0){
                    entAcceso oPadre = (entAcceso)xNode.Tag;
                    if (oEnt.Aplicacion.Equals(oPadre.Aplicacion)){
                        String IdnivHijo = oEnt.IdenNiv;
                        String IdnivPadr = oPadre.IdenNiv;
                        Boolean esHijo = false;
                        if (oPadre.Niveles.Equals("0")) { esHijo = true; }
                        else{
                            if (IdnivPadr.Equals(IdnivHijo.Substring(0, IdnivHijo.Length - 2)) && !IdnivHijo.Equals(IdnivPadr)){
                                esHijo = true;
                            }
                        }
                        if (esHijo){
                            TreeListNode xNodeHijo = tvMaestro.AppendNode(new object[] { oEnt.NombreFin }, xNode);
                            xNodeHijo.Tag = oEnt;
                            xNodeHijo.ImageIndex = 1;
                            xNodeHijo.SelectImageIndex = 1;
                            fxTreeViewMaestroChild(oList, xNodeHijo);
                        }
                    }
                }
            }
        }

        private void fxSeguridadBotones(String Modulo,String Niveles)
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnVer.Enabled = true;

            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)){
                btnVer.Enabled = false;
                return;
            }
            fnAcceso objFn = new fnAcceso();
            objFn.addControl(new Funciones.Controles(btnNuevo, Niveles, fnEnum.AccesoOpcion.Nuevo));
            objFn.addControl(new Funciones.Controles(btnModificar, Niveles, fnEnum.AccesoOpcion.Modificar));
            objFn.addControl(new Funciones.Controles(btnEliminar, Niveles, fnEnum.AccesoOpcion.Eliminar));
            objFn.HabControl(GlobalVar.UsuarioLogeo, Modulo);
            objFn = null;
        }

        #endregion

        #region "==EventObject=="

        private void tvMaestro_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            entAcceso oEnt = (entAcceso)e.Node.Tag;
            if (oEnt != null){
                if (!(oEnt.Niveles.Equals("0"))){
                    fxGenerarForm(oEnt);
                }
            }
        }

        #endregion

        #region "==FuncionesList=="

        private void fxGenerarForm(entAcceso oEnt) {
            String Modulo = "", Niveles = "";
            if (pnlContenedor.Controls.Count > 0) { pnlContenedor.Controls.RemoveAt(0); }
            fxSeguridadBotones(oEnt.Aplicacion,oEnt.Niveles);

            Modulo = oEnt.Aplicacion;
            Niveles = oEnt.Niveles;

            #region "==Modulo Contabilidad=="

            if (Modulo.Equals(fnConst.ModContabilidadCod)){
                #region "==Area=="

                if (Niveles.Equals("0203150000")){
                    ModMaestro.Contabilidad.frmArea frm = new ModMaestro.Contabilidad.frmArea();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Asiento Modelo=="

                if (Niveles.Equals("0203030000")){
                    ModMaestro.Contabilidad.frmAsientoModelo frm = new ModMaestro.Contabilidad.frmAsientoModelo();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Centro Costo=="

                if (Niveles.Equals("0203140000")){
                    ModMaestro.RRHH.frmCentroCosto frm = new ModMaestro.RRHH.frmCentroCosto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Clasificacion Centro Costo=="

                if (Niveles.Equals("0203160000")){
                    ModMaestro.RRHH.frmClasifCentroCosto frm = new ModMaestro.RRHH.frmClasifCentroCosto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Clasificacion Mayor=="

                if (Niveles.Equals("0203080000")){
                    ModMaestro.Contabilidad.frmClasificacionMayor frm = new ModMaestro.Contabilidad.frmClasificacionMayor();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Correlativo Voucher=="

                if (Niveles.Equals("0203020000")){
                    ModMaestro.Contabilidad.frmCorrelativoVoucher frm = new ModMaestro.Contabilidad.frmCorrelativoVoucher();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Cuenta Mayor=="

                if (Niveles.Equals("0203110000")){
                    ModMaestro.Contabilidad.frmCuentaMayor frm = new ModMaestro.Contabilidad.frmCuentaMayor();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Cuenta Mayor 04=="

                if (Niveles.Equals("0203310000")){
                    ModMaestro.Contabilidad.frmCuentaMayor04 frm = new ModMaestro.Contabilidad.frmCuentaMayor04();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Cuenta Mayor 05=="

                if (Niveles.Equals("0203320000")){
                    ModMaestro.Contabilidad.frmCuentaMayor05 frm = new ModMaestro.Contabilidad.frmCuentaMayor05();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Rel Cuenta General-Empresarial=="

                if (Niveles.Equals("0203330000")){
                    ModMaestro.Contabilidad.frmRelCtaGenEmp frm = new ModMaestro.Contabilidad.frmRelCtaGenEmp();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Departamento=="

                if (Niveles.Equals("0203220000")){
                    ModMaestro.General.frmDepartamento frm = new ModMaestro.General.frmDepartamento();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==DepartamentoCia=="

                if (Niveles.Equals("0203190000")){
                    ModMaestro.RRHH.frmDepartCia frm = new ModMaestro.RRHH.frmDepartCia();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Distrito=="

                if (Niveles.Equals("0203240000")){
                    ModMaestro.General.frmDistrito frm = new ModMaestro.General.frmDistrito();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Elemento Gasto=="

                if (Niveles.Equals("0203350000")){
                    ModMaestro.Contabilidad.frmElementoGasto frm = new ModMaestro.Contabilidad.frmElementoGasto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Grupo Elemento Gasto=="

                if (Niveles.Equals("0203340000")){
                    ModMaestro.Contabilidad.frmGrupoElementoGasto frm = new ModMaestro.Contabilidad.frmGrupoElementoGasto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Linea Producto(AF)=="

                if (Niveles.Equals("0203040000")){
                    ModMaestro.Contabilidad.frmLineaProducto frm = new ModMaestro.Contabilidad.frmLineaProducto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Paises=="

                if (Niveles.Equals("0203210000"))
                {
                    ModMaestro.General.frmPaises frm = new ModMaestro.General.frmPaises();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Parametros=="

                if (Niveles.Equals("0203130000")){
                    ModMaestro.General.frmParametro frm = new ModMaestro.General.frmParametro();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Periodo Cierre Cia=="

                if (Niveles.Equals("0203050000")){
                    ModMaestro.General.frmPeriodoCierreCia frm = new ModMaestro.General.frmPeriodoCierreCia();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Persona-CtaEspecifica=="

                if (Niveles.Equals("0203170000")){
                    ModMaestro.RRHH.frmTipoPersonaUsuario frm = new ModMaestro.RRHH.frmTipoPersonaUsuario();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Plan de Cuentas=="

                if (Niveles.Equals("0203010000")){
                    ModMaestro.Contabilidad.frmCuentaContable frm = new ModMaestro.Contabilidad.frmCuentaContable();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Provincia=="

                if (Niveles.Equals("0203230000"))
                {
                    ModMaestro.General.frmProvincia frm = new ModMaestro.General.frmProvincia();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Proyecto=="

                if (Niveles.Equals("0203180000")){
                    ModMaestro.Contabilidad.frmProyecto frm = new ModMaestro.Contabilidad.frmProyecto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Rubro Gasto=="

                if (Niveles.Equals("0203300000")){
                    ModMaestro.Contabilidad.frmRubroGasto frm = new ModMaestro.Contabilidad.frmRubroGasto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Sucursal=="

                if (Niveles.Equals("0203200000")){
                    ModMaestro.RRHH.frmSucursal frm = new ModMaestro.RRHH.frmSucursal();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Cuenta Balance=="

                if (Niveles.Equals("0203090000")){
                    ModMaestro.Contabilidad.frmTipoCuentaBalComp frm = new ModMaestro.Contabilidad.frmTipoCuentaBalComp();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Activo=="

                if (Niveles.Equals("0203250000")){
                    ModMaestro.Contabilidad.frmTipoActivo frm = new ModMaestro.Contabilidad.frmTipoActivo();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Cambio=="

                if (Niveles.Equals("0203280000")){
                    ModMaestro.General.frmTipoCambio frm = new ModMaestro.General.frmTipoCambio();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Cambio Periodo=="

                if (Niveles.Equals("0203290000")){
                    ModMaestro.General.frmTipoCambioPeriodo frm = new ModMaestro.General.frmTipoCambioPeriodo();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles; frm.SistemaPK = fnConst.ModContabilidadCod;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Gasto=="

                if (Niveles.Equals("0203060000")){
                    ModMaestro.Contabilidad.frmTipoGasto frm = new ModMaestro.Contabilidad.frmTipoGasto();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Pago=="

                if (Niveles.Equals("0203270000")){
                    ModMaestro.Tesoreria.frmTipoPago frm = new ModMaestro.Tesoreria.frmTipoPago();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Servicio=="

                if (Niveles.Equals("0203260000")){
                    ModMaestro.Tesoreria.frmTipoServicio frm = new ModMaestro.Tesoreria.frmTipoServicio();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

                #region "==Tipo Voucher=="

                if (Niveles.Equals("0203070000")){
                    ModMaestro.Contabilidad.frmTipoVoucher frm = new ModMaestro.Contabilidad.frmTipoVoucher();
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.IntoOfPanel = true; frm.TopLevel = false;
                    frm.Modulo = Modulo; frm.Niveles = Niveles;
                    pnlContenedor.Controls.Add(frm);
                    frm.Show(); frm = null;
                }

                #endregion

            }

            #endregion
        }

        #endregion

        #region "==Evento Nuevo=="

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String Modulo = "", Niveles = "";            
            entAcceso oEnt = (entAcceso)tvMaestro.FocusedNode.Tag;
            if (oEnt == null) { return; }

            Modulo = oEnt.Aplicacion;
            Niveles = oEnt.Niveles;

            #region "==Modulo Contabilidad=="

            if (Modulo.Equals(fnConst.ModContabilidadCod)){
                switch (Niveles){
                    #region "==Area=="

                    case "0203150000":
                        ((ModMaestro.Contabilidad.frmArea)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Asiento Modelo=="

                    case "0203030000":
                        ((ModMaestro.Contabilidad.frmAsientoModelo)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Centro Costo=="

                    case "0203140000":
                        ((ModMaestro.RRHH.frmCentroCosto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Clasificacion Centro Costo=="

                    case "0203160000":
                        ((ModMaestro.RRHH.frmClasifCentroCosto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Clasificacion Mayor=="

                    case "0203080000":
                        ((ModMaestro.Contabilidad.frmClasificacionMayor)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Correlativo Voucher=="

                    case "0203020000":
                        ((ModMaestro.Contabilidad.frmCorrelativoVoucher)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Cuenta Mayor=="

                    case "0203110000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 04=="

                    case "0203310000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor04)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 05=="

                    case "0203320000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor05)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Rel. Cta General-Empresarial=="

                    case "0203330000":
                        ((ModMaestro.Contabilidad.frmRelCtaGenEmp)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Departamento=="

                    case "0203220000":
                        ((ModMaestro.General.frmDepartamento)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==DepartamentoCia=="

                    case "0203190000":
                        ((ModMaestro.RRHH.frmDepartCia)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Distrito=="

                    case "0203240000":
                        ((ModMaestro.General.frmDistrito)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Elemento Gasto=="

                    case "0203350000":
                        ((ModMaestro.Contabilidad.frmElementoGasto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Grupo Elemento Gasto=="

                    case "0203340000":
                        ((ModMaestro.Contabilidad.frmGrupoElementoGasto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Linea Producto(AF)=="

                    case "0203040000":
                        ((ModMaestro.Contabilidad.frmLineaProducto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Paises=="

                    case "0203210000":
                        ((ModMaestro.General.frmPaises)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Parametros=="

                    case "0203130000":
                        ((ModMaestro.General.frmParametro)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Periodo Cierre Cia=="

                    case "0203050000":
                        ((ModMaestro.General.frmPeriodoCierreCia)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Persona-CtaEspecifica=="

                    case "0203170000":
                        ((ModMaestro.RRHH.frmTipoPersonaUsuario)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Plan de Cuentas=="

                    case "0203010000":
                        ((ModMaestro.Contabilidad.frmCuentaContable)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Provincia=="

                    case "0203230000":
                        ((ModMaestro.General.frmProvincia)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Proyecto=="

                    case "0203180000":
                        ((ModMaestro.Contabilidad.frmProyecto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Rubro Gasto=="

                    case "0203300000":
                        ((ModMaestro.Contabilidad.frmRubroGasto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Sucursal=="

                    case "0203200000":
                        ((ModMaestro.RRHH.frmSucursal)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Cuenta Balance=="

                    case "0203090000":
                        ((ModMaestro.Contabilidad.frmTipoCuentaBalComp)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Activo=="

                    case "0203250000":
                        ((ModMaestro.Contabilidad.frmTipoActivo)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Cambio=="

                    case "0203280000":
                        ((ModMaestro.General.frmTipoCambio)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Cambio Periodo=="

                    case "0203290000":
                        ((ModMaestro.General.frmTipoCambioPeriodo)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Gasto=="

                    case "0203060000":
                        ((ModMaestro.Contabilidad.frmTipoGasto)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Pago=="

                    case "0203270000":
                        ((ModMaestro.Tesoreria.frmTipoPago)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Servicio=="

                    case "0203260000":
                        ((ModMaestro.Tesoreria.frmTipoServicio)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                    #region "==Tipo Voucher=="

                    case "0203070000":
                        ((ModMaestro.Contabilidad.frmTipoVoucher)pnlContenedor.Controls[0]).ue_nuevo();
                        break;

                    #endregion

                }
            }

            #endregion

        }

        #endregion

        #region "==Evento Modificar=="

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String Modulo = "", Niveles = "";
            entAcceso oEnt = (entAcceso)tvMaestro.FocusedNode.Tag;
            if (oEnt == null) { return; }

            Modulo = oEnt.Aplicacion;
            Niveles = oEnt.Niveles;

            #region "==Modulo Contabilidad=="

            if (Modulo.Equals(fnConst.ModContabilidadCod)){
                switch (Niveles){
                    #region "==Area=="

                    case "0203150000":
                        ((ModMaestro.Contabilidad.frmArea)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Asiento Modelo=="

                    case "0203030000":
                        ((ModMaestro.Contabilidad.frmAsientoModelo)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Centro Costo=="

                    case "0203140000":
                        ((ModMaestro.RRHH.frmCentroCosto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Clasificación Centro Costo=="

                    case "0203160000":
                        ((ModMaestro.RRHH.frmClasifCentroCosto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Clasificación Mayor=="

                    case "0203080000":
                        ((ModMaestro.Contabilidad.frmClasificacionMayor)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Correlativo Voucher=="

                    case "0203020000":
                        ((ModMaestro.Contabilidad.frmCorrelativoVoucher)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor=="

                    case "0203110000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 04=="

                    case "0203310000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor04)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 05=="

                    case "0203320000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor05)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Rel. Cta. General-Empresarial=="

                    case "0203330000":
                        ((ModMaestro.Contabilidad.frmRelCtaGenEmp)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Departamento=="

                    case "0203220000":
                        ((ModMaestro.General.frmDepartamento)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==DepartamentoCia=="

                    case "0203190000":
                        ((ModMaestro.RRHH.frmDepartCia)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Distrito=="

                    case "0203240000":
                        ((ModMaestro.General.frmDistrito)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Elemento Gasto=="

                    case "0203350000":
                        ((ModMaestro.Contabilidad.frmElementoGasto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Grupo Elemento Gasto=="

                    case "0203340000":
                        ((ModMaestro.Contabilidad.frmGrupoElementoGasto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Linea Producto(AF)=="

                    case "0203040000":
                        ((ModMaestro.Contabilidad.frmLineaProducto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Paises=="

                    case "0203210000":
                        ((ModMaestro.General.frmPaises)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Parametros=="

                    case "0203130000":
                        ((ModMaestro.General.frmParametro)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Periodo Cierre Cia=="

                    case "0203050000":
                        ((ModMaestro.General.frmPeriodoCierreCia)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Persona-CtaEspecifica=="

                    case "0203170000":
                        ((ModMaestro.RRHH.frmTipoPersonaUsuario)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Plan de Cuentas=="

                    case "0203010000":
                        ((ModMaestro.Contabilidad.frmCuentaContable)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Provincia=="

                    case "0203230000":
                        ((ModMaestro.General.frmProvincia)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Proyecto=="

                    case "0203180000":
                        ((ModMaestro.Contabilidad.frmProyecto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Rubro Gasto=="

                    case "0203300000":
                        ((ModMaestro.Contabilidad.frmRubroGasto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Sucursal=="

                    case "0203200000":
                        ((ModMaestro.RRHH.frmSucursal)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Activo=="

                    case "0203250000":
                        ((ModMaestro.Contabilidad.frmTipoActivo)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Cambio=="

                    case "0203280000":
                        ((ModMaestro.General.frmTipoCambio)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Cambio Periodo=="

                    case "0203290000":
                        ((ModMaestro.General.frmTipoCambioPeriodo)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Gasto=="

                    case "0203060000":
                        ((ModMaestro.Contabilidad.frmTipoGasto)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion
                        
                    #region "==Tipo Pago=="

                    case "0203270000":
                        ((ModMaestro.Tesoreria.frmTipoPago)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Servicio=="

                    case "0203260000":
                        ((ModMaestro.Tesoreria.frmTipoServicio)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion

                    #region "==Tipo Voucher=="

                    case "0203070000":
                        ((ModMaestro.Contabilidad.frmTipoVoucher)pnlContenedor.Controls[0]).ue_modificar();
                        break;

                    #endregion
                }
            }

            #endregion
        }

        #endregion

        #region "==Evento Eliminar=="

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String Modulo = "", Niveles = "";
            entAcceso oEnt = (entAcceso)tvMaestro.FocusedNode.Tag;
            if (oEnt == null) { return; }

            Modulo = oEnt.Aplicacion;
            Niveles = oEnt.Niveles;

            #region "==Modulo Contabilidad=="

            if (Modulo.Equals(fnConst.ModContabilidadCod)){
                switch (Niveles){
                    #region "==Area=="

                    case "0203150000":
                        ((ModMaestro.Contabilidad.frmArea)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Asiento Modelo=="

                    case "0203030000":
                        ((ModMaestro.Contabilidad.frmAsientoModelo)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Centro Costo=="

                    case "0203140000":
                        ((ModMaestro.RRHH.frmCentroCosto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Clasificación Centro Costo=="

                    case "0203160000":
                        ((ModMaestro.RRHH.frmClasifCentroCosto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Clasificación Mayor=="

                    case "0203080000":
                        ((ModMaestro.Contabilidad.frmClasificacionMayor)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Correlativo Voucher=="

                    case "0203020000":
                        ((ModMaestro.Contabilidad.frmCorrelativoVoucher)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor=="

                    case "0203110000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 04=="

                    case "0203310000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor04)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 05=="

                    case "0203320000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor05)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Rel. Cta. General-Empresarial=="

                    case "0203330000":
                        ((ModMaestro.Contabilidad.frmRelCtaGenEmp)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Departamento=="

                    case "0203220000":
                        ((ModMaestro.General.frmDepartamento)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==DepartamentoCia=="

                    case "0203190000":
                        ((ModMaestro.RRHH.frmDepartCia)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Distrito=="

                    case "0203240000":
                        ((ModMaestro.General.frmDistrito)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Elemento Gasto=="

                    case "0203350000":
                        ((ModMaestro.Contabilidad.frmElementoGasto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Grupo Elemento Gasto=="

                    case "0203340000":
                        ((ModMaestro.Contabilidad.frmGrupoElementoGasto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Linea Producto(AF)=="

                    case "0203040000":
                        ((ModMaestro.Contabilidad.frmLineaProducto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Paises=="

                    case "0203210000":
                        ((ModMaestro.General.frmPaises)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Parametros=="

                    case "0203130000":
                        ((ModMaestro.General.frmParametro)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Periodo Cierre Cia=="

                    case "0203050000":
                        ((ModMaestro.General.frmPeriodoCierreCia)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Persona-CtaEspecifica=="

                    case "0203170000":
                        ((ModMaestro.RRHH.frmTipoPersonaUsuario)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Plan de Cuentas=="

                    case "0203010000":
                        ((ModMaestro.Contabilidad.frmCuentaContable)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Provincia=="

                    case "0203230000":
                        ((ModMaestro.General.frmProvincia)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Proyecto=="

                    case "0203180000":
                        ((ModMaestro.Contabilidad.frmProyecto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Rubro Gasto=="

                    case "0203300000":
                        ((ModMaestro.Contabilidad.frmRubroGasto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Sucursal=="

                    case "0203200000":
                        ((ModMaestro.RRHH.frmSucursal)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Cuenta Balance=="

                    case "0203090000":
                        ((ModMaestro.Contabilidad.frmTipoCuentaBalComp)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Activo=="

                    case "0203250000":
                        ((ModMaestro.Contabilidad.frmTipoActivo)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Cambio=="

                    case "0203280000":
                        ((ModMaestro.General.frmTipoCambio)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Cambio Periodo=="

                    case "0203290000":
                        ((ModMaestro.General.frmTipoCambioPeriodo)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Gasto=="

                    case "0203060000":
                        ((ModMaestro.Contabilidad.frmTipoGasto)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Pago=="

                    case "0203270000":
                        ((ModMaestro.Tesoreria.frmTipoPago)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Servicio=="

                    case "0203260000":
                        ((ModMaestro.Tesoreria.frmTipoServicio)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion

                    #region "==Tipo Voucher=="

                    case "0203070000":
                        ((ModMaestro.Contabilidad.frmTipoVoucher)pnlContenedor.Controls[0]).ue_eliminar();
                        break;

                    #endregion
                }
            }

            #endregion
        }

        #endregion

        #region "==Evento Ver=="

        private void btnVer_Click(object sender, EventArgs e)
        {
            String Modulo = "", Niveles = "";
            entAcceso oEnt = (entAcceso)tvMaestro.FocusedNode.Tag;
            if (oEnt == null) { return; }

            Modulo = oEnt.Aplicacion;
            Niveles = oEnt.Niveles;

            #region "==Modulo Contabilidad=="

            if (Modulo.Equals(fnConst.ModContabilidadCod)){
                switch (Niveles){
                    #region "==Area=="

                    case "0203150000":
                        ((ModMaestro.Contabilidad.frmArea)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Asiento Modelo=="

                    case "0203030000":
                        ((ModMaestro.Contabilidad.frmAsientoModelo)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Centro Costo=="

                    case "0203140000":
                        ((ModMaestro.RRHH.frmCentroCosto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Clasificacion Centro Costo=="

                    case "0203160000":
                        ((ModMaestro.RRHH.frmClasifCentroCosto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Clasificacion Mayor=="

                    case "0203080000":
                        ((ModMaestro.Contabilidad.frmClasificacionMayor)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Correlativo Voucher=="

                    case "0203020000":
                        ((ModMaestro.Contabilidad.frmCorrelativoVoucher)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Cuenta Mayor=="

                    case "0203110000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 04=="

                    case "0203310000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor04)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Cuenta Mayor 05=="

                    case "0203320000":
                        ((ModMaestro.Contabilidad.frmCuentaMayor05)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Rel. Cta. General-Empresarial=="

                    case "0203330000":
                        ((ModMaestro.Contabilidad.frmRelCtaGenEmp)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Departamento=="

                    case "0203220000":
                        ((ModMaestro.General.frmDepartamento)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Departamento=="

                    case "0203190000":
                        ((ModMaestro.RRHH.frmDepartCia)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Distrito=="

                    case "0203240000":
                        ((ModMaestro.General.frmDistrito)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Elemento Gasto=="

                    case "0203350000":
                        ((ModMaestro.Contabilidad.frmElementoGasto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Grupo Elemento Gasto=="

                    case "0203340000":
                        ((ModMaestro.Contabilidad.frmGrupoElementoGasto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Linea Producto(AF)=="

                    case "0203040000":
                        ((ModMaestro.Contabilidad.frmLineaProducto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Paises=="

                    case "0203210000":
                        ((ModMaestro.General.frmPaises)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Periodo Cierre Cia=="

                    case "0203050000":
                        ((ModMaestro.General.frmPeriodoCierreCia)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Persona-CtaEspecifica=="

                    case "0203170000":
                        ((ModMaestro.RRHH.frmTipoPersonaUsuario)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Plan de Cuentas=="

                    case "0203010000":
                        ((ModMaestro.Contabilidad.frmCuentaContable)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Provincia=="

                    case "0203230000":
                        ((ModMaestro.General.frmProvincia)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Proyecto=="

                    case "0203180000":
                        ((ModMaestro.Contabilidad.frmProyecto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Rubro Gasto=="

                    case "0203300000":
                        ((ModMaestro.Contabilidad.frmRubroGasto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Sucursal=="

                    case "0203200000":
                        ((ModMaestro.RRHH.frmSucursal)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Cuenta Balance=="

                    case "0203090000":
                        ((ModMaestro.Contabilidad.frmTipoCuentaBalComp)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Activo=="

                    case "0203250000":
                        ((ModMaestro.Contabilidad.frmTipoActivo)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Cambio=="

                    case "0203280000":
                        ((ModMaestro.General.frmTipoCambio)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Cambio Periodo=="

                    case "0203290000":
                        ((ModMaestro.General.frmTipoCambioPeriodo)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Gasto=="

                    case "0203060000":
                        ((ModMaestro.Contabilidad.frmTipoGasto)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Pago=="

                    case "0203270000":
                        ((ModMaestro.Tesoreria.frmTipoPago)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Servicio=="

                    case "0203260000":
                        ((ModMaestro.Tesoreria.frmTipoServicio)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion

                    #region "==Tipo Voucher=="

                    case "0203070000":
                        ((ModMaestro.Contabilidad.frmTipoVoucher)pnlContenedor.Controls[0]).ue_ver();
                        break;

                    #endregion
                }
            }

            #endregion
        }

        #endregion

    }
}
