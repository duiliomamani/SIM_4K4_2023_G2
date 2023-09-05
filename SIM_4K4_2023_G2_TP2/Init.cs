using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_4K4_2023_G2_TP2
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void btn_uniform_Click(object sender, EventArgs e)
        {
            UniformDistribution uniformDistribution = new UniformDistribution();

            uniformDistribution.Show();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            ExponentialDistribution expDistribution = new ExponentialDistribution();

            expDistribution.Show();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {

        }
    }
}
