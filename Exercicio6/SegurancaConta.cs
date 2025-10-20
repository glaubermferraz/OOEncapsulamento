namespace Exercicio6;

internal class SegurancaConta
{
    public bool ValidarSaque(double valor)
    {
        return valor <= 1000;
    }
}
