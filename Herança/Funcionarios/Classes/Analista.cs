namespace Funcionarios.Classes;

internal class Analista : Funcionario
{
    public override void ExibirInformacoes()
    {
        Console.WriteLine("***********************");
        Console.WriteLine("Informações do Analista");
        Console.WriteLine("***********************\n");
        base.ExibirInformacoes();

        Console.Write("\nDigite a área de atuação do analista: ");
        string areaAtuacao = Console.ReadLine()!;
        Console.WriteLine("Área de atuação do analista: {0}", areaAtuacao);

        Console.WriteLine("\nCom base na área de atuação, o analista analisará os dados do projeto.\n");
    }
}


