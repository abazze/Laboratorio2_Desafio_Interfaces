using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2_Volador
{
    sealed class Pato : Animal, IVolador
    {
        private int energia = 10;

        public void Volador()
        {
            this.energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuack!");
        }
    }
}
