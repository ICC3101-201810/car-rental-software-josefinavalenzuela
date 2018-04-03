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
 
        string Patente;
        public Vehiculo (string tipo, string patente)
        {
            Tipo = tipo;
            Patente = patente;

        }

        public List<Vehiculo> IngresarVehiculos()
        {

            string termino = "";
            List<Vehiculo> lista = new List<Vehiculo>();

            while (termino == "")
            {
                Console.WriteLine("Ingrese el tipo de vehiculo que pertenecen a la sucursal y su patente");
                string tipo = Console.ReadLine();
                string patente1 = Console.ReadLine();
                Vehiculo v = new Vehiculo(tipo, patente1);

                lista.Add(v);

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
