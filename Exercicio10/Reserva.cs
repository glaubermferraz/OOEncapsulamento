
namespace Exercicio10;

internal class Reserva
{
    private int diarias;
    public readonly Hospede Hospede;
    public readonly Quarto Quarto;
    public Reserva(Hospede hospede,  Quarto quarto, int diarias)
    {
        if (diarias <= 0) {
            throw new ArgumentException("O número de diárias deve ser maior que zero.");
        }
        this.diarias = diarias;
        Hospede = hospede;
        Quarto = quarto;
    }

    public double ValorTotal
    {
        get { return Quarto.ValorDiaria * diarias; }
    }
}
