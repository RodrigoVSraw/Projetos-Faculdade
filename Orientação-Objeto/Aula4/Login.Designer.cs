namespace PrjLivroCaixa
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
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.pnTrocaSenha = new System.Windows.Forms.Panel();
            this.btOk2 = new System.Windows.Forms.Button();
            this.txSenhaB = new System.Windows.Forms.TextBox();
            this.lbSenhaB = new System.Windows.Forms.Label();
            this.txSenhaA = new System.Windows.Forms.TextBox();
            this.lbSenhaA = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.op1_CADUser = new System.Windows.Forms.ToolStripMenuItem();
            this.op2_LivroCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTrocaSenha.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbLogin.Location = new System.Drawing.Point(32, 36);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 26);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // txLogin
            // 
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogin.Location = new System.Drawing.Point(114, 36);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(192, 29);
            this.txLogin.TabIndex = 1;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(114, 89);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(192, 29);
            this.txSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbSenha.Location = new System.Drawing.Point(32, 89);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(75, 26);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(37, 143);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(269, 37);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pnTrocaSenha
            // 
            this.pnTrocaSenha.Controls.Add(this.btOk2);
            this.pnTrocaSenha.Controls.Add(this.txSenhaB);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaB);
            this.pnTrocaSenha.Controls.Add(this.txSenhaA);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaA);
            this.pnTrocaSenha.Controls.Add(this.lbAviso);
            this.pnTrocaSenha.Location = new System.Drawing.Point(37, 210);
            this.pnTrocaSenha.Name = "pnTrocaSenha";
            this.pnTrocaSenha.Size = new System.Drawing.Size(477, 205);
            this.pnTrocaSenha.TabIndex = 5;
            this.pnTrocaSenha.Visible = false;
            // 
            // btOk2
            // 
            this.btOk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk2.Location = new System.Drawing.Point(25, 137);
            this.btOk2.Name = "btOk2";
            this.btOk2.Size = new System.Drawing.Size(298, 37);
            this.btOk2.TabIndex = 8;
            this.btOk2.Text = "OK";
            this.btOk2.UseVisualStyleBackColor = true;
            this.btOk2.Click += new System.EventHandler(this.btOk2_Click);
            // 
            // txSenhaB
            // 
            this.txSenhaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenhaB.Location = new System.Drawing.Point(131, 87);
            this.txSenhaB.Name = "txSenhaB";
            this.txSenhaB.PasswordChar = '*';
            this.txSenhaB.Size = new System.Drawing.Size(192, 29);
            this.txSenhaB.TabIndex = 7;
            // 
            // lbSenhaB
            // 
            this.lbSenhaB.AutoSize = true;
            this.lbSenhaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbSenhaB.Location = new System.Drawing.Point(20, 89);
            this.lbSenhaB.Name = "lbSenhaB";
            this.lbSenhaB.Size = new System.Drawing.Size(96, 26);
            this.lbSenhaB.TabIndex = 6;
            this.lbSenhaB.Text = "Senha B";
            // 
            // txSenhaA
            // 
            this.txSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenhaA.Location = new System.Drawing.Point(131, 52);
            this.txSenhaA.Name = "txSenhaA";
            this.txSenhaA.PasswordChar = '*';
            this.txSenhaA.Size = new System.Drawing.Size(192, 29);
            this.txSenhaA.TabIndex = 5;
            // 
            // lbSenhaA
            // 
            this.lbSenhaA.AutoSize = true;
            this.lbSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaA.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbSenhaA.Location = new System.Drawing.Point(20, 54);
            this.lbSenhaA.Name = "lbSenhaA";
            this.lbSenhaA.Size = new System.Drawing.Size(96, 26);
            this.lbSenhaA.TabIndex = 4;
            this.lbSenhaA.Text = "Senha A";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbAviso.Location = new System.Drawing.Point(19, 16);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(357, 26);
            this.lbAviso.TabIndex = 1;
            this.lbAviso.Text = "Primeiro Acesso, Troque sua senha";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMensagem.Location = new System.Drawing.Point(32, 442);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 26);
            this.lbMensagem.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1_CADUser,
            this.op2_LivroCaixa});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            this.menu.Visible = false;
            // 
            // op1_CADUser
            // 
            this.op1_CADUser.Name = "op1_CADUser";
            this.op1_CADUser.Size = new System.Drawing.Size(69, 20);
            this.op1_CADUser.Text = "CAD User";
            this.op1_CADUser.Click += new System.EventHandler(this.op1_CADUser_Click);
            // 
            // op2_LivroCaixa
            // 
            this.op2_LivroCaixa.Name = "op2_LivroCaixa";
            this.op2_LivroCaixa.Size = new System.Drawing.Size(77, 20);
            this.op2_LivroCaixa.Text = "Livro Caixa";
            this.op2_LivroCaixa.Click += new System.EventHandler(this.op2_LivroCaixa_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.pnTrocaSenha);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnTrocaSenha.ResumeLayout(false);
            this.pnTrocaSenha.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel pnTrocaSenha;
        private System.Windows.Forms.TextBox txSenhaB;
        private System.Windows.Forms.Label lbSenhaB;
        private System.Windows.Forms.TextBox txSenhaA;
        private System.Windows.Forms.Label lbSenhaA;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Button btOk2;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem op1_CADUser;
        private System.Windows.Forms.ToolStripMenuItem op2_LivroCaixa;
    }
}