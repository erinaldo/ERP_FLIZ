using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entAsientoModeloDet : entBase
    {
        private String c_Compania, c_Modelo, c_Cuenta, c_CentroCosto, c_Documento, c_Descripcion, c_UltimoUsuarioMod, c_Cuenta_Ant;
        private int n_Linea, n_Persona;
        private Decimal n_Porcentaje = 0, n_Monto = 0;
        private DateTime d_UltimaFechaMod;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Modelo
        {
            get { return c_Modelo; }
            set { c_Modelo = value; }
        }

        public Int32 Linea
        {
            get { return n_Linea; }
            set { n_Linea = value; }
        }

        public String Cuenta
        {
            get { return c_Cuenta; }
            set { c_Cuenta = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public Int32 Persona
        {
            get { return n_Persona; }
            set { n_Persona = value; }
        }

        public String Documento
        {
            get { return c_Documento; }
            set { c_Documento = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public Decimal Porcentaje
        {
            get { return n_Porcentaje; }
            set { n_Porcentaje = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public String Cuenta_Ant
        {
            get { return c_Cuenta_Ant; }
            set { c_Cuenta_Ant = value; }
        }

        public Decimal Monto
        {
            get { return n_Monto; }
            set { n_Monto = value; }
        }

    }
}