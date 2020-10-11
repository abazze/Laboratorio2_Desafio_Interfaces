using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1_Imprimible
{
    class Documento : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
