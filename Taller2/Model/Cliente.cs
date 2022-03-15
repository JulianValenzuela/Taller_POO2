using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{       
    internal class Cliente
    {
        public string Id = Guid.NewGuid().ToString();
        public string Cedula;
        public string Nombre;
        public string Direccion;
        public string Telefono;
        public Boolean Activo = true;


    }
}