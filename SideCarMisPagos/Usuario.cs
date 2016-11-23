using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    class Usuario
    {
        public string UsuarioId { get; set; }
        public string UsuarioMisPagos { get; set; }
        public string Contrasenia { get; set; }
        public double saldo { get; set; }
        public Usuario() { }

    }
}
