using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Herenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //não é possível instanciar uma classe abstrata
            //Pessoa obj = new pessoa();

            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(14 99999-9999)";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Senac Marília";
            pessoaJuridica.CNPJ = "99.999.999/9999-9999";
            pessoaJuridica.Telefone = "(014 9999-9999)";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine("É a mesma pessoa");
            else
                Console.WriteLine($"Não é a mesma pessoa");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
