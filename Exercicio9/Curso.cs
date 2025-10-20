namespace Exercicio9;

internal class Curso
{
    public string Nome { get; }
    public int VagasTotais { get; }
    private List<Estudante> matriculas;
    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        this.matriculas = new List<Estudante>();
        Console.WriteLine($"Criado curso de {Nome} com {VagasTotais} vagas.");
    }
    public int VagasDisponiveis()
    {
        return VagasTotais - matriculas.Count;
    }
    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados em {Nome}:");
        foreach (var item in matriculas)
        {
            Console.WriteLine($"- {item.Nome}");
        }
    }
    public void Matricular(Estudante novoEstudante)
    {
        if (VagasDisponiveis() > 0) {
            matriculas.Add(novoEstudante);
            Console.WriteLine($"Estudante {novoEstudante.Nome} matriculado com sucesso no curso {Nome}.");
        } else
        {
            Console.WriteLine($"Erro: Não há vagas disponíveis para o curso {Nome}. Estudante {novoEstudante.Nome} não foi matriculado.");
        }
    }
}
