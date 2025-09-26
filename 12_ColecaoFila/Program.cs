using System;
using System.Collections.Generic;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando a fila de atendimento
            Queue<string> fila = new Queue<string>();

            Console.WriteLine(" FILA DE ATENDIMENTO ");

            Console.Write("Quantas pessoas deseja colocar na fila? ");
            int quantidade = int.Parse(Console.ReadLine());

            // Pedindo os nomes e validando
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome da pessoa {i + 1}: ");
                string nome = Console.ReadLine();

                // Verifica se o nome tem pelo menos 3 caracteres
                if (nome.Length >= 3)
                {
                    fila.Enqueue(nome); // Adiciona a pessoa na fila
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ter pelo menos 3 letras.");
                    i--; // volta uma posição para pedir de novo
                }
            }

            Console.WriteLine("\n ATENDIMENTO ");

            // Mostra quem foi o atendido
            for (int i = 1; i <= 3; i++)
            {
                if (fila.Count > 0) // se ainda tem pessoas na fila
                {
                    string atendido = fila.Dequeue(); // retira o primeiro da fila
                    Console.WriteLine($"{i}º atendido: {atendido}");
                }
                else
                {
                    Console.WriteLine($"{i}º atendido: (ninguém na fila)");
                }
            }

            // Mostra quem ainda está aguardando
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
                Console.WriteLine("Ninguém está aguardando.");
            }

            Console.ReadKey();
        }
    }
}
