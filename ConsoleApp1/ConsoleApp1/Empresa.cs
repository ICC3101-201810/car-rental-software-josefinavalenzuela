using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa: Cliente
    {
        string Permiso;

        public Empresa(string nombre, string id, string permiso): base(nombre, id)
        {
            Permiso = permiso;
        }

    }
}
