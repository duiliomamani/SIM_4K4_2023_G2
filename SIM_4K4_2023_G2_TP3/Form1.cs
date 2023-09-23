using SIM_4K4_2023_G2_TP3.Model;
using System.Globalization;

namespace SIM_4K4_2023_G2_TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDtProb();

            txt_n.Text = 100000.ToString();
            txt_i.Text = 0.ToString();
            txt_j.Text = 200.ToString();
            txt_u.Text = 100.ToString();
            txt_c.Text = 150.ToString();
        }
        private void CreateDtProb()
        {
            dtg_prob.Columns.Add("passenger", "Pasajeros que se presentan");
            dtg_prob.Columns.Add("probability", "Probabilidad");


            IList<Probability> probabilities = new List<Probability>() {
             new (){ passenger = 38, probability = 0.05d },
             new (){ passenger = 39, probability = 0.25d },
             new (){ passenger = 40, probability = 0.45d },
             new (){ passenger = 41, probability = 0.15d },
             new (){ passenger = 42, probability = 0.05d },
             new (){ passenger = 43, probability = 0.05d }
            };

            foreach (var p in probabilities)
            {
                dtg_prob.Rows.Add(p.passenger, p.probability);
            }

            dtg_prob.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtg_prob.ScrollBars = ScrollBars.None;
            dtg_prob.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtg_prob.AutoSize = true;
            dtg_prob.AllowUserToOrderColumns = false;

            foreach (DataGridViewColumn col in dtg_prob.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable; // Deshabilitamos la ordenación en la columna
            }
        }

        #region Validators
        private void txt_number_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //No vacio
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                e.Cancel = true;
                (sender as TextBox).Focus();
                errorProviderApp.SetError((sender as TextBox), $"No debe estar vacio.");
            }
            //Tipo de dato correcto
            else if (!int.TryParse((sender as TextBox).Text, NumberStyles.Float, CultureInfo.InvariantCulture, out int n) || (n <= 0))
            {
                e.Cancel = true;
                (sender as TextBox).Focus();
                errorProviderApp.SetError((sender as TextBox), $"Es de tipo incorrecto.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError((sender as TextBox), "");
            }
        }
        private void dtg_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Console.WriteLine("Hola");
        }
        #endregion

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
            }
        }
    }
}