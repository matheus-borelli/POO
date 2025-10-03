using System;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpfDigitado = Console.ReadLine();

            // Instancia a interface com a classe concreta 
            IDocumento documento = new CPF(cpfDigitado);

            // Chama o método Validar()
            if (documento.Validar())
            {
                Console.WriteLine($"CPF {documento.Numero} é VÁLIDO!");
            }
            else
            {
                Console.WriteLine($"CPF {documento.Numero} é INVÁLIDO!");
            }
        }
    }
}
