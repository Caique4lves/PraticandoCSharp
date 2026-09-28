namespace CadastroFuncionario.Classes;

internal class Freelancer : Funcionario
{
    public int ValorProjeto { get; set; }

    public Freelancer(string nome, string cargo, int valorProjeto) : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }

    public void Descricao()
    {
        Console.WriteLine($"Freelancer {Nome} - Cargo: {Cargo} - Projeto atual: {ValorProjeto:C}");
    }
}
