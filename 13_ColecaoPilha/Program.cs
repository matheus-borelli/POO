using System;
using System.Collections.Generic;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilha = new Stack<int>();

            Console.WriteLine(" PILHA ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: "); //i + 1 volta para valor i
                int numero = int.Parse(Console.ReadLine());
                pilha.Push(numero);// push enumera as pilhas
            }

            Console.WriteLine($"\nO último número inserido foi: {pilha.Peek()}");
        }
    }
}
