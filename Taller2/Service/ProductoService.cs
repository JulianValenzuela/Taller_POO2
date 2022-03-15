using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;
using Taller2.Vista;

namespace Taller2.service
{
    internal class ProductoService
    {

        public void IngresarDatos(List<Producto> productos, Producto producto)
        {
            Console.WriteLine("-------------------CREAR UN PRODUCTO------------------");
            Console.WriteLine("Ingrese codigo del producto: ");
            producto.Codigo = Console.ReadLine();


            Producto resultado = productos.Find(dato => dato.Codigo == producto.Codigo);
            if (resultado != null)
            {
                Console.WriteLine("ERROR Codigo duplicado");
                return;
            }

            Console.WriteLine("Ingrese nombre del producto: ");

            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            producto.Precio = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad del producto: ");
            producto.Cantidad = Console.ReadLine();

            productos.Add(producto);

        }
        public void BuscarDatos(List<Producto> productos, Producto producto)
        {


            Console.WriteLine("-------------------BUSCAR PRODUCTO------------------");
            Console.WriteLine("Ingrese el codigo del producto que desea buscar: ");
            string codigo = Console.ReadLine();
            producto = productos.Find(producto => producto.Codigo == codigo);
            if (producto == null)
            {
                Console.WriteLine("El producto no esta registrado en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
            }
            else
                Console.WriteLine(producto.Nombre + "  " + producto.Codigo + " " + producto.Precio + " " + producto.Cantidad);

        }

        public void ModificarDatos(List<Producto> productos, Producto producto)
        {
            Console.WriteLine("-------------------MODIFICAR PRODUCTO-----------------");
            Console.WriteLine("Ingrese el codigo del producto que desea editar: ");
            string codigo = Console.ReadLine();

            if (producto == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema ");
            }
            else
            {
                productos.Remove(producto);
                IngresarDatos(productos, new Producto());
                Console.WriteLine(producto.Codigo + "  " + producto.Nombre + "  " + producto.Precio +
                    "  " + producto.Cantidad);
            }

        }

        public void ListarDatos(List<Producto> productos)
        {

            Console.WriteLine("-------------------LISTAR PRODUCTOS-------------------");
            Console.WriteLine("           Codigo           Nombre           Precio           Cantidad           ");
            productos.ForEach(producto =>
            {
                if (producto.Activo)
                    Datos(producto);

            });

            foreach (var item in productos)
            {
                Console.WriteLine(item.Nombre);
            }


        }

        public void ActivarDesactivar(List<Producto> productos, Producto producto)
        {
            Console.WriteLine("-------------------ACTIVAR O DESACTIVAR UN PRODUCTO-------------------");
            Console.WriteLine("Ingrese codigo del producto ");
            string codigo = Console.ReadLine();
            producto = productos.Find(producto => producto.Codigo == codigo);
            if (producto == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema ");
            }
            else
            {
                producto.Activo = !producto.Activo;
                IngresarDatos(productos, new Producto());
                Console.WriteLine(producto.Codigo + "  " + producto.Nombre + "  " + producto.Precio +
                    "  " + producto.Cantidad);
            }



        }

        public void Encontrar(List<Producto> productos)
        {
            string codigo = Console.ReadLine();

            Producto producto = productos.Find(producto => producto.Codigo == codigo);
            if (producto == null)
            {
                Console.WriteLine("El producto no esta registrado en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
                return;
            }
        }

        public void Datos(Producto producto)
        {
            Console.WriteLine("           " + producto.Codigo + "           " + producto.Nombre + "           "
                  + producto.Precio + "           " + producto.Cantidad + "           ");
        }

    }
} 