using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Página_de_Fatura.Classes
{
    [Serializable]
    public class Apresentacao
    {
        public String Descricao { get; private set; }

        public int Peso { get; private set; }

        public Apresentacao(string descricao, int peso)
        {
            Descricao = descricao;
            Peso = peso;
        }
    }
}
