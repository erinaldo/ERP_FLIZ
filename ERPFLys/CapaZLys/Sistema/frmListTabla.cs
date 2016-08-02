using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Sistema;
using FiltroLys.Domain.Sistema;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Sistema
{
    public partial class frmListTabla : FiltroLys.ZLys.Controles.Formulario.frmList
    {
        #region "==EventForm=="

        public frmListTabla()
        {
            InitializeComponent();
        }

        private void frmListTabla_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxValoresDefault();
        }

        #endregion

        #region "==EventObject=="

        private void btnGenEntidad_Click(object sender, EventArgs e)
        {
            if (fxValidarGenQuery())
            {
                fxGenerarEntidad();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sTabla;
            if (!fxValidarCriterio()) { return; }

            sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            List<entColumna> Ls = negTabla.ListColumna(sTabla);
            grControl.DataSource = Ls;
            
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Tabla
            List<entTabla> Lst = negTabla.ListTabla();
            cmbTabla.Properties.DataSource = Lst;
            cmbTabla.Properties.DisplayMember = "TableName";
            cmbTabla.Properties.ValueMember = "TableName";
            Lst = null;
        }

        private void fxValoresDefault()
        {
            txtFolder.Text = String.Empty;
            txtEntidad.Text = String.Empty;
            cmbTabla.EditValue = fnConst.TextSeleccioneNom;
        }

        private Boolean fxValidarCriterio()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            if (sTabla.Equals(fnConst.TextSeleccioneNom)){
                fnMensaje.MensajeInfo("Seleccionar Tabla por favor.");
                cmbTabla.Focus();
                return false;
            }
            return true;
        }

        private Boolean fxValidarGenQuery()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();

            if (sTabla.Equals(fnConst.TextSeleccioneNom))
            {
                fnMensaje.MensajeInfo("Seleccionar Tabla por favor.");
                cmbTabla.Focus();
                return false;
            }

            if (sFolder.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("Ingresar Folder por favor.");
                txtFolder.Focus();
                return false;
            }

            if (sEntidad.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("Ingresar Entidad por favor.");
                txtEntidad.Focus();
                return false;
            }

            if (gvDatos.DataRowCount == 0)
            {
                fnMensaje.MensajeInfo("No Existe informaciòn de Columnas");
                cmbTabla.Focus();
                return false;
            }
            return true;
        }

        private void fxGenerarEntidad()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();
            String sprivateString = "", sprivateInt = "", sprivateDecimal = "", sprivateDatetime = "", scampo = "", stipo = "";
            StringBuilder query = new StringBuilder();
            int nCount = gvDatos.DataRowCount;

            //Datos Cabecera
            query.Append("using System;").AppendLine();
            query.Append("using System.Collections.Generic;").AppendLine();
            query.Append("using System.Linq;").AppendLine();
            query.Append("using System.Text;").AppendLine();
            query.Append("using System.Threading.Tasks;").AppendLine();
            query.AppendLine();
            query.Append("namespace FiltroLys.Model." + sFolder).AppendLine();
            query.Append("{").AppendLine();
            query.Append("\t" + "public class " + sEntidad + " : entBase ").AppendLine();
            query.Append("\t{").AppendLine();

            //Datos Propiedad Private
            for (int i = 0; i < gvDatos.DataRowCount;i++)
            {                
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.VB.Equals("S"))
                {
                    scampo = objE.Nombre.Substring(0, 2) + objE.Propiedad;
                    switch (objE.Tipo)
                    {
                        case "varchar":
                        case "char":
                        case "nvarchar":
                            sprivateString = sprivateString + scampo + (objE.Default.Length > 0 ? "=\"" + objE.Default + "\"" : "") + ", ";
                            break;
                        case "int":
                            sprivateInt = sprivateInt + scampo + (objE.Default.Length > 0 ? "=" + objE.Default : "") + ", ";
                            break;
                        case "decimal":
                        case "numeric":
                            sprivateDecimal = sprivateDecimal + scampo + (objE.Default.Length > 0 ? "=" + objE.Default : "") + ", ";
                            break;
                        case "datetime":
                            sprivateDatetime = sprivateDatetime + scampo + (objE.Default.Length > 0 ? "=DateTime.Now" : "") + ", ";
                            break;
                    }
                }
            }
            sprivateString = sprivateString.Trim();
            sprivateInt = sprivateInt.Trim();
            sprivateDecimal = sprivateDecimal.Trim();
            sprivateDatetime = sprivateDatetime.Trim();

            if (sprivateString.Length > 0) { query.Append("\t\t private String " + sprivateString.Substring(0, sprivateString.Length - 1) + ";").AppendLine(); }
            if (sprivateInt.Length > 0) { query.Append("\t\t private int " + sprivateInt.Substring(0, sprivateInt.Length - 1) + ";").AppendLine(); }
            if (sprivateDecimal.Length > 0) { query.Append("\t\t private Decimal " + sprivateDecimal.Substring(0, sprivateDecimal.Length - 1) + ";").AppendLine(); }
            if (sprivateDatetime.Length > 0) { query.Append("\t\t private DateTime " + sprivateDatetime.Substring(0, sprivateDatetime.Length - 1) + ";").AppendLine(); }
            query.AppendLine();

            //Datos Propiedad Publica
            for (int i = 0; i < gvDatos.DataRowCount; i++)
            {
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.VB.Equals("S"))
                {
                    scampo = objE.Nombre.Substring(0, 2) + objE.Propiedad;
                    switch (objE.Tipo)
                    {
                        case "varchar":
                        case "char":
                        case "nvarchar":
                            stipo = "String";
                            break;
                        case "int":
                            stipo = "Int32";
                            break;
                        case "decimal":
                        case "numeric":
                            stipo = "Decimal";
                            break;
                        case "datetime":
                            stipo = "DateTime";
                            break;
                    }

                    query.Append("\t\t public " + stipo + " " + objE.Propiedad + "{").AppendLine();
                    query.Append("\t\t\t get { return " + scampo + ";}").AppendLine();
                    query.Append("\t\t\t set { " + scampo + "= value;}").AppendLine();
                    query.Append("\t\t }").AppendLine().AppendLine();
                }
            }

            query.Append("\t }").AppendLine();
            query.Append("}");
            txtQuery.Text = query.ToString();

        }

        #endregion

    }
}
