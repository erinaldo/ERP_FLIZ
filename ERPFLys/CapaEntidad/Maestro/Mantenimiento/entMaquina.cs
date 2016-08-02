using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Mantenimiento
{
    public class entMaquina:entBase
    {
        private String c_Compania, c_Maquina, c_Descripcion, c_TipoMaquina, c_CentroCosto, c_CodMarca, c_CodModelo, c_NumeroDerie;
        private String c_MonedaCosto, c_MonedaCostoParada, c_Criticidad, c_TiempoGarantia, c_InformacionTecnica, c_Planos;
        private String c_CaracteristicasOperacion, c_Estado = "A", c_UltimoUsuario, c_Gas = "N", c_OtroRepresentante, c_Critica = "N";
        private String c_Paralelo = "N", c_Alquiler = "N", c_OpAU = "N", c_OpSA = "N", c_OpMN = "N", c_CodigoBarra, c_FamiliaInspeccion;
        private int n_PiezasMax, n_AnoGabricacion, n_AnoPuestaMarcha, n_ProvFabricante, n_ProvRepresentante, n_NivelCriticidad = 0;
        private Decimal n_Potencia = 0, n_CostoMaquinaHora = 0, n_PesoTotal = 0, n_Largo = 0, n_Ancho = 0, n_Altura = 0, n_PotencialTotal = 0;
        private Decimal n_PromedioHoraDia = 0, n_Costo = 0, n_CostoParada = 0, n_Turno1 = 0, n_Turno2 = 0, n_Turno3 = 0, n_TiempoPreparacion = 0;
        private Decimal n_TiempoRegulacion = 0;
        private DateTime d_UltimaFechaModificacion = DateTime.Now, d_FechaAnoPuestaMarcha;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Maquina
        {
            get { return c_Maquina; }
            set { c_Maquina = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String TipoMaquina
        {
            get { return c_TipoMaquina; }
            set { c_TipoMaquina = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public Decimal Potencia
        {
            get { return n_Potencia; }
            set { n_Potencia = value; }
        }

        public Int32 PiezasMax
        {
            get { return n_PiezasMax; }
            set { n_PiezasMax = value; }
        }

        public Decimal CostoMaquinaHora
        {
            get { return n_CostoMaquinaHora; }
            set { n_CostoMaquinaHora = value; }
        }

        public String CodMarca
        {
            get { return c_CodMarca; }
            set { c_CodMarca = value; }
        }

        public String CodModelo
        {
            get { return c_CodModelo; }
            set { c_CodModelo = value; }
        }

        public String NumeroDerie
        {
            get { return c_NumeroDerie; }
            set { c_NumeroDerie = value; }
        }

        public Int32 AnoGabricacion
        {
            get { return n_AnoGabricacion; }
            set { n_AnoGabricacion = value; }
        }

        public Int32 AnoPuestaMarcha
        {
            get { return n_AnoPuestaMarcha; }
            set { n_AnoPuestaMarcha = value; }
        }

        public Int32 ProvFabricante
        {
            get { return n_ProvFabricante; }
            set { n_ProvFabricante = value; }
        }

        public Int32 ProvRepresentante
        {
            get { return n_ProvRepresentante; }
            set { n_ProvRepresentante = value; }
        }

        public Decimal PesoTotal
        {
            get { return n_PesoTotal; }
            set { n_PesoTotal = value; }
        }

        public Decimal Largo
        {
            get { return n_Largo; }
            set { n_Largo = value; }
        }

        public Decimal Ancho
        {
            get { return n_Ancho; }
            set { n_Ancho = value; }
        }

        public Decimal Altura
        {
            get { return n_Altura; }
            set { n_Altura = value; }
        }

        public Decimal PotencialTotal
        {
            get { return n_PotencialTotal; }
            set { n_PotencialTotal = value; }
        }

        public Decimal PromedioHoraDia
        {
            get { return n_PromedioHoraDia; }
            set { n_PromedioHoraDia = value; }
        }

        public String MonedaCosto
        {
            get { return c_MonedaCosto; }
            set { c_MonedaCosto = value; }
        }

        public Decimal Costo
        {
            get { return n_Costo; }
            set { n_Costo = value; }
        }

        public String MonedaCostoParada
        {
            get { return c_MonedaCostoParada; }
            set { c_MonedaCostoParada = value; }
        }

        public Decimal CostoParada
        {
            get { return n_CostoParada; }
            set { n_CostoParada = value; }
        }

        public String Criticidad
        {
            get { return c_Criticidad; }
            set { c_Criticidad = value; }
        }

        public String TiempoGarantia
        {
            get { return c_TiempoGarantia; }
            set { c_TiempoGarantia = value; }
        }

        public String InformacionTecnica
        {
            get { return c_InformacionTecnica; }
            set { c_InformacionTecnica = value; }
        }

        public String Planos
        {
            get { return c_Planos; }
            set { c_Planos = value; }
        }

        public String CaracteristicasOperacion
        {
            get { return c_CaracteristicasOperacion; }
            set { c_CaracteristicasOperacion = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public Decimal Turno1
        {
            get { return n_Turno1; }
            set { n_Turno1 = value; }
        }

        public Decimal Turno2
        {
            get { return n_Turno2; }
            set { n_Turno2 = value; }
        }

        public Decimal Turno3
        {
            get { return n_Turno3; }
            set { n_Turno3 = value; }
        }

        public Decimal TiempoPreparacion
        {
            get { return n_TiempoPreparacion; }
            set { n_TiempoPreparacion = value; }
        }

        public Decimal TiempoRegulacion
        {
            get { return n_TiempoRegulacion; }
            set { n_TiempoRegulacion = value; }
        }

        public String Gas
        {
            get { return c_Gas; }
            set { c_Gas = value; }
        }

        public String OtroRepresentante
        {
            get { return c_OtroRepresentante; }
            set { c_OtroRepresentante = value; }
        }

        public DateTime FechaAnoPuestaMarcha
        {
            get { return d_FechaAnoPuestaMarcha; }
            set { d_FechaAnoPuestaMarcha = value; }
        }

        public String Critica
        {
            get { return c_Critica; }
            set { c_Critica = value; }
        }

        public Int32 NivelCriticidad
        {
            get { return n_NivelCriticidad; }
            set { n_NivelCriticidad = value; }
        }

        public String Paralelo
        {
            get { return c_Paralelo; }
            set { c_Paralelo = value; }
        }

        public String Alquiler
        {
            get { return c_Alquiler; }
            set { c_Alquiler = value; }
        }

        public String OpAU
        {
            get { return c_OpAU; }
            set { c_OpAU = value; }
        }

        public String OpSA
        {
            get { return c_OpSA; }
            set { c_OpSA = value; }
        }

        public String OpMN
        {
            get { return c_OpMN; }
            set { c_OpMN = value; }
        }

        public String CodigoBarra
        {
            get { return c_CodigoBarra; }
            set { c_CodigoBarra = value; }
        }

        public String FamiliaInspeccion
        {
            get { return c_FamiliaInspeccion; }
            set { c_FamiliaInspeccion = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}