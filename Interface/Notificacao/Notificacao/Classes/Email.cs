using Notificacao.Modelo;
namespace Notificacao.Classes
{
    internal class Email : INotificavel
    {
        public void EnviarNotificacao()
        {
            Console.WriteLine("Notificação enviada por e-mail...");
        }
    }
}
