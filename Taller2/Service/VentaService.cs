using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;
using Taller2.Vista;

namespace Taller2.service
{
    internal class VentaService
    {
        public List<Ventas> ventas = new List<Ventas>();
        public void IngresarDatos(List<Ventas> ventas, Ventas venta, Cliente cliente, Producto producto)

        {   //Cli es una variable normal
            var cli = new VistaCliente();
            var venta1 = new Ventas();
            Console.WriteLine("------------------------CREAR UNA VENTA--------------------------------");
            Console.WriteLine("Codigo de venta: ");
            venta1.IdFactura = Guid.NewGuid().ToString();
            Console.WriteLine("Ingrese la Cedula del cliente: ");
            cliente.Cedula = Console.ReadLine();
            Cliente resultado = cli.clientes.Find(dato => dato.Cedula == cliente.Cedula);
            venta.Cliente = resultado;
            Console.WriteLine("Ingrese el codigo del producto para agregar a la venta: ");
            producto.Codigo= Console.ReadLine();
            string r = "si";
            do
            {
                var pro = new VistaProducto();
                Producto resultadoProducto = pro.productos.Find(dato => dato.Codigo == producto.Codigo);
                if (resultadoProducto == null)
                {
                    Console.WriteLine("ERROR el producto no existe.");

                }
                venta.listaProductosVenta.Add(resultadoProducto);
                Console.WriteLine("¿Desea agregar otro producto?");
                r = Console.ReadLine();


            } while (r != "no");
            Console.WriteLine("Nombre del vendedor: ");
            venta.Vendedor = Console.ReadLine();
            ventas.Add(venta);



        }

    }
}