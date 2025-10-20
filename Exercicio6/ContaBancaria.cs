namespace Exercicio6;

public class ContaBancaria
{
    public string Titular { get; }
    private double saldo;
    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }
    public double Saldo { get { return saldo; } }
    public void Sacar(double valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
        } else {
            Console.WriteLine("Saque negado pela política de segurança.");
        }

    }
}
