using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Sistema;

namespace FiltroLys.Repository
{
    public class Configuracion
    {
        public static String getCadConexion(fnEnum.ConexionSQL conn = fnEnum.ConexionSQL.Lys){
            String sIni = "";
            switch (conn) {
                case fnEnum.ConexionSQL.Lys:
                    sIni = fnConst.ConexionIniLys;
                    break;
                case fnEnum.ConexionSQL.Ibsa:
                    sIni = fnConst.ConexionIniIbsa;
                    break;
                case fnEnum.ConexionSQL.Iso9001:
                    sIni = fnConst.ConexionIniIso9001;
                    break;
            }
            
            StringBuilder CadConex = new StringBuilder();
            ReadIni Rx = new ReadIni("inidata.ini");
            CadConex.Append("data source = " + Rx.Read("ServerName", sIni) + "; ");
            CadConex.Append("initial catalog = " + Rx.Read("Database", sIni) + "; ");
            CadConex.Append("user id = " + Rx.Read("LogId", sIni) + "; ");
            CadConex.Append("password = " + Rx.Read("LogPass", sIni));
            return CadConex.ToString();
        }

        public static entConexion getEntConexion(fnEnum.ConexionSQL conn = fnEnum.ConexionSQL.Lys)
        {
            String sIni = "";
            entConexion eObj = new entConexion();
            switch (conn)
            {
                case fnEnum.ConexionSQL.Lys:
                    sIni = fnConst.ConexionIniLys;
                    break;
                case fnEnum.ConexionSQL.Ibsa:
                    sIni = fnConst.ConexionIniIbsa;
                    break;
                case fnEnum.ConexionSQL.Iso9001:
                    sIni = fnConst.ConexionIniIso9001;
                    break;
            }

            ReadIni Rx = new ReadIni("inidata.ini");
            eObj.Server = Rx.Read("ServerName", sIni);
            eObj.DataSource = Rx.Read("Database", sIni);
            eObj.Login = Rx.Read("LogId", sIni);
            eObj.Password = Rx.Read("LogPass", sIni);
            eObj.ConeccionString = "data source = " + eObj.Server + ";" +
                                   "initial catalog = " + eObj.DataSource + ";" +
                                   "user id = " + eObj.Login + ";" +
                                   "password = " + eObj.Password;
            return eObj;
        }

    }
}
