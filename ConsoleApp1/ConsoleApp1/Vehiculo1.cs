using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehiculo
    {
        string Tipo;
        string Marca; 
        string Patente;
        public List<Vehiculo> lista = new List<Vehiculo>();
        public Vehiculo (string tipo, string patente, string marca)
        {
            Tipo = tipo;
            Patente = patente;
            Marca = marca;

        }

        public List<Vehiculo> IngresarVehiculos()
        {

            string termino = "";
            

            while (termino == "")
            {
                Console.WriteLine("Ingrese el tipo de vehiculo que pertenecen a la sucursal : Auto (1), Moto (2), Camion (3), Acuatico (4), MaquinariaPesada (5). Y su patente");
                string tipo = Console.ReadLine();
                string patente1 = Console.ReadLine();
                

                

                Console.WriteLine("ingrese fin si termino");


                if (tipo == "fin")
                {
                    termino = " ";
                }
            }

            return lista;

        }

        public Vehiculo IdVehiculo(string id)
        {
            
        }


    }
}
