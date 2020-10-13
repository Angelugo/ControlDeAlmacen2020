using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAlmacen2020.Entidades
{
    public class Prestamos : BaseDTO
    {
        public string Empleado { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Entrada { get; set; }
        public string Herramienta { get; set; }
        public bool Estado { get; set; }
    }
}
