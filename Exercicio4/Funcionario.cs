namespace Exercicio4;

internal class Funcionario
{
    public string Nome { get; }
    private double salario;
    public Funcionario (string nome, double salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }
    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > Salario)
        {
            salario = novoValor;
            Console.WriteLine($"Salário atualizado para {Salario}.");
        }
        else
        {
            Console.WriteLine("Salario invalido");
        } 
    }
    public double Salario
    {
        get { return salario; }
    }
}
