using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    internal class CPFQtdeDigitosExcepetio : Exception
    {
        public CPFQtdeDigitosExcepetio()  :base("O CPF dve ter 11 dígitos!") { }
    }
}
