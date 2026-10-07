namespace CalculoJuros.Modelos;

internal interface IEmprestimo
{
    decimal CalcularValorFinal(decimal valor, int meses);
}
