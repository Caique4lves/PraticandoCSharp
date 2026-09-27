namespace GestaoServicos.Classes;
using GestaoServicos.Modelos;
internal class Consultoria : IServico
{
    private Funcionario Responsavel { get; set; }

    public string TituloTarefa { get; set; }

    public Consultoria(string tipoServico, Funcionario responsavel)
    {
        TituloTarefa = tipoServico;
        Responsavel = responsavel;
    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {TituloTarefa}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}\n");     
    }

}
