namespace RegistroClientes.Classes;

internal class ClienteVIP : Pessoa
{
    public string NivelVIP { get; set; }
    public string CodigoVIP { get; set; }

    public ClienteVIP(string nome, int idade, string nivelVIP, string codigoVIP) : base(nome, idade)
    {
        NivelVIP = nivelVIP;
        CodigoVIP = codigoVIP;
    }

    public void BoasVindas()
    {
        Console.WriteLine($"Bem-vindo, cliente VIP: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Nível de fidelidade: {NivelVIP}");
        Console.WriteLine($"Código VIP: {CodigoVIP}\n");
    }
}
