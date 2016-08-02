using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;*/
using FiltroLys.Type;
using FiltroLys.Model.Sistema;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.Funciones
{
    public class fnReport
    {
        public static void SetLoginRPT(/*ReportDocument mainInRD, */fnEnum.ConexionSQL conn = fnEnum.ConexionSQL.Lys)
        {
            //Parametro Connecion
            entConexion EObj = negConexion.getEntConexion(conn);

            //Informacion Conexion Reporte Principal
            /*TableLogOnInfo logonInfo = null;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in mainInRD.Database.Tables)
            {
                logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo.ServerName = EObj.Server;
                logonInfo.ConnectionInfo.DatabaseName = "";
                logonInfo.ConnectionInfo.UserID = EObj.Login;
                logonInfo.ConnectionInfo.Password = EObj.Password;
                table.ApplyLogOnInfo(logonInfo);
            }
            try
            {
                //Actualizando Conexion a SubReportes
                if (!mainInRD.IsSubreport && mainInRD.Subreports != null && mainInRD.Subreports.Count > 0)
                {
                    foreach (ReportDocument rd in mainInRD.Subreports)
                    {
                        SetLoginRPT(rd, conn);
                    }
                }
            }
            catch
            {
            }*/
        }
    }
}
