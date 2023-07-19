using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestion.Entities
{
    public class Empleado
    {
        [Key]
        public int cod_empleado { get; set; }
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string Email { get; set; }
        public int salario { get; set; }
    }
}
