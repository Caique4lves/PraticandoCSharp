namespace MontagemComputador.Classes;

internal class Computador
{
    private Processador Cpu;
    private PlacaMae Mobo;

    public Computador(Processador cpu, PlacaMae mobo)
    {
        Cpu = cpu;
        Mobo = mobo;
    }

    public void ExibirConfiguracoes()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {Cpu.Marca} - {Cpu.Modelo}");
        Console.WriteLine($"Placa-Mãe: {Mobo.Fabricante} - {Mobo.Socket}");
    }
}
