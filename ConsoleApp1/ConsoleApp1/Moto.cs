using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Moto: Vehiculo
    {
        string Ruedas;
        public Moto(string patente, string marca, string modelo, string ano, string ruedas, int precio, int disponibles)
        {

            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Ruedas = ruedas;
            Precio = precio;
            Disponibles = disponibles;

        }
    }
}
