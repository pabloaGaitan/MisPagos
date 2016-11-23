using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    class RepositorioUsuario
    {
        public void CrearUsuario(Usuario usuario)
        {
            Contexto ctx = new Contexto();
            ctx.Usuarios.Add(usuario);
        }

        public Usuario UsuarioByCC(string cedula)
        {
            Contexto ctx = new Contexto();
            return ctx.Usuarios.Find(cedula);
        }
    }
}
