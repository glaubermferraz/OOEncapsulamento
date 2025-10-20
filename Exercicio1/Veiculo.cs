namespace Exercicio1
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        private double velocidadeAtual;

        public Veiculo(string placa)
        {
            Placa = placa;
            velocidadeAtual = 0;
        }
        public void AtualizarVelocidade(double novaVelocidade)
        {
            if (novaVelocidade >= 0)
            {
                velocidadeAtual = novaVelocidade;
                Console.WriteLine($"Velocidade atualizada para {velocidadeAtual}");
            }
        }
        public double VelocidadeAtual { 
            get { return velocidadeAtual; 
            } 
        }
    }
}
