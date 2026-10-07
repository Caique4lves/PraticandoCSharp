namespace RelatorioFuncionarios.Classes;

internal class Desenvolvedor : Funcionario
{
    public override string GerarRelatorio()
    {
        base.GerarRelatorio();
        return "Relatório do desenvolvedor: escreve código e corrige bugs";
    }
}
