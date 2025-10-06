using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcalcula_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lado.Text, out float flado))
            {
                Quadrado q = new Quadrado(); // Quadrado criado
                q.setLado(flado);
                lbMensagem.Text = "Área: " + q.area().ToString() +", Perímetro: " + q.perimetro().ToString() +", Diagonal: " + q.diagonal().ToString();
            }
            else
            {
                lbMensagem.Text = "Valor digitado inválido !!!";
            }
        }
    }
}
