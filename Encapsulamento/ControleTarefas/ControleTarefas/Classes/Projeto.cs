namespace ControleTarefas.Classes;

internal class Projeto
{
    public string Nome { get; set; }

    public int QtdTarefas
    {
        get { return tarefas.Count; }
    }

    private List<string> tarefas;

    public Projeto(string nome)
    {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {Nome}\n");
        Console.WriteLine("Tarefas:\n");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"- {tarefa}");
        }
        Console.WriteLine($"\nTotal de tarefas: {QtdTarefas}");
    }

    
        
}
