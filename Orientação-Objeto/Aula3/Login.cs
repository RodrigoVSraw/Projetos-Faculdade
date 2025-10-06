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
    public partial class Login : Form
    {
        private static List<Usuario> usuarios;

        private static string nomeArquivo = "DadosUser.Dat";

        public Login()
        {
            InitializeComponent();

            if (usuarios == null)
            {
                if (File.Exists(nomeArquivo))
                {
                    usuarios = Serializa.DesserializaUsuario(nomeArquivo);

                }
                else
                {
                    usuarios = new List<Usuario>();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario achei = null;

            foreach (Usuario u in usuarios)
            {
                if (txLogin.Text.Equals(u.Login)) 
                {                    
                    achei = u;
                    break; 
                }
                
            }

            if (achei == null)
            {
                lbMensagem.Text = "Usuário não cadastrado";
                return;
            }

            if (Util.ValidarCPF(txSenha.Text))
            {
                pnTrocaSenha.Visible = true;

                return;
            }

            if(txSenha.Text.Equals(achei.Senha))
            {
                Hide();
                CadUser frm = new CadUser();
                frm.Show();
                return;
            }

            lbMensagem.Text = "Usuário não cadastrado";
            return;
        }

        private void lbTLogin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btConfirm2_Click(object sender, EventArgs e)
        {
            Usuario achei = null;

            if(txSenhaA.Text.Length < 8)
            {
                lbMensagem.Text = "Senha tem que conter 8 ou mais digítos";
                return;
            }

            if (!txSenhaA.Text.Equals(txSenhaB.Text))
            {
                lbMensagem.Text = "Senhas não conferem";
                return;
            }

            foreach (Usuario u in usuarios)
            {
                if (u.Login.Equals(txSenha.Text))
                {
                    achei = u;
                    break;
                }
            }

            if(achei != null)
            {
                achei.AlteraSenha(txSenhaA.Text);
                Serializa.SerializaUsuario(usuarios, nomeArquivo);
                pnTrocaSenha.Visible = false;
                return;
            }

            lbMensagem.Text = "Usuário não cadastrado";
            return;
        }
    } 
}

