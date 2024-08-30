using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace exe12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void exploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Text = "";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Escolhe o ficheiro de texto";
            ofd.Filter = "Ficheiros de Texto| *. txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtb_area.Text = File.ReadAllText(ofd.FileName, Encoding.UTF7);
            }
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Escolhe o ficheiro de texto";
            sfd.Filter = "Ficheiros de Texto| *. txt";

            if (sfd.ShowDialog() == DialogResult.OK)

                rtb_area.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Redo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb_area.Paste();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtb_area.SelectionFont = fd.Font;
            }
                
        }

        private void coreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtb_area.SelectionColor = cd.Color;
            }  
        }
    }
}
