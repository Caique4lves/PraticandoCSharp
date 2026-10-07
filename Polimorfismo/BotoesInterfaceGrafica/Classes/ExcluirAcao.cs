namespace BotoesInterfaceGrafica.Classes;
using BotoesInterfaceGrafica.Modelos;

internal class ExcluirAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Excluindo registro do sistema...");
    }
}
