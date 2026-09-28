namespace PlataformaCursos.Classes;

internal class Instrutor
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Instrutor(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}
