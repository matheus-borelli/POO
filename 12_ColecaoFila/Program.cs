using System;
using System.Collections.Generic;
 
namespace ColecaoFila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            int totalPessoas = 0;
 
            Console.WriteLine("Fila de Atendimento");
            Console.Write("Quantas pessoas você quer adicionar à fila? ");
 
            
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out totalPessoas) && totalPessoas >= 3)
                {
                    break;
                }
                else
                {
                    Console.Write("Digite um número válido (mínimo 3): ");
                }
            }
 
            
            for (int i = 1; i <= totalPessoas; i++)
            {
                while (true)
                {
                    Console.Write($"Digite o nome da pessoa {i}: ");
                    string nome = Console.ReadLine();
 
                    if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                    {
                        fila.Enqueue(nome);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nome inválido. O nome deve ter no mínimo 3 caracteres.");
                    }
                }
            }
 
            Console.WriteLine("\nAtendimento:");
            for (int i = 1; i <= 3; i++)
            {
                if (fila.Count > 0)
                {
                    string atendido = fila.Dequeue();
                    Console.WriteLine($"{i}º atendido: {atendido}");
                }
                else
                {
                    Console.WriteLine($"{i}º atendido: (ninguém na fila)");
                }
            }
 
           
            Console.WriteLine("\nQuem ainda está aguardando na fila:");
            if (fila.Count == 0)
            {
                Console.WriteLine("Nenhuma pessoa aguardando.");
            }
            else
            {
                foreach (string pessoa in fila)
                {
                    Console.WriteLine($"- {pessoa}");
                }
            }
        }
    }
}

 