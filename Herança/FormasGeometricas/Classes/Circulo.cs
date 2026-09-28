namespace Ex1.Classes;

internal class Circulo : FormaGeometrica
{
    public override void CalcularAreaFigura()
    {
        float area;
        float pi = 3.14f;
        Console.Write("\nDigite o raio do círculo: ");
        float raio = float.Parse(Console.ReadLine()!);
        area = pi * raio * raio;
        Console.WriteLine("A área do círculo é: {0}", area);
    }
}
