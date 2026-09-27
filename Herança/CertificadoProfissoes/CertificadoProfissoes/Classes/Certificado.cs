namespace CertificadoProfissoes.Classes;

internal class Certificado
{
    private Profissao profissao;
    public Certificado(Profissao profissao)
    {
        this.profissao = profissao;
    }

    public void EmitirCertificado()
    {
        Console.WriteLine($"Certificado emitido para: {profissao.Titulo}");
    }
}