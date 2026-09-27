using System;
using System.Collections.Generic;
using System.Text;
using Armazenar.Modelo;
namespace Armazenar.Classes
{
    internal class Arquivo : IArmazenavel
    {
        public void Salvar()
        {
            Console.WriteLine("Arquivo salvo com sucesso no computador principal.");
        }

        public void Recuperar()
        {
            Console.WriteLine("Arquivo recuperado por meio da última versão disponível do computador principal.");
        }
    }
}
