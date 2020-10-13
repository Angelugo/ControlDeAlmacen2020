using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAlmacen2020.Entidades
{
    public class Administrador : BaseDTO
    {
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Area { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public List<string> Permisos { get; set; }

    }
}
