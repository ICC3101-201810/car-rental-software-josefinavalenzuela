using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresar i = new Ingresar();

            Console.WriteLine("Desea crear sucursal (1), desea gestionar un arriendo (2)");
            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {

             
                i.IngresarSucursal();


            }

            else if (respuesta == "2")
            {
                Console.WriteLine("Cliente nuevo? Si (1), No (2)");
                string c = Console.ReadLine();

                if (c == "1")
                {
              
                    i.AgregarCliente();

                }
                else if (c == "2")
                {

                    i.ArrriendoGeneral();

   

                }
            
            
            }
        }
    }
}
