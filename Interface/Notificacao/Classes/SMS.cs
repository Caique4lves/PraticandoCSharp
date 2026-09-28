using Notificacao.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notificacao.Classes
{
    internal class SMS : INotificavel
    {
        public void EnviarNotificacao()
        {
            Console.WriteLine("\nNotificação enviada por SMS...");
        }
    }
}
