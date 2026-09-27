using Formas.Modelos;

namespace Formas.Classes;

internal class Retangulo : IForma
{
    public int Base { get; set; }
    public int Altura { get; set; }
    public void CalcularArea()
    {
        Console.WriteLine($"\nValor da base: {Base}");
        Console.WriteLine($"Valor da altura: {Altura}");
        int area = Base * Altura;
        Console.WriteLine($"Área do retângulo: {area}");
    }

    public void CalcularPerimetro()
    {
        int perimetro = 2 * (Base + Altura);
        Console.WriteLine($"\nPerímetro do retângulo: {perimetro}");
    }
}
