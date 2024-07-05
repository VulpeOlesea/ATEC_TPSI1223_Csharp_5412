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

namespace exe10
{
    public partial class Form1 : Form
    {
        XmlDocument doc;

        public Form1()
        {
            InitializeComponent();
        }

         private void btn_escoler_Click(object sender, EventArgs e)
         {
            openFileDialog1.Title = "Escolher ficheiro XML";
            openFileDialog1.Filter = "Ficheiros XML| *. xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_caminho.Text = openFileDialog1.FileName;
            }
         }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            if (tb_caminho.Text == "")
            {
                MessageBox.Show("Atenção, terá de escolher um ficheiro XML primeiro");
            }
            else
            {
                doc = new XmlDocument();
                doc.Load(tb_caminho.Text);

                XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

                lst_imagens.Items.Clear();

                foreach (XmlNode no in nodeList)
                {
                    XmlElement elemento = no as XmlElement;

                    lst_imagens.Items.Add(elemento.Attributes.GetNamedItem("ficheiro").Value);
                }
            }
        }

        private void lst_imagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = nodeList.Item(lst_imagens.SelectedIndex);
            XmlElement elemento = no as XmlElement;

            tb_id.Text = elemento.Attributes.GetNamedItem("id").Value;
            tb_descricao.Text = elemento.Attributes.GetNamedItem("descricao").Value;
            tb_ficheiro.Text = elemento.Attributes.GetNamedItem("ficheiro").Value;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = nodeList.Item(lst_imagens.SelectedIndex);
            XmlElement elemento = no as XmlElement;

            elemento.Attributes.GetNamedItem("id").Value = tb_id.Text;
            elemento.Attributes.GetNamedItem("descricao").Value = tb_descricao.Text;
            elemento.Attributes.GetNamedItem("ficheiro").Value = tb_ficheiro.Text;

            doc.Save(tb_caminho.Text);

            int posicao = lst_imagens.SelectedIndex;

            // Refrescar os dados da listbox

            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

            lst_imagens.Items.Clear();

            foreach (XmlNode no2 in nodeList2)
            {
                XmlElement elemento2 = no2 as XmlElement;

                lst_imagens.Items.Add(elemento2.Attributes.GetNamedItem("ficheiro").Value);
            }

            lst_imagens.SelectedIndex = posicao;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = nodeList.Item(lst_imagens.SelectedIndex);
            XmlElement elemento = no as XmlElement;
            elemento.ParentNode.RemoveChild(no);

            doc.Save(tb_caminho.Text);

            // Regrescar a ListBox

            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

            lst_imagens.Items.Clear();

            foreach (XmlNode no2 in nodeList2)
            {
                XmlElement elemento2 = no2 as XmlElement;

                lst_imagens.Items.Add(elemento2.Attributes.GetNamedItem("ficheiro").Value);
            }

            tb_id.Text = "";
            tb_descricao.Text = "";
            tb_ficheiro.Text = "";
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            XmlNodeList nodeList = doc.SelectNodes(@"/galeria/imagem");

            XmlNode no = doc.SelectSingleNode("/galeria");
            XmlElement elemento = doc.CreateElement("imagem");
            elemento.SetAttribute("id", tb_id.Text);
            elemento.SetAttribute("descricao", tb_descricao.Text);
            elemento.SetAttribute("ficheiro", tb_ficheiro.Text);

            no.AppendChild(elemento);

            doc.Save(tb_caminho.Text);

            // Regrescar a ListBox

            XmlNodeList nodeList2 = doc.SelectNodes(@"/galeria/imagem");

            lst_imagens.Items.Clear();

            foreach (XmlNode no2 in nodeList2)
            {
                XmlElement elemento2 = no2 as XmlElement;

                lst_imagens.Items.Add(elemento2.Attributes.GetNamedItem("ficheiro").Value);

            }

            tb_id.Text = "";
            tb_descricao.Text = "";
            tb_ficheiro.Text = "";
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Existem {lst_imagens.Items.Count} imagens no ficheiro.");
        }
    }    
}
