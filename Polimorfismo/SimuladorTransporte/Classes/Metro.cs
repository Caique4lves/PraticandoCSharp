namespace SimuladorTransporte.Classes;

internal class Metro : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        int CalculoTempo = distanciaKm + 5;
        return CalculoTempo;
    }
}
