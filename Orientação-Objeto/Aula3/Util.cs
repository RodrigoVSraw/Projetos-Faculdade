using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivroCaixa
{
    public class Util
    {
        public static bool ValidarCPF(string cpf)
        {
            // Remover caracteres especiais
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verificar se o CPF possui 11 caracteres numéricos
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }

            // Verificar se todos os dígitos são iguais (CPF como "111.111.111-11" é inválido)
            if (cpf.All(c => c == cpf[0]))
            {
                return false;
            }

            // Validação do primeiro dígito verificador
            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int digito1 = (soma1 * 10) % 11;
            if (digito1 == 10 || digito1 == 11)
            {
                digito1 = 0;
            }

            if (int.Parse(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            // Validação do segundo dígito verificador
            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            int digito2 = (soma2 * 10) % 11;
            if (digito2 == 10 || digito2 == 11)
            {
                digito2 = 0;
            }

            if (int.Parse(cpf[10].ToString()) != digito2)
            {
                return false;
            }

            return true;
        }
    }
}
