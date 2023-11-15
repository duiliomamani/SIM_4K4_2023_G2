using System.Data;

namespace SIM_4K4_2023_G2_TP2
{
    public partial class Euler : Form
    {
        public Euler(double h, int C, double a, double R)
        {
            InitializeComponent();

            var euler = new SIM_4K4_2023_G2_TP5.Model.Euler(h);

            euler.calcularUnidadesDeIntegracion(C, a, R);

            dt_gridData.DataSource = euler.mostrarEuler();
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
