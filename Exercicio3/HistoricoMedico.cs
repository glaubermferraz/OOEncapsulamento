namespace Exercicio3;

internal class HistoricoMedico
{
    private string CodigoProntuario;

    public HistoricoMedico(string codigoProntuario)
    {
        CodigoProntuario = codigoProntuario;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do Prontuário: {CodigoProntuario}");
    }
}
