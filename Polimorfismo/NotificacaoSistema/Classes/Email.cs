namespace NotificacaoSistema.Classes;

using NotificacaoSistema.Modelos;
using System.Net.Mime;

internal class Email : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Disparando e-mail: {mensagem}");
    }

}
