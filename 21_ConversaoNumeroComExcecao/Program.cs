using System;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            try
            {
                // Solicita ao usuário um número inteiro
                Console.Write("Digite um número inteiro: ");
                string entrada = Console.ReadLine();

                // Converte o valor digitado para inteiro
                int numero = int.Parse(entrada);

                // Calcula o dobro
                int dobro = numero * 2;

                // Exibe o resultado
                Console.WriteLine();
                Console.WriteLine($"O dobro de {numero} é {dobro}!");
            }
            catch (FormatException)
            {
                // Mensagem de erro amigável
                Console.WriteLine();
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

            // Espera o usuário apertar Enter antes de fechar
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
