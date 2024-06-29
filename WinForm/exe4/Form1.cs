using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exe4
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_1.Text) || string.IsNullOrWhiteSpace(tb_2.Text))
            {
                MessageBox.Show("Escreva dois numeros!");
            }

            double num1 = Convert.ToDouble(tb_1.Text);
            double num2 = Convert.ToDouble(tb_2.Text);
            double result = 0;
            
            if (rb_somar.Checked)
            {
                result = num1 + num2;
            }
            else if (rb_subtrair.Checked)
            {
                result = num1 - num2;
            }
            else if (rb_multiplicar.Checked)
            {
                result = num1 * num2;
            }
            else if (rb_dividir.Checked)
            {
                result = num1 / num2;
            }

            lb_result.Text = result.ToString();
        }
    }
}
