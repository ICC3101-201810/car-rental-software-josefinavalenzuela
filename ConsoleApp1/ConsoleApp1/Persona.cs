using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona: Cliente
    {
        string Licencia;

        public Persona(string nombre, string id, string licencia): base(nombre, id)
        {
            Licencia = licencia;

        }
    }
}
