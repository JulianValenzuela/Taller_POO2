using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;
using Taller2.service;

namespace Taller2.Vista
{
    internal class VistaVenta
    {
        public List<Ventas> ventas = new List<Ventas>();

        public void CrearVenta()
        {
            var productos = new List<Producto>();
            Producto producto = new Producto();
            Cliente cliente = new Cliente();
            Ventas venta = new Ventas();


            var cli = new VistaCliente();
            var venta1 = new Ventas();
            Console.WriteLine("------------------------CREAR UNA VENTA--------------------------------");
            Console.WriteLine("Ingrese Id de factura");
            venta.IdFactura = Console.ReadLine();
            Console.WriteLine("Ingrese la Cedula del cliente: ");
            cliente.Cedula = Console.ReadLine();
            Cliente resultado = cli.clientes.Find(dato => dato.Cedula == cliente.Cedula);
            venta.Cliente = resultado;
            Console.WriteLine("Ingrese el codigo del producto para agregar a la venta: ");
            string r = "si";
            do
            {
                string codigo = Console.ReadLine();
                var pro = new VistaProducto();
                Producto resultadoProducto = pro.productos.Find(dato => dato.Codigo == codigo);
                if (resultadoProducto == null)
                {
                    Console.WriteLine("ERROR el producto no existe.");

                }
                else
                {
                    Console.WriteLine("Cantidad a llevar: ");
                    var cantidad = Console.ReadLine();
                    if (int.Parse(cantidad) > int.Parse(producto.Cantidad))
                    {
                        Console.WriteLine("Paso la cantidad del producto.");
                    }
                    else
                    {
                        producto.Cantidad = (int.Parse(producto.Cantidad) - int.Parse(cantidad)).ToString();
                        venta.listaProductosVenta.Add(resultadoProducto);
                    }
                }
                Console.WriteLine("¿Desea agregar otro producto?");
                r = Console.ReadLine();


            } while (r != "no");
            Console.WriteLine("Nombre del vendedor: ");
            venta.Vendedor = Console.ReadLine();
            ventas.Add(venta);

        }

        public void MenuVenta()
        {
            while (true)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Marque la opcion para ingresar al menu deseado");
                Console.WriteLine("Opcion 1: Crear una venta");
                Console.WriteLine("Opcion 2: Ver detalle de una venta");
                Console.WriteLine("Opcion 3: Listar ventas");
                Console.WriteLine("Opcion 4: Activar o desactivar venta");
                Console.WriteLine("Opcion 5: Ver factura de un cliente");
                Console.WriteLine("Opcion 6: Salir");
                Console.WriteLine("------------------------------------------------------");
                string opcion = Console.ReadLine();
                Producto producto = new();
                switch (opcion)
                {
                    case "1":
                        CrearVenta();
                        MenuVenta();
                        break;
                    case "2":
                        BuscarVenta();
                        MenuVenta();
                        break;

                    case "3":
                        ListarVentas();
                        MenuVenta();
                        break;
                    case "4":
                        ActivarDesactivar();
                        break;

                    case "5":
                        VerFactura();
                        break;
                    case "6": break;

                    default:
                        break;
                }

            }
        }

        public void BuscarVenta()
        {

            Console.WriteLine("------------------------BUSCAR VENTA------------------------");

            Console.WriteLine("Ingrese el Id de venta: ");
            string idVenta = Console.ReadLine();
            var venta = new Ventas();

            venta = ventas.Find(venta => venta.IdFactura == idVenta);
            if (venta == null)
            {
                Console.WriteLine("La venta no está registrada en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
            }
            else
            {
                Console.WriteLine(venta.Cliente + "  " + venta.IdFactura + " " + venta.Fecha + " ");

            }


        }
        public void ActivarDesactivar()
        {

            Console.WriteLine("------------------------BUSCAR VENTA------------------------");

            var venta = new Ventas();
            ListarVentas();
            Console.WriteLine("Ingrese el Id de venta: ");
            string idVenta = Console.ReadLine();

            venta = ventas.Find(venta => venta.IdFactura == idVenta);
            if (venta == null)
            {
                Console.WriteLine("La venta no está registrada en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
                MenuVenta();
            }
            else
            {
                Console.WriteLine("Venta Activa: " + venta.Activo);
                venta.Activo = Boolean.Parse(Console.ReadLine());
            }
        }
        public void ListarVentas()
        {
            foreach (var ventas in ventas)
            {
                Console.WriteLine($"Vendedor: {ventas.Vendedor} + fecha: {ventas.Fecha} cliente " +
                    $"{ventas.Cliente} ID Venta: {ventas.IdFactura} Activo: {ventas.Activo}");
            }
        }
        public void VerFactura()
        {
            Console.WriteLine("------------------------BUSCAR VENTA------------------------");

            Console.WriteLine("Ingrese el Id de venta: ");
            string idVenta = Console.ReadLine();
            var venta = new Ventas();

            venta = ventas.Find(venta => venta.IdFactura == idVenta);
            if (venta == null)
            {
                Console.WriteLine("La venta no está registrada en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
            }
            else
            {
                double total = 0;
                Console.WriteLine("Vendedor: " + venta.Vendedor);
                Console.WriteLine("Cliente: " + venta.Cliente);
                Console.WriteLine("Fecha: " + venta.Fecha);

                foreach (var item in venta.listaProductosVenta)
                {
                    Console.WriteLine(item.Cantidad);
                    total = total + (int.Parse(venta.Valor) * int.Parse(item.Cantidad));

                }
                Console.WriteLine("Total: " + total);
            }
        }
    }

}
