namespace SimuladorTransporte.Classes;

internal class Onibus : Transporte
{
    public override int CalcularTempo(int distanciaKm)
    {
        int CalculoTempo = (distanciaKm * 2) + 5;
        return CalculoTempo;
    }
}
