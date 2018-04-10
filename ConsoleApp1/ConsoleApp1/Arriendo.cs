using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        Cliente Cliente;
        Vehiculo Vehiculo;
        
        DateTime FechaInicio;
        string Total;
        string Terminos;

        public Arriendo(Cliente cliente, Vehiculo vehiculo, DateTime fechaInicio, string total, string terminos)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            
            FechaInicio = fechaInicio;
            Total = total;
            Terminos = terminos;

        }



    }
}
