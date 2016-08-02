using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using FiltroLys.Domain.Sistema;
using System.Data;

namespace FiltroLys.ZLys.ModReporte.Reporte
{
    public partial class rptPrueba : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPrueba()
        {
            InitializeComponent();            
        }

        public String GenerarReport(String sCia, String sPeriodo) {
            String xcon = negConexion.getEntConexion().ConeccionString;
            sqlConnRPT.Connection.ConnectionString = xcon;            
            sqlConnRPT.Queries[0].Parameters[0].Value = sCia;
            sqlConnRPT.Queries[0].Parameters[1].Value = sPeriodo;            
            xrPeriodo.Text = sPeriodo;
            CreateDocument();
            return sqlConnRPT.Queries[0].Name;
        }

    }
}
