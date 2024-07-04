using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_binario_Click(object sender, EventArgs e)
        {
            lb_resultado.Text = Convert.ToString(int.Parse(tb_decimal.Text), 2);
        }

        private void btn_octal_Click(object sender, EventArgs e)
        {
            lb_resultado.Text = Convert.ToString(int.Parse(tb_decimal.Text), 8);
        }

        private void btn_hexa_Click(object sender, EventArgs e)
        {
            lb_resultado.Text = Convert.ToString(int.Parse(tb_decimal.Text), 16);
        }
    }
}
