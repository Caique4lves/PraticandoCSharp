namespace Veiculos.Classes;
using Veiculos.Modelos;
internal class Veiculo : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("Pilotando o veículo...");
    }

    public void Voar()
    {
        Console.WriteLine("Voando com o veículo...");
    }
}
