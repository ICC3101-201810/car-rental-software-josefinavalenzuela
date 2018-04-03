using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArriendoAcc: Arriendo
    {
        Accesorio Accesorio;
        public ArriendoAcc(Cliente cliente, Vehiculo vehiculo, DateTime fechaInicio, int total, string terminos, Accesorio accesorio): base(cliente, vehiculo, fechaInicio, total, terminos)
        {
            Accesorio = accesorio;
        }
    }
}
