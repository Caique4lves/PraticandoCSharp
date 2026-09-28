namespace ProdutosEletronicos.Classes;

internal class ProdutoEletronico
{
    public string Marca { get; set; }

    public string Modelo { get; set; }
    public string AnoLancamento { get; set; }

    public string Cor { get; set; }
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine("*******************************");
        Console.WriteLine("Exibindo informações do produto");
        Console.WriteLine("*******************************");
        Console.WriteLine($"\nMarca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}" );
        Console.WriteLine($"Cor: {Cor}\n");
    }
}
