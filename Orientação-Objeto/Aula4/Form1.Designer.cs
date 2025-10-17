namespace PrjLivroCaixa
{
    partial class FrmCadUser
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCpf = new System.Windows.Forms.TextBox();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.rbADM = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbBusca = new System.Windows.Forms.Label();
            this.txBusca = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.btExclui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTitulo.Location = new System.Drawing.Point(375, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(385, 44);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Usuários";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbNome.Location = new System.Drawing.Point(37, 124);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(71, 26);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCpf.Location = new System.Drawing.Point(250, 124);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(56, 26);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbLogin.Location = new System.Drawing.Point(420, 124);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 26);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbPerfil.Location = new System.Drawing.Point(614, 124);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(62, 26);
            this.lbPerfil.TabIndex = 4;
            this.lbPerfil.Text = "Perfil";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(42, 153);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(205, 29);
            this.txNome.TabIndex = 5;
            // 
            // txCpf
            // 
            this.txCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCpf.Location = new System.Drawing.Point(253, 153);
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(157, 29);
            this.txCpf.TabIndex = 6;
            // 
            // txLogin
            // 
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogin.Location = new System.Drawing.Point(416, 153);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(183, 29);
            this.txLogin.TabIndex = 7;
            // 
            // rbADM
            // 
            this.rbADM.AutoSize = true;
            this.rbADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbADM.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbADM.Location = new System.Drawing.Point(619, 154);
            this.rbADM.Name = "rbADM";
            this.rbADM.Size = new System.Drawing.Size(70, 28);
            this.rbADM.TabIndex = 8;
            this.rbADM.TabStop = true;
            this.rbADM.Text = "ADM";
            this.rbADM.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbUser.Location = new System.Drawing.Point(695, 154);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(79, 28);
            this.rbUser.TabIndex = 9;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "USER";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(780, 146);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(111, 44);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Cadastrar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRelatorio.Location = new System.Drawing.Point(42, 202);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.ReadOnly = true;
            this.txRelatorio.Size = new System.Drawing.Size(1113, 285);
            this.txRelatorio.TabIndex = 11;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(1059, 511);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(96, 44);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMensagem.Location = new System.Drawing.Point(37, 602);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(21, 26);
            this.lbMensagem.TabIndex = 13;
            this.lbMensagem.Text = "*";
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusca.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBusca.Location = new System.Drawing.Point(916, 124);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(73, 26);
            this.lbBusca.TabIndex = 14;
            this.lbBusca.Text = "Busca";
            // 
            // txBusca
            // 
            this.txBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBusca.Location = new System.Drawing.Point(912, 154);
            this.txBusca.Name = "txBusca";
            this.txBusca.Size = new System.Drawing.Size(77, 29);
            this.txBusca.TabIndex = 15;
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.Location = new System.Drawing.Point(1008, 146);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(66, 44);
            this.btBusca.TabIndex = 16;
            this.btBusca.Text = "OK";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // btExclui
            // 
            this.btExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExclui.Location = new System.Drawing.Point(947, 511);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(96, 44);
            this.btExclui.TabIndex = 17;
            this.btExclui.Text = "Exclui";
            this.btExclui.UseVisualStyleBackColor = true;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // FrmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 670);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.txBusca);
            this.Controls.Add(this.lbBusca);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbADM);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.txCpf);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmCadUser";
            this.Text = "Cadastro De Usuários";
            this.Load += new System.EventHandler(this.FrmCadUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txCpf;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.RadioButton rbADM;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txRelatorio;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.TextBox txBusca;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Button btExclui;
    }
}

