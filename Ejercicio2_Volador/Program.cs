using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2_Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Boing747 boing = new Boing747();
            Superman superman = new Superman();
            TorreDeControl torre = new TorreDeControl();

            torre.AgregarVolador(pato);
            torre.AgregarVolador(boing);
            torre.AgregarVolador(superman);

            torre.VuelenTodos();

            Console.ReadKey();
        }
    }
}
