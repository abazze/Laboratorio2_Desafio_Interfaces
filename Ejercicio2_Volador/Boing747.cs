using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2_Volador
{
    sealed class Boing747 : Aviones, IVolador
    {
        private float horasVuelo = 0.0f;

        public void Volador()
        {
            this.horasVuelo += 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
