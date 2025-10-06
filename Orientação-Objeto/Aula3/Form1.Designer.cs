namespace ProjetoLivroCaixa
{
    partial class CadUser
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
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCpf = new System.Windows.Forms.TextBox();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.rbAdm = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.btBusca = new System.Windows.Forms.Button();
            this.lbBusca = new System.Windows.Forms.Label();
            this.txBusca = new System.Windows.Forms.TextBox();
            this.btExclui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Coral;
            this.lbTitulo.Location = new System.Drawing.Point(273, 30);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(442, 37);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "CADASTRO DE USUÁRIOS";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNome.Location = new System.Drawing.Point(310, 103);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 26);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCpf.Location = new System.Drawing.Point(326, 150);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(66, 26);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF:";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPerfil.Location = new System.Drawing.Point(317, 250);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(75, 26);
            this.lbPerfil.TabIndex = 3;
            this.lbPerfil.Text = "Perfil:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLogin.Location = new System.Drawing.Point(315, 199);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(77, 26);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login:";
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(398, 103);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(196, 29);
            this.txNome.TabIndex = 5;
            // 
            // txCpf
            // 
            this.txCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCpf.Location = new System.Drawing.Point(398, 150);
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(196, 29);
            this.txCpf.TabIndex = 6;
            // 
            // txLogin
            // 
            this.txLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLogin.Location = new System.Drawing.Point(398, 199);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(196, 29);
            this.txLogin.TabIndex = 7;
            // 
            // rbAdm
            // 
            this.rbAdm.AutoSize = true;
            this.rbAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAdm.Location = new System.Drawing.Point(409, 252);
            this.rbAdm.Name = "rbAdm";
            this.rbAdm.Size = new System.Drawing.Size(84, 24);
            this.rbAdm.TabIndex = 8;
            this.rbAdm.TabStop = true;
            this.rbAdm.Text = "ADMIN";
            this.rbAdm.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUser.Location = new System.Drawing.Point(509, 252);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(77, 24);
            this.rbUser.TabIndex = 9;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "USER";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(409, 301);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(173, 34);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Cadastrar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRelatorio.Location = new System.Drawing.Point(59, 369);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.Size = new System.Drawing.Size(849, 296);
            this.txRelatorio.TabIndex = 11;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(809, 698);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(99, 42);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Red;
            this.lbMensagem.Location = new System.Drawing.Point(54, 714);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 26);
            this.lbMensagem.TabIndex = 13;
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.Location = new System.Drawing.Point(764, 150);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(144, 34);
            this.btBusca.TabIndex = 14;
            this.btBusca.Text = "Buscar";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBusca.Location = new System.Drawing.Point(759, 103);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(85, 26);
            this.lbBusca.TabIndex = 15;
            this.lbBusca.Text = "Busca:";
            // 
            // txBusca
            // 
            this.txBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBusca.Location = new System.Drawing.Point(850, 103);
            this.txBusca.Name = "txBusca";
            this.txBusca.Size = new System.Drawing.Size(58, 29);
            this.txBusca.TabIndex = 16;
            // 
            // btExclui
            // 
            this.btExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExclui.Location = new System.Drawing.Point(688, 698);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(99, 42);
            this.btExclui.TabIndex = 17;
            this.btExclui.Text = "Exclui";
            this.btExclui.UseVisualStyleBackColor = true;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // CadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(974, 816);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.txBusca);
            this.Controls.Add(this.lbBusca);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbAdm);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.txCpf);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Name = "CadUser";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.CadUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txCpf;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.RadioButton rbAdm;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txRelatorio;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.TextBox txBusca;
        private System.Windows.Forms.Button btExclui;
    }
}

