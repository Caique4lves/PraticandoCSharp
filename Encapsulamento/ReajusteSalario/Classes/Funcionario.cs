namespace ReajusteSalario.Classes;

internal class Funcionario
{
    public string Nome { get; set; }

    private double salarioInicial;

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        this.salarioInicial = salario;
    }

    public void ReajustarSalario(double novoValor)
    {
        if (novoValor < salarioInicial)
        {
            Console.WriteLine("Erro: Reajuste deve ser maior que o atual.");
        }
        else
        {
            salarioInicial = novoValor;
            Console.WriteLine($"Funcionário: {Nome}");
            Console.WriteLine($"Salário reajustado para {salarioInicial:C}");
        }
    }

    public double Salario 
    { 
        get { return salarioInicial; }
    }

}

