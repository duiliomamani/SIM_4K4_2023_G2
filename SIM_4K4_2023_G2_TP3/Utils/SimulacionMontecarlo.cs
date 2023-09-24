using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_4K4_2023_G2_TP3.Utils
{
    internal class SimulacionMontecarlo
    {
        Random random = new Random();
        private int n;
        public DataTable montecarlo;
        private double utilidad;
        private double costo;
        DataTable pasajeros;

        public SimulacionMontecarlo(int n, double utilidad, double costo, DataTable pasajeros)
        {
            this.n = n;
            this.utilidad = utilidad;
            this.costo = costo;
            this.pasajeros = pasajeros;
            this.montecarlo = new DataTable();

            generarTablaMontecarlo(montecarlo);
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
            for (int i = 0; i < n; i++)
            {
                double rnd = redondear(random.NextDouble());
                int _pasajeros = buscarPasajeros(rnd);
                double _utilidad = calcularUtilidad(_pasajeros);
                string sobreventa = existeSobreventa(_pasajeros);
                double _utilidadNeta = calcularUtilidadNeta(_utilidad, _pasajeros);
                double _promedio = calcularPromedio(promAnt, i, _utilidadNeta);
                promAnt = _promedio;


                montecarlo.Rows.Add(i, rnd, _pasajeros,
                    _utilidad,
                    sobreventa,
                    _utilidadNeta,
                    _promedio);



            }
        }

        private double calcularPromedio(double promAnt, int i, double utilidadNeta)
        {
            double promedio = (promAnt * (i - 1) + utilidadNeta) / 1;
            return promedio;
        }

        private double calcularUtilidad(int pasajeros)
        {
            double utld = pasajeros * this.utilidad;

            return utld;
        }

        private double calcularUtilidadNeta(double utilidad, int pasajeros)
        {
            double utilidadNeta;
            if (pasajeros > 40)
            {
                utilidadNeta = utilidad - (pasajeros - 40) * this.costo;
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
            foreach (DataRow row in pasajeros.Rows)
            {
                if (rnd >= double.Parse(row["intervalo desde"].ToString()) && rnd <= double.Parse(row["intervalo hasta"].ToString()))
                {
                    return int.Parse(row["Pasajeros"].ToString());
                }
            }
            return -1;
        }

        private double redondear(double value)
        {
            return Math.Truncate(value * 100) / 100;
        }
    }
}
