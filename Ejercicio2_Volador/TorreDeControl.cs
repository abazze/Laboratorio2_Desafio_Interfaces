using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2_Volador
{
    class TorreDeControl
    {
        private List<IVolador> voladores = new List<IVolador>();

        public void VuelenTodos()
        {
            foreach(IVolador v in voladores)
            {
                v.Volador();
            }
        }

        public void AgregarVolador(IVolador volable)
        {
            this.voladores.Add(volable);
        }
    }
}
