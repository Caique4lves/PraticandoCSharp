namespace ContasBancarias.Classes;

internal class ContaPoupanca : ContaBancaria
{
    public string Agencia { get; set; }
    public string numConta { get; set; }
    public void ExibirInformacoes()
    {
        Console.WriteLine("\n// CONTA POUPANÇA// ");
        Console.WriteLine("\n***********************");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {numConta}");
        Console.WriteLine("***********************");
    }

    public override void CalcularSaldo()
    {
        base.CalcularSaldo();
    }
}
