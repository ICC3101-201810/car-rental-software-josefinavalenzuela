using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursal
    {
        public string Nombre;
        public string Direccion;
        public List<Vehiculo> Vehiculos = new List<Vehiculo>();
        List<Sucursal> Sucursales = new List<Sucursal>();

        public Sucursal(string nombre, string direccion, List<Vehiculo> vehiculos)
        {
            Nombre = nombre;
            Direccion = direccion;
            Vehiculos = vehiculos;

        }

        public bool IngresarSucursal(List <Vehiculo> ListaVehiculos)
        {
            Console.WriteLine("Ingrese en nombre y direccion de la sucursal");
            string n = Console.ReadLine();
            string d = Console.ReadLine();

            Sucursal s = new Sucursal(n, d, ListaVehiculos);
            Sucursales.Add(s);

            return true;
            
        }

    }
}
