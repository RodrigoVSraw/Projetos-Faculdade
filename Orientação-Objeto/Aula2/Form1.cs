using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjClinica
{
    public partial class Form1 : Form
    {
        private static List<Paciente> pacientes;

        private static Paciente pacienteBusca;
        public Form1()
        {
            InitializeComponent();

            if(pacientes == null)
            {
                pacientes = new List<Paciente>();
            }

            if (pacienteBusca == null)
            {
                btExcluir.Enabled = false;
            }
            else 
            { 
                btExcluir.Enabled = true; 
            }
            

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            textNome.Text =
                textAltura.Text =
                textData.Text =
                textPeso.Text =
                textCpf.Text =
                textResult.Text = String.Empty;

            rbFem.Checked =
                rbMas.Checked =
                rbPnD.Checked = false;

            textNome.ReadOnly = 
            textCpf.ReadOnly = 
            textData.ReadOnly = false;

            rbFem.Enabled = 
            rbMas.Enabled = 
            rbPnD.Enabled = true;

            pacienteBusca = null;

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            textResult.Text = String.Empty;

            if (!float.TryParse(textPeso.Text, out float peso))
            {
                textResult.Text = "Peso Inválido";
                return;
            }

            if (peso < 40 || peso > 200)
            {
                textResult.Text = "Peso deve estar entre 40Kg e 200Kg!";
                return;
            }

            if (!float.TryParse(textAltura.Text, out float altura))
            {
                textResult.Text = "Altura Inválida";
                return;
            }

            if (altura < 1.1 || altura > 2.2)
            {
                textResult.Text = "Altura deve estar entre 1,1m e 2,2m!";
                return;
            }

            if (pacienteBusca != null)
            {
                pacienteBusca.Atualiza(peso, altura);
                Mostra(pacienteBusca);
                return;
            }

            if (textNome.Text.Trim() == String.Empty)
            {
                textResult.Text = "Digite o nome do paciente";
                return;
            }

            if (!DateTime.TryParse(textData.Text, out DateTime dtNasc))
            {
                textResult.Text = "Data inválida";
                return;
            }

            int idade = DateTime.Now.Year - dtNasc.Year;

            if(idade < 15 || idade > 100)
            {
                textResult.Text = "Idade deve estar entre 15 e 100 anos";
                return;
            }

            char sexo = '*';

            if (rbFem.Checked)
            {
                sexo = 'F';
            }

            if (rbMas.Checked)
            {
                sexo = 'M';
            } 

            Paciente R = new Paciente(textNome.Text, textCpf.Text, sexo, dtNasc, peso, altura);

            textResult.Text = R.Imc.Classificacao();

            foreach(Paciente paciente in pacientes)
            {
                if (paciente.Cpf.Equals(textCpf.Text))
                {
                    textResult.Text = "Paciente já cadastrado";
                    return;
                }
            }

            pacientes.Add(R);
        }

        private void textPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbBusca_Click(object sender, EventArgs e)
        {

        }

        private void Mostra(Paciente R)
        {
            textNome.Text = R.Nome;
            textAltura.Text = R.Imc.Altura.ToString();
            textData.Text = R.DTNascimento.ToString("dd/MM/yyyy");
            textPeso.Text = R.Imc.Peso.ToString();
            textCpf.Text = R.Cpf;
            textResult.Text = R.Imc.Classificacao();

            rbFem.Checked = R.Sexo == 'F';
            rbMas.Checked = R.Sexo == 'M';
            rbPnD.Checked = R.Sexo == '*';
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            foreach(Paciente R in pacientes)
            {
                if (R.Registro.Equals(textBusca.Text)) 
                { 
                    Mostra(R);

                    pacienteBusca = R;

                    textNome.ReadOnly = true;
                    textCpf.ReadOnly = true;
                    textData.ReadOnly = true;

                    rbFem.Enabled = false;
                    rbMas.Enabled = false;
                    rbPnD.Enabled = false;

                    return;
                }
            }

            textResult.Text = "Paciente não cadastrado";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
                if (pacienteBusca != null)
                {
                    pacientes.Remove(pacienteBusca);

                textNome.Text =
            textAltura.Text =
            textData.Text =
            textPeso.Text =
            textCpf.Text =
            textResult.Text = String.Empty;

                rbFem.Checked =
                    rbMas.Checked =
                    rbPnD.Checked = false;

            }

            
        }
    }
}
