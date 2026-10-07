namespace ExibirMidia.Classes;

internal class Imagem : Midia
{
    public string Resolucao { get; set; }

    public Imagem(string nome, string resolucao)
    {
        Nome = nome;
        Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}
