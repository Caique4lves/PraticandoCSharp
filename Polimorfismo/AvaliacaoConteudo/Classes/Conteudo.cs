namespace AvaliacaoConteudo.Classes;

internal class Conteudo
{
    public string Titulo { get; set; }

    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine("Exibindo informação genérica do conteúdo...");
    }
}