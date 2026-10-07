namespace ExibirMidia;

internal class Midia
{
    public string Nome { get; set; }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine("Exibindo detalhes da mídia genérica.");
    }
}
