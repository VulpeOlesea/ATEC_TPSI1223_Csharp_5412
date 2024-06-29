using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe3
{
    public partial class Form1 : Form
    {
        private int valor = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rodar_Click_1(object sender, EventArgs e)
        {
            valor -= 50;

            Random aleatorio = new Random();

            for (int i = 0; i < 10; i++)
            {
                lbl_und1.Text = aleatorio.Next(0, 10).ToString();
                lbl_und1.Refresh();

                lbl_und2.Text = aleatorio.Next(0, 10).ToString();
                lbl_und2.Refresh();

                lbl_und3.Text = aleatorio.Next(0, 10).ToString();
                lbl_und3.Refresh();

                System.Threading.Thread.Sleep(200);
            } 

            if (lbl_und1.Text == lbl_und2.Text && lbl_und2.Text == lbl_und3.Text)
            {
                // se 3 numeros iguais
                valor += 500;
            }
            else if (lbl_und1.Text == lbl_und2.Text || lbl_und1.Text == lbl_und3.Text || lbl_und2.Text == lbl_und3.Text)
            {
                // se 2 numeros iguais
                valor += 250;
            }

            lbl_valor.Text = valor.ToString();
            lbl_valor.Refresh();
        }
    }
}
