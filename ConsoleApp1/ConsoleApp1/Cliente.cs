using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente
    {
        string Nombre;
        public string Id;
        Sucursal sucursal1;

        public List<Cliente> Clientes = new List<Cliente>();

        public Cliente( string nombre, string id, Sucursal sucursal2)
        {
            Nombre = nombre;
            Id = id;
            sucursal1 = sucursal2;
     

        }

        public string GetId()
        {
            return Id;
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
