using System;

namespace _24_CriandoExcecaoPersonalizada
{
    // Classe de exceção personalizada
    public class NotaInvalidaException : Exception
    {
        public NotaInvalidaException()
            : base("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.")
        {
        }
    }
}
