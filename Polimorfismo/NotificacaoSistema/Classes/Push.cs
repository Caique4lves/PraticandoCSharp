namespace NotificacaoSistema.Classes;

using NotificacaoSistema.Modelos;

internal class Push : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Disparando notificação: {mensagem}");
    }
}
