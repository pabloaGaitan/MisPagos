using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SideCarMisPagos
{
    public class Usuario
    {
        [Key]
        [Column(Order = 1)]
        public string TipoDocumento { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Documento { get; set; }
        public string UsuarioMisPagos { get; set; }
        public string Contrasenia { get; set; }
        public double saldo { get; set; }
        public virtual List<Transaccion> Transaccions { get; set; }
        public Usuario() {
            Transaccions = new List<Transaccion>();        
        }

        public void AgregarTransaccion(Transaccion t)
        {
            Transaccions.Add(t);
        }

        public void EliminarTransaccion(Transaccion t)
        {
            Transaccions.Remove(t);
        }

    }
}
