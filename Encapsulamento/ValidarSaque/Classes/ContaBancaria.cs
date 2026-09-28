namespace ValidarSaque.Classes;

internal class ContaBancaria
{
    public string Titular { get; set; }

    private decimal saldo;

    public decimal Saldo { get { return saldo; } }

    public ContaBancaria(string titular, decimal saldoAtual)
    {
        Titular = titular;
        saldo = saldoAtual;
    }

    public void Sacar(double valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= (decimal)valor;
            Console.WriteLine($"Saque realizado com sucesso. Saldo atual: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Erro, saque acima do limite permitido.");
        }
    }
}
