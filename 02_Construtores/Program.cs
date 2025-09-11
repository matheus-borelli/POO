using System;

using System.Collections.Generic;

using System.Data.SqlTypes;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace _02_Construtores

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //declaração da instância

            Quadrado quadrado = new Quadrado(5);

            quadrado.ImprimirArea();

            Retangulo retangulo = new Retangulo(15, 5);

            retangulo.ImprimirArea();

            Circulo circulo = new Circulo(7.5);

            circulo.ImprimirArea();

            Triangulo triangulo = new Triangulo(12.75, 25.5);

            triangulo.ImprimirArea();

        }

    }

    //declaração da classe

    public class Quadrado

    {

        //modificador de acesso: Private

        //pode ser acessado apenas dentro do escopo da classe e não fora dela

        private int Lado; //declaração do atributo da classe

        //Overload (Sobrecarga) de Construtor

        //Usado para declarar mais de um construtor com a lista de argumentos diferentes
        //this(5) aciona o construtor que recebe um parâmettro

        public Quadrado():this(5)

        {

            //this.Lado = 5;

        }

        //declaração do construtor

        //o construtor serve para instanciar o objeto e inicializar os atributos

        public Quadrado(int Lado)

        {
            if (Lado > 0)
            this.Lado = Lado; //"this" indica que estamos acessando o atributo (o membro "Lado") da própria classe.

        }

        //declaração dos métodos

        public int CalculaArea()

        {

            return Lado * Lado;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}.");

        }

    }



    //declaração da classe 

    public class Retangulo

    {

        //declaração do atributo da classe

        private int Largura, Altura;

        //declaração do construtor

        public Retangulo(int Largura, int Altura)

        {

            this.Largura = Largura; //"this" indica que estamos acessando o atributo (o membro "Largura e Altura") da própria classe.

            this.Altura = Altura;

        }

        //declaraçõ dos métodos

        public int CalculaArea()

        {

            return Largura * Altura;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Retângulo com largura de {Largura}, altura de {Altura} possui uma área de {CalculaArea()}");

        }


    }

    //declaração da classe

    public class Circulo

    {

        //declaração do atributo da classe

        private double Raio;

        //declaração do construtor

        public Circulo(double Raio)

        {

            this.Raio = Raio;

        }

        //declaração dos métodos

        public double CalculaArea()

        {

            return Math.Pow(Raio, 2) * Math.PI;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Circulo com Raio de {Raio} possui uma área de {CalculaArea()}");

        }

    }

    //declaração da cçlasse 

    public class Triangulo

    {

        //declaração dos atributos da classe

        private double Base, Altura;

        //declaração do construtor

        public Triangulo(double Base, double Altura)

        {

            this.Base = Base;

            this.Altura = Altura;

        }

        //declaração dos métodos

        public double CalculaArea()

        {

            return Base * Altura / 2;

        }

        public void ImprimirArea()

        {

            Console.WriteLine($"Triângulo com base de  {Base} e altura de {Altura} possui uma área de {CalculaArea()}");

        }

    }

}


