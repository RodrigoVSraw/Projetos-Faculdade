namespace PrjClinica
{
    partial class FrmLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbMens = new System.Windows.Forms.Label();
            this.tituloLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLogin.Location = new System.Drawing.Point(110, 74);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(58, 20);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login:";
            // 
            // txLogin
            // 
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogin.Location = new System.Drawing.Point(174, 68);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(140, 26);
            this.txLogin.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSenha.Location = new System.Drawing.Point(102, 116);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(66, 20);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha:";
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(174, 110);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(140, 26);
            this.txSenha.TabIndex = 5;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(329, 68);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(62, 68);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbMens
            // 
            this.lbMens.AutoSize = true;
            this.lbMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMens.ForeColor = System.Drawing.Color.Red;
            this.lbMens.Location = new System.Drawing.Point(149, 170);
            this.lbMens.Name = "lbMens";
            this.lbMens.Size = new System.Drawing.Size(19, 20);
            this.lbMens.TabIndex = 7;
            this.lbMens.Text = "a";
            // 
            // tituloLogin
            // 
            this.tituloLogin.AutoSize = true;
            this.tituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tituloLogin.Location = new System.Drawing.Point(138, 9);
            this.tituloLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLogin.Name = "tituloLogin";
            this.tituloLogin.Size = new System.Drawing.Size(235, 29);
            this.tituloLogin.TabIndex = 8;
            this.tituloLogin.Text = "PÁGINA DE LOGIN";
            this.tituloLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tituloLogin.Click += new System.EventHandler(this.titulo_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.tituloLogin);
            this.Controls.Add(this.lbMens);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.lbLogin);
            this.Name = "FrmLogin";
            this.Text = "Login da Clínica";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbMens;
        private System.Windows.Forms.Label tituloLogin;
    }
}