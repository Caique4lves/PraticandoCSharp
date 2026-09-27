using System;
using System.Collections.Generic;
using System.Text;

namespace Armazenar.Modelo
{
    internal interface IArmazenavel
    {
        public void Salvar();

        public void Recuperar();
    }
}
