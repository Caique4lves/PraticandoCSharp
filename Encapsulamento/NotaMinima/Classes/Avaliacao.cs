namespace NotaMinima.Classes;

internal class Avaliacao
{
    public string Aluno { get; set; }

    public Avaliacao (string aluno)
    {
        Aluno = aluno;
    }

    public double Nota { get; private set; }

    public void AtribuirNota(double nota)
    {
        if(nota < 0 || nota > 10)
        {
            Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
        }
        else
        {
            Nota = nota;
            Console.WriteLine($"Aluno: {Aluno}");
            Console.WriteLine($"Nota atribuída: {Nota}");
        }
    }
}
