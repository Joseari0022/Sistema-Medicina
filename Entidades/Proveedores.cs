using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        public int ProveedoresId { get; set; }
        public string Nombres { get; set; }
        public string Ciudad { get; set; }
        public string Direcciones { get; set; }
        public int Telefonos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}
