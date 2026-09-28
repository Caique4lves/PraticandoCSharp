namespace AgendaControle.Classes;

internal class Agenda
{
    public string Proprietario { get; set; }
    private readonly List<Contato> contatos;

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public int QtdContatos { get { return contatos.Count; } }

    public bool AdicionarContato(Contato contato)
    { 
        if(!contatos.Any(c => c.Nome == contato.Nome))
        {
            contatos.Add(contato);
            return true;
        }
        else
        {
            Console.WriteLine($"Erro: O {contato.Nome} já existe na agenda.");
            return false;
        }
    }

    public void ListarContatos()
    {
        Console.WriteLine($"Agenda de {Proprietario}");
        Console.WriteLine("Contatos:");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | {contato.Telefone}");
        }
        Console.WriteLine($"Total de contatos: {QtdContatos}");
    }
}
