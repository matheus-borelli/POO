using System;

namespace _09_Herenca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }

        public override string ToString()
        {
            return $"<ToString() >Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null /*|| this.GetType() != obj.GetType()*/) 
                return false;

            //Cast=> Conversão de objeto
            //((Pessoa)obj)=> convert obj que é tipo Object para tipo pessoa
            return this.Id == ((Pessoa)obj).Id;

        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
