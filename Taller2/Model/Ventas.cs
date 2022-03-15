using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Model
{
    internal class Ventas
    {
        public string IdFactura;
        public string Vendedor = "Alex";
        public string Fecha = DateTime.Now.ToString();
        public string Valor;
        public Cliente Cliente;
        public List<Producto> listaProductosVenta = new List<Producto>();
        public Boolean Activo = true;
    }
}
