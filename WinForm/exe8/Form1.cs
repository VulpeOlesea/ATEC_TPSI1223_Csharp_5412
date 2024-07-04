using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace exe8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolher ficheiro XML";
            openFileDialog1.Filter = "Ficheiros XML| *. xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_caminho.Text = openFileDialog1.FileName;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(tb_caminho.Text);

            XmlNodeList nodeList = doc.SelectNodes("VGames/Game");

            foreach (XmlNode no in nodeList)
            {
                if (!cbb_plataformas.Items.Contains(no.SelectSingleNode("Platform").InnerText))
                {
                    cbb_plataformas.Items.Add(no.SelectSingleNode("Platform").InnerText);
                }                 
            }            
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var jogos = from jogo in xmlDoc.Descendants("Game")
                        select new
                        {
                            Titulo = jogo.Element("Title").Value,
                            Plataforma = jogo.Element("Platform").Value,
                        };    

            foreach (var jogo in jogos)
            {
                rtb_conteudo.Text += jogo.Titulo + " - " +jogo.Plataforma + "\n";
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            rtb_conteudo.Text = "";

            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var jogos = from jogo in xmlDoc.Descendants("Game")
                        where jogo.Element("Platform").Value == cbb_plataformas.SelectedItem.ToString()
                        select new
                        {
                            Titulo = jogo.Element("Title").Value,
                            Plataforma = jogo.Element("Platform").Value,
                        };

            foreach (var jogo in jogos)
            {
                rtb_conteudo.Text += jogo.Titulo + " - " + jogo.Plataforma + "\n";
            }
        }
    }
}
