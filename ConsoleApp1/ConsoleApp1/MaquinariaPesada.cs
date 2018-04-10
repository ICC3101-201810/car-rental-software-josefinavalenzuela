using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MaquinariaPesada: Vehiculo
    {
        string Capacidad;
        List<Vehiculo> maquinaria = new List<Vehiculo>();
        public MaquinariaPesada(string patente, string marca, string modelo, string ano, string capacidad)
        {
            Capacidad = capacidad;
           
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
       
        }


    }
}
