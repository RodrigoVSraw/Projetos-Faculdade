using PrjCalculadoraWeb.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TP
// No relatório de lançamentos, colocar mais uma coluna com o
// saldo (última coluna)
// Assunto: LIVRO-CAIXA-SEX-MANHA-PARTEIII Nome do aluno
// Email: halrangel@yahoo.com.br

// Colar a foto do FrmLancamento com pelo menos 3 lançamentos
// Colar os fontes das classes: Lancamento e LivroCaixa


namespace PrjLivroCaixa
{
    public class LivroCaixa
    {
        public DateTime Data { get; private set; }
        public decimal ValorTransportado { get; private set; }

        private List<Lancamento> lancamentos;

        public void Add(Lancamento lan)
        {
            lancamentos.Add(lan);
        }

        public String Relatorio()
        {
            Decimal saldo = ValorTransportado;

            StringBuilder sb = new StringBuilder();
            foreach (Lancamento lan in lancamentos)
            {
               saldo += lan.Tipo == 'C' ? lan.Valor : -lan.Valor;
               sb.AppendLine(lan.ToString() + ", " + String.Format("{0:###,###.00}",saldo));
            }

            return sb.ToString();
        }

        public void SalvaLista(String nomeArquivo)
        {
            Serializa.SerializaLancamento(lancamentos, nomeArquivo);
        }

        public LivroCaixa(DateTime data, decimal valorTransportado, string nomeArquivo)
        {
            Data = data;
            ValorTransportado = valorTransportado;

            if (lancamentos == null)
            {
                if (File.Exists(nomeArquivo))
                {
                    lancamentos = Serializa.DesserializaLancamento(nomeArquivo); 
                    Lancamento.AcertaContador(lancamentos);
                } 
                else
                {
                    lancamentos=new List<Lancamento>();
                }
            }


        }
    }
}
