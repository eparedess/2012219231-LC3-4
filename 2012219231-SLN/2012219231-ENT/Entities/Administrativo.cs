using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_ENT.Entities
{
   public class Administrativo : Empleado
    {

        public string Cargo { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

    }
}
