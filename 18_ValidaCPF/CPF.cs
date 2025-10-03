using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18_ValidaCPF
{
    internal class CPF : IDocumento
    {
        public string Numero { get; private set; } // Propridade somente leitura

        public CPF(string numero)
        {
            // Remove tudo que não for número
            Numero = Regex.Replace(numero, "[^0-9]", ""); 
        }

        public bool Validar()
        {
            // 1 - Validar se tem 11 dígitos
            if (Numero.Length != 11)
                return false;

            // 2 - Verificar se todos os dígitos são iguais
            if (Numero.Distinct().Count() == 1)
                return false;

            // 3 - Calcular dígitos verificadores
            int dig1 = CalculaDV(Numero, 9, 10);
            int dig2 = CalculaDV(Numero, 10, 11);

            // 4 - Verificar se são iguais aos informados
            return (int.Parse(Numero[9].ToString()) == dig1) &&
                   (int.Parse(Numero[10].ToString()) == dig2);
        }

        private int CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cpfVetor[i].ToString()) * (peso - i);
            }

            int resto = soma % 11;
            return (resto >= 2) ? (11 - resto) : 0;
        }
    }
}
