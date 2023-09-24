using SIM_4K4_2023_G2_TP3.Logic;
using System.Data;

namespace SIM_4K4_2023_G2_TP3.Utils
{
    internal class SimulacionMontecarlo
    {
        private int _n;
        public DataTable _montecarlo;
        private double _utility;
        private double _cost;
        IList<(int q_passenger, double probality, double p_ac, double li, double ls)> _limits;

        public SimulacionMontecarlo(int n, double utilidad, double costo, IList<(int q_passenger, double probality, double p_ac, double li, double ls)> limits)
        {
            _n = n;
            _utility = utilidad;
            _cost = costo;
            _limits = limits;
            _montecarlo = new DataTable();

            generarTablaMontecarlo(_montecarlo);
            simular(_montecarlo);
        }

        private void generarTablaMontecarlo(DataTable montecarlo)
        {
            montecarlo.Columns.Add("Reloj", typeof(int));
            montecarlo.Columns.Add("RND", typeof(string));
            montecarlo.Columns.Add("Pasajeros", typeof(int));
            montecarlo.Columns.Add("Utilidad", typeof(double));
            montecarlo.Columns.Add("Sobreventa", typeof(string));
            montecarlo.Columns.Add("Utilidad neta", typeof(string));
            montecarlo.Columns.Add("Promedio", typeof(double));
        }

        private void simular(DataTable montecarlo)
        {
            double promAnt = 0;
            for (int i = 1; i <= _n; i++)
            {
                double rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
                int _pasajeros = buscarPasajeros(rnd);
                double _utilidad = calcularUtilidad(_pasajeros);
                string sobreventa = existeSobreventa(_pasajeros);
                double _utilidadNeta = calcularUtilidadNeta(_utilidad, _pasajeros);
                double _promedio = calcularPromedio(promAnt, i, _utilidadNeta);
                promAnt = _promedio;

                montecarlo.Rows.Add(i, rnd, _pasajeros, _utilidad, sobreventa,_utilidadNeta, _promedio);
            }
        }

        private double calcularPromedio(double promAnt, int i, double utilidadNeta)
        {
            double promedio = (promAnt * (i - 1) + utilidadNeta) / i;
            return DoubleUtils.TruncateNumber(promedio);
        }

        private double calcularUtilidad(int pasajeros)
        {
            double utld = pasajeros * _utility;

            return utld;
        }

        private double calcularUtilidadNeta(double utilidad, int pasajeros)
        {
            double utilidadNeta;
            if (pasajeros > 40)
            {
                utilidadNeta = utilidad - (pasajeros - 40) * _cost;
            }
            else
            {
                utilidadNeta = utilidad;
            }

            return utilidadNeta;
        }

        private string existeSobreventa(int pasajeros)
        {
            if (pasajeros > 40)
            {
                return "S";
            }

            return "N";
        }

        private int buscarPasajeros(double rnd)
        {
            foreach (var l in _limits)
            {
                if(rnd == 0.997)
                {

                }
                if (rnd >= l.li && rnd <= l.ls)
                    return l.q_passenger;
            }
            return -1;
        }
    }
}
