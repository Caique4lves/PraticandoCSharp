namespace NotificacaoSistema.Classes;

using NotificacaoSistema.Modelos;

internal class Sms : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Disparando mensagem: {mensagem}");
    }
}
