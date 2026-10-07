namespace AvaliacaoConteudo.Classes;

internal class AulaGravada : Conteudo
{
    public int Duracao { get; set; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} minutos");
    }
}
