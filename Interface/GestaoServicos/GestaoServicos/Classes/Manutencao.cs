namespace GestaoServicos.Classes;
using GestaoServicos.Modelos;
internal class Manutencao : IServico
{
    public Funcionario Responsavel { get; set; }
    public string TituloTarefa { get; set; }

    public Manutencao(string tipoServico, Funcionario responsavel)
    {
        TituloTarefa = tipoServico;
        Responsavel = responsavel;
    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {TituloTarefa}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}\n");
    }
}
