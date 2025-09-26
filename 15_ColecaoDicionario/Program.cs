using System;
using System.Collections.Generic;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando o dicionário RA com Nome
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            Console.WriteLine(" CADASTRO DE ALUNOS ");

            // pedindo 5 alunos
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o RA do aluno: ");
                int ra = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                // no minimo 3 caracteres no nome
                if (nome.Length >= 3)
                {
                    alunos.Add(ra, nome); // adicionei ao dicionário
                }
                else
                {
                    Console.WriteLine("Nome inválido! Deve ter pelo menos 3 letras.");
                    i--; // repetindo a entrada
                }
            }

            // lista de alunos cadastrados
            Console.WriteLine("\nLISTA DE ALUNOS");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"RA: {aluno.Key} - Nome: {aluno.Value}");// ra ID e Nome string
            }

            Console.ReadKey();
        }
    }
}
