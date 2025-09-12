using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();
            Conta conta = new Conta("111-88");

            conta.setNome("Matheus Yuri Sadamatsu");

            //Não é possível atribuir o valor em um atributo privado
            //conta.numero = "111-88";                      

            //conta.saldo = -1000.00m;
            conta.Depositar(-1000.00m);

            //Utilizando o metodo acessador
            conta.setSaldo(1000.00m);
            //Console.WriteLine($"Saldo Atual: {conta.getSaldo():c2}");
            conta.ImprimirSaldo();

            while (true)
            {
                //conta.numero = "777-66";
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo():c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }
    public class Conta
    {
        private string numero;

        private string nome;

        public Conta(string numero)
        {
            this.numero = numero;
        }

        //Transformar a conta Saldo com acesso privado
        //public decimal Saldo;        
        private decimal saldo;

        //métodos acessadores
        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public string getNumero()
        {
            return numero;
        }
        public string getNome()
        {
            
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void ImprimirSaldo()
        {
            //Console.WriteLine($"Saldo Atual: {getSaldo():c2}");
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }
    }
}