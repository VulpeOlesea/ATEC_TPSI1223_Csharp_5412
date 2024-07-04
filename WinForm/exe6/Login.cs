using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            if (tb_utilizador.Text == "admin" && tb_pw.Text == "123")
            {
                Form1 formulario = new Form1(); // Открывает новое окно и закрывает это
                formulario.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Utilizador ou palavra-passe errados");
            }

        }
    }
}
