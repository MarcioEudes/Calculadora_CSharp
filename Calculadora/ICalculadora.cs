using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    interface ICalculadora
    {
        void Adicionar();
        void Subtrair();
        void Multiplicar();
        void Dividir();
        void Sair();
        void Default();
    }
}
