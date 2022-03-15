using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;

namespace Taller2.Vista
{
    internal class VistaConfiguracion
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Producto> productos = new List<Producto>();

        public void Configuracion()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("=                       DRAGONTEC                    =");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("¿Desea ingresar clientes y productos aleatorios?---------- si / no");

            string configuracion = Console.ReadLine();
            while (configuracion != "si")
            {
                var cliente1 = new Cliente { Nombre = "Maria", Cedula = "8905743", Direccion = "Calle 10 No. 9 - 78", Telefono = "3201211533" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Nahomi", Cedula = "7048484", Direccion = "Carrera 56A No. 51 - 81", Telefono = "3206626635" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Lana", Cedula = "10450304", Direccion = "Carrera 56A No. 51 - 81", Telefono = "3201592157" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Carolina", Cedula = "1243434", Direccion = "Carrera 54 No. 68 - 80 ", Telefono = "3204771945" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Paula", Cedula = "6343243", Direccion = "Calle 59 No. 27 - 35 ", Telefono = "3207623061" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Valeria", Cedula = "7043233", Direccion = "Carrera 10A No. 20 - 40", Telefono = "3202448795" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Juliana", Cedula = "1034343", Direccion = "Carrera 8  No. 20 - 59", Telefono = "3204406989" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Harly", Cedula = "435633", Direccion = "Calle 20 No. 22 - 27", Telefono = "3206765116" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Ramon", Cedula = "40295453", Direccion = "Carrera 8a No. 7 - 88", Telefono = "3208928546" }; clientes.Add(cliente1);
                cliente1 = new Cliente { Nombre = "Daniel", Cedula = "1433452", Direccion = "Carrera  5 No. 3 -74 ", Telefono = "3208065914" }; clientes.Add(cliente1);

                foreach (var item in clientes)
                {
                    Console.WriteLine(item.Nombre + "----" + item.Cedula + "----" + item.Direccion + "----" + item.Telefono);
                    Console.WriteLine("¿Desea ingresar clientes y productos aleatorios?---------- si / no");
                }
                if (configuracion == "no")
                {
                    var programa = new Program();
                    programa.MenuPrincipal();
                }

            }
            Console.WriteLine("¿Desea ingresar clientes y productos aleatorios?---------- si / no");
            configuracion = Console.ReadLine();
            while (configuracion != "si")
            {

                var vistaProducto = new VistaProducto();
                var producto1 = new Producto { Cantidad = "1", Codigo = "0001", Nombre = "Teclado Mecanico", Precio = "150.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "1", Codigo = "0002", Nombre = "Raton gamer", Precio = "80.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "1", Codigo = "0003", Nombre = "Silla gamer", Precio = "700.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "3", Codigo = "0004", Nombre = "Luces rgb", Precio = "60.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "2", Codigo = "0005", Nombre = "Mouse pad", Precio = "50.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "1", Codigo = "0006", Nombre = "Escritorio", Precio = "1.000.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "9", Codigo = "0007", Nombre = "Poster", Precio = "30.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "2", Codigo = "0008", Nombre = "Monitor", Precio = "1.400.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "2", Codigo = "0009", Nombre = "Play 5", Precio = "3.200.000" }; vistaProducto.productos.Add(producto1);
                producto1 = new Producto { Cantidad = "1", Codigo = "0010", Nombre = "Procesador ryzen 7", Precio = "1.600.000" }; vistaProducto.productos.Add(producto1);
                foreach (var producto in productos)
                {
                    Console.WriteLine(producto.Cantidad + "----" + producto.Codigo + "----" + producto.Nombre + "----" + producto.Precio);
                }
                var programa = new Program();
                programa.MenuPrincipal();
            }
        }
    }





}