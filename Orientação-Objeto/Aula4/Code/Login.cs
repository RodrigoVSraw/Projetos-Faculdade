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

        private void btOk_Click(object sender, EventArgs e)
        { 
             Usuario achei = null;
             
            lbMensagem.Text = String.Empty;
            
             foreach(Usuario u in usuarios)
             {
                if (txLogin.Text.Equals(u.Login))
                {                  
                    achei = u;
                    break;
                }
             }
             if (achei == null)
             {
                lbMensagem.Text = "Usuário não cadastrado!";
                return;
             }
            if (Util.ValidarCPF(txSenha.Text))
            {
                if(achei.Senha == achei.Cpf)
                {
                    pnTrocaSenha.Visible = true;
                }
                else
                {
                    lbMensagem.Text = "Usuário já trocou a senha";
                }          
                return;
            }
            if (txSenha.Text.Equals(achei.Senha))
            {
                if(achei.Perfil == 'A')
                {
                    menu.Visible = true;
                }
                else
                {
                    Hide();
                    FrmCadUser frm = new FrmCadUser();
                    frm.Show();
                }

                return;
            }
            lbMensagem.Text = "Usuário não cadastrado!";
            return;
        }

        private void btOk2_Click(object sender, EventArgs e)
        {
            String aviso = Util.ValidaSenha(txSenhaA.Text);

            if (aviso != "")
            {
                lbMensagem.Text = aviso;
                return;
            }
            if (!txSenhaA.Text.Equals(txSenhaB.Text))
            {
                lbMensagem.Text = "Senhas não conferem!";
                return;
            }
            Usuario achei = null;
            foreach (Usuario u in usuarios)
            {
                if (txLogin.Text.Equals(u.Login))
                {
                    achei = u;
                    break;
                }
            }
            if (achei != null)
            {
                achei.AlteraSenha(txSenhaA.Text);
                Serializa.SerializaUsuario(usuarios, nomeArquivo);
                pnTrocaSenha.Visible = false;
                return;
            }
            lbMensagem.Text = "Usuário não cadastrado!";
            return;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void op1_CADUser_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadUser frm = new FrmCadUser();
            frm.Show();
            return;
        }

        private void op2_LivroCaixa_Click(object sender, EventArgs e)
        {

        }
    }
}
