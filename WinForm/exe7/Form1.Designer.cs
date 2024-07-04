namespace exe7
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_decimal = new System.Windows.Forms.TextBox();
            this.btn_binario = new System.Windows.Forms.Button();
            this.btn_octal = new System.Windows.Forms.Button();
            this.btn_hexa = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ Decimal:";
            // 
            // tb_decimal
            // 
            this.tb_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_decimal.Location = new System.Drawing.Point(281, 112);
            this.tb_decimal.Name = "tb_decimal";
            this.tb_decimal.Size = new System.Drawing.Size(261, 26);
            this.tb_decimal.TabIndex = 1;
            // 
            // btn_binario
            // 
            this.btn_binario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_binario.Location = new System.Drawing.Point(39, 197);
            this.btn_binario.Name = "btn_binario";
            this.btn_binario.Size = new System.Drawing.Size(203, 73);
            this.btn_binario.TabIndex = 2;
            this.btn_binario.Text = "Para Binário (Base 2)";
            this.btn_binario.UseVisualStyleBackColor = true;
            this.btn_binario.Click += new System.EventHandler(this.btn_binario_Click);
            // 
            // btn_octal
            // 
            this.btn_octal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_octal.Location = new System.Drawing.Point(295, 197);
            this.btn_octal.Name = "btn_octal";
            this.btn_octal.Size = new System.Drawing.Size(203, 73);
            this.btn_octal.TabIndex = 3;
            this.btn_octal.Text = "Para Octal (Base 8)";
            this.btn_octal.UseVisualStyleBackColor = true;
            this.btn_octal.Click += new System.EventHandler(this.btn_octal_Click);
            // 
            // btn_hexa
            // 
            this.btn_hexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hexa.Location = new System.Drawing.Point(544, 197);
            this.btn_hexa.Name = "btn_hexa";
            this.btn_hexa.Size = new System.Drawing.Size(203, 73);
            this.btn_hexa.TabIndex = 4;
            this.btn_hexa.Text = "Para Hexadecimal (Base 16)";
            this.btn_hexa.UseVisualStyleBackColor = true;
            this.btn_hexa.Click += new System.EventHandler(this.btn_hexa_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(274, 333);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 60);
            this.lb_resultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 429);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.btn_hexa);
            this.Controls.Add(this.btn_octal);
            this.Controls.Add(this.btn_binario);
            this.Controls.Add(this.tb_decimal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_decimal;
        private System.Windows.Forms.Button btn_binario;
        private System.Windows.Forms.Button btn_octal;
        private System.Windows.Forms.Button btn_hexa;
        private System.Windows.Forms.Label lb_resultado;
    }
}

