using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accesorio
    {
        public enum Acc {Radio, GPS, ruedaRepuesto, CortinaVentana, SillaInfante };
        Acc Tipo;
       

        public Accesorio( Acc tipo)
        {
            Tipo = tipo;
        }
    }
}
