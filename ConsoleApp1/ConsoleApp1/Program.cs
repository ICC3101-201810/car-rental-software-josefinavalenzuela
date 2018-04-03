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

            Console.WriteLine("Desea crear sucursal (1), desea gestionar un arriendo (2)");
            string respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                Vehiculo h = new Vehiculo("Auto", "AAAA12");
                Vehiculo g = new Vehiculo("Moto", "AAAA13");
                List<Vehiculo> t = new List<Vehiculo>();
                t.Add(h);
                t.Add(g);
                string n = "n";
                string d = "d";

                Sucursal f = new Sucursal(n, d, t);
                

                List<Vehiculo> lista = h.IngresarVehiculos();
                if (f.IngresarSucursal(lista))
                {
                    Console.WriteLine("Sucursal creada correctamente");
                }

            }

            else if (respuesta == "2")
            {
                Console.WriteLine("Cliente nuevo? Si (1), No (2)");
                string c = Console.ReadLine();

                if (c == "1")
                {
                    Cliente hola = new Cliente("josefina", "196868119");
                    
                    
                
                    hola.AgregarCliente();

                }
                else if (c == "2")
                {
                    Cliente hola = new Cliente("josefina", "196868119");

                    Console.WriteLine("Ingrese su id");
                    string id = Console.ReadLine();
                    hola.GetCliente(id);

                    Console.WriteLine("Ingrese id vehiculo, valor y terminos del contrato ");
                    string IDV = Console.ReadLine();
                    string valor = Console.ReadLine();
                    string terminos = Console.ReadLine();





                    

                }
            
            
            }
        }
    }
}
