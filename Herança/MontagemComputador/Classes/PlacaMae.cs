namespace MontagemComputador.Classes;

internal class PlacaMae
{
    public string Fabricante { get; set; }
    public string Socket { get; set; }

    public PlacaMae(string fabricante, string socket)
    {
        Fabricante = fabricante;
        Socket = socket;
    }
}
