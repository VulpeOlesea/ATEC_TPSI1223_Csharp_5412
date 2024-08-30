using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace exe11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_net_share_Click(object sender, EventArgs e)
        {
            Process netshare = new Process();
            netshare.StartInfo.FileName = "net ";
            netshare.StartInfo.Arguments = "share";

            netshare.StartInfo.UseShellExecute = false;
            netshare.StartInfo.CreateNoWindow = true;
            netshare.StartInfo.RedirectStandardOutput = true;
            netshare.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850); //помогает писать буквы с акцентами и символы

            netshare.Start();
            rtb_mensagem.Text = netshare.StandardOutput.ReadToEnd();
        }

        private void btn_getmac_Click(object sender, EventArgs e)
        {
            Process getmac = new Process();
            getmac.StartInfo.FileName = "getmac ";

            getmac.StartInfo.UseShellExecute = false;
            getmac.StartInfo.CreateNoWindow = true;
            getmac.StartInfo.RedirectStandardOutput = true;
            getmac.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            getmac.Start();
            rtb_mensagem.Text = getmac.StandardOutput.ReadToEnd();
        }

        private void btn_testar_Click(object sender, EventArgs e)
        {
            Process ping = new Process();
            ping.StartInfo.FileName = "ping ";
            ping.StartInfo.Arguments = tb_endereco.Text;

            ping.StartInfo.UseShellExecute = false;
            ping.StartInfo.CreateNoWindow = true;
            ping.StartInfo.RedirectStandardOutput = true;
            ping.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            ping.Start();
            Cursor.Current = Cursors.WaitCursor;
            rtb_mensagem.Text = ping.StandardOutput.ReadToEnd();
            Cursor.Current = DefaultCursor;
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            Process ipconfig = new Process();
            ipconfig.StartInfo.FileName = "ipconfig ";

            ipconfig.StartInfo.UseShellExecute = false;
            ipconfig.StartInfo.CreateNoWindow = true;
            ipconfig.StartInfo.RedirectStandardOutput = true;
            ipconfig.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(850);

            if (rbl_all.Checked)
            {
                ipconfig.StartInfo.Arguments = "/all";
            }
            else if (rbl_release.Checked)
            {
                ipconfig.StartInfo.Arguments = "/release";
            }
            else if (rbl_renew.Checked)
            {
                ipconfig.StartInfo.Arguments = "/renew";
            }

            ipconfig.Start();
            Cursor.Current = Cursors.WaitCursor;
            rtb_mensagem.Text = ipconfig.StandardOutput.ReadToEnd();
            Cursor.Current = DefaultCursor;
        }
    }
}
