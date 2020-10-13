using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.COMMON.Entidades
{
    public class Herramienta : BaseDTO
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo_Unitario { get; set; }
        public decimal Monto_Total { get; set; }
        public DateTime FechaEntrada { get; set; }

    }
}
