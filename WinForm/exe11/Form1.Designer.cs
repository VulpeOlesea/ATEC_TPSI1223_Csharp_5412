namespace exe11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_mensagem = new System.Windows.Forms.RichTextBox();
            this.btn_net_share = new System.Windows.Forms.Button();
            this.btn_getmac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_testar = new System.Windows.Forms.Button();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.rbl_release = new System.Windows.Forms.RadioButton();
            this.rbl_renew = new System.Windows.Forms.RadioButton();
            this.rbl_all = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_mensagem
            // 
            this.rtb_mensagem.Location = new System.Drawing.Point(282, 38);
            this.rtb_mensagem.Name = "rtb_mensagem";
            this.rtb_mensagem.Size = new System.Drawing.Size(632, 603);
            this.rtb_mensagem.TabIndex = 0;
            this.rtb_mensagem.Text = "";
            // 
            // btn_net_share
            // 
            this.btn_net_share.Location = new System.Drawing.Point(47, 38);
            this.btn_net_share.Name = "btn_net_share";
            this.btn_net_share.Size = new System.Drawing.Size(196, 60);
            this.btn_net_share.TabIndex = 1;
            this.btn_net_share.Text = "NET SHARE";
            this.btn_net_share.UseVisualStyleBackColor = true;
            this.btn_net_share.Click += new System.EventHandler(this.btn_net_share_Click);
            // 
            // btn_getmac
            // 
            this.btn_getmac.Location = new System.Drawing.Point(47, 123);
            this.btn_getmac.Name = "btn_getmac";
            this.btn_getmac.Size = new System.Drawing.Size(196, 60);
            this.btn_getmac.TabIndex = 2;
            this.btn_getmac.Text = "GETMAC";
            this.btn_getmac.UseVisualStyleBackColor = true;
            this.btn_getmac.Click += new System.EventHandler(this.btn_getmac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_testar);
            this.groupBox1.Controls.Add(this.tb_endereco);
            this.groupBox1.Location = new System.Drawing.Point(43, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PING";
            // 
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(35, 85);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(120, 35);
            this.btn_testar.TabIndex = 4;
            this.btn_testar.Text = "Testar";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(6, 41);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(188, 22);
            this.tb_endereco.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_executar);
            this.groupBox2.Controls.Add(this.rbl_release);
            this.groupBox2.Controls.Add(this.rbl_renew);
            this.groupBox2.Controls.Add(this.rbl_all);
            this.groupBox2.Location = new System.Drawing.Point(47, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 171);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IPCONFIG";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(31, 120);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(120, 35);
            this.btn_executar.TabIndex = 5;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            // 
            // rbl_release
            // 
            this.rbl_release.AutoSize = true;
            this.rbl_release.Location = new System.Drawing.Point(31, 84);
            this.rbl_release.Name = "rbl_release";
            this.rbl_release.Size = new System.Drawing.Size(94, 20);
            this.rbl_release.TabIndex = 8;
            this.rbl_release.TabStop = true;
            this.rbl_release.Text = "/RELEASE";
            this.rbl_release.UseVisualStyleBackColor = true;
            // 
            // rbl_renew
            // 
            this.rbl_renew.AutoSize = true;
            this.rbl_renew.Location = new System.Drawing.Point(31, 58);
            this.rbl_renew.Name = "rbl_renew";
            this.rbl_renew.Size = new System.Drawing.Size(83, 20);
            this.rbl_renew.TabIndex = 7;
            this.rbl_renew.TabStop = true;
            this.rbl_renew.Text = "/RENEW";
            this.rbl_renew.UseVisualStyleBackColor = true;
            // 
            // rbl_all
            // 
            this.rbl_all.AutoSize = true;
            this.rbl_all.Location = new System.Drawing.Point(31, 32);
            this.rbl_all.Name = "rbl_all";
            this.rbl_all.Size = new System.Drawing.Size(55, 20);
            this.rbl_all.TabIndex = 6;
            this.rbl_all.TabStop = true;
            this.rbl_all.Text = "/ALL";
            this.rbl_all.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_getmac);
            this.Controls.Add(this.btn_net_share);
            this.Controls.Add(this.rtb_mensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_mensagem;
        private System.Windows.Forms.Button btn_net_share;
        private System.Windows.Forms.Button btn_getmac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbl_release;
        private System.Windows.Forms.RadioButton rbl_renew;
        private System.Windows.Forms.RadioButton rbl_all;
        private System.Windows.Forms.Button btn_executar;
    }
}

