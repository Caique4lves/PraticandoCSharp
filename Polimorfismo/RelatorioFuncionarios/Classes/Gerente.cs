using System.Threading.Channels;

namespace RelatorioFuncionarios.Classes;

internal class Gerente : Funcionario
{
    public override string GerarRelatorio()
    {
        base.GerarRelatorio();
        return "Relatório do gerente: supervisiona a equipe.";
    }
}
