using Armazenar.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Armazenar.Classes
{
    internal class BancoDeDados : IArmazenavel
    {
        public void Salvar()
        {
            Console.WriteLine("\nDados salvos com sucesso no banco de dados.");
        }

        public void Recuperar()
        {
            Console.WriteLine("Dados recuperados por meio da última versão disponível do banco de dados.");
        }
    }
}
