namespace ReservaHotel.Classes;

internal class Reserva
{
    private int diarias;
    public Hospede Cliente { get; }
    public Quarto Quarto { get; }
    public double ValorTotal { get { return Quarto.ValorDiaria * diarias; } }

    public Reserva(Hospede cliente, Quarto quarto, int diarias)
    {
        Cliente = cliente;
        Quarto = quarto;
        this.diarias = diarias;
    }

    public void ExibirReserva()
    {
        Console.WriteLine($"Reserva: {Cliente.Nome}");
        Console.WriteLine($"Quarto: {Quarto.Numero}");
        Console.WriteLine($"Valor total: {ValorTotal:C}");
    }
}
