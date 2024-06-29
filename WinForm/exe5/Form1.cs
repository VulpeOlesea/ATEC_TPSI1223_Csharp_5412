using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher a foto";
            openFileDialog1.Filter = "Ficheiros PNG|*.png|Ficheiros JPG|*.jpg|Ficheiros Gif|*.gif|Todos os ficheiros|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) // если нажимаем ОК то картинка загружается
            {
                tb_caminho.Text = openFileDialog1.FileName;
                pb_imagem.Image = new Bitmap(openFileDialog1.OpenFile());
                pb_imagem.SizeMode = PictureBoxSizeMode.StretchImage; // растягивает картинку на всю длину бокса
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
           int resposta = Convert.ToInt32(MessageBox.Show("Pretende sair?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
           
            if (resposta == 6) // кнопки ответов имеют свои цифры: 6 - это да, 7 - нет.
            {
                Application.Exit();
            }
        }
    }
}
