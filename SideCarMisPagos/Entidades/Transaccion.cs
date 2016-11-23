using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    public class Transaccion
    {
        public string TransaccionId { get; set; }
        public string Concepto;
        public string Descripcion;
        public string CedulaUsuario { get; set; }
        [ForeignKey("CedulaUsuario")]
        public virtual Usuario Usser { get; set; }
        public double valor { get; set; }

        public Transaccion() { }
    }
}
