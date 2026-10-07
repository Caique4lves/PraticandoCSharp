namespace AvaliacaoConteudo.Classes;

internal class MaterialComplementar : Conteudo
{
    public int Paginas { get; set; }

    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        Paginas = paginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"\nTítulo: {Titulo}");
        Console.WriteLine($"Páginas: {Paginas} páginas");
    }
}
