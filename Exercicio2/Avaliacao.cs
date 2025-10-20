namespace Exercicio2;

internal class Avaliacao
{
    public string Aluno { get; set; }
    public double Nota { get; private set; }

    public Avaliacao(string aluno)
    {
        Aluno = aluno;
        Nota = 0.0;
    }
    public void AtribuirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
        } else
        {
            Console.WriteLine($"Nota {nota} inválida, deve estar entre 0 e 10");
        }
    }
}
