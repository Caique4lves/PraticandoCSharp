namespace ContasBancarias.Classes;

internal class ContaBancaria
{
    public decimal SaldoAtual { get; set; }

    public decimal SaldoAReceber { get; set; }

    public decimal SaldoNovo { get; set; }
    public virtual void CalcularSaldo()
    {
         Console.WriteLine($"\nSaldo: {SaldoAtual:C}");
         Console.WriteLine($"\nSaldo a receber: {SaldoAReceber:C}");
         SaldoNovo = SaldoAtual += SaldoAReceber;
         Console.WriteLine($"\nNovo saldo: {SaldoNovo:C}");     
    }
}
