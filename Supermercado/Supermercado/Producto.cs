using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Supermercado
{
    internal class Producto
    {
        public void Areas()
        {
            Datos d = new Datos();
            Producto p = new Producto();

            WriteLine("------------Areas------------");
            string a1 = "Comida";
            string a2 = "Bebida";

            WriteLine($"1-{d.area=a1} \n2-{d.area=a2}");
            WriteLine("Elige una opcion: ");
            int opcion = int.Parse(ReadLine());

            if(opcion == 1)
            {
               
                p.Categorias("Carnes", "Vegetales", "Frutas");
            }
            else if(opcion == 2)
            {
                p.Categorias("Jugos", "Sodas", "Bebidas alcoholicas");
            }
            else
            {
                WriteLine("Invalidos");
            }
        }
        public void Categorias(string categ1, string categ2, string categ3)
        {
            Datos d = new Datos();
            Producto p = new Producto();
            ArrayList ListCategorias = new ArrayList();

            WriteLine("------------Categorias------------");
            string c1 = categ1;
            string c2 = categ2;
            string c3 = categ3;

            WriteLine($"1-{d.categoria = c1} \n2-{d.categoria = c2} \n3-{d.categoria = c3}");
            WriteLine($"1-Agregar \n2-Seleccionar ");
            int eleccion = int.Parse(ReadLine());

            if (eleccion == 1)
            {
               
            }
            else if(eleccion == 2)
            {
                WriteLine("Elige una opcion: ");
                int opcion = int.Parse(ReadLine());


                if (opcion == 1)
                {
                    d.categoria = "Carnes";
                    p.Productos("Tortitas", "Menudos", "Frutas");

                }
                else if (opcion == 2)
                {
                    d.categoria = "Vegetales";
                    p.Productos("Tomates", "Papas", "Pepinos");
                }
                else if (opcion == 3)
                {
                    d.categoria = "Frutas";
                    p.Productos("Guineos", "Uvas", "Naranjas");
                }
                else
                {
                    WriteLine("Invalido");
                }
            }
          
        }
        public void Productos(string p1, string p2, string p3)
        {
            Datos d = new Datos();

            WriteLine("------------Productos------------");
            string c1 = p1;
            string c2 = p2;
            string c3 = p3;


            WriteLine($"1-{d.nombre = c1} \n2-{d.nombre = c3} \n3-{d.nombre = c3}");
            WriteLine("Elige una opcion: ");
            int opcion = int.Parse(ReadLine());

            if (opcion == 1)
            {
                WriteLine("\n------------Detalles------------");
                d.nombre = "Tortitas";
                d.categoria = "Comida";
                d.descripcion = "Carne de res" ;
                d.cantidad = 3;
                d.precio = 15.5;
                d.fechaVenc = "10/12/2025";

                WriteLine($"Nombre: {d.nombre} \nCategoria: {d.categoria} \nDescripcion: {d.descripcion} \nUnidades: {d.cantidad} \nPrecio: {d.precio} \nFecha de Vencimiento: {d.fechaVenc}");
            }
            else if (opcion == 2)
            {
                WriteLine("\n------------Detalles------------");
                d.nombre = "Menudos";
                d.categoria = "Comida";
                d.descripcion = "Carne de pollo";
                d.cantidad = 2;
                d.precio = 3;
                d.fechaVenc = "31/12/2025";

                WriteLine ($"Nombre: {d.nombre} \nCategoria: {d.categoria} \nDescripcion: {d.descripcion} \nUnidades: {d.cantidad} \nPrecio: {d.precio} \nFecha de Vencimiento: {d.fechaVenc}");
            }
            else if(opcion == 3)
            {
                WriteLine("\n------------Detalles------------");
                d.nombre = "Chicharrones";
                d.categoria = "Comida";
                d.descripcion = "Carne de Cerdo";
                d.cantidad = 4;
                d.precio = 20;
                d.fechaVenc = "11/02/2025";

                WriteLine ($"Nombre: {d.nombre} \nCategoria: {d.categoria} \nDescripcion: {d.descripcion} \nUnidades: {d.cantidad} \nPrecio: {d.precio} \nFecha de Vencimiento: {d.fechaVenc}");
            }
            else
            {
                WriteLine("Invalido");
            }
        }
    }
}
