using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAlmacen2020.Entidades
{
    public class Materiales : BaseDTO
    {
        public string Clave { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Total { get; set; }
        public bool EsEntrada { get; set; }

    }
}
