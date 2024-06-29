namespace WinForm
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
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_curso = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lb_hobbies = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lb_distrito = new System.Windows.Forms.Label();
            this.lb_concelho = new System.Windows.Forms.Label();
            this.cbb_distrito = new System.Windows.Forms.ComboBox();
            this.cbb_concelho = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.Location = new System.Drawing.Point(449, 69);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(140, 52);
            this.btn_mostrar.TabIndex = 0;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(35, 82);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(85, 29);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(144, 84);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(288, 28);
            this.tb_nome.TabIndex = 2;
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curso.Location = new System.Drawing.Point(35, 142);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(83, 29);
            this.lb_curso.TabIndex = 3;
            this.lb_curso.Text = "Curso:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(160, 151);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CET TPSI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 178);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CET GRSI";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(160, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 20);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "EFA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // lb_hobbies
            // 
            this.lb_hobbies.AutoSize = true;
            this.lb_hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hobbies.Location = new System.Drawing.Point(313, 142);
            this.lb_hobbies.Name = "lb_hobbies";
            this.lb_hobbies.Size = new System.Drawing.Size(110, 29);
            this.lb_hobbies.TabIndex = 7;
            this.lb_hobbies.Text = "Hobbies:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Leitura",
            "Viajar",
            "Jogos"});
            this.checkedListBox1.Location = new System.Drawing.Point(449, 151);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(140, 106);
            this.checkedListBox1.TabIndex = 8;
            // 
            // lb_distrito
            // 
            this.lb_distrito.AutoSize = true;
            this.lb_distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distrito.Location = new System.Drawing.Point(37, 260);
            this.lb_distrito.Name = "lb_distrito";
            this.lb_distrito.Size = new System.Drawing.Size(118, 36);
            this.lb_distrito.TabIndex = 9;
            this.lb_distrito.Text = "Distrito:";
            // 
            // lb_concelho
            // 
            this.lb_concelho.AutoSize = true;
            this.lb_concelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_concelho.Location = new System.Drawing.Point(37, 310);
            this.lb_concelho.Name = "lb_concelho";
            this.lb_concelho.Size = new System.Drawing.Size(153, 36);
            this.lb_concelho.TabIndex = 10;
            this.lb_concelho.Text = "Concelho:";
            // 
            // cbb_distrito
            // 
            this.cbb_distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_distrito.FormattingEnabled = true;
            this.cbb_distrito.Items.AddRange(new object[] {
            "-------------",
            "Setúbal",
            "Lisboa",
            "Porto"});
            this.cbb_distrito.Location = new System.Drawing.Point(177, 260);
            this.cbb_distrito.Name = "cbb_distrito";
            this.cbb_distrito.Size = new System.Drawing.Size(200, 28);
            this.cbb_distrito.TabIndex = 11;
            this.cbb_distrito.SelectedIndexChanged += new System.EventHandler(this.cbb_distrito_SelectedIndexChanged);
            // 
            // cbb_concelho
            // 
            this.cbb_concelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_concelho.FormattingEnabled = true;
            this.cbb_concelho.Location = new System.Drawing.Point(177, 310);
            this.cbb_concelho.Name = "cbb_concelho";
            this.cbb_concelho.Size = new System.Drawing.Size(200, 28);
            this.cbb_concelho.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 421);
            this.Controls.Add(this.cbb_concelho);
            this.Controls.Add(this.cbb_distrito);
            this.Controls.Add(this.lb_concelho);
            this.Controls.Add(this.lb_distrito);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lb_hobbies);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.btn_mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_curso;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lb_hobbies;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lb_distrito;
        private System.Windows.Forms.Label lb_concelho;
        private System.Windows.Forms.ComboBox cbb_distrito;
        private System.Windows.Forms.ComboBox cbb_concelho;
    }
}

