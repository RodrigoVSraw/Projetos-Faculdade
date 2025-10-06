namespace WindowsFormsApp1
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
            this.lado = new System.Windows.Forms.TextBox();
            this.btcalcula = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lado
            // 
            this.lado.Location = new System.Drawing.Point(267, 348);
            this.lado.Name = "lado";
            this.lado.Size = new System.Drawing.Size(194, 20);
            this.lado.TabIndex = 0;
            this.lado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btcalcula
            // 
            this.btcalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btcalcula.Location = new System.Drawing.Point(302, 82);
            this.btcalcula.Name = "btcalcula";
            this.btcalcula.Size = new System.Drawing.Size(132, 50);
            this.btcalcula.TabIndex = 1;
            this.btcalcula.Text = "Calcula";
            this.btcalcula.UseVisualStyleBackColor = true;
            this.btcalcula.Click += new System.EventHandler(this.btcalcula_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.BackColor = System.Drawing.Color.Red;
            this.lbMensagem.Location = new System.Drawing.Point(66, 119);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(35, 13);
            this.lbMensagem.TabIndex = 2;
            this.lbMensagem.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btcalcula);
            this.Controls.Add(this.lado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lado;
        private System.Windows.Forms.Button btcalcula;
        private System.Windows.Forms.Label lbMensagem;
    }
}

