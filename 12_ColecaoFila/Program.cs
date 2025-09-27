using System;
using System.Collections.Generic;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando a fila de atendimento
            Queue<string> fila = new Queue<string>();

            Console.WriteLine(" FILA DE ATENDIMENTO ");

            Console.Write("Quantas pessoas deseja colocar na fila? ");
            int quantidade = int.Parse(Console.ReadLine());

            // pedindo os nomes e validando
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome da pessoa {i + 1}: ");
                string nome = Console.ReadLine();

                // nome deve ter pelo menos 3 caracteres
                if (nome.Length >= 3)
                {
                    fila.Enqueue(nome); // adiciona na fila
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ter pelo menos 3 letras.");
                    i--; // repete a entrada
                }
            }

            Console.WriteLine("\n ATENDIMENTO ");

            // atende os 3 primeiros
            for (int i = 1; i <= 3; i++)
            {
                if (fila.Count > 0)
                {
                    string atendido = fila.Dequeue(); // remove o primeiro
                    Console.WriteLine($"{i}º atendido: {atendido}");
                }
                else
                {
                    Console.WriteLine($"{i}º atendido: (ninguém na fila)");
                }
            }

            // mostrando quem ainda está esperando
            Console.WriteLine("\n PESSOAS AINDA NA FILA ");

            if (fila.Count > 0)
            {
                foreach (string pessoa in fila)
                {
                    Console.WriteLine(pessoa);
                }
            }
            else
            {
                Console.WriteLine("Ninguém está na fila.");
            }

            Console.ReadKey();
        }
    }
}
