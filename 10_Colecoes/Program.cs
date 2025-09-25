﻿using System;
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
