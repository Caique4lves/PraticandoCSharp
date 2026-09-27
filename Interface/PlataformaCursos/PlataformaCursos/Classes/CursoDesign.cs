namespace PlataformaCursos.Classes;
using PlataformaCursos.Modelos;

internal class CursoDesign : ICurso
{
    private Instrutor Instrutor { get; set; }
    public string Curso { get; set; }

    public CursoDesign(string curso, Instrutor instrutor)
    {
        Curso = curso;
        Instrutor = instrutor;    
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de design: {Curso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {Curso} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})");
    }
}
