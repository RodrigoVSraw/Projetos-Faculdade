using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjLivroCaixa
{
    
    public partial class FrmLivroCaixa : Form
    {
        public static LivroCaixa livro;

        private static String nomeArquivo = "Lancamentos.dat";
        public FrmLivroCaixa()
        {
            InitializeComponent();

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txData.Text, out DateTime data))
            {
                lbMensagem.Text = "Data inválida";
                return;
            }
            if (!decimal.TryParse(txValor.Text, out decimal valor) || valor <=0 )
            {
                lbMensagem.Text = "Valor inválido";
                return;
            }
            if (txDescricao.Text.Trim() == "")
            {
                lbMensagem.Text = "Cade a descrição?";
                return;
            }
            if (rbCredito.Checked== false && rbDebito.Checked == false)
            {
                lbMensagem.Text = "É crédio ou débito ????????????????";
                return;
            }

            Lancamento lan = new Lancamento(data,valor,txDescricao.Text, rbCredito.Checked?'C':'D',
                                      new Usuario("Helio Rangel","","",'A'));
            livro.Add(lan);
            livro.SalvaLista(nomeArquivo);
            txRelatorio.Text = livro.Relatorio();
            txData.Text = txDescricao.Text = txValor.Text = "";
            rbCredito.Checked = rbDebito.Checked = false;
        }

        private void txRelatorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLivroCaixa_Load(object sender, EventArgs e)
        {
            if (livro == null)
            {
                livro = new LivroCaixa(DateTime.Now, 1000, nomeArquivo);
                txRelatorio.Text = livro.Relatorio();
            }

            txRelatorio.Text = livro.Relatorio();

            lbTitulo.Text = "Livro Caixa da livraria Alas: " + livro.Data.ToString("yyyy/MM");
        }
    }
}
