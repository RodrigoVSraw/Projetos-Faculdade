namespace PrjClinica
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
            this.titulo = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbPnD = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbBusca = new System.Windows.Forms.Label();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Yellow;
            this.titulo.Location = new System.Drawing.Point(49, 28);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(410, 29);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "CLÍNICA EMAGRECIMENTO RAW";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nome.Location = new System.Drawing.Point(28, 97);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(60, 20);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(94, 91);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(341, 26);
            this.textNome.TabIndex = 2;
            // 
            // textCpf
            // 
            this.textCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpf.Location = new System.Drawing.Point(94, 132);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(341, 26);
            this.textCpf.TabIndex = 3;
            this.textCpf.Text = "123.321.231/11";
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textData.Location = new System.Drawing.Point(132, 174);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(303, 26);
            this.textData.TabIndex = 4;
            this.textData.Text = "25/03/2004";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCpf.Location = new System.Drawing.Point(28, 138);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(42, 20);
            this.lbCpf.TabIndex = 5;
            this.lbCpf.Text = "Cpf:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbData.Location = new System.Drawing.Point(28, 180);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(98, 20);
            this.lbData.TabIndex = 6;
            this.lbData.Text = "Data Nasc:";
            // 
            // textPeso
            // 
            this.textPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeso.Location = new System.Drawing.Point(164, 291);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(159, 26);
            this.textPeso.TabIndex = 7;
            this.textPeso.TextChanged += new System.EventHandler(this.textPeso_TextChanged);
            // 
            // textAltura
            // 
            this.textAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.Location = new System.Drawing.Point(164, 327);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(159, 26);
            this.textAltura.TabIndex = 8;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPeso.Location = new System.Drawing.Point(90, 297);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(54, 20);
            this.lbPeso.TabIndex = 9;
            this.lbPeso.Text = "Peso:";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAltura.Location = new System.Drawing.Point(90, 333);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(62, 20);
            this.lbAltura.TabIndex = 10;
            this.lbAltura.Text = "Altura:";
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(360, 328);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 25);
            this.btConfirm.TabIndex = 11;
            this.btConfirm.Text = "Confirmar";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btClean
            // 
            this.btClean.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.Location = new System.Drawing.Point(360, 291);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 26);
            this.btClean.TabIndex = 12;
            this.btClean.Text = "Limpar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFem.Location = new System.Drawing.Point(212, 230);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(75, 17);
            this.rbFem.TabIndex = 13;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMas.Location = new System.Drawing.Point(104, 230);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(82, 17);
            this.rbMas.TabIndex = 14;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbPnD
            // 
            this.rbPnD.AutoSize = true;
            this.rbPnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPnD.Location = new System.Drawing.Point(315, 230);
            this.rbPnD.Name = "rbPnD";
            this.rbPnD.Size = new System.Drawing.Size(120, 17);
            this.rbPnD.TabIndex = 15;
            this.rbPnD.TabStop = true;
            this.rbPnD.Text = "Prefiro não Dizer";
            this.rbPnD.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSexo.Location = new System.Drawing.Point(28, 227);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(54, 20);
            this.lbSexo.TabIndex = 16;
            this.lbSexo.Text = "Sexo:";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(132, 397);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(303, 26);
            this.textResult.TabIndex = 17;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResult.Location = new System.Drawing.Point(28, 403);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(96, 20);
            this.lbResult.TabIndex = 18;
            this.lbResult.Text = "Resultado:";
            // 
            // lbBusca
            // 
            this.lbBusca.AutoSize = true;
            this.lbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBusca.Location = new System.Drawing.Point(460, 97);
            this.lbBusca.Name = "lbBusca";
            this.lbBusca.Size = new System.Drawing.Size(64, 20);
            this.lbBusca.TabIndex = 19;
            this.lbBusca.Text = "Busca:";
            this.lbBusca.Click += new System.EventHandler(this.lbBusca_Click);
            // 
            // textBusca
            // 
            this.textBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusca.Location = new System.Drawing.Point(530, 91);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(102, 26);
            this.textBusca.TabIndex = 20;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(653, 91);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(42, 26);
            this.btOk.TabIndex = 21;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(530, 138);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(165, 26);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.lbBusca);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.rbPnD);
            this.Controls.Add(this.rbMas);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Página de Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.RadioButton rbPnD;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbBusca;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btExcluir;
    }
}

