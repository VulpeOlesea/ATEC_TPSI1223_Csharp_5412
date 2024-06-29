namespace exe4
{
    partial class Calculadora
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rb_somar = new System.Windows.Forms.RadioButton();
            this.rb_subtrair = new System.Windows.Forms.RadioButton();
            this.rb_multiplicar = new System.Windows.Forms.RadioButton();
            this.rb_dividir = new System.Windows.Forms.RadioButton();
            this.lb_result = new System.Windows.Forms.Label();
            this.Operação = new System.Windows.Forms.GroupBox();
            this.Operação.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.Location = new System.Drawing.Point(105, 78);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(148, 26);
            this.tb_1.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.Location = new System.Drawing.Point(105, 130);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(148, 26);
            this.tb_2.TabIndex = 1;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_calcular.Location = new System.Drawing.Point(105, 177);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(148, 39);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rb_somar
            // 
            this.rb_somar.AutoSize = true;
            this.rb_somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_somar.Location = new System.Drawing.Point(26, 40);
            this.rb_somar.Name = "rb_somar";
            this.rb_somar.Size = new System.Drawing.Size(86, 28);
            this.rb_somar.TabIndex = 3;
            this.rb_somar.TabStop = true;
            this.rb_somar.Text = "Somar";
            this.rb_somar.UseVisualStyleBackColor = true;
            // 
            // rb_subtrair
            // 
            this.rb_subtrair.AutoSize = true;
            this.rb_subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_subtrair.Location = new System.Drawing.Point(26, 84);
            this.rb_subtrair.Name = "rb_subtrair";
            this.rb_subtrair.Size = new System.Drawing.Size(95, 28);
            this.rb_subtrair.TabIndex = 4;
            this.rb_subtrair.TabStop = true;
            this.rb_subtrair.Text = "Subtrair";
            this.rb_subtrair.UseVisualStyleBackColor = true;
            // 
            // rb_multiplicar
            // 
            this.rb_multiplicar.AutoSize = true;
            this.rb_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_multiplicar.Location = new System.Drawing.Point(26, 126);
            this.rb_multiplicar.Name = "rb_multiplicar";
            this.rb_multiplicar.Size = new System.Drawing.Size(115, 28);
            this.rb_multiplicar.TabIndex = 5;
            this.rb_multiplicar.TabStop = true;
            this.rb_multiplicar.Text = "Multiplicar";
            this.rb_multiplicar.UseVisualStyleBackColor = true;
            // 
            // rb_dividir
            // 
            this.rb_dividir.AutoSize = true;
            this.rb_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_dividir.Location = new System.Drawing.Point(26, 169);
            this.rb_dividir.Name = "rb_dividir";
            this.rb_dividir.Size = new System.Drawing.Size(82, 28);
            this.rb_dividir.TabIndex = 6;
            this.rb_dividir.TabStop = true;
            this.rb_dividir.Text = "Dividir";
            this.rb_dividir.UseVisualStyleBackColor = true;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.BackColor = System.Drawing.SystemColors.Info;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_result.Location = new System.Drawing.Point(109, 261);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(21, 29);
            this.lb_result.TabIndex = 7;
            this.lb_result.Text = "-";
            // 
            // Operação
            // 
            this.Operação.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Operação.Controls.Add(this.rb_somar);
            this.Operação.Controls.Add(this.rb_subtrair);
            this.Operação.Controls.Add(this.rb_dividir);
            this.Operação.Controls.Add(this.rb_multiplicar);
            this.Operação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operação.Location = new System.Drawing.Point(330, 51);
            this.Operação.Name = "Operação";
            this.Operação.Size = new System.Drawing.Size(200, 224);
            this.Operação.TabIndex = 8;
            this.Operação.TabStop = false;
            this.Operação.Text = "Operação";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(643, 350);
            this.Controls.Add(this.Operação);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Operação.ResumeLayout(false);
            this.Operação.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.RadioButton rb_somar;
        private System.Windows.Forms.RadioButton rb_subtrair;
        private System.Windows.Forms.RadioButton rb_multiplicar;
        private System.Windows.Forms.RadioButton rb_dividir;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.GroupBox Operação;
    }
}

