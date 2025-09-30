using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado
    {
        public int dia {  get; set; }
        public string Descricao { get; set; }
        public int Dia { get; internal set; }

        public Feriado(int dia, string descricao)
        {
            this.dia = dia;
            this.Descricao = descricao;
        }
    }
}
