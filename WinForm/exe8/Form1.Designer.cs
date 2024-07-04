namespace exe8
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
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_todos = new System.Windows.Forms.Button();
            this.rtb_conteudo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_plataformas = new System.Windows.Forms.ComboBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_caminho
            // 
            this.tb_caminho.Location = new System.Drawing.Point(203, 66);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(593, 22);
            this.tb_caminho.TabIndex = 0;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(35, 55);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(144, 42);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Selecionar";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_todos
            // 
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.Location = new System.Drawing.Point(652, 124);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(144, 42);
            this.btn_todos.TabIndex = 2;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // rtb_conteudo
            // 
            this.rtb_conteudo.Location = new System.Drawing.Point(35, 124);
            this.rtb_conteudo.Name = "rtb_conteudo";
            this.rtb_conteudo.Size = new System.Drawing.Size(593, 279);
            this.rtb_conteudo.TabIndex = 3;
            this.rtb_conteudo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plataforma:";
            // 
            // cbb_plataformas
            // 
            this.cbb_plataformas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_plataformas.FormattingEnabled = true;
            this.cbb_plataformas.Location = new System.Drawing.Point(652, 232);
            this.cbb_plataformas.Name = "cbb_plataformas";
            this.cbb_plataformas.Size = new System.Drawing.Size(144, 28);
            this.cbb_plataformas.TabIndex = 5;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.Location = new System.Drawing.Point(652, 279);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(144, 66);
            this.btn_filtrar.TabIndex = 6;
            this.btn_filtrar.Text = "Filtrar para Plataforma";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cbb_plataformas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_conteudo);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.tb_caminho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.RichTextBox rtb_conteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_plataformas;
        private System.Windows.Forms.Button btn_filtrar;
    }
}

