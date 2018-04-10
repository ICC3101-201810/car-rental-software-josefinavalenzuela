using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ingresar
    {
        public List<Cliente> Clientes = new List<Cliente>();
        List<Vehiculo> Vehiculos = new List<Vehiculo>();
        List<Sucursal> Sucursales = new List<Sucursal>();

        public void IngresarSucursal()
        {
            Console.WriteLine("Ingrese el nombre de la sucursal y la direccion");
            string nombre = Console.ReadLine();
            string direccion = Console.ReadLine();
            List<Vehiculo> vehiculos = new List<Vehiculo>();


            string x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar maquinaria pesada? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, capacidad");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string cap = Console.ReadLine();
                MaquinariaPesada nuevo = new MaquinariaPesada(pat, mar, mod, an, cap);
                vehiculos.Add(nuevo);



            }
            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Camion? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, capacidad");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string cap = Console.ReadLine();
                Camion nuevo = new Camion(pat, mar, mod, an, cap);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Acuatico? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();

                Acuatico nuevo = new Acuatico(pat, mar, mod, an);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Auto? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();

                Auto nuevo = new Auto(pat, mar, mod, an);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Moto? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, ruedas");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string rue = Console.ReadLine();

                Moto nuevo = new Moto(pat, mar, mod, an, rue);
                vehiculos.Add(nuevo);

            }

            Sucursal nuev = new Sucursal(nombre, direccion, vehiculos);

        }

        public bool IngresarSucursal(List<Vehiculo> ListaVehiculos)
        {
            Console.WriteLine("Ingrese en nombre y direccion de la sucursal");
            string n = Console.ReadLine();
            string d = Console.ReadLine();

            Sucursal s = new Sucursal(n, d, ListaVehiculos);
            Sucursales.Add(s);

            return true;

        }

        public Sucursal GetSucursal(string n)
        {
            foreach (Sucursal i in Sucursales)
            {
                if (i.Nombre == n)
                {
                    return i;
                }
            }
            return null;
        }

        public void AgregarCliente()
        {

            Console.WriteLine("Empresa (1)/ Persona(2)");
            string j = Console.ReadLine();

            Console.WriteLine("Ingrese nombre, id, sucursal");
            string nombre = Console.ReadLine();
            string id = Console.ReadLine();
            string su = Console.ReadLine();
            Sucursal s = GetSucursal(su);


            if (j == "1")
            {
                Console.WriteLine("Ingrese permiso");
                string permiso = Console.ReadLine();
                Cliente em = new Empresa(nombre, id, permiso, s);
                Clientes.Add(em);
            }

            else if (j == "2")
            {
                Console.WriteLine("Ingrese licencia");
                string licencia = Console.ReadLine();
                Cliente pe = new Persona(nombre, id, licencia, s);
                Clientes.Add(pe);
            }
        }


        public Cliente GetCliente(string rut)
        {
            foreach (Cliente i in Clientes)
            {
                if (rut == i.Id)
                {
                    return i;
                }
            }

            return null;


        }

        public Vehiculo GetVehiculo(string p)
        {
            foreach (Vehiculo j in Vehiculos)
            {
                if (j.Patente == p)
                {
                    return j;
                }
            }
            return null;
        }



        public void ArrriendoGeneral()
        {
            Console.WriteLine("Ingrese su id");
            string id = Console.ReadLine();
            Cliente c = GetCliente(id);

            Console.WriteLine("Ingrese patente vehiculo, valor y terminos del contrato ");
            string IDV = Console.ReadLine();
            string valor = Console.ReadLine();
            string terminos = Console.ReadLine();

            Arriendo a = new Arriendo(c, GetVehiculo(IDV), DateTime.Now, valor, terminos);
        }
    }
}
