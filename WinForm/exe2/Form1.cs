using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            lst_formandos.Items.Add(tb_nome.Text); // Добавляет текст в форму 
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lst_formandos.Items.Remove(lst_formandos.SelectedItem); // Удаляет текст с формы
        }
    }
}
