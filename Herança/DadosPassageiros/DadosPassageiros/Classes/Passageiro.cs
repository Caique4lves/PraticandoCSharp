using System.Threading.Channels;

namespace DadosPassageiros.Classes;

internal class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; set; }

    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Passageiro: {Nome} - Idade: {Idade} - Bilhetes: {QuantidadeBilhetes}");
    }

}
