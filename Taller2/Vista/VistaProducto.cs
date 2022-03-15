using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;
using Taller2.service;

namespace Taller2.Vista
{

    internal class VistaProducto
    {
        public List<Producto> productos = new();
        public void MenuProducto()
        {

            ProductoService productoService = new ProductoService();

            var opcion = "2";

            while (opcion != "6")
            {

                Console.WriteLine("--------------------Menu de opciones------------------");
                Console.WriteLine("1.Crear un producto");
                Console.WriteLine("2.Buscar un producto");
                Console.WriteLine("3.Editar un producto");
                Console.WriteLine("4.Listar un producto");
                Console.WriteLine("5.Activar o desactivar un producto");
                Console.WriteLine("6.Salir del sistema");
                Console.WriteLine("------------------------------------------------------");


                Console.WriteLine("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                Producto producto = new();
                switch (opcion)
                {
                    case "1":

                        productoService.IngresarDatos(productos, producto);
                        break;
                    case "2":
                        productoService.BuscarDatos(productos, producto);
                        break;
                    case "3":
                        productoService.ModificarDatos(productos, producto);
                        break;
                    case "4":
                        productoService.ListarDatos(productos);
                        break;
                    case "5":
                        productoService.ActivarDesactivar(productos, producto);
                        break;
                    case "6":
                        Console.WriteLine("Salio de producto");
                        break;
                    default:
                        Console.WriteLine("Error esta opcion no existe");
                        break;


                }
            }


        }
    }
}