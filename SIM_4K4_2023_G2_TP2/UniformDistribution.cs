using SIM_4K4_2023_G2_TP2.Logic;
using System.Data;

namespace SIM_4K4_2023_G2_TP2
{
    public partial class UniformDistribution : Form
    {
        private double[] _randomValues;

        public UniformDistribution()
        {
            InitializeComponent();
        }
        private DataTable dataTable()
        {
            var _dt_gridUniformDistr = new DataTable();
            _dt_gridUniformDistr.Columns.Add("n");
            _dt_gridUniformDistr.Columns.Add("RND");
            _dt_gridUniformDistr.Columns.Add("U(A,B)");
            return _dt_gridUniformDistr;
        }
        private void generateListUniformDistr()
        {
            dt_gridUniformDistr.VirtualMode = true;

            Cursor.Current = Cursors.WaitCursor;

            double _upper = double.Parse(txt_upper.Text);
            double _lower = double.Parse(txt_lower.Text);
            int _n = int.Parse(txt_n.Text);

            _randomValues = new double[_n];

            var _dt_gridUniformDistr = dataTable();

            for (int i = 0; i < _n; i++)
            {
                progressBar.Value = (int)(100 / double.Parse(_n.ToString()) * (i + 1));
                double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
                double _value = DoubleUtils.TruncateNumber(_lower + _rnd * (_upper - _lower));

                _dt_gridUniformDistr.Rows.Add(i + 1, _rnd, _value);

                _randomValues[i] = _value;
            }

            dt_gridUniformDistr.DataSource = _dt_gridUniformDistr;
            progressBar.Value = 100;

            Cursor.Current = Cursors.Default;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_generationU_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                generateListUniformDistr();
            }
        }
        private void txt_lower_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_lower.Text))
            {
                e.Cancel = true;
                txt_lower.Focus();
                errorProviderApp.SetError(txt_lower, $"{lbl_lower.Text} no debe estar vacio.");
            }
            else if (!double.TryParse(txt_lower.Text, out _))
            {
                e.Cancel = true;
                txt_lower.Focus();
                errorProviderApp.SetError(txt_lower, $"{lbl_lower.Text} es de tipo incorrecto.");
            }
            else if (!string.IsNullOrWhiteSpace(txt_upper.Text) && double.Parse(txt_lower.Text) > double.Parse(txt_upper.Text))
            {
                e.Cancel = true;
                txt_lower.Focus();
                errorProviderApp.SetError(txt_lower, $"{lbl_lower.Text} debe ser menor que el limite superior.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txt_lower, "");
            }
        }
        private void txt_upper_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_upper.Text))
            {
                e.Cancel = true;
                txt_upper.Focus();
                errorProviderApp.SetError(txt_upper, $"{lbl_upper.Text} no debe estar vacio.");
            }
            else if (!double.TryParse(txt_upper.Text, out _))
            {
                e.Cancel = true;
                txt_upper.Focus();
                errorProviderApp.SetError(txt_upper, $"{lbl_upper.Text} es de tipo incorrecto.");
            }
            else if (!string.IsNullOrWhiteSpace(txt_lower.Text) && (double.Parse(txt_lower.Text) > double.Parse(txt_upper.Text)))
            {
                e.Cancel = true;
                txt_lower.Focus();
                errorProviderApp.SetError(txt_upper, $"{lbl_lower.Text} debe ser mayor que el limite inferior.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txt_upper, "");
            }
        }
        private void txt_n_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_n.Text))
            {
                e.Cancel = true;
                txt_n.Focus();
                errorProviderApp.SetError(txt_n, $"{lbl_n.Text} no debe estar vacio.");
            }
            else if (!int.TryParse(txt_n.Text, out _))
            {
                e.Cancel = true;
                txt_n.Focus();
                errorProviderApp.SetError(txt_n, $"{lbl_n.Text} es de tipo incorrecto.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txt_n, "");
            }
        }
    }
}