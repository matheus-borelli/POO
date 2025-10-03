using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    public enum Mes
    {
        Janeiro = 1,
        Fevereiro,
        Marco,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }
    public enum DiaDaSemana
    {
        Domingo = 0, // O DateTime.DayOfWeek retorna 0 para Domingo
        Segunda,     // 1
        Terca,       // 2
        Quarta,      // 3
        Quinta,      // 4
        Sexta,       // 5
        Sabado       // 6
    }
}

