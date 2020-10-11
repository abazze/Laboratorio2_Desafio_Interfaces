using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1_Imprimible
{
    class Impresora
    {
        private List<IImprimible> ColaDeImpresion = new List<IImprimible>();

        public void ImprimirTodo()
        {
            foreach(IImprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(IImprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
