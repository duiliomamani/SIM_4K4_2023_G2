using SIM_4K4_2023_G2_TP2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_4K4_2023_G2_TP2
{
    public partial class Histogram : Form
    {
        private (double LI, double LS, double FE, double FO)[] _intervalsValues { get; set; }
        public Histogram((double LI, double LS, double FE, double FO)[] intervalsValues)
        {
            _intervalsValues = intervalsValues;

            InitializeComponent();

            draw_Histogram();
        }

        private void draw_Histogram()
        {
            chart.Series[0].Points.Clear();
            chart.Visible = true;
            chart.ChartAreas[0].AxisY.Title = "Frecuencia Observada";
            chart.ChartAreas[0].AxisY.Minimum = 0;

            // Establecer el tipo de gráfico en Column
            chart.Series[0].ChartType = SeriesChartType.Column;

            // Ajustar el ancho de las columnas
            chart.Series[0]["PointWidth"] = "1";

            // Ajustar el desplazamiento del intervalo
            chart.ChartAreas[0].AxisX.IntervalOffset = 0.5;

            // Establecer IsXValueIndexed en true
            chart.Series[0].IsXValueIndexed = true;

            // Ocultar las líneas de la cuadrícula vertical
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart.Series[0].IsValueShownAsLabel = true;

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart.ChartAreas[0].AxisX.Interval = 1;

            for (int i = 0; i < _intervalsValues.Count(); i++)
            {
                chart.Series[0].Points.AddXY($"[{_intervalsValues[i].LI}, {_intervalsValues[i].LS})", _intervalsValues[i].FO);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
