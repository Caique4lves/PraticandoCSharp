namespace CatalogoItem.Classes;

internal class Pergaminho : ItemDigital
{
    public string ContTextual { get; set; }

    public Pergaminho(string tituloItem, string contTextual) : base(tituloItem)
    {
        ContTextual = contTextual;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Título: {TituloItem}");
        Console.WriteLine($"Descrição: {ContTextual}");
    }
}
