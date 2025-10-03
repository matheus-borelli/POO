using System;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
        }

        // Implementação do IComparable<Feriado>
        public int CompareTo(Feriado other)
        {
            if (other == null) return 1; // null sempre fica "menor"
           return this.Dia.CompareTo(other.Dia);
            //return other.Dia.CompareTo(this.Dia)
        }

        // (Opcional) Sobrescreve ToString para facilitar exibição
        public override string ToString()
        {
            return $"{Dia:D2} - {Descricao}";
        }
    }
}
