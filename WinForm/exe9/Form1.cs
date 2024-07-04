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

namespace exe9
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

            XmlNodeList nodeList = doc.SelectNodes("Formandos/Formando");

            foreach (XmlNode no in nodeList)
            {
                if (!cbb_curso.Items.Contains(no.SelectSingleNode("Curso").InnerText))
                {
                    cbb_curso.Items.Add(no.SelectSingleNode("Curso").InnerText);
                }

                if (!cbb_regime.Items.Contains(no.SelectSingleNode("Regime").InnerText))
                {
                    cbb_regime.Items.Add(no.SelectSingleNode("Regime").InnerText);
                }

            }
        }

        private void btn_todos_Click_1(object sender, EventArgs e)
        {
            rtb_conteudo.Text = "";

            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var formandos = from id in xmlDoc.Descendants("Formando")
                            select new
                            {
                                idFormando = id.Element("idFormando").Value,
                                Nome = id.Element("Nome").Value,
                                Morada = id.Element("Morada").Value,
                                Telemovel = id.Element("Telemovel").Value,
                                Curso = id.Element("Curso").Value,
                                Regime = id.Element("Regime").Value,
                            };

            foreach (var id in formandos)
            {
                rtb_conteudo.Text += id.idFormando + " - " + id.Nome + " - " + id.Morada + " - " + id.Telemovel + " - " + id.Curso + " - " + id.Regime + "\n";
            }
        }

        private void btn_filtrar_curso_Click_1(object sender, EventArgs e)
        {
            rtb_conteudo.Text = "";

            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var formandos = from id in xmlDoc.Descendants("Formando")
                            where id.Element("Curso").Value == cbb_curso.SelectedItem.ToString()
                            select new
                            {
                                idFormando = id.Element("idFormando").Value,
                                Nome = id.Element("Nome").Value,
                                Morada = id.Element("Morada").Value,
                                Telemovel = id.Element("Telemovel").Value,
                                Curso = id.Element("Curso").Value,
                                Regime = id.Element("Regime").Value,
                            };

            foreach (var id in formandos)
            {
                rtb_conteudo.Text += id.idFormando + " - " + id.Nome + " - " + id.Morada + " - " + id.Telemovel + " - " + id.Curso + " - " + id.Regime + "\n";
            }
        }

        private void btn_filtrar_regime_Click(object sender, EventArgs e)
        {
            rtb_conteudo.Text = "";

            XDocument xmlDoc = XDocument.Load(tb_caminho.Text);

            var formandos = from id in xmlDoc.Descendants("Formando")
                            where id.Element("Regime").Value == cbb_regime.SelectedItem.ToString()
                            select new
                            {
                                idFormando = id.Element("idFormando").Value,
                                Nome = id.Element("Nome").Value,
                                Morada = id.Element("Morada").Value,
                                Telemovel = id.Element("Telemovel").Value,
                                Curso = id.Element("Curso").Value,
                                Regime = id.Element("Regime").Value,
                            };

            foreach (var id in formandos)
            {
                rtb_conteudo.Text += id.idFormando + " - " + id.Nome + " - " + id.Morada + " - " + id.Telemovel + " - " + id.Curso + " - " + id.Regime + "\n";
            }
        }
    }
}
