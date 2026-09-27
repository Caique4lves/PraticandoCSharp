namespace Funcionarios.Classes;

internal class Gerente: Funcionario
{
    public override void ExibirInformacoes()
    {
        Console.WriteLine("**********************");
        Console.WriteLine("Informações do Gerente");
        Console.WriteLine("**********************\n");
        base.ExibirInformacoes();

        Console.Write("\nDigite quantos funcionários estão sob supervisão: ");
        string funcionariosSupervisionados = Console.ReadLine()!;
        Console.WriteLine("Quantidade de funcionários sob supervisão do gerente: {0}", funcionariosSupervisionados);

        Console.Write("\nDigite qual será o próximo projeto de tecnologia: ");
        string novoProjeto = Console.ReadLine()!;
        Console.WriteLine("Próximo projeto da empresa: {0}\n", novoProjeto);
    }
}
