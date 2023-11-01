using SIM_4K4_2023_G2_TP4.Clases;
using System.Data;
using System.Globalization;

namespace SIM_4K4_2023_G2_TP4
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

            dgv_state.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_state.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_state.AllowUserToOrderColumns = false;

            dgv_state.Columns.Add("Objeto[i]", "Objeto[i]");
            dgv_state.Columns.Add("Estado", "Estado");
            dgv_state.Columns.Add("Hora", "Hora");
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

                dgv_state.Rows.Clear();
                dgv_simulacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_simulacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_simulacion.AllowUserToOrderColumns = false;
                dgv_simulacion.DataSource = _simulate.dataTable;
            }
        }

        private void dgv_simulacion_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView gv = sender as DataGridView;
            if (gv != null && gv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv.SelectedRows[0];
                var i = Convert.ToInt32(row.Cells["i"].Value);

                var _state_iteracion = _simulate._iteracion[i];
                i = 0;

                dgv_state.Rows.Clear();
                foreach (var s in _state_iteracion.ColaClientes)
                {
                    dgv_state.Rows.Add($"Cliente[{i}]", s.estado, s.hora_llegada);
                    i++;
                }
            }
        }
    }
}
