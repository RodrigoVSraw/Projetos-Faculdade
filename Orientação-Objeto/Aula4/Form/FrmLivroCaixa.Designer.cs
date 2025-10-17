namespace PrjLivroCaixa
{
    partial class FrmLivroCaixa
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
            this.lbData = new System.Windows.Forms.Label();
            this.txData = new System.Windows.Forms.TextBox();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lbTitulo.Location = new System.Drawing.Point(196, 42);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(337, 29);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Brown;
            this.lbData.Location = new System.Drawing.Point(21, 117);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(58, 26);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data";
            // 
            // txData
            // 
            this.txData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txData.Location = new System.Drawing.Point(26, 146);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(115, 29);
            this.txData.TabIndex = 2;
            // 
            // txDescricao
            // 
            this.txDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricao.Location = new System.Drawing.Point(154, 146);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(497, 29);
            this.txDescricao.TabIndex = 4;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.ForeColor = System.Drawing.Color.Brown;
            this.lbDescricao.Location = new System.Drawing.Point(149, 117);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(109, 26);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(661, 146);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(115, 29);
            this.txValor.TabIndex = 6;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.Brown;
            this.lbValor.Location = new System.Drawing.Point(656, 117);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(63, 26);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "Valor";
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.ForeColor = System.Drawing.Color.Brown;
            this.rbCredito.Location = new System.Drawing.Point(802, 117);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(88, 28);
            this.rbCredito.TabIndex = 7;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebito.ForeColor = System.Drawing.Color.Brown;
            this.rbDebito.Location = new System.Drawing.Point(802, 149);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(82, 28);
            this.rbDebito.TabIndex = 8;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Débito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.Brown;
            this.btOk.Location = new System.Drawing.Point(919, 129);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 47);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRelatorio.Location = new System.Drawing.Point(26, 202);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.ReadOnly = true;
            this.txRelatorio.Size = new System.Drawing.Size(968, 344);
            this.txRelatorio.TabIndex = 10;
            this.txRelatorio.TextChanged += new System.EventHandler(this.txRelatorio_TextChanged);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Brown;
            this.lbMensagem.Location = new System.Drawing.Point(21, 558);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(18, 26);
            this.lbMensagem.TabIndex = 11;
            this.lbMensagem.Text = ".";
            // 
            // FrmLivroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 593);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbDebito);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmLivroCaixa";
            this.Text = "Livro Caixa";
            this.Load += new System.EventHandler(this.FrmLivroCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txData;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txRelatorio;
        private System.Windows.Forms.Label lbMensagem;
    }
}
