using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjLivroCaixa
{
    public class Util
    {
        public static bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            // Remove caracteres não numéricos (pontos, traços, barras)
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            // Verifica se o CNPJ tem 14 dígitos
            if (cnpj.Length != 14)
                return false;

            // Verifica se todos os dígitos são iguais (ex: "00.000.000/0000-00"), o que é inválido.
            if (new string(cnpj[0], 14) == cnpj)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            // Calcula o primeiro dígito verificador
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            // Calcula o segundo dígito verificador
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            // Compara os dígitos calculados com os dígitos reais do CNPJ
            return cnpj.EndsWith(digito);
        }

        public static String FormataCpf(String cpf)
        {
            cpf = cpf.Replace(".", "").
                Replace("-", "").
                Replace(" ", "").
                Replace("/", "");

            if (cpf.Length != 11) return "";

            if (!double.TryParse(cpf, out double x)) return "";

            return cpf.Substring(0, 3) + "." +
                   cpf.Substring(3, 3) + "." +
                   cpf.Substring(6, 3) + "-" +
                   cpf.Substring(9, 2);



        }
        public static String ValidaSenha(String senha)
        {
            if (senha.Length < 8)
            {
                return "Número mínimo de 8 caracteres!";
            }
            int nN = 0, nMa = 0, nMi = 0, nE = 0;
            char [] carac = senha.ToCharArray();
            foreach (char c in carac)
            {
                if (c == ' ') return "Espaços não são permitidos";

                if (c >= '0' && c <= '9') nN++;
                else if (c >= 'A' && c <= 'Z') nMa++;
                     else if (c >= 'a' && c <= 'z') nMi++;
                          else nE++;
            }
            if (nN == 0) return "Obrigatório pelo menos um número";
            if (nMi == 0) return "Obrigatório pelo menos uma letra minúscula";
            if (nMa == 0) return "Obrigatório pelo menos uma letra maiúscula";
            if (nE == 0) return "Obrigatório pelo menos um Caracter especial";

            return "";


        }
        public static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.Distinct().Count() == 1)
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int primeiroDigito = soma % 11;
            primeiroDigito = primeiroDigito < 2 ? 0 : 11 - primeiroDigito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            int segundoDigito = soma % 11;
            segundoDigito = segundoDigito < 2 ? 0 : 11 - segundoDigito;

            return cpf[9] - '0' == primeiroDigito && cpf[10] - '0' == segundoDigito;
        }
    }
}
