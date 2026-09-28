namespace ValidarSaque.Classes;

internal class SegurancaConta
{
    public bool ValidarSaque(double valor) 
    { 
        return valor <= 1000;
    }
}
