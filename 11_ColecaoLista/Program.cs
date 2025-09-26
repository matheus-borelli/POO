using System;
using System.Collections.Generic;

namespace _11_ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando a lista nomes
            List<string> nomes = new List<string>();

            // pedidindo 5 nomes
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();

               // pedindo para 3 caracteres
                if (nome.Length >= 3)
                {
                    nomes.Add(nome); 
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ter pelo menos 3 caracteres.");
                    i--; // esse i--; ele anula
                }
            }

           
            Console.WriteLine("\nOs nomes digitados foram:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
