namespace ExibirMidia.Classes;

internal class Video : Midia
{
    public int Duracao { get; set; }

    public Video(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome} - Duração: {Duracao} minutos");
    }
}
