using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2_Volador
{
    sealed class Superman : Superheroe, IVolador
    {
        private int experiencia = 0;

        public void Volador()
        {
            this.experiencia += 3;
            Console.WriteLine("Estoy volando como un campeón...");
        }
    }
}
