namespace PlataformaCursos.Classes;
using PlataformaCursos.Modelos;

internal class CursoProgramacao : ICurso
{
    private Instrutor Instrutor { get; set; }

    public string Curso { get; set; }

    public CursoProgramacao(string curso, Instrutor instrutor)
    {
        Curso = curso;
        Instrutor = instrutor;
        
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Curso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Curso} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
    }
}
