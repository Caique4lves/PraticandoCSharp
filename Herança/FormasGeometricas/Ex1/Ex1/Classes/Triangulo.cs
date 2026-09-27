namespace Ex1.Classes;
internal class Triangulo : FormaGeometrica
{
    public override void CalcularAreaFigura()
    {
        int area;
        Console.Write("\nDigite a base do triângulo: ");
        int baseTriangulo = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a altura do triângulo: ");
        int alturaTriangulo = int.Parse(Console.ReadLine()!);
        area = baseTriangulo * alturaTriangulo / 2;
        Console.WriteLine("Área do triângulo: {0}", area);
    }
}
