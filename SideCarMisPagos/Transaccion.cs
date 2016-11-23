using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    class Transaccion
    {
        public string TransaccionId { get; set; }
        public string fecha { get; set; }
        public Usuario Cedula_usuario { get; set; }
        public double valor { get; set; }

        public Transaccion() { }
    }
}
