using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1_Imprimible
{
    class Foto : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
