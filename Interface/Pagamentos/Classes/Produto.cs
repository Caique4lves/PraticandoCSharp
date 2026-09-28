namespace Pagamento.Classes;
using Pagamento.Modelos;
internal class Produto : IPagavel
{
    public string NomeProduto { get; set; }
    public int QtdProdutos { get; set; }
    public int ValorProduto { get; set; }
    public int TaxaHoraria { get; set; }
    public decimal ValorTotalComTaxa { get; set; }
    public decimal CalcularPagamento()
    {
        ValorTotalComTaxa = (decimal) (ValorProduto * QtdProdutos) + TaxaHoraria;
        return ValorTotalComTaxa;
    }
}
