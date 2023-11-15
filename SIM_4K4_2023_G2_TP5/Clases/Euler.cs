using SIM_4K4_2023_G2_TP5.Logic;
using System.Data;

namespace SIM_4K4_2023_G2_TP5.Model
{
    internal class Euler
    {
        private static double _h;
        public double proxFinOrdenamiento = Double.MaxValue;
        private IList<(double t, double D, double dydx, double t1, double hdydx)> memoization; //optimización
        struct Keydc
        {
            public double dKey;
            public double cKey;
        }
        public Euler(double h)
        {
            _h = h;
            memoization = new List<(double t, double D, double dydx, double t1, double hdydx)>(); //optimization
        }

        public double calcularUnidadesDeIntegracion(int C, double a, double R)
        {
            memoization.Clear();

            double actualD = 0.0d;
            double d1 = 0.0d;
            double actualt = 0.0d;
            double t1 = 0.0d;

            while (actualD < C)
            {
                double dydx = DoubleUtils.TruncateNumber(0.8d * C + actualt + a * R);
                actualD = DoubleUtils.TruncateNumber(d1);
                d1 += DoubleUtils.TruncateNumber(_h * dydx);
                actualt = DoubleUtils.TruncateNumber(t1);
                t1 = DoubleUtils.TruncateNumber(actualt +_h);
                memoization.Add((actualt, actualD, dydx, t1, d1));
            }

            return actualt;
        }

        public DataTable mostrarEuler()
        {
            var _dt_gridUniformDistr = new DataTable();
            _dt_gridUniformDistr.Columns.Add("t");
            _dt_gridUniformDistr.Columns.Add("D");
            _dt_gridUniformDistr.Columns.Add("dD/dt'");
            _dt_gridUniformDistr.Columns.Add("t+1'");
            _dt_gridUniformDistr.Columns.Add("D+1");

            foreach (var i in memoization)
            {
                _dt_gridUniformDistr.Rows.Add(i.t, i.D, i.dydx, i.t1, i.hdydx);
            }

            return _dt_gridUniformDistr;
        }

        public double generarProximaOrdenamiento(double reloj, int C, double a, double R)
        {
            double euler = calcularUnidadesDeIntegracion(C, a, R);
            proxFinOrdenamiento = reloj + euler;
            return euler;
        }
    }
}
