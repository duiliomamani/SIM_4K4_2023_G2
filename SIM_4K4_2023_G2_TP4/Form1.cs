using SIM_4K4_2023_G2_TP4.Clases;
using System.Globalization;

namespace SIM_4K4_2023_G2_TP4
{
    public partial class frmPrincipal : Form
    {
        public int horaDesde;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            horaDesde = int.Parse(txt_desde_hora.Text);
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
            else if ((!int.TryParse((sender as MaskedTextBox).Text, NumberStyles.Float, CultureInfo.InvariantCulture, out int n) || (n <= 0)))
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
                var _simulate = new Simulacion(this);
                _simulate.simular();
                _simulate.mostrarDatos();

                dgv_simulacion.DataSource = _simulate.dataTable;
            }
        }
    }
}
