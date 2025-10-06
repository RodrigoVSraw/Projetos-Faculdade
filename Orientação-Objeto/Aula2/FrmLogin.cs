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
    public partial class FrmLogin : Form
    {
        private static List<Usuario> usuarios;
        public FrmLogin()
        {
            InitializeComponent();

            if(usuarios == null)
            {
                usuarios = new List<Usuario>();

                Usuario doido = new Usuario("Maluco", "111.222.333/33", 'M', new DateTime(2003, 10, 10), "maluco", "12345");
                usuarios.Add(doido);

                Usuario helio = new Usuario("Helio", "167.456.124/00", 'M', new DateTime(2012, 01, 16), "helio", "12345");
                usuarios.Add(helio);

                Usuario rodrigo = new Usuario("Rodrigo", "123.321.231/11", 'M', new DateTime(2004, 03, 25), "rodrigo", "12345");
                usuarios.Add(rodrigo);

                Usuario joana = new Usuario("Joana", "789.567.234/23", 'F', new DateTime(1988, 09, 12), "joana", "12345");
                usuarios.Add(joana);

                Usuario claudia = new Usuario("Claudia", "327.686.498/59", 'F', new DateTime(2005, 12, 31), "claudia", "12345");
                usuarios.Add(claudia);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            foreach(Usuario u in usuarios)
            {
                if(u.Verifica(txLogin.Text, txSenha.Text))
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
            }

            lbMens.Text = "Usuário não cadastrado";
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
