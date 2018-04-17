using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Accesorio
    {
        int Codigo;
        string Marca;
        string Modelo;
        string Ano;
        int Valor;
        int Disponibilidad;
        Sucursal Sucursal;
       

        public Accesorio( int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal)
        {
            Codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Valor = valor;
            Disponibilidad = disponiblidad;
            Sucursal = sucursal;
        }
    }

    public class Bluetooth: Accesorio

    {
        public Bluetooth(int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal): base(codigo, marca, modelo, ano, valor, disponiblidad, sucursal)
        {

        }
    }

    public class GPS : Accesorio

    {
        public GPS(int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal) : base(codigo, marca, modelo, ano, valor, disponiblidad, sucursal)
        {

        }
    }

    public class RuedaExtra : Accesorio

    {
        public RuedaExtra(int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal) : base(codigo, marca, modelo, ano, valor, disponiblidad, sucursal)
        {

        }
    }

    public class Cortina : Accesorio

    {
        public Cortina(int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal) : base(codigo, marca, modelo, ano, valor, disponiblidad, sucursal)
        {

        }
    }

    public class Silla : Accesorio

    {
        public Silla(int codigo, string marca, string modelo, string ano, int valor, int disponiblidad, Sucursal sucursal) : base(codigo, marca, modelo, ano, valor, disponiblidad, sucursal)
        {

        }
    }

    public class ArriendoAcc
    {
        public int Codigo;
        Cliente Cliente;
        public Accesorio Accesorio;
        Sucursal Sucursal;
        DateTime FechaInicio;
        public bool Vigencia;

        string Terminos;

        public ArriendoAcc(int codigo, Cliente cliente, Accesorio accesorio, DateTime fechaInicio, string terminos, Sucursal sucursal, bool vigencia)
        {
            Codigo = codigo;
            Cliente = cliente;
            Accesorio = accesorio;
            Sucursal = sucursal;
            FechaInicio = fechaInicio;
            Vigencia = vigencia;
            Terminos = terminos;

        }

    }
    

}
