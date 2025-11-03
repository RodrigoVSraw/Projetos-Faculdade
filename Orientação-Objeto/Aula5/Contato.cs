using PrjLivroCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Página_de_Fatura.Classes
{
    [Serializable]
    public class Contato
    {
        public Contato(string nome, string cpf, string email, string telFixo, string telMovel, string cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            TelFixo = telFixo;
            TelMovel = telMovel;
            Cargo = cargo;

            if (!Util.ValidarCPF(cpf))
            {
                throw new ArgumentException("CPF Inválido" + cpf);
            }
        }

        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Email { get; private set; }

        public string TelFixo { get; private set; }

        public String TelMovel { get; private set; }

        public String Cargo { get; private set; }
    }
}
