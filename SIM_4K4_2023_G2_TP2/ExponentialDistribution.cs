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
        private double _lamba;

        public ExponentialDistribution()
        {
            InitializeComponent();
        }

        private DataTable generateDataTable()
        {
            //Generador de la dataTable
            var _dt_gridExpDistr = new DataTable();
            _dt_gridExpDistr.Columns.Add("n");
            _dt_gridExpDistr.Columns.Add("RND");
            _dt_gridExpDistr.Columns.Add("EXP()");
            return _dt_gridExpDistr;
        }
        private void generateListExpDistr()
        {
            dt_gridExpDistr.VirtualMode = true;

            Cursor.Current = Cursors.WaitCursor;

            if (radiobtn_lamba.Checked)
                _lamba = double.Parse(txt_lm.Text, CultureInfo.InvariantCulture);
            else
                _lamba = 1 / double.Parse(txt_lm.Text, CultureInfo.InvariantCulture);


            _n = int.Parse(txt_n.Text, CultureInfo.InvariantCulture);

            _randomValues = new double[_n];

            var _dt_gridExpDistr = generateDataTable();

            for (int i = 0; i < _n; i++)
            {
                //Barra de progreso 
                progressBar.Value = (int)(100 / double.Parse(_n.ToString()) * (i + 1));

                //Calculo numero random
                double _rnd = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
                //Formula de la distribucion uniforme
                double _value = DoubleUtils.TruncateNumber(-1 / _lamba * Math.Log(1 - _rnd));

                //Agrego a la lista o tabla para mostrar
                _dt_gridExpDistr.Rows.Add(i + 1, _rnd, _value);

                //Lo guardo en un array o lista
                _randomValues[i] = _value;
            }

            dt_gridExpDistr.DataSource = _dt_gridExpDistr;
            progressBar.Value = 100;
            generateInterval();
            Cursor.Current = Cursors.Default;
        }

        // Genera un array de tuplas de intervalos min y max
        private void generateInterval()
        {
            int _cIntervals = int.Parse(cmb_interval.SelectedItem.ToString());

            //Genero un array de tuplas LI, LS, FE, FO
            (double LI, double LS, double FE, double FO)[] _dtIntervals = new (double LI, double LS, double FE, double FO)[_cIntervals];

            //Obtengo minimo y maximo
            double min = _randomValues.Min();
            double max = _randomValues.Max();

            //Calculo la amplitud
            double amplitude = (max - min) / _cIntervals;


            // Creación de los límites inferiores y superiores de los intervalos
            for (int i = 0; i < _cIntervals; i++)
            {
                double _max;
                double _min;

                if (i == 0)
                {
                    // Si es el primer intervalo, suma el minimo + ancho de los intervalos.
                    _max = DoubleUtils.TruncateNumber(min + amplitude);
                    _min = min;
                }
                else if (i == (_cIntervals - 1))
                {
                    // Seteo el maximo y el anterior intervalo obtengo el limite superior
                    _min = DoubleUtils.TruncateNumber(_dtIntervals[i - 1].LS);
                    _max = DoubleUtils.TruncateNumber(max + 0.0001d);
                }
                else
                {
                    // Si es cualquier otro intervalo, suma el max anterior + ancho de los intervalos + 0.0001 (Para ajustar y tomar todos los valores).
                    _min = DoubleUtils.TruncateNumber(_dtIntervals[i - 1].LS);
                    _max = DoubleUtils.TruncateNumber(_min + amplitude);
                }
                //Calculo la frecuencia
                double marca = (_max + _min) / 2;
                double frecuency = (DoubleUtils.TruncateNumber((_lamba * (Math.Exp(-_lamba * marca)) * (_max - _min)) * _n));

                //Defino las tuplas
                _dtIntervals[i] = (LI: _min, LS: _max, FE: frecuency, FO: 0);
            }

            //Calculo las freecuencias observadas para cada intervalo dependiendo los valores generados
            for (int j = 0; j < _n; j++)
            {
                for (int i = 0; i < _cIntervals; i++)
                {
                    if (_randomValues[j] >= _dtIntervals[i].LI && _randomValues[j] < _dtIntervals[i].LS)
                    {
                        _dtIntervals[i].FO += 1;
                    }
                }
            }

            _intervalsValues = _dtIntervals;
            //Generador de la dataTable
            var _dt_gridData = new DataTable();
            _dt_gridData.Columns.Add("LI");
            _dt_gridData.Columns.Add("LS");
            _dt_gridData.Columns.Add("FE");
            _dt_gridData.Columns.Add("FO");

            //Seteo la vista de la tabla
            foreach (var data in _dtIntervals)
            {
                _dt_gridData.Rows.Add(data.LI, data.LS, data.FE, data.FO);
            }

            dt_gridData.DataSource = _dt_gridData;
        }
        //Restriccion de solo numeros a los textBox
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
                    && (e.KeyChar != '.') && (e.KeyChar != '-'))
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
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
            else if (!double.TryParse(txt_lm.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
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

        private void btn_generationU_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                generateListExpDistr();
            }
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {

            Histogram _formHistogram = new Histogram(_intervalsValues);
            //_formHistogram.intervalos_seleccionado = intervalos_seleccionado;
            //formHistograma.serie_generada = serie_generada;
            _formHistogram.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
