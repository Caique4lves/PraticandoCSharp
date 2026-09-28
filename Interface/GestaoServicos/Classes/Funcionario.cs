namespace GestaoServicos.Classes;

internal class Funcionario
{
    public string Nome { get; set; }
    public string Departamento { get; set; }

    public Funcionario(string nome, string departamento)
    {
        Nome = nome;
        Departamento = departamento;
    }
}
