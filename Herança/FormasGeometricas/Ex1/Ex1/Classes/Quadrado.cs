namespace Ex1.Classes;

internal class Quadrado : FormaGeometrica
{
    public override void CalcularAreaFigura()
    {
        int area;
        Console.Write("Digite o lado do quadrado: ");
        int lado = int.Parse(Console.ReadLine()!);
        area = lado * lado;
        Console.WriteLine("A área do quadrado é: {0}", area);
    }
}
