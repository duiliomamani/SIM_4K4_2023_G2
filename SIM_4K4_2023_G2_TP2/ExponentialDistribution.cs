using SIM_4K4_2023_G2_TP2.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_4K4_2023_G2_TP2
{
    public partial class ExponentialDistribution : Form
    {
        private double[] _randomValues;
        private (double LI, double LS, double FE, double FO)[] _intervalsValues;
        private int _n;
        public ExponentialDistribution()
        {
            InitializeComponent();
        }

        private DataTable generateDataTable()
        {
            //Generador de la dataTable
            var _dt_gridUniformDistr = new DataTable();
            _dt_gridUniformDistr.Columns.Add("n");
            _dt_gridUniformDistr.Columns.Add("EXP()");
            return _dt_gridUniformDistr;
        }
        private void generateListUniformDistr()
        {
            dt_gridExpDistr.VirtualMode = true;

            Cursor.Current = Cursors.WaitCursor;

            double lamba;

            //if(radiobtn_lamba.Checked)


            //double _upper = double.Parse(tx.Text, CultureInfo.InvariantCulture);
            //double _lower = double.Parse(txt_lower.Text, CultureInfo.InvariantCulture);
            //_n = int.Parse(txt_n.Text, CultureInfo.InvariantCulture);

            //_randomValues = new double[_n];

            //var _dt_gridUniformDistr = generateDataTable();

            //for (int i = 0; i < _n; i++)
            //{
            //    //Barra de progreso 
            //    progressBar.Value = (int)(100 / double.Parse(_n.ToString()) * (i + 1));

            //    //Calculo numero random
            //    double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());

            //    //Formula de la distribucion uniforme
            //    double _value = DoubleUtils.TruncateNumber(_lower + _rnd * (_upper - _lower));

            //    //Agrego a la lista o tabla para mostrar
            //    _dt_gridUniformDistr.Rows.Add(i + 1, _rnd, _value);

            //    //Lo guardo en un array o lista
            //    _randomValues[i] = _value;
            //}

            //dt_gridUniformDistr.DataSource = _dt_gridUniformDistr;
            //progressBar.Value = 100;
            //generateInterval();
            //Cursor.Current = Cursors.Default;
        }
        //Restriccion de solo numeros a los textBox
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Solamente dejo que el . sea separador decimal
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        #region Validations

        //Validaciones del tamaño de la muestra
        private void txt_lm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //No vacio
            if (string.IsNullOrWhiteSpace(txt_lm.Text))
            {
                e.Cancel = true;
                txt_lm.Focus();
                errorProviderApp.SetError(txt_lm, $"Lamba/Media no debe estar vacio.");
            }
            //Tipo de dato correcto
            else if (!double.TryParse(txt_lm.Text, out _))
            {
                e.Cancel = true;
                txt_lm.Focus();
                errorProviderApp.SetError(txt_lm, $"Lamba/Media es de tipo incorrecto.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txt_lm, "");
            }
        }

        //Validaciones del tamaño de la muestra
        private void txt_n_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //No vacio
            if (string.IsNullOrWhiteSpace(txt_n.Text))
            {
                e.Cancel = true;
                txt_n.Focus();
                errorProviderApp.SetError(txt_n, $"{lbl_n.Text} no debe estar vacio.");
            }
            //Tipo de dato correcto
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

        private void cmb_interval_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //No vacio
            if (string.IsNullOrWhiteSpace(cmb_interval.SelectedItem?.ToString()))
            {
                e.Cancel = true;
                cmb_interval.Focus();
                errorProviderApp.SetError(cmb_interval, $"{lbl_Interval.Text} debe seleccionar una opción.");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txt_n, "");
            }
        }
        #endregion
    }
}
