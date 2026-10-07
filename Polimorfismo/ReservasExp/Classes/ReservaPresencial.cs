namespace ReservasExp.Classes;

internal class ReservaPresencial : Reserva
{
    public string Reserva { get; set; }
    public string PtoEncontro { get; set; }

    public ReservaPresencial(string reserva, string ptoEncontro)
    {
        Reserva = reserva;
        PtoEncontro = ptoEncontro;
    }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva principal: {Reserva}");
        Console.WriteLine($"Ponto de encontro: {PtoEncontro}");
    }
}
