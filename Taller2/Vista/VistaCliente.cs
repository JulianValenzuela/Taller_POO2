using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Model;
using Taller2.Service;

namespace Taller2.Vista
{
    internal class VistaCliente
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Producto> productos = new List<Producto>();


        public void MenuCliente()
        {

            ClienteService clienteService = new ClienteService();
            var opcion = "2";
            while (opcion != "6")
            {

                Console.WriteLine("--------------------Menu de opciones------------------");
                Console.WriteLine("1.Crear un cliente");
                Console.WriteLine("2.Buscar un cliente");
                Console.WriteLine("3.Editar un cliente");
                Console.WriteLine("4.Listar un cliente");
                Console.WriteLine("5.Activar o desactivar un cliente");
                Console.WriteLine("6.Salir del sistema");
                Console.WriteLine("------------------------------------------------------");


                Console.WriteLine("Ingrese una opcion: ");
                opcion = Console.ReadLine();

                Cliente cliente = new();
                switch (opcion)
                {
                    case "1":

                        clienteService.IngresarDatos(clientes, cliente);
                        break;
                    case "2":
                        clienteService.BuscarDatos(clientes, cliente);
                        break;
                    case "3":
                        clienteService.ModificarDatos(clientes, cliente);
                        break;
                    case "4":
                        clienteService.ListarDatos(clientes);
                        break;
                    case "5":
                        clienteService.ActivarDesactivar(clientes, cliente);
                        break;
                    case "6":
                        Console.WriteLine("Salio de cliente");
                        break;
                    default:
                        Console.WriteLine("Error esta opcion no existe");
                        break;
                }
            }
        }
    }
}