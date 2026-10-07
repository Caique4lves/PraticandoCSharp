namespace SimuladorTransporte.Classes;

internal class Transporte
{
    public int Minutos { get; set; }
    public virtual int CalcularTempo(int distanciaKm)
    {
        int CalculoTempo = (distanciaKm) + Minutos;
        return CalculoTempo;
    }
}
