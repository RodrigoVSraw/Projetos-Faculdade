using PrjCalculadoraWeb.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjLivroCaixa
{
    public partial class FrmCadUser : Form
    {
        private static List<Usuario> usuarios;

        private static string nomeArquivo = "DadosUser.Dat";

        private static int posicaoAchei = -1; // Propriedade para armazenar posição achei
        public FrmCadUser()
        {
            InitializeComponent();

            if (usuarios == null)
            {
                if (File.Exists(nomeArquivo))
                {
                    usuarios = Serializa.DesserializaUsuario(nomeArquivo);
                    Usuario.AcertaContador(usuarios);
                    txRelatorio.Text = Relatorio();
                }
                else
                {
                    usuarios = new List<Usuario>();
                }
            }
        }
        private void FrmCadUser_Load(object sender, EventArgs e)
        {            

            btOk.Text = posicaoAchei >= 0 ? "Alterar" : "Cadastrar";

            btExclui.Enabled = posicaoAchei >= 0;

        }
        private void btLimpar_Click(object sender, EventArgs e)
        {           
            lbMensagem.Text =
                txNome.Text = 
                txLogin.Text =
                txBusca.Text =
                txCpf.Text =   String.Empty;

            rbADM.Checked = 
                rbUser.Checked = false;

            posicaoAchei = -1;
            btOk.Text = "Cadastrar";
            btExclui.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txNome.Text.Trim().Equals(String.Empty))
            {
                lbMensagem.Text = "Obrigatório o nome do usuário.";
                return;
            }

            if (!rbADM.Checked && !rbUser.Checked)
            {
                lbMensagem.Text = "Obrigatório o perfil do usuário.";
                return;
            }

            if (posicaoAchei >= 0)
            {
                usuarios[posicaoAchei].Atualiza(txNome.Text, rbUser.Checked ? 'U' : 'A');
                txRelatorio.Text = Relatorio();
                Mostra(usuarios[posicaoAchei]);
                Serializa.SerializaUsuario(usuarios, nomeArquivo);
                return;
            }

            if (!Util.ValidarCPF(txCpf.Text))
            {
                lbMensagem.Text = "CPF inválido.";
                return;
            }

            if (txLogin.Text.Trim().Equals(String.Empty))
            {
                lbMensagem.Text = "Obrigatório o login do usuário.";
                return;
            }

            

            foreach (Usuario u in usuarios)
            {
                if (u.Cpf.Equals(txCpf.Text))
                {
                    lbMensagem.Text = "Já existe um usuário com este CPF!";
                    return;
                }
            }

            foreach (Usuario u in usuarios)
            {
                if (u.Login.Equals(txLogin.Text))
                {
                    lbMensagem.Text = "Já existe um usuário com este CPF!";
                    return;
                }
            }

            Usuario usuario =  new Usuario(txNome.Text,
                Util.FormataCpf(txCpf.Text),
                txLogin.Text, rbUser.Checked ? 'U' : 'A');

                usuarios.Add(usuario);

                usuarios.Sort();


            Serializa.SerializaUsuario(usuarios, nomeArquivo);

            txRelatorio.Text = Relatorio();

            btLimpar_Click(sender, e);  
        }
        private String Relatorio()
        {
            StringBuilder str = new StringBuilder();            
            foreach(Usuario u in usuarios)
            {
              str.AppendLine(u.ToString());
            }
            return str.ToString();
        }

        private void Mostra(Usuario u)
        {
            txNome.Text = u.Nome;
            txCpf.Text = u.Cpf;
            txLogin.Text = u.Login;
            rbADM.Checked = u.Perfil == 'A';
            rbUser.Checked = u.Perfil == 'U';
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txBusca.Text, out int num))
            {
                lbMensagem.Text = "Número digitado inválido";
                return;
            }
            Usuario fajuto = new Usuario(num.ToString("D4"));

            int pos = usuarios.BinarySearch(fajuto);

            if (pos < 0)
            {
                lbMensagem.Text = "Achei ninguém com este registro não!";
                return;
            }

            posicaoAchei = pos;
            btOk.Text = "Alterar";
            btExclui.Enabled = true;
            Mostra(usuarios[pos]);

        }
        private void btExclui_Click(object sender, EventArgs e)
        {
            if (posicaoAchei < 0)
            {
                return;
            }
            usuarios.Remove(usuarios[posicaoAchei]);
            txRelatorio.Text = Relatorio();
            btLimpar_Click(sender, e);
            Serializa.SerializaUsuario(usuarios, nomeArquivo);
        }
    }
}
