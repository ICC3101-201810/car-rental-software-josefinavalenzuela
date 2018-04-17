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
            int cod = 0;
            int w = 0;
            int var = 0;
            while (w == 0)
            {
                
                Console.WriteLine("Desea crear sucursal (1), desea gestionar un arriendo (2), desea devolver un auto (3), desea ingresar accesorios (4), desea salir del programa (presione enter)");
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
                        i.ArrendarVehiculo(cod);
                        cod += 1;

                    }
                    else if (c == "2")
                    {
                        i.ArrendarVehiculo(cod);
                        cod += 1;

                    }
                    
    
            
                }
                else if(respuesta == "3")
                {
                    i.DevolverVehiculo();
                }

                else if(respuesta == "")
                {
                    w = 1;
                }

                else if(respuesta == "4")
                {
                    i.AgregarAccesorio(var);
                    var += 1;


                }

                else
                {
                    Console.WriteLine("La opcion ingresada es incorrecta");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Beep();
                    Console.Beep();

                }

                
            }
        }
    }
}
