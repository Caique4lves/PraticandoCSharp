namespace SituacaoEstudante.Classes;
internal class Estudante
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Estudante(string nome, double nota1, double nota2)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }
    public double Media { get { return (Nota1 + Nota2) / 2; } }
    public string Situacao { get { return Media >= 6 ? "Aprovado" : "Reprovado"; }}

    public void ExibirSituacao()
    {
        Console.WriteLine($"Estudante: {Nome}");
        Console.WriteLine($"Média: {Media}");
        Console.WriteLine($"Situação: {Situacao}");
    }
}
