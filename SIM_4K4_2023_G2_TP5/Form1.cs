using SIM_4K4_2023_G2_TP2;
using SIM_4K4_2023_G2_TP5.Clases;
using System.Data;
using System.Globalization;

namespace SIM_4K4_2023_G2_TP5
{
    public partial class frmPrincipal : Form
    {
        private Simulacion _simulate { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            _simulate = new Simulacion(this);
        }

        private void txt_number_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //No vacio
            if (string.IsNullOrWhiteSpace((sender as MaskedTextBox).Text))
            {
                (sender as MaskedTextBox).Focus();
                errorProviderApp.SetError((sender as MaskedTextBox), $"No debe estar vacio.");
            }
            //Tipo de dato correcto
            else if ((!int.TryParse((sender as MaskedTextBox).Text, NumberStyles.Float, CultureInfo.InvariantCulture, out int n) || (n < 0)))
            {
                (sender as MaskedTextBox).Focus();
                errorProviderApp.SetError((sender as MaskedTextBox), $"Es de tipo incorrecto.");
            }
            else
            {
                errorProviderApp.SetError((sender as MaskedTextBox), "");
            }
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _simulate.simular();
                _simulate.mostrarDatos();

                dgv_simulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_simulacion.AllowUserToOrderColumns = false;
                dgv_simulacion.Font = new Font("Segoe UI", 14);
                dgv_simulacion.DataSource = _simulate.dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var last = _simulate._iteracion.LastOrDefault(x => x.Evento == Eventos.FinDeReparacion);
            int C = _simulate._iteracion.LastOrDefault(x => x.Evento == Eventos.FinDeReparacion).CantPiezas;
            int R = _simulate._iteracion.LastOrDefault(x => x.Evento == Eventos.FinDeReparacion).ColaReparacion;

            Euler euler = new Euler(double.Parse(txt_Euler.Text), C, double.Parse(txt_CTEa.Text), R);

            euler.ShowDialog();
        }
    }
}
