using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos d = new Datos();
            Producto p = new Producto();

            WriteLine("***************Bienvenidos**************");
            WriteLine("Usuario: ");
            d.usuario = ReadLine();

            WriteLine("Clave");
            d.clave = ReadLine();

            if(d.usuario == "Ludwin" && d.clave == "l123")
            {
                d.rol = "Admin";
            }
            else
            {
                d.rol = "Vendedor";
            }

            if(d.rol == "Admin")
            {
                p.Areas();
            }
            else
            {
                ///p.Categorias(" ", " ", " ");
                WriteLine("intruso");
                
            }
            ReadLine();
        }
    }
}
