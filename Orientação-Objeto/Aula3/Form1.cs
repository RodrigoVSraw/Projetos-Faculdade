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

namespace ProjetoLivroCaixa
{
    public partial class CadUser : Form
    {
        private static List<Usuario> usuarios;

        private static string nomeArquivo = "DadosUser.Dat";

        private static int posicaoAche = -1;

        public CadUser()
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

        private void CadUser_Load(object sender, EventArgs e)
        {

            btOk.Text = posicaoAche >= 0 ? "Alterar" : "Cadastrar";

            btExclui.Enabled = posicaoAche >= 0;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbMensagem.Text =
                txNome.Text =
                txCpf.Text =
                txLogin.Text = 
                txBusca.Text = String.Empty;

            rbAdm.Checked = rbUser.Checked = false;

            posicaoAche = -1;

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

            if (!rbAdm.Checked && !rbUser.Checked)
            {
                lbMensagem.Text = "Obrigatório mostrar o tipo de perfil";
                return;
            }

            if (posicaoAche >= 0)
            {
                usuarios[posicaoAche].Atualiza(txNome.Text, rbUser.Checked ? 'U' : 'A');
                txRelatorio.Text = Relatorio();
                Mostra(usuarios[posicaoAche]);
                Serializa.SerializaUsuario(usuarios, nomeArquivo);
                return;
            }

            if (!Util.ValidarCPF(txCpf.Text))
            {
                lbMensagem.Text = "CPF Inválido";
                return;
            }

            if (txLogin.Text.Trim().Equals(String.Empty))
            {
                lbMensagem.Text = "Login é obrigatório";
                return;
            }

            foreach (Usuario u in usuarios)
            {
                if (u.Cpf.Equals(txCpf.Text))
                {
                    lbMensagem.Text = "Existe um usuário com este CPF";
                    return;
                }
            }

            foreach (Usuario u in usuarios)
            {
                if (u.Login.Equals(txLogin.Text))
                {
                    lbMensagem.Text = "Existe um usuário com este Login";
                    return;
                }
            }

            Usuario usuario = new Usuario(txNome.Text, txLogin.Text, txCpf.Text, rbUser.Checked ? 'U' : 'A');

            usuarios.Add(usuario);

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
            rbAdm.Checked = u.Perfil == 'A';
            rbUser.Checked = u.Perfil == 'U';
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txBusca.Text, out int num))
            {
                lbMensagem.Text = "Número digitado inválido";
                return;
            }

            lbMensagem.Text = String.Empty;

            Usuario fajuto = new Usuario(num.ToString("D4"));

            int pos = usuarios.BinarySearch(fajuto);

            if (pos < 0)
            {
                lbMensagem.Text = "Não existe cadastro com esse registro";
                return;
            }

            posicaoAche = pos;
            Mostra(usuarios[pos]);

            btOk.Text = "Alterar";

            btExclui.Enabled = true;
        }

        private void btExclui_Click(object sender, EventArgs e)
        {
            if (posicaoAche < 0)
            {
                return;
            }

            usuarios.Remove(usuarios[posicaoAche]);
            txRelatorio.Text = Relatorio();

            btLimpar_Click(sender, e);

            Serializa.SerializaUsuario(usuarios, nomeArquivo);
        }
    }
}
