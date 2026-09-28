namespace Pagamento.Classes;
using Pagamento.Modelos;
internal class Servico : IPagavel
{
    public string NomeServico { get; set; }
    public int QtdLicencas { get; set; }
    public int ValorLicenca { get; set; }
    public int TaxaHoraria { get; set; }
    public  decimal ValorTotalComTaxa { get; set; }
    public decimal CalcularPagamento()
    {
        ValorTotalComTaxa = (decimal) (ValorLicenca * QtdLicencas) + TaxaHoraria;
        return ValorTotalComTaxa;
    }

}
