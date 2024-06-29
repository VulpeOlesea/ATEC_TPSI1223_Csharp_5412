using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Olá {tb_nome.Text}!");
        }

        private void cbb_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_concelho.Items.Clear(); // Стирает вторую строку, каждый раз, при новом выборе 

            if(cbb_distrito.SelectedItem.ToString() == "Setúbal") 
                // с каждым выбором в 1 строке, дроплист во 2 строке меняется в соответствии с указанным списком 
            {
                cbb_concelho.Items.Add("Alcásar do Sol");
                cbb_concelho.Items.Add("Almada");
            }
            else if (cbb_distrito.SelectedItem.ToString() == "Lisboa")
            {
                cbb_concelho.Items.Add("Amadora");
                cbb_concelho.Items.Add("Odivelas");
                cbb_concelho.Items.Add("Olivais");
            }
            else if (cbb_distrito.SelectedItem.ToString() == "Porto")
            {
                cbb_concelho.Items.Add("Matosinhos");
                cbb_concelho.Items.Add("Gondomar");
                cbb_concelho.Items.Add("Gaia");
            }
        }
    }
}
