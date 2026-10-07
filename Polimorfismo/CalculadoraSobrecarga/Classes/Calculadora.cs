namespace CalculadoraSobrecarga.Classes;

internal class Calculadora
{
    public void Somar(int numero1, int numero2)
    {
        int soma = numero1 + numero2;
        Console.WriteLine($"Soma: {soma}");
    }
    public void Somar(int numero1, int numero2, int numero3)
    {
        int soma = numero1 + numero2 + numero3;
        Console.WriteLine($"Soma: {soma}");
    }

    public void Somar(double numeroDecimal1, double numeroDecimal2)
    {
        double soma = numeroDecimal1 + numeroDecimal2;
        Console.WriteLine($"Soma: {soma}");
    }
}
