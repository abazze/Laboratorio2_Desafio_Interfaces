using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1_Imprimible
{
    class Contrato : IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
