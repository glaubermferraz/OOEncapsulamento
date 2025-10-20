namespace Exercicio7;

internal class Agenda
{
    public string Proprietario {  get; set; }
    private readonly List<Contato> contatos;
    public Agenda(string Proprietario)
    {
        this.Proprietario = Proprietario;
        this.contatos = new List<Contato>();
    }
    public bool AdicionarContato(Contato novoContato)
    {
        if (contatos.Any(c => c.Nome == novoContato.Nome))
        {
            Console.WriteLine($"Contato com o nome {novoContato.Nome} já está na agenda.");
            return false;
        }
        else
        {
            contatos.Add(novoContato);
            Console.WriteLine($"Contato de {novoContato.Nome} adicionado na agenda.");
            return true;
        }
    }
    public void ListarContatos()
    {
        Console.WriteLine("Lista de contatos");
        foreach (Contato contato in contatos)
        {
            Console.WriteLine($"- {contato.Nome} {contato.Telefone}");
        }
    }
    public int QuantidadeDeContatos
    {
        get
        {
            return contatos.Count;
        }
    }
}
