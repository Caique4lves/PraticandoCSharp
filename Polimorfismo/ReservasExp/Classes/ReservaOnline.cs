namespace ReservasExp.Classes;

internal class ReservaOnline : Reserva
{
    public string ReservaDigital { get; set; }

    public ReservaOnline(string reservaDigital)
    {
        ReservaDigital = reservaDigital;
    }
    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva online: {ReservaDigital}");
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}
