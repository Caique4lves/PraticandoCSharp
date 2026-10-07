namespace BotoesInterfaceGrafica.Classes;
using BotoesInterfaceGrafica.Modelos;

internal class SalvarAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Salvando dados no banco de dados...");
    }
}
