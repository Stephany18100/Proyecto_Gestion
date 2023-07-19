using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestion.Entities
{
    class Capacitacion
    {
        public int IdCapacitacion { get; set; }
        public string TipoCapacitacion { get; set; }
        public DateTime FechaInicialC { get;set; }
        public DateTime FechaFinal { get;set; }

    }
}
