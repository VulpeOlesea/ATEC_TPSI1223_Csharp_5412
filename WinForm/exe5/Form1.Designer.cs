namespace exe5
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
            this.lb_caminho = new System.Windows.Forms.Label();
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_caminho
            // 
            this.lb_caminho.AutoSize = true;
            this.lb_caminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_caminho.Location = new System.Drawing.Point(70, 50);
            this.lb_caminho.Name = "lb_caminho";
            this.lb_caminho.Size = new System.Drawing.Size(106, 26);
            this.lb_caminho.TabIndex = 0;
            this.lb_caminho.Text = "Caminho:";
            // 
            // tb_caminho
            // 
            this.tb_caminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_caminho.Location = new System.Drawing.Point(179, 53);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(573, 24);
            this.tb_caminho.TabIndex = 1;
            // 
            // btn_carregar
            // 
            this.btn_carregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregar.Location = new System.Drawing.Point(75, 435);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(461, 56);
            this.btn_carregar.TabIndex = 2;
            this.btn_carregar.Text = "Carregar imagem";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(75, 107);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(676, 301);
            this.pb_imagem.TabIndex = 3;
            this.pb_imagem.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(553, 435);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(198, 56);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyrightToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // copyrightToolStripMenuItem
            // 
            this.copyrightToolStripMenuItem.Name = "copyrightToolStripMenuItem";
            this.copyrightToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyrightToolStripMenuItem.Text = "Copyright";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 556);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.pb_imagem);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.tb_caminho);
            this.Controls.Add(this.lb_caminho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_caminho;
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightToolStripMenuItem;
    }
}

