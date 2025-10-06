namespace ProjetoLivroCaixa
{
    partial class Login
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
            this.lbSenha = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbTLogin = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.pnTrocaSenha = new System.Windows.Forms.Panel();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.btConfirm2 = new System.Windows.Forms.Button();
            this.txSenhaA = new System.Windows.Forms.TextBox();
            this.txSenhaB = new System.Windows.Forms.TextBox();
            this.lbSenhaB = new System.Windows.Forms.Label();
            this.lbSenhaA = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            this.pnTrocaSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLogin.Location = new System.Drawing.Point(203, 109);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(77, 26);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSenha.Location = new System.Drawing.Point(193, 170);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(87, 26);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txLogin
            // 
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogin.Location = new System.Drawing.Point(286, 110);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(196, 29);
            this.txLogin.TabIndex = 6;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(286, 170);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(196, 29);
            this.txSenha.TabIndex = 7;
            // 
            // lbTLogin
            // 
            this.lbTLogin.AutoSize = true;
            this.lbTLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTLogin.ForeColor = System.Drawing.Color.Coral;
            this.lbTLogin.Location = new System.Drawing.Point(279, 34);
            this.lbTLogin.Name = "lbTLogin";
            this.lbTLogin.Size = new System.Drawing.Size(242, 37);
            this.lbTLogin.TabIndex = 8;
            this.lbTLogin.Text = "FAZER LOGIN\r\n";
            this.lbTLogin.Click += new System.EventHandler(this.lbTLogin_Click);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(505, 109);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(125, 90);
            this.btLogin.TabIndex = 11;
            this.btLogin.Text = "Confirm";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnTrocaSenha
            // 
            this.pnTrocaSenha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnTrocaSenha.Controls.Add(this.lbMensagem);
            this.pnTrocaSenha.Controls.Add(this.btConfirm2);
            this.pnTrocaSenha.Controls.Add(this.txSenhaA);
            this.pnTrocaSenha.Controls.Add(this.txSenhaB);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaB);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaA);
            this.pnTrocaSenha.Controls.Add(this.lbAviso);
            this.pnTrocaSenha.Location = new System.Drawing.Point(198, 251);
            this.pnTrocaSenha.Name = "pnTrocaSenha";
            this.pnTrocaSenha.Size = new System.Drawing.Size(432, 142);
            this.pnTrocaSenha.TabIndex = 12;
            this.pnTrocaSenha.Visible = false;
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Firebrick;
            this.lbMensagem.Location = new System.Drawing.Point(5, 116);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 26);
            this.lbMensagem.TabIndex = 17;
            // 
            // btConfirm2
            // 
            this.btConfirm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm2.Location = new System.Drawing.Point(310, 35);
            this.btConfirm2.Name = "btConfirm2";
            this.btConfirm2.Size = new System.Drawing.Size(107, 68);
            this.btConfirm2.TabIndex = 13;
            this.btConfirm2.Text = "Confirm";
            this.btConfirm2.UseVisualStyleBackColor = true;
            this.btConfirm2.Click += new System.EventHandler(this.btConfirm2_Click);
            // 
            // txSenhaA
            // 
            this.txSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenhaA.Location = new System.Drawing.Point(108, 35);
            this.txSenhaA.Name = "txSenhaA";
            this.txSenhaA.Size = new System.Drawing.Size(196, 29);
            this.txSenhaA.TabIndex = 16;
            // 
            // txSenhaB
            // 
            this.txSenhaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenhaB.Location = new System.Drawing.Point(108, 74);
            this.txSenhaB.Name = "txSenhaB";
            this.txSenhaB.Size = new System.Drawing.Size(196, 29);
            this.txSenhaB.TabIndex = 13;
            // 
            // lbSenhaB
            // 
            this.lbSenhaB.AutoSize = true;
            this.lbSenhaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSenhaB.Location = new System.Drawing.Point(5, 74);
            this.lbSenhaB.Name = "lbSenhaB";
            this.lbSenhaB.Size = new System.Drawing.Size(103, 26);
            this.lbSenhaB.TabIndex = 15;
            this.lbSenhaB.Text = "SenhaB:";
            this.lbSenhaB.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSenhaA
            // 
            this.lbSenhaA.AutoSize = true;
            this.lbSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSenhaA.Location = new System.Drawing.Point(5, 37);
            this.lbSenhaA.Name = "lbSenhaA";
            this.lbSenhaA.Size = new System.Drawing.Size(103, 26);
            this.lbSenhaA.TabIndex = 14;
            this.lbSenhaA.Text = "SenhaA:";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAviso.Location = new System.Drawing.Point(5, 6);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(381, 26);
            this.lbAviso.TabIndex = 13;
            this.lbAviso.Text = "Primeiro acesso, troque sua senha";
            this.lbAviso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.pnTrocaSenha);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbTLogin);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnTrocaSenha.ResumeLayout(false);
            this.pnTrocaSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label lbTLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel pnTrocaSenha;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbSenhaB;
        private System.Windows.Forms.Label lbSenhaA;
        private System.Windows.Forms.TextBox txSenhaA;
        private System.Windows.Forms.TextBox txSenhaB;
        private System.Windows.Forms.Button btConfirm2;
        private System.Windows.Forms.Label lbMensagem;
    }
}