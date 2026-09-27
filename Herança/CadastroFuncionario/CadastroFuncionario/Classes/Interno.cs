namespace CadastroFuncionario.Classes;
internal class Interno : Funcionario
{
    public decimal Salario { get; set; }

    public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
    {
        Salario = salario;
    }

    public void Descricao()
    {
        Console.WriteLine($"Funcionária {Nome} - Cargo: {Cargo} - Salário: {Salario:C}");
    }
}

