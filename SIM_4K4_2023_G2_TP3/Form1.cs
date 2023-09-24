using SIM_4K4_2023_G2_TP3.Model;
using System.Globalization;
using System.Windows.Forms;

namespace SIM_4K4_2023_G2_TP3
{
    public partial class Form1 : Form
    {
        public IList<(int q_passenger, double probality, double p_ac, double li, double ls)> _limits = new List<(int, double, double, double, double)>();

        public IList<Probability> _probabilites = new List<Probability>();
        public Form1()
        {
            InitializeComponent();
            CreateDtProb();

            txt_n.Text = 100000.ToString();
            txt_i.Text = 1.ToString();
            txt_j.Text = 200.ToString();
            txt_u.Text = 100.ToString();
            txt_c.Text = 150.ToString();
        }
        private void CreateDtProb()
        {
            dtg_prob.Columns.Add("passenger", "Pasajeros que se presentan");
            dtg_prob.Columns.Add("probability", "Probabilidad");
            dtg_prob.Columns.Add("p_ac", "P_AC");
            dtg_prob.Columns.Add("li", "LI");
            dtg_prob.Columns.Add("ls", "LS");

            _probabilites = new List<Probability>() {
                 new (){ passenger = 38, probability = 0.05d },
                 new (){ passenger = 39, probability = 0.25d },
                 new (){ passenger = 40, probability = 0.45d },
                 new (){ passenger = 41, probability = 0.15d },
                 new (){ passenger = 42, probability = 0.05d },
                 new (){ passenger = 43, probability = 0.05d }
            };

            foreach (var p in _probabilites)
            {
                dtg_prob.Rows.Add(p.passenger, p.probability.ToString(CultureInfo.InvariantCulture));
            }

            dtg_prob.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtg_prob.ScrollBars = ScrollBars.None;
            dtg_prob.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtg_prob.AutoSize = true;
            dtg_prob.AllowUserToOrderColumns = false;

            dtg_prob.Columns[2].ReadOnly = true;
            dtg_prob.Columns[3].ReadOnly = true;
            dtg_prob.Columns[4].ReadOnly = true;
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
                (sender as TextBox).Focus();
                errorProviderApp.SetError((sender as TextBox), $"No debe estar vacio.");
            }
            //Tipo de dato correcto
            else if (((sender as TextBox).Name.Equals("txt_c") || (sender as TextBox).Name.Equals("txt_u")) && (!double.TryParse((sender as TextBox).Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double c) || (c <= 0)))
            {
                (sender as TextBox).Focus();
                errorProviderApp.SetError((sender as TextBox), $"Es de tipo incorrecto.");
            }
            else if (!((sender as TextBox).Name.Equals("txt_c") || (sender as TextBox).Name.Equals("txt_u")) && (!int.TryParse((sender as TextBox).Text, NumberStyles.Float, CultureInfo.InvariantCulture, out int n) || (n <= 0)))
            {
                (sender as TextBox).Focus();
                errorProviderApp.SetError((sender as TextBox), $"Es de tipo incorrecto.");
            }
            else
            {
                errorProviderApp.SetError((sender as TextBox), "");
            }
        }
        private void dtg_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dtCell = (sender as DataGridView);
            //No vacio
            if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
            {
                dtCell.Rows[e.RowIndex].ErrorText = "No debe estar vacio.";
            }
            // Confirm that the cell is an integer.
            else if (dtCell.Columns[e.ColumnIndex].Name == nameof(Probability.passenger) && (!int.TryParse(e.FormattedValue.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out int p) || p <= 0))
            {
                dtCell.Rows[e.RowIndex].ErrorText = "Es de tipo incorrecto.";
            }
            // Confirm that the cell is an integer.
            else if (dtCell.Columns[e.ColumnIndex].Name == nameof(Probability.probability) && (!double.TryParse(e.FormattedValue.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double o) || o < 0))
            {
                dtCell.Rows[e.RowIndex].ErrorText = "Es de tipo incorrecto.";
            }
            else
            {
                dtCell.Rows[e.RowIndex].ErrorText = string.Empty;
            }
        }

        private void dtg_prob_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var dtCell = (sender as DataGridView);
            if (dtCell.IsCurrentRowDirty && dtCell.Rows.Count >= 6)
            {
                var sum = dtCell.Rows.OfType<DataGridViewRow>().Select(r => r.Cells[1]).Where(x => x.Value is not null).Sum(r => double.Parse((string)r.Value, NumberStyles.Float, CultureInfo.InvariantCulture));
                if (!sum.Equals(1))
                {
                    MessageBox.Show("La suma de las probilidades debe ser 1.");
                }
                var min = dtCell.Rows.OfType<DataGridViewRow>().Select(r => r.Cells[0]).Where(x => x.Value is not null).Min(r => int.Parse(r.Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture));
                var max = dtCell.Rows.OfType<DataGridViewRow>().Select(r => r.Cells[0]).Where(x => x.Value is not null).Max(r => int.Parse(r.Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture));
                if (min < 38 && max > 43)
                {
                    MessageBox.Show("La cantidad de pasajeros debe estar dada entre 38 y 43");
                }
            }
        }
        #endregion

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //if (dtg_prob.Rows.Count < 7)
                //{
                //    MessageBox.Show("Se deben incluir las cantidad de pasajeros \n y sus respectivas probabilidades");
                //}

                //Calculo los limites y probalidad acumulada
                Console.WriteLine($"Q_PASSENGER , PROBABILITY , P_AC , LI , LS");
                _limits.Clear();
                _probabilites = dtg_prob.Rows.OfType<DataGridViewRow>()
                                             .Where(x => x.Cells.OfType<DataGridViewCell>()
                                                                .Any(x => x.Value is not null))
                                             .Select(r => new Probability
                                             {
                                                 passenger = int.Parse(r.Cells[0].Value.ToString(), CultureInfo.InvariantCulture),
                                                 probability = double.Parse(r.Cells[1].Value.ToString(), CultureInfo.InvariantCulture)
                                             }).ToList();
                for (int i = 0; i < _probabilites.Count; i++)
                {
                    double p_ac;
                    double li;
                    double ls;
                    if (i == 0)
                    {
                        p_ac = Math.Round(_probabilites[i].probability, 2);
                        li = 0;
                        ls = Math.Round(_probabilites[i].probability == 0 ? 0 : _probabilites[i].probability - 0.01d, 2);
                    }
                    else
                    {
                        p_ac = Math.Round(_limits[i - 1].p_ac + _probabilites[i].probability, 2);
                        li = Math.Round(_limits[i - 1].ls + 0.01d, 2);
                        ls = Math.Round(p_ac - 0.01d, 2);
                    }

                    _limits.Add((_probabilites[i].passenger, _probabilites[i].probability, p_ac, li, ls));

                    dtg_prob.Rows[i].Cells[2].Value = p_ac.ToString(CultureInfo.InvariantCulture);
                    dtg_prob.Rows[i].Cells[3].Value = li.ToString(CultureInfo.InvariantCulture);
                    dtg_prob.Rows[i].Cells[4].Value = ls.ToString(CultureInfo.InvariantCulture);
                }



            }
        }
    }
}