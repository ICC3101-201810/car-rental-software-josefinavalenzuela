using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ingresar

    {
        public List<Cliente> Clientes = new List<Cliente>();
        List<Vehiculo> Vehiculos = new List<Vehiculo>();
        List<Sucursal> Sucursales = new List<Sucursal>();
        List<Arriendo> Arriendos = new List<Arriendo>();
        public List<Accesorio> Accesorios = new List<Accesorio>();

        public void IngresarSucursal()
        {
            Console.WriteLine("Ingrese el nombre de la sucursal y la direccion");
            string nombre = Console.ReadLine();
            string direccion = Console.ReadLine();
            List<Vehiculo> vehiculos = new List<Vehiculo>();


            string x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar maquinaria pesada? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, capacidad, precio, cantidad disponible");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string cap = Console.ReadLine();
                int pre = Convert.ToInt32(Console.ReadLine());
                int disp = Convert.ToInt32(Console.ReadLine());
                MaquinariaPesada nuevo = new MaquinariaPesada(pat, mar, mod, an, cap, pre, disp);
                vehiculos.Add(nuevo);



            }
            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Camion? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, capacidad, precio, disponiblidad");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string cap = Console.ReadLine();
                int pre = Convert.ToInt32(Console.ReadLine());
                int disp = Convert.ToInt32(Console.ReadLine());

                Camion nuevo = new Camion(pat, mar, mod, an, cap, pre, disp);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Acuatico? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, precio, disponiblidad");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                int pre = Convert.ToInt32(Console.ReadLine());
                int disp = Convert.ToInt32(Console.ReadLine());

                Acuatico nuevo = new Acuatico(pat, mar, mod, an, pre, disp);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Auto? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, precio, disponibilidad, DVD, asientos extra, maletero extra");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                int pre = Convert.ToInt32(Console.ReadLine());
                int disp = Convert.ToInt32(Console.ReadLine());
                bool DVD = Convert.ToBoolean(Console.ReadLine());
                bool asient = Convert.ToBoolean(Console.ReadLine());
                bool malet = Convert.ToBoolean(Console.ReadLine());

                Auto nuevo = new Auto(pat, mar, mod, an, pre, disp, DVD, asient, malet);
                vehiculos.Add(nuevo);

            }

            x = "";
            while (x == "")
            {
                Console.WriteLine("Desea ingresar Moto? Si (1) No (2)");
                string r = Console.ReadLine();
                if (r == "2")
                {
                    break;
                }
                Console.WriteLine("Ingrese Patente, marca, modelo, ano, ruedas, precio, disponibilidad");
                string pat = Console.ReadLine();
                string mar = Console.ReadLine();
                string mod = Console.ReadLine();
                string an = Console.ReadLine();
                string rue = Console.ReadLine();
                int pre = Convert.ToInt32(Console.ReadLine());
                int disp = Convert.ToInt32(Console.ReadLine());

                Moto nuevo = new Moto(pat, mar, mod, an, rue, pre, disp);
                vehiculos.Add(nuevo);

            }

            Sucursal nuev = new Sucursal(nombre, direccion, vehiculos);
            Console.WriteLine("Sucursal creada exitosamente");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();

        }



        public Sucursal GetSucursal(string n)
        {
            foreach (Sucursal i in Sucursales)
            {
                if (i.Nombre == n)
                {
                    return i;
                }
            }
            Console.WriteLine("No existe la sucursal" + n);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Beep();

            return null;
        }

        public void AgregarAccesorio(int cc)
        {
            Console.WriteLine("Ingrese el tipo de accesorio que es: 1. Bluetooth, 2. GPS, 3. Rueda extra, 4. Cortinas, 5. Silla guagua0");
            string l = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la sucursal");
            string ss = Console.ReadLine();
            Sucursal sss = GetSucursal(ss);
            Console.WriteLine("Marca, modelo, ano valor y disponiblidad");
            string mar = Console.ReadLine();
            string mod = Console.ReadLine();
            string an = Console.ReadLine();
            int pre = Convert.ToInt32(Console.ReadLine());
            int disp = Convert.ToInt32(Console.ReadLine());

            if (l == "1")
            {
                Accesorio accesorio = new Bluetooth(cc, mar, mod, an, pre, disp, sss);
                Accesorios.Add(accesorio);
                Console.WriteLine("Accesorio ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }
            else if (l == "2")
            {
                Accesorio accesorio = new GPS(cc, mar, mod, an, pre, disp, sss);
                Accesorios.Add(accesorio);
                Console.WriteLine("Accesorio ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }

            else if (l == "3")
            {
                Accesorio accesorio = new RuedaExtra(cc, mar, mod, an, pre, disp, sss);
                Accesorios.Add(accesorio);
                Console.WriteLine("Accesorio ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }

            else if (l == "4")
            {
                Accesorio accesorio = new Cortina(cc, mar, mod, an, pre, disp, sss);
                Accesorios.Add(accesorio);
                Console.WriteLine("Accesorio ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }

            else if (l == "5")
            {
                Accesorio accesorio = new Silla(cc, mar, mod, an, pre, disp, sss);
                Accesorios.Add(accesorio);
                Console.WriteLine("Accesorio ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }

            else
            {
                Console.WriteLine("La opcion ingresada es incorrecta");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
                Console.Beep();

            }

   

        }


        public void AgregarCliente()
        {

            Console.WriteLine("Empresa (1)/ Persona(2)");
            string j = Console.ReadLine();

            Console.WriteLine("Ingrese nombre, id, sucursal");
            string nombre = Console.ReadLine();
            string id = Console.ReadLine();
            string su = Console.ReadLine();
            Sucursal s = GetSucursal(su);


            if (j == "1")
            {
                Console.WriteLine("Ingrese permiso");
                string permiso = Console.ReadLine();
                Cliente em = new Empresa(nombre, id, permiso, s);
                Clientes.Add(em);
            }

            else if (j == "2")
            {
                Console.WriteLine("Ingrese licencia");
                string licencia = Console.ReadLine();
                Cliente pe = new Persona(nombre, id, licencia, s);
                
                Clientes.Add(pe);
                Console.WriteLine("Cliente ingresado exitosamente");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
            }


        }


        public Cliente GetCliente(string rut)
        {
            foreach (Cliente i in Clientes)
            {
                if (rut == i.Id)
                {
                    return i;
                }
            }
            Console.WriteLine("No existe un cliente con el rut" + rut);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Beep();

            return null;


        }

        public Vehiculo GetVehiculo(string p)
        {
            foreach (Vehiculo j in Vehiculos)
            {
                if (j.Patente == p)
                {
                    return j;
                }
            }
            Console.WriteLine("No existe un vehiculo con la patente" + p);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Beep();

            return null;
        }

        public Arriendo GetArriendo(int num)
        {
            foreach(Arriendo u in Arriendos)
            {
                if ( u.Codigo == num)
                {
                    return u;
                }
            }
            Console.WriteLine("No existe un arriendo con el codigo" + num);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Beep();

            return null;
        }



        public void ArrendarVehiculo(int codigo)
        {

    
            Console.WriteLine("Ingrese el nombre de la sucursal");
            string s = Console.ReadLine();
            Sucursal suc = GetSucursal(s);

            foreach (Vehiculo u in suc.Vehiculos)
            {
                Console.WriteLine("Ingrese los terminos");
                string t = Console.ReadLine();
    
                Console.WriteLine("Ingrese su id");
                string id = Console.ReadLine();
                Cliente cli = GetCliente(id);
 

                Console.WriteLine("Ingrese patente vehiculo y  terminos del contrato ");
                string IDV = Console.ReadLine();
                Vehiculo vehi = GetVehiculo(IDV);
                vehi.Disponibles--;
                


                string terminos = Console.ReadLine();

                if (u == vehi)
                {
                    if (u.Disponibles > 0)
                    {

                        Console.WriteLine("Vehiculo disponible");

                      

                        Arriendo arriendo = new Arriendo(codigo, cli, vehi, DateTime.Today , terminos, suc, true);
                        Arriendos.Add(arriendo);

                        Console.WriteLine("Arriendo ingresado exitosamente, su codigo es:" + codigo);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Beep();
                    }

                }

                else
                {
                    Console.WriteLine("No existe un vehiculo disponible con la patente" + IDV);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Beep();
                    Console.Beep();
                }
            }
        }

        public void DevolverVehiculo()
        {
            Console.WriteLine("Ingrese el codigo del arriendo");
            int cdg = Convert.ToInt32(Console.ReadLine());

            if (GetArriendo(cdg) != null)
            {
                Arriendo arr = GetArriendo(cdg);
                arr.Vehiculo.Disponibles += 1;
                arr.Vigencia = false;
                Console.WriteLine("Vehiculo devuelto exitosamente.");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();


            }
    







        }
    }
}
