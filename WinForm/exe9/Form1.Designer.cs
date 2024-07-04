namespace exe9
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
            this.btn_filtrar_curso = new System.Windows.Forms.Button();
            this.cbb_curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_conteudo = new System.Windows.Forms.RichTextBox();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.btn_filtrar_regime = new System.Windows.Forms.Button();
            this.cbb_regime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_filtrar_curso
            // 
            this.btn_filtrar_curso.BackColor = System.Drawing.SystemColors.Info;
            this.btn_filtrar_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar_curso.Location = new System.Drawing.Point(34, 214);
            this.btn_filtrar_curso.Name = "btn_filtrar_curso";
            this.btn_filtrar_curso.Size = new System.Drawing.Size(176, 66);
            this.btn_filtrar_curso.TabIndex = 13;
            this.btn_filtrar_curso.Text = "Filtrar para Curso";
            this.btn_filtrar_curso.UseVisualStyleBackColor = false;
            this.btn_filtrar_curso.Click += new System.EventHandler(this.btn_filtrar_curso_Click_1);
            // 
            // cbb_curso
            // 
            this.cbb_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_curso.FormattingEnabled = true;
            this.cbb_curso.Location = new System.Drawing.Point(34, 168);
            this.cbb_curso.Name = "cbb_curso";
            this.cbb_curso.Size = new System.Drawing.Size(176, 28);
            this.cbb_curso.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Curso:";
            // 
            // rtb_conteudo
            // 
            this.rtb_conteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_conteudo.Location = new System.Drawing.Point(20, 298);
            this.rtb_conteudo.Name = "rtb_conteudo";
            this.rtb_conteudo.Size = new System.Drawing.Size(593, 421);
            this.rtb_conteudo.TabIndex = 10;
            this.rtb_conteudo.Text = "";
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.Location = new System.Drawing.Point(469, 183);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(144, 42);
            this.btn_todos.TabIndex = 9;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click_1);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(469, 116);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(144, 42);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "Selecionar";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // tb_caminho
            // 
            this.tb_caminho.Location = new System.Drawing.Point(20, 65);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(593, 22);
            this.tb_caminho.TabIndex = 7;
            // 
            // btn_filtrar_regime
            // 
            this.btn_filtrar_regime.BackColor = System.Drawing.SystemColors.Info;
            this.btn_filtrar_regime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar_regime.Location = new System.Drawing.Point(233, 214);
            this.btn_filtrar_regime.Name = "btn_filtrar_regime";
            this.btn_filtrar_regime.Size = new System.Drawing.Size(174, 66);
            this.btn_filtrar_regime.TabIndex = 16;
            this.btn_filtrar_regime.Text = "Filtrar para Regime";
            this.btn_filtrar_regime.UseVisualStyleBackColor = false;
            this.btn_filtrar_regime.Click += new System.EventHandler(this.btn_filtrar_regime_Click);
            // 
            // cbb_regime
            // 
            this.cbb_regime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_regime.FormattingEnabled = true;
            this.cbb_regime.Location = new System.Drawing.Point(233, 168);
            this.cbb_regime.Name = "cbb_regime";
            this.cbb_regime.Size = new System.Drawing.Size(174, 28);
            this.cbb_regime.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Regime:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 746);
            this.Controls.Add(this.btn_filtrar_regime);
            this.Controls.Add(this.cbb_regime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_filtrar_curso);
            this.Controls.Add(this.cbb_curso);
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

        private System.Windows.Forms.Button btn_filtrar_curso;
        private System.Windows.Forms.ComboBox cbb_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_conteudo;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Button btn_filtrar_regime;
        private System.Windows.Forms.ComboBox cbb_regime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

