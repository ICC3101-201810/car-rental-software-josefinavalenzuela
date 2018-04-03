using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cliente
    {
        string Nombre;
        string Id;
        public List<Cliente> Clientes = new List<Cliente>();

        public Cliente( string nombre, string id)
        {
            Nombre = nombre;
            Id = id;

        }

        public string GetId()
        {
            return Id;
        }

        public void AgregarCliente()
        {
            Console.WriteLine("Empresa (1)/ Persona(2)");
            string j = Console.ReadLine();
            if (j == "1")

                Console.WriteLine("Ingrese nombre, id");
            string nombre = Console.ReadLine();
            string id = Console.ReadLine();

            if (j == "1")
            {
                Console.WriteLine("Ingrese permiso");
                string permiso = Console.ReadLine();
                Cliente em = new Empresa(nombre, id, permiso);
                Clientes.Add(em);
            }

            else if (j == "2")
            {
                Console.WriteLine("Ingrese licencia");
                string licencia = Console.ReadLine();
                Cliente pe = new Persona(nombre, id, licencia);
                Clientes.Add(pe);
            }
        }

        public Cliente GetCliente(string rut)
        {
            foreach( Cliente i in Clientes)
            {
                if (rut == i.Id)
                {
                    return i;
                }
            }

            return null;

            
        }
    }
}
