using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto: Vehiculo
    {
        public Auto(string patente, string marca, string modelo, string ano)
        {
            
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

        }
    }
}
