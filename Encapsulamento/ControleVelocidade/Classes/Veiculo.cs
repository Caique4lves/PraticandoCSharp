using System.Security.Cryptography.X509Certificates;

namespace ControleVelocidade.Classes;

internal class Veiculo
{
    public string Placa { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    private double velocidadeAtual;

    public void AtualizarVelocidade(double novaVelocidade)
    {
       velocidadeAtual = novaVelocidade;
    }
    public double VelocidadeAtual 
    {
        get { return velocidadeAtual; } 
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Veículo: {Placa}");
        Console.WriteLine($"Velocidade Atual: {velocidadeAtual} km/h");
    }
}
