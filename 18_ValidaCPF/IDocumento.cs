namespace _18_ValidaCPF
{
    internal interface IDocumento
    {
        string Numero { get; }
        bool Validar();
    }
}
