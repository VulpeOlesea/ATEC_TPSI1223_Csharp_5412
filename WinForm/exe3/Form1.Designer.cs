namespace exe3
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
            this.lbl_und1 = new System.Windows.Forms.Label();
            this.btn_rodar = new System.Windows.Forms.Button();
            this.lbl_und2 = new System.Windows.Forms.Label();
            this.lbl_und3 = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_und1
            // 
            this.lbl_und1.AutoSize = true;
            this.lbl_und1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_und1.Location = new System.Drawing.Point(109, 213);
            this.lbl_und1.Name = "lbl_und1";
            this.lbl_und1.Size = new System.Drawing.Size(68, 95);
            this.lbl_und1.TabIndex = 0;
            this.lbl_und1.Text = "-";
            // 
            // btn_rodar
            // 
            this.btn_rodar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rodar.Location = new System.Drawing.Point(125, 337);
            this.btn_rodar.Name = "btn_rodar";
            this.btn_rodar.Size = new System.Drawing.Size(200, 56);
            this.btn_rodar.TabIndex = 1;
            this.btn_rodar.Text = "Rodar";
            this.btn_rodar.UseVisualStyleBackColor = false;
            this.btn_rodar.Click += new System.EventHandler(this.btn_rodar_Click_1);
            // 
            // lbl_und2
            // 
            this.lbl_und2.AutoSize = true;
            this.lbl_und2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_und2.Location = new System.Drawing.Point(183, 213);
            this.lbl_und2.Name = "lbl_und2";
            this.lbl_und2.Size = new System.Drawing.Size(68, 95);
            this.lbl_und2.TabIndex = 2;
            this.lbl_und2.Text = "-";
            // 
            // lbl_und3
            // 
            this.lbl_und3.AutoSize = true;
            this.lbl_und3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_und3.Location = new System.Drawing.Point(257, 213);
            this.lbl_und3.Name = "lbl_und3";
            this.lbl_und3.Size = new System.Drawing.Size(68, 95);
            this.lbl_und3.TabIndex = 3;
            this.lbl_und3.Text = "-";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(104, 55);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(114, 39);
            this.lbl_saldo.TabIndex = 4;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(233, 55);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(93, 39);
            this.lbl_valor.TabIndex = 5;
            this.lbl_valor.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_und3);
            this.Controls.Add(this.lbl_und2);
            this.Controls.Add(this.btn_rodar);
            this.Controls.Add(this.lbl_und1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_und1;
        private System.Windows.Forms.Button btn_rodar;
        private System.Windows.Forms.Label lbl_und2;
        private System.Windows.Forms.Label lbl_und3;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_valor;
    }
}

