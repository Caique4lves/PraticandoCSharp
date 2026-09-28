using Formas.Modelos;

namespace Formas.Classes;

internal class Circulo : IForma
{
    public float Pi { get; set; }
    public int Raio { get; set; }
    public void CalcularArea()
    {
        Console.WriteLine($"Valor de Pi: {Pi}");
        Console.WriteLine($"Valor do Raio: {Raio}");
        Console.WriteLine($"Valores: Pi = {Pi}, Raio = {Raio}");
        float area = Pi * (Raio * Raio);

        Console.WriteLine($"\nÁrea do círculo: {area}");
    }

    public void CalcularPerimetro()
    {
        int Diametro = 2 * Raio;
        Console.WriteLine($"\nDiâmetro: {Diametro}");
        float perimetro = Pi * (Diametro);
        Console.WriteLine($"Perímetro do círculo: {perimetro}");
    }
}
