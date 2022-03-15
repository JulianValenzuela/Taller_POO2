using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;

namespace Taller2.service
{
    internal class DetalleFacturaService
    {
        public void IngresarDatos(List<Producto> productos, Producto producto)
        {
            Console.WriteLine("¿Que producto desea?: ");
            string productoN = Console.ReadLine();

            producto = productos.Find(dato => producto.Codigo == productoN);
            if (producto == null)
            {
                Console.WriteLine("El producto no esta registrado en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
                return;
            }

            Console.WriteLine("Ingrese el número de productos: ");
            int numeroProductos = int.Parse(Console.ReadLine());

        }
    }
}