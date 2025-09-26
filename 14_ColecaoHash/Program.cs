using System;
using System.Collections.Generic;

namespace _14_ColecaoHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criei um HashSet de números inteiros
        
            HashSet<int> numeros = new HashSet<int>();

            Console.WriteLine("=== HASHSET DE NÚMEROS ===");

            // pedindo 10 números
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                int num = int.Parse(Console.ReadLine());
                numeros.Add(num); // adiciona ao HashSet, mas não duplica
            }

           
            Console.WriteLine("\nNúmeros armazenados no HashSet :"); // exibindo a lista
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
