using System.Security.Cryptography.X509Certificates;

namespace ControleMatricula.Classes;

internal class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }
    private List<Estudante> matriculas;
    public int VagasDisp { get { return VagasTotais - matriculas.Count; } }


    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }
    
    public bool Matricular(Estudante estudante)
    {
        matriculas.Count();
        if(matriculas.Count() < VagasTotais)
        {
            matriculas.Add(estudante);
            Console.WriteLine($"Estudante {estudante.Nome} matriculado com sucesso no curso {Nome}");
            return true;
        }
        else
        {
            Console.WriteLine($"Erro: Não há mais vagas disponíveis para o curso {Nome}.");
            return false;
        }
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"\nEstudantes matriculados no curso {Nome}:");
        foreach(var estudante in matriculas)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }
        Console.WriteLine($"Vagas disponíveis: {VagasDisp}");
    }
}
