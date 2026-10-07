namespace SimuladorTransporte.Classes;

internal class Bicicleta : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        int CalculoTempo = distanciaKm * 4;
        return CalculoTempo;
    }
}
