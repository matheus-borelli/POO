using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                //<Genéric> 
            List<string> nomes = new List<string>();
            nomes.Add("Suely");
            nomes.Add("Celso");

            List<Aluno> alunos = new List<Aluno>();
            Aluno suely = new Aluno { id = 1, Nome = "Suely" };
            AlunoEspecial celso = new AlunoEspecial { id = 2, Nome = "Celso", Deficiencia = "Especial" };
            alunos.Add(suely);
            alunos.Add(celso);

            alunos.Add(new Aluno { id = 3, Nome = "Gustavo" });
            nomes.Add(suely.Nome);

            Console.WriteLine("impressão dos nomes");
            foreach (string nome in nomes)
            {
                Console.WriteLine($" - {nome}");
            }
            Console.WriteLine("Impressão dos alunos");
            foreach (Aluno aluno in alunos)
            {
               // Console.WriteLine($" -ID: {aluno.id} Nome: {aluno.Nome}");
               aluno.ImprimirAluno();
            }
            Dictionary<int, String> dicNomes = new Dictionary<int, String>();
            dicNomes.Add(1, "Gustavo");
            dicNomes.Add(2, "Celso");
            dicNomes.Add(3, "Suely");
            //Não adicionar chave duplicada no Dictionary
            //dicNomes.Add(3, "Suely")
            Console.WriteLine("Impressão dos dicNomes");
            for (int i = 1; i <= dicNomes.Count; i++)//não iniciar com 0 
            {
                Console.WriteLine($" - {dicNomes[i]}");
            }
            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(suely.id, suely);
            dicAlunos.Add(celso.id, celso);

            Console.WriteLine("impressão dos dicAlunos");
            //for (int i = 1; i <= dicAlunos.Count; i++)
           // {
           //     dicAlunos[i].ImprimirAluno();
           // }
            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }

            Queue <String> filaNomes = new Queue<String>();
            filaNomes.Enqueue("Gustavo");
            filaNomes.Enqueue("Celso");
            filaNomes.Enqueue("Suely");
            Console.WriteLine("Impressão dos filaNomes");
            Console.WriteLine($" 1º) {filaNomes.Dequeue()}");

            foreach (String nome in filaNomes)
            {
                Console.WriteLine($" - {nome}" );
            }

            Stack<String> stackNomes = new Stack<String>();
            stackNomes.Push("Gustavo");
            stackNomes.Push("Celso");
            stackNomes.Push("Suely");

            Console.WriteLine("Impressão dos stackNomes");
            Console.WriteLine($"1° {stackNomes.Pop()}");

            foreach (String nome in stackNomes)
            {
                Console.WriteLine($" - {nome}");
            }
             HashSet<String> setNomes = new HashSet<String>();
            setNomes.Add("Gustavo");
            setNomes.Add("Celso");
            setNomes.Add("Suely");
            //ignora valores Duplicados
            setNomes.Add("Gustavo");
            setNomes.Add("Celso");
            setNomes.Add("Suely");

            Console.WriteLine("Impressão dos setNomes");
            foreach (String nome in setNomes)
            {
                Console.WriteLine($" - {nome}");
            }



        }
        class Aluno
        {
            public int id {  get; set; }
            public string Nome { get; set; }
            public double Notas { get; set; }
            public virtual void ImprimirAluno()// virtual = metodo não terminado
            {
                Console.WriteLine($" - ID: {this.id} Nome: {this.Nome}");
            }
        }
        class AlunoEspecial : Aluno
        {
            public string Deficiencia { get; set; }
            public override void ImprimirAluno()
            {
                Console.WriteLine($" - ID: {this.id} Nome: {this.Nome} - {this.Deficiencia}");
            }
        }
    }
}
