using System;

using System.Collections.Generic;

using System.Linq;
using System.Net.Http.Headers;
using System.Text;

using System.Threading.Tasks;

namespace _01_DeclaracaoClasse

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Quadrado obj1 = new Quadrado();  // Cria (instancia) um objeto da classe Quadrado chamado obj1

            obj1.Lado = 5; // Define o valor do lado do quadrado como 5

            obj1.ImprimeArea(); // Chama o método que imprime a área do quadrado

            //Alteração do valor do lado do quadrado para 15

            obj1.Lado = 15;

            obj1.ImprimeArea();


            Quadrado obj2 = new Quadrado();  // Cria (instancia) um objeto da classe Quadrado chamado obj2

            obj2.Lado = 25; // Define o valor do lado do quadrado como 5

            obj2.ImprimeArea();

            //------------------------------------------------------------


            Retangulo objRet = new Retangulo(); //Cria (instancia) um objeto da classe Retangulo chamado objRet

            objRet.BaseRet = 6; // Define o valor da Base do Retangulo para 6

            objRet.AlturaRet = 4;  // Define o valor da Altura do Retangulo para 4

            objRet.ImprimeArea(); //Chama o método que imprime a área do Retangulo


            //------------------------------------------------------------

            Circulo objCirc = new Circulo();

            objCirc.Raio = 7.5;

            objCirc.ImprimeArea();


            //-------------------------------------------------------------

            Triangulo objTri = new Triangulo();

            objTri.BaseTri = 10;

            objTri.AlturaTri = 5;

            objTri.ImprimeArea();

            Conta contaMatheus = new Conta();

            contaMatheus.Banco = 237;

            contaMatheus.Agencia = "002-8";

            contaMatheus.Numero = "99248-8";

            contaMatheus.Saldo = 0.00;

            contaMatheus.Limite = 500.00;

            contaMatheus.Depositar(1050.55);

            Console.WriteLine($"Saldo Atual: {contaMatheus.ConsultarSaldo()}");

            contaMatheus.Sacar(200.00);

            Console.WriteLine($"Saldo Atual: {contaMatheus.ConsultarSaldo()}");

        }

    }


    public class Quadrado // Declaração da classe Quadrado

    {

        public int Lado; // Declaração da Propriedade (atributo) que representa o lado do quadrado


        public int CalculaArea() // Método (função) que calcula a área do quadrado

        {

            int area = Lado * Lado;// Declarou uma variavel area com o calculo da área do Quadrado

            return area; // Retorna o Resultado do Calculo

        }

        public void ImprimeArea() // Método que imprime a área do quadrado no console

        {

            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}"); // Escreve no console o valor do lado e a área calculada

        }

    }

    //----------------------------------------------------------------------------------------------

    public class Retangulo // Declaração da classe Retângulo

    {

        public int BaseRet; //Declaração da Propiedade (atributo)

        public int AlturaRet; //Declaração da Propiedade (atributo)

        public int CalculaArea() // Método (função) que calcula a área do Retâmgulo

        {

            int area = BaseRet * AlturaRet; //Declaração da variavel área com o cálculo da área do Retângulo

            return area; //Retorna o Resultado do Calculo

        }

        public void ImprimeArea() //Método que imprime a área do Retângulo no Console

        {

            Console.WriteLine($"Retângulo com Largura de {BaseRet} e Altura de {AlturaRet} possui uma Área de {CalculaArea()}"); //Escreve no Console o resultado

        }

    }

    //---------------------------------------------------------------------------------------------

    public class Circulo // Declaração da classe Circulo

    {

        public double Raio; // Declaração da Propriedade (atributo) que representa o Raio do Circulo


        public double CalculaArea() // Método (função) que calcula a área do Circulo

        {

            double area = Math.PI * Raio * Raio; //Declaração da variavel área com o cálculo da área do Circulo

            return area; //Retorna o Resultado do calculo

        }

        public void ImprimeArea() //Método que imprime a área do Circulo no Console

        {

            Console.WriteLine($"Circulo com Raio de {Raio} possui uma Área de {CalculaArea():F2}"); //Escreve no Console o resultado, o "F2" (para formatar com 2 casas decimais

        }

    }

    //-----------------------------------------------------------------------------------------------

    public class Triangulo

    {

        public double BaseTri;

        public double AlturaTri;

        public double CalculaArea() // Método (função) que calcula a área do Circulo

        {

            return BaseTri * AlturaTri;

        }

        public void ImprimeArea() //Método que imprime a área do Circulo no Console

        {

            Console.WriteLine($"Triângulo com Base de {BaseTri}, e altura de {AlturaTri} possui uma área de {CalculaArea():F2}");

        }

    }

}

//DECLARAÇÃO DA CLASSE CONTA

public class Conta

{

    //DECLARAÇÃO DOS ATRIBUTOS (características da conta)

    public int Banco;

    public string Agencia;

    public string Numero;

    public double Saldo;

    public double Limite;


    //DECLARAÇÃO DOS MÉTODOS (ações que a conta pode realizar)

    public void Depositar(double valor)

    {

        Saldo += valor;

    }

    public void Sacar(double valor)

    {

        Saldo -= valor;

    }

    // Método para consultar o saldo disponível

    // Retorna o valor atual do saldo da conta

    public double ConsultarSaldo()

    {

        return Saldo;

    }

}

public class Aluno
{
    public int Codigo;
    public string Nome;
    public double[] Notas = new double[4];  // Correção no tipo do array

    public void LancarNota(int trimestre, double nota)
    {
        // Corrigido para Notas (array com 'N' maiúsculo)
        Notas[trimestre - 1] = nota;
    }

    public double CalcularMedia()
    {
        double media = 0;
        foreach (double nota in Notas)
        {
            media += nota;  // Corrigido a soma das notas
        }
        return media / 4.0;  // Retorno da média
    }

    public string Mencao()
    {
        // Aprovado se a média for >= 5.0
        if (CalcularMedia() >= 5.0)
            return "Aprovado";
        else
            return "Reprovado";
    }
}
