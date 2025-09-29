using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo sem Enum
            // List<int> diaDaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            List<int> diaDaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 }; //foi reprogramado de 1 a 7

            foreach (var item in diaDaSemanaSemEnum)
            {
                //ctrl k/c
                //if (item == 0) Console.WriteLine("Domingo");
                //else if (item == 1) Console.WriteLine("Segunda");
                //else if (item == 2) Console.WriteLine("Terça");
                //else if (item == 3) Console.WriteLine("Quarta");
                //else if (item == 4) Console.WriteLine("Quinta");
                //else if (item == 5) Console.WriteLine("Sexta");
                //else if (item == 6) Console.WriteLine("Sábado");
                if (item == 1) Console.WriteLine("Domingo");
                else if (item == 2) Console.WriteLine("Segunda");
                else if (item == 3) Console.WriteLine("Terça");
                else if (item == 4) Console.WriteLine("Quarta");
                else if (item == 5) Console.WriteLine("Quinta");
                else if (item == 6) Console.WriteLine("Sexta");
                else if (item == 7) Console.WriteLine("Sábado");
            }

            Console.WriteLine("\n\nCom a utilização de Enum");

            // Exemplo com Enum
            List<DiaDaSemana> diaDaSemanaComEnum = new List<DiaDaSemana>
            {
                DiaDaSemana.Domingo,
                DiaDaSemana.Segunda,
                DiaDaSemana.Terca,
                DiaDaSemana.Quarta,
                DiaDaSemana.Quinta,
                DiaDaSemana.Sexta,
                DiaDaSemana.Sabado
            };

            foreach (var item in diaDaSemanaComEnum)
            {
                //{item} - Chama o método toString()
                //{ (int)item } - faz um Cast, conversão, do texto para número equivalente
                Console.WriteLine($"{item} Número: { (int)item }");
            }

           
        }
    }
}

public enum DiaDaSemana
{
    Domingo = 1,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}
