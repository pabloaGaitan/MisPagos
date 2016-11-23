using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    class TransaccionRepositorio
    {
        Contexto ctx = new Contexto();
        public void CrearTransaccion(Transaccion usuario)
        {
            
            ctx.Transacciones.Add(usuario);
        }

        public Usuario UsuarioByCC(string cedula)
        {
            
            return ctx.Usuarios.Find(cedula);
        }
    }
}
