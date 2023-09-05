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
    public partial class NormalDistribution : Form
    {

        private double[] _randomValues;
        private (double LI, double LS, double FE, double FO)[] _intervalsValues;
        private int _n;
        private double _media;
        private double _desv;
        public NormalDistribution()
        {
            InitializeComponent();
        }

        private DataTable generateDataTable()
        {
            //Generador de la dataTable
            var _dt_gridUniformDistr = new DataTable();
            _dt_gridUniformDistr.Columns.Add("n");
            _dt_gridUniformDistr.Columns.Add("RND1");
            _dt_gridUniformDistr.Columns.Add("RND2");
            _dt_gridUniformDistr.Columns.Add("N()");

            return _dt_gridUniformDistr;
        }
        private void generateListNormalDistr()
        {
            dt_gridUniformDistr.VirtualMode = true;

            Cursor.Current = Cursors.WaitCursor;

            _media = double.Parse(txt_media.Text, CultureInfo.InvariantCulture);
            _desv = double.Parse(txt_desv.Text, CultureInfo.InvariantCulture);
            _n = int.Parse(text_n.Text, CultureInfo.InvariantCulture);

            _randomValues = new double[_n];


            var _dt_gridNormalDistr = generateDataTable();

            for (int i = 0; i < _n; i++)
            {
            
                //Calculo numeros random
                double aux1 = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());
                double aux2 = DoubleUtils.TruncateNumber(DoubleUtils.RandomNumber());

                //Fix ln(0) va al infinito
                aux1 = aux1 == 0 ? 1 : aux1;
                aux2 = aux2 == 0 ? 1 : aux2;

                //Formula de la distribucion normal(med,desv) Box Muller
                double z = DoubleUtils.TruncateNumber(Math.Sqrt(-2 * Math.Log(aux1)) * Math.Sin(2 * Math.PI * aux2) * _desv + _media);
                double z2 = DoubleUtils.TruncateNumber(Math.Sqrt(-2 * Math.Log(aux1)) * Math.Cos(2 * Math.PI * aux2) * _desv + _media);

                //Agrego a la lista o tabla para mostrar el primer numero normal
                _dt_gridNormalDistr.Rows.Add(i + 1, aux1.ToString() , aux2.ToString(), z);
                //Lo guardo en un array o lista
                _randomValues[i] = z;

                if (i == _n - 1)
                {
                    break;
                }

                i++;
                //Agrego a la lista o tabla para mostrar el segundo numero normal
                _dt_gridNormalDistr.Rows.Add(i + 1, aux1.ToString(), aux2.ToString(), z2);
                //Lo guardo en el mismo array o lista
                _randomValues[i] = z2;
            }

            dt_gridUniformDistr.DataSource = _dt_gridNormalDistr;
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
                    _min = DoubleUtils.TruncateNumber(_dtIntervals[i - 1].LS + 0.0001d);
                    _max = max + 0.0001d;
                }
                else
                {
                    // Si es cualquier otro intervalo, suma el max anterior + ancho de los intervalos + 0.0001 (Para ajustar y tomar todos los valores).
                    _min = DoubleUtils.TruncateNumber(_dtIntervals[i - 1].LS + 0.0001d);
                    _max = DoubleUtils.TruncateNumber(_min + amplitude + 0.0001d);
                }
                //Calculo la frecuencia
                double marca_clase = (_max + _min) / 2;

                double frecuency = DoubleUtils.TruncateNumber((Math.Pow(Math.E, -0.5 * Math.Pow((marca_clase - _media) / _desv, 2)) / (_desv * Math.Sqrt(2 * Math.PI)))* _n );

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
        private void btn_generationN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                generateListNormalDistr();
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
