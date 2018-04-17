using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Auto: Vehiculo
    {
        bool DVD;
        bool AsientosExtra;
        bool MaleteroExtra;
        public Auto(string patente, string marca, string modelo, string ano, int precio, int disponibles, bool dvd, bool asientos, bool maletero)
        {
            
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Precio = precio;
            Disponibles = disponibles;
            DVD = dvd;
            AsientosExtra = asientos;
            MaleteroExtra = maletero;
        }
    }
}
