using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        public int Codigo;
        Cliente Cliente;
        public Vehiculo Vehiculo;
        Sucursal Sucursal;
        DateTime FechaInicio;
        public bool Vigencia;
        
        string Terminos;

        public Arriendo(int codigo, Cliente cliente, Vehiculo vehiculo, DateTime fechaInicio, string terminos, Sucursal sucursal, bool vigencia)
        {
            Codigo = codigo;
            Cliente = cliente;
            Vehiculo = vehiculo;
            Sucursal = sucursal;
            FechaInicio = fechaInicio;
            Vigencia = vigencia;
            
            Terminos = terminos;

        }



    }
}
