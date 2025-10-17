using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjLivroCaixa
{
    [Serializable]
    public class Lancamento  : IComparable<Lancamento>
    {
        public String Id { get; private set; }
        public DateTime Data { get; private set;}
        public decimal Valor { get; private set; }
        public String Descricao { get; private set; }
        public char Tipo { get; private set; }
        public Usuario Responsavel { get; private set; }

        private static int contador;

        public static void AcertaContador(List<Lancamento> list)
        {
            if (list.Count == 0)
            {
                contador = 0;
                return;
            }
            String id = list[list.Count - 1].Id;
            int.TryParse(id, out contador);
        }

        public Lancamento(
            DateTime data, 
            decimal valor, 
            string descricao, 
            char tipo, 
            Usuario responsavel)
        {
            Data = data;
            Valor = valor;
            Descricao = descricao;
            Tipo = tipo;
            Responsavel = responsavel;
            Id = (++contador).ToString("D6"); // 000001
        }

        public override string ToString()
        {
            return String.Concat(
                Id, ",  ",
                Responsavel.Nome, ", ",
                Data.ToString("dd/MM/yy"), ", ",
                Descricao, ", ",
                Tipo, ", ",
                String.Format("{0:###,###.00}", Valor)
                ); 
        }

        int IComparable<Lancamento>.CompareTo(Lancamento lan)
        {
            return Id.CompareTo(lan.Id);
        }
    }
}
