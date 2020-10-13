using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.COMMON.Entidades
{
    public class Proveedor : BaseDTO
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Cp { get; set; }
    }
}
