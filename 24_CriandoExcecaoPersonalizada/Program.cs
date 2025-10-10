using System;

namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                Console.Write("Digite a nota do aluno (0 a 10): ");
                string textoNota = Console.ReadLine();

                double nota = double.Parse(textoNota);

                // Verifica se a nota é válida
                if (nota < 0 || nota > 10)
                {
                    // Lança a exceção personalizada
                    throw new NotaInvalidaException();
                }

                // Exibe o resultado
                if (nota >= 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("Aluno aprovado! ");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Aluno reprovado! ");
                }
            }
            catch (NotaInvalidaException erro) // 
            {
                Console.WriteLine();
                Console.WriteLine(erro.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Erro: digite apenas números!");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o programa!");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
