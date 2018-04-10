using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Camion: Vehiculo
    {
        string Capacidad;
        
        public Camion(string patente, string marca, string modelo, string ano, string capacidad)
        {
            Capacidad = capacidad;
            Ano = ano;
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
        


        }
    }
}
