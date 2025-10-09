using System;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Pede o primeiro número
                Console.Write("Digite o primeiro número inteiro: ");
                string texto1 = Console.ReadLine();
                int numero1 = int.Parse(texto1); // Converte o texto em número

                // Pede o segundo número
                Console.Write("Digite o segundo número inteiro: ");
                string texto2 = Console.ReadLine();
                int numero2 = int.Parse(texto2); // Converte o texto em número

                // Faz a divisão
                int resultado = numero1 / numero2;

                // Mostra o resultado
                Console.WriteLine();
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            catch (FormatException)
            {
                // Caso o usuário digite letras ou símbolos
                Console.WriteLine();
                Console.WriteLine("Erro: valor inválido! Digite apenas números inteiros.");
            }
            catch (DivideByZeroException)
            {
                // Caso o usuário tente dividir por zero
                Console.WriteLine();
                Console.WriteLine("Erro: não é possível dividir por zero!");
            }
            finally
            {
                // Sempre aparece, mesmo que dê erro
                Console.WriteLine();
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o programa!");
            }

            // Espera o usuário apertar uma tecla antes de fechar 
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
